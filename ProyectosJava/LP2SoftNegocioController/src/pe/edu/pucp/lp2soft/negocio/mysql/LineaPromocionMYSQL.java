package pe.edu.pucp.lp2soft.negocio.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.negocio.dao.LineaPromocionDAO;
import pe.edu.pucp.lp2soft.negocio.model.Categoria;
import pe.edu.pucp.lp2soft.negocio.model.LineaPromocion;
import pe.edu.pucp.lp2soft.negocio.model.Producto;

/**
 *
 * necesario?
 */
public class LineaPromocionMYSQL implements LineaPromocionDAO{
    private Connection con; 
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(LineaPromocion linea, int idPromo) {
        int resultado = 0;
        try{
            con= DBManager.getInstance().getConnection();
            cs= con.prepareCall("{call INSERTAR_LINEA_PROMOCION(?,?,?,?)}");
            cs.registerOutParameter("_idLineaPromocion", java.sql.Types.INTEGER);
            cs.setInt("_unidades", linea.getUnidades());
            cs.setInt("_fid_promocion", idPromo);
            cs.setInt("_fid_producto", linea.getProducto().getIdItemVendible());
            linea.setEstado(true);
            cs.executeUpdate();
            linea.setIdLineaPromocion(cs.getInt("_idLineaPromocion"));
            resultado = linea.getIdLineaPromocion(); 
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(LineaPromocion linea, int idPromo) {
        int resultado = 0;
        try{
            con= DBManager.getInstance().getConnection();
            cs= con.prepareCall("{call MODIFICAR_LINEA_PROMOCION(?,?,?,?,?)}");
            cs.setInt("_id_linea_promocion", linea.getIdLineaPromocion()); 
            cs.setInt("_unidad", linea.getUnidades());
            cs.setInt("_fid_promocion", idPromo);
            cs.setInt("_fid_producto", linea.getProducto().getIdItemVendible());
            cs.setBoolean("_estado", linea.isEstado());
            cs.executeUpdate();
            resultado = 1 ;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idLinea, int idPromo) {
        int resultado = 0;
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_LINEA_PROMOCION(?,?)}");
            cs.setInt("_idlinea", idLinea);
            cs.setInt("_idPromo", idPromo);
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
    public ArrayList<LineaPromocion> listarTodos( int idPromo) {
        ArrayList<LineaPromocion> list_lineas= new ArrayList<>();
        try{
            //creacion de la lista asociada
            con= DBManager.getInstance().getConnection();
            cs=con.prepareCall("{call LISTAR_LINEA_PROMOCION_PROMO(?)}");
            cs.setInt("_idPromo", idPromo);
            ResultSet subrs = cs.executeQuery();
            while (subrs.next()) {
                LineaPromocion linea=new LineaPromocion();//la promo ya apunta a cada linea 
                linea.setEstado(subrs.getBoolean("estado"));
                linea.setIdLineaPromocion(subrs.getInt("id_linea_promocion"));
                linea.setUnidades(subrs.getInt("unidad"));
                
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
                nuevo.setIdItemVendible(subrs.getInt("id_item_vendible"));
                
                nuevo.setNombre(subrs.getString("nombre"));
                nuevo.setPrecio(subrs.getDouble("precio"));

                linea.setProducto(nuevo);
                //fin del seteo de producto ahora sigue linea
                list_lineas.add(linea);//agregamos a la lista 
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return list_lineas; 
    }
}
