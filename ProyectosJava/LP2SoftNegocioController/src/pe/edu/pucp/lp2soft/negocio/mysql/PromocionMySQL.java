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
import pe.edu.pucp.lp2soft.negocio.model.LineaPromocion;
import pe.edu.pucp.lp2soft.negocio.model.Promocion;

/**
 *
 * Jhosep Huaricallo Quispe
 * 20170398
 */
//FALTA LA LISTA DE COMIDAS
public class PromocionMySQL implements PromocionDAO{
    private Connection con; 
    private CallableStatement cs;
    private ResultSet rs;
    
    
    /* private int idItemVendible;
    private String nombre;
    private boolean estado; 
    private double precio;
    private String descripcion;*/
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
            cs.setBoolean("_estado", promocion.isEstado());
            cs.executeUpdate();
            promocion.setIdItemVendible(cs.getInt("_id_item_vendible"));
            
            for (LineaPromocion linea : promocion.getLista_de_Comidas()) {
                cs= con.prepareCall("{call INSERTAR_LINEA_PROMOCION(?,?,?,?)}");
                cs.registerOutParameter("_idLineaPromocion", java.sql.Types.INTEGER);
                cs.setInt("_unidades", linea.getUnidades());
                cs.setInt("_fid_promocion", linea.getPromocion().getIdItemVendible());
                cs.setInt("_fid_producto", linea.getProducto().getIdProducto());
                linea.setEstado(true); //porque si lo inserto entrara por defecto como activo
                
                cs.executeUpdate();
                linea.setIdLineaPromocion(cs.getInt("_idLineaPromocion"));//Este es el generado
                
            }
            resultado = 1;
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
           
            //Por ejemplo le damos la misma lista pero con las lineas cambiadas y aqui
          //las cambiaria en la BD 
          
            //modificamos cada una de las Lineas asociadas a la promo 
            //funcion sin mandar el _id_item_vendible supongo
            //porque el id no se va a cambiar y usara el que ya existe para ubicar al
            //que deba cambiar 
            //aprovecharemos que el idLinea es unico 
            for (LineaPromocion linea : promocion.getLista_de_Comidas()) {
                cs= con.prepareCall("{call MODIFICAR_LINEA_PROMOCION(?,?,?,?,?)}");
                cs.setInt("_id_linea_promocion", linea.getIdLineaPromocion()); // el _id_linea_promocion es aparte del itemvendi
                cs.setInt("_unidad", linea.getUnidades());
                cs.setInt("_fid_promocion", linea.getPromocion().getIdItemVendible());//este es el item vendible
                cs.setInt("_fid_producto", linea.getProducto().getIdProducto());
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
            
            
            //ponemos las lineas en desactivadas
            //deberia de poner un estado?
            //ELIMINAR PROMOCION SE ENCARGA DE DESACTIVAR LAS LINEASPROMOCION
            
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
                //promocion.setEstado(True);
               
                //promocion.setLista_de_Comidas(new ArrayList<>());
                LineaPromocion linea=new LineaPromocion();
                cs=con.prepareCall("{call LISTAR_LINEA_PROMOCION_PROMO(?)}");
                cs.setInt("_id_item_vendible", promocion.getIdItemVendible());
                //ahora te devuelve un query con solo las lineas que usan la promocion 
                
                ResultSet subrs = cs.executeQuery();
                while (subrs.next()) {
                    linea.setIdLineaPromocion(subrs.getInt("id_linea_promocion"));
                    linea.setUnidades(subrs.getInt("unidad"));
                    linea.setPromocion(promocion);//esto hace que todos apunten al mismo lugar lo que es riesgoso (cambias uno -> cambias el original)
                    //a la linea se le da el mismo objeto que lo contiene mmmmm....
                    //linea.getPromocion(subrs.getInt("fid_promocion"));esto no es necesario porque promocion ya esta con el id ingresado arriba
                    //linea.setProducto(subrs.get(columnLabel, type)); ESTO TENGO QUE PENSARLO SI SE USA PRODUCTO 
                    //SE CAERA PORQUE APUNTA A NULL ¿como obtengo el producto?
                    //Linea promo podria tener solo unidades idlinea y producto (o una fk producto)
                    linea.setIdLineaPromocion(subrs.getInt("fid_producto"));
                    
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
    
}
