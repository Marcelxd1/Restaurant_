package pe.edu.pucp.lp2soft.negocio.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.negocio.model.Producto;
import pe.edu.pucp.lp2soft.negocio.dao.ProductoDAO;
import pe.edu.pucp.lp2soft.negocio.model.Categoria;

public class ProductoMySQL implements ProductoDAO{

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    @Override
    public ArrayList<Producto> listarTodas() {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PRODUCTOS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Producto producto = new Producto();
                producto.setIdItemVendible(rs.getInt("id_item_vendible"));
                producto.setNombre(rs.getString("nombre"));
                producto.setPrecio(rs.getDouble("precio"));
                producto.setEstado(rs.getBoolean("estado"));
                producto.setDescripcion(rs.getString("descripcion"));
                producto.setPresentacion(rs.getString("presentacion"));
                producto.setTipoProducto(rs.getString("fid_tipo_producto").charAt(0));
                producto.setCategoria(new Categoria());
                producto.getCategoria().setIdCategoria(rs.getInt("id_categoria"));
                producto.getCategoria().setDescripcion(rs.getString("descripcion"));
                producto.getCategoria().setNombre(rs.getString("nombre_cat"));
                productos.add(producto);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return productos;
    }

    @Override
    public int insertar(Producto producto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PRODUCTO(?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_item_vendible", java.sql.Types.INTEGER);
            cs.setString("_nombre", producto.getNombre());
            cs.setDouble("_precio", producto.getPrecio());
            cs.setString("_descripcion", producto.getDescripcion());
            cs.setBoolean("_estado", true);
            cs.setString("_fid_tipo_producto", String.valueOf(producto.getTipoProducto()));
            cs.setString("_presentacion", producto.getPresentacion());
            cs.setInt("_fid_categoria", producto.getCategoria().getIdCategoria());
            cs.executeUpdate();
            producto.setIdItemVendible(cs.getInt("_id_item_vendible"));
            resultado = producto.getIdItemVendible();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Producto producto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_PRODUCTO(?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_item_vendible",producto.getIdItemVendible());
            cs.setString("_nombre", producto.getNombre());
            cs.setDouble("_precio", producto.getPrecio());
            cs.setString("_descripcion", producto.getDescripcion());
            cs.setBoolean("_estado", producto.isEstado());
            cs.setString("_fid_tipo_producto", String.valueOf(producto.getTipoProducto()));
            cs.setString("_presentacion", producto.getPresentacion());
            cs.setInt("_fid_categoria", producto.getCategoria().getIdCategoria());
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
    public int eliminar(int idProducto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_PRODUCTO(?)}");
            cs.setInt("_id_item_vendible", idProducto);
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
    public ArrayList<Producto> listarXNombre(String nombre) {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PRODUCTOS_X_NOMBRE(?)}");
            cs.setString("_nombre",nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Producto producto = new Producto();
                producto.setIdProducto(rs.getInt("id_item_vendible"));
                producto.setIdItemVendible(rs.getInt("id_item_vendible"));
                producto.setNombre(rs.getString("nombre"));
                producto.setPrecio(rs.getDouble("precio"));
                producto.setDescripcion(rs.getString("descripcion"));
                producto.setPresentacion(rs.getString("presentacion"));
                producto.setTipoProducto(rs.getString("fid_tipo_producto").charAt(0));
                producto.setCategoria(new Categoria());
                producto.getCategoria().setIdCategoria(rs.getInt("id_categoria"));
                producto.getCategoria().setDescripcion(rs.getString("descripcion"));
                producto.getCategoria().setNombre(rs.getString("nombre_cat"));
                productos.add(producto);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return productos;
    }


}
