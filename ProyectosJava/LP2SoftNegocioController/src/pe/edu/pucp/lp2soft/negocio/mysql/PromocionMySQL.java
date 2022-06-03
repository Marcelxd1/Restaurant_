/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.negocio.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.negocio.dao.PromocionDAO;
import pe.edu.pucp.lp2soft.negocio.model.Categoria;
import pe.edu.pucp.lp2soft.negocio.model.LineaPromocion;
import pe.edu.pucp.lp2soft.negocio.model.Producto;
import pe.edu.pucp.lp2soft.negocio.model.Promocion;

/**
 *
 * Jhosep Huaricallo Quispe
 * 20170398
 * Modificacion de LineaPromocion para que no contenga a Promocion -> no debe de ser ciclico
 * solo se puede ir desde Promocion a cada linea por medio de la lista de lineas que tiene promocion
 * PromoSQL
 * LineaPromocion
 * 
 * //Si se elimina un producto -> eliminar combo
    //trigger
 */
public class PromocionMySQL implements PromocionDAO{
    private Connection con; 
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public int insertar(Promocion promocion) {
        //asume que le daras una promocion con su lista creada
        //unidades de LineaPromocion son la cantidad no la medida
        int resultado = 0;
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PROMOCION(?,?,?,?,?)}");
            cs.registerOutParameter("_id_item_vendible", java.sql.Types.INTEGER);
            cs.setString("_nombre", promocion.getNombre());
            cs.setDouble("_precio", promocion.getPrecio());
            cs.setString("_descripcion", promocion.getDescripcion());
            cs.setBoolean("_estado", true);//porque si se inserta sera usado 
            cs.executeUpdate();
            promocion.setIdItemVendible(cs.getInt("_id_item_vendible"));
            
            for (LineaPromocion linea : promocion.getLista_de_Comidas()) {
                cs= con.prepareCall("{call INSERTAR_LINEA_PROMOCION(?,?,?,?)}");
                cs.registerOutParameter("_idLineaPromocion", java.sql.Types.INTEGER);
                cs.setInt("_unidades", linea.getUnidades());
                cs.setInt("_fid_promocion", promocion.getIdItemVendible());
                //cs.setInt("_fid_promocion", linea.getPromocion().getIdItemVendible());
                cs.setInt("_fid_producto", linea.getProducto().getIdItemVendible());//no se usa el idProducto
                linea.setEstado(true); //porque si lo inserto entrara por defecto como activo
                
                cs.executeUpdate();
                linea.setIdLineaPromocion(cs.getInt("_idLineaPromocion"));//Este es el generado
                
            }
            resultado = promocion.getIdItemVendible();//////////
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Promocion promocion) {
       int resultado = 0;
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_PROMOCION(?,?,?,?,?)}");
            
            cs.setInt("_id_item_vendible", promocion.getIdItemVendible());
            cs.setString("_nombre", promocion.getNombre());
            cs.setDouble("_precio", promocion.getPrecio());
            cs.setString("_descripcion", promocion.getDescripcion());
            cs.setBoolean("_estado", promocion.isEstado());
            cs.executeUpdate();
           
            //modificamos cada una de las Lineas asociadas a la promo 
            for (LineaPromocion linea : promocion.getLista_de_Comidas()) {
                cs= con.prepareCall("{call MODIFICAR_LINEA_PROMOCION(?,?,?,?,?)}");
                cs.setInt("_id_linea_promocion", linea.getIdLineaPromocion()); // el _id_linea_promocion es aparte del itemvendi
                cs.setInt("_unidad", linea.getUnidades());
                cs.setInt("_fid_promocion", promocion.getIdItemVendible());//aun necesita la FK 
                //cs.setInt("_fid_promocion", linea.getPromocion().getIdItemVendible());//este es el item vendible
                cs.setInt("_fid_producto", linea.getProducto().getIdItemVendible());
                cs.setBoolean("_estado", linea.isEstado());
                cs.executeUpdate();
                
            }
            resultado = 1;
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado; 
    }

    @Override
    public int eliminar(int idPromocion) {
        int resultado = 0;
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_PROMOCION(?)}");
            cs.setInt("_id_item_vendible", idPromocion);
            cs.executeUpdate();
            resultado = 1;
            
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado; 
    }

    @Override
    public ArrayList<Promocion> listarTodos() {
        ArrayList<Promocion> promociones= new ArrayList<>();
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PROMOCIONES_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Promocion promocion = new Promocion();
                promocion.setIdItemVendible(rs.getInt("id_item_vendible"));
                promocion.setNombre(rs.getString("nombre"));
                promocion.setPrecio(rs.getDouble("precio"));
                promocion.setDescripcion(rs.getString("descripcion"));
                promocion.setEstado(rs.getBoolean("estado"));
                
                //creacion de la lista asociada
                promocion.setLista_de_Comidas(new ArrayList<LineaPromocion>());
                
                cs=con.prepareCall("{call LISTAR_LINEA_PROMOCION_PROMO(?)}");
                cs.setInt("_idPromo", promocion.getIdItemVendible());
                ResultSet subrs = cs.executeQuery();
                while (subrs.next()) {
                    LineaPromocion linea=new LineaPromocion();//la promo ya apunta a cada linea 
                    linea.setEstado(subrs.getBoolean("estado"));
                    linea.setIdLineaPromocion(subrs.getInt("id_linea_promocion"));
                    linea.setUnidades(subrs.getInt("unidad"));
                    //linea.setPromocion(promocion);//apuntan al que los contiene -> no porque los hace ciclicos
                    
                    //insertamos datos de producto,hereda de item vendible y tiene categoria
                    
                    Producto nuevo = new Producto();
                    Categoria categoria= new Categoria();
                    categoria.setActivo(subrs.getBoolean("activo"));
                    categoria.setDescripcion(subrs.getString("descripcion"));
                    categoria.setIdCategoria(subrs.getInt("id_categoria"));
                    categoria.setNombre(subrs.getString("nombre"));
                    nuevo.setCategoria(categoria);
                    
                    nuevo.setIdProducto(subrs.getInt("id_producto"));
                    nuevo.setPresentacion(subrs.getString("presentacion"));
                    nuevo.setTipoProducto(subrs.getString("fid_tipo_producto").charAt(0));
                    nuevo.setDescripcion(subrs.getString("descripcion"));
                    nuevo.setEstado(subrs.getBoolean("estado"));
                    nuevo.setIdItemVendible(subrs.getInt("id_item_vendible"));//este es el id del producto en la linea
                    //no el id de la promocion que tiene el nombre de _id_item_vendible
                    nuevo.setNombre(subrs.getString("nombre"));
                    nuevo.setPrecio(subrs.getDouble("precio"));
                    
                    linea.setProducto(nuevo);
                    //fin del seteo de producto ahora sigue linea
                    linea.setIdLineaPromocion(subrs.getInt("fid_producto"));
                    promocion.getLista_de_Comidas().add(linea);//agregamos a la lista 
                }
                promociones.add(promocion);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return promociones; 
    }

    @Override
    public ArrayList<Promocion> listarTodosXID_nombre(String idnom) {
        ArrayList<Promocion> promociones= new ArrayList<>();
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PROMOCIONES_X_NOMBRE(?)}");
            cs.setString("_nom", idnom);
            rs = cs.executeQuery();
            while(rs.next()){
                Promocion promocion = new Promocion();
                promocion.setIdItemVendible(rs.getInt("id_item_vendible"));
                promocion.setNombre(rs.getString("nombre"));
                promocion.setPrecio(rs.getDouble("precio"));
                promocion.setDescripcion(rs.getString("descripcion"));
                promocion.setEstado(rs.getBoolean("estado"));
                
                promociones.add(promocion);
                //creacion de la lista asociada
                //no hay porque quita tiempo pero se puede usar el listar lineas 
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return promociones; 
    }
    
}
