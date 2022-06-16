package pe.edu.pucp.lp2soft.caja.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.caja.dao.LineaPedidoDAO;
import pe.edu.pucp.lp2soft.caja.dao.PedidoDAO;
import pe.edu.pucp.lp2soft.caja.model.LineaPedido;
import pe.edu.pucp.lp2soft.caja.model.Pedido;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.negocio.model.ItemVendible;

public class LineaPedidoMySQL implements LineaPedidoDAO{

    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(LineaPedido lineaPedido) {
        int resultado = 0;
        try{
            lineaPedido.setSubtotal(lineaPedido.getItem().getPrecio()*lineaPedido.getUnidades());
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_LINEA_PEDIDO(?,?,?,? ,?)}");
            cs.registerOutParameter("_id_linea_pedido", java.sql.Types.INTEGER);
            cs.setInt("_fid_itemVendible", lineaPedido.getItem().getIdItemVendible());
            cs.setInt("_fid_pedido", lineaPedido.getPedido().getIdPedido());
            cs.setInt("_unidades", lineaPedido.getUnidades());
            cs.setDouble("_subtotal", lineaPedido.getSubtotal());
            cs.executeUpdate();
            
            lineaPedido.setId_linea_pedido(cs.getInt("_id_linea_pedido"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(LineaPedido lineaPedido) {
        int resultado = 0;
        try{
            lineaPedido.setSubtotal(lineaPedido.getItem().getPrecio()*lineaPedido.getUnidades());
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_LINEA_PEDIDO(?,?,?,?, ?)}");
            cs.setInt("_id_linea_pedido", java.sql.Types.INTEGER);
            cs.setInt("_fid_itemVendible", lineaPedido.getItem().getIdItemVendible());
            cs.setInt("_fid_pedido", lineaPedido.getPedido().getIdPedido());
            cs.setInt("_unidades", lineaPedido.getUnidades());
            cs.setDouble("_subtotal", lineaPedido.getSubtotal());
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
    public int eliminar(int idLineaPedido) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<LineaPedido> listarTodas() {
        ArrayList<LineaPedido> lineas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_LINEA_PEDIDO()}");
            rs = cs.executeQuery();
            while(rs.next()){
                LineaPedido linea=new LineaPedido();
                linea.setId_linea_pedido(rs.getInt("id_linea_pedido"));

                ItemVendible item= new ItemVendible();
                item.setIdItemVendible(rs.getInt("id_item_vendible"));
                item.setNombre(rs.getString("nombre"));
                item.setPrecio(rs.getDouble("precio"));
                item.setDescripcion(rs.getString("descripcion"));
                item.setEstado(true);
                linea.setItem(item); 
                
                PedidoDAO pedidodao = new PedidoMySQL();
                linea.setPedido(pedidodao.listarPorId(rs.getInt("fid_pedido")));//el mismo que los contiene
                
                linea.setUnidades(rs.getInt("unidades"));
                linea.setSubtotal(rs.getInt("subtotal"));
                
                lineas.add(linea);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return lineas;
    }

    @Override
    public LineaPedido listarPorId(int idLineaPedido) {
        LineaPedido linea = null;
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_LINEAPEDIDO_POR_ID(?)}");
            cs.setInt("_id_lineaPedido", idLineaPedido);
            rs = cs.executeQuery();
            if(rs.next()){
                linea = new LineaPedido();
                linea.setId_linea_pedido(idLineaPedido);
                
                linea.setItem(new ItemVendible());
                linea.getItem().setIdItemVendible(rs.getInt("fid_itemVendible"));
                linea.getItem().setNombre(rs.getString("nombre"));
                linea.getItem().setDescripcion(rs.getString("descripcion"));
                linea.getItem().setPrecio(rs.getDouble("precio"));
                linea.getItem().setEstado(true);
                
                PedidoDAO pedidodao = new PedidoMySQL();
                linea.setPedido(pedidodao.listarPorId(rs.getInt("fid_pedido")));
                
                linea.setUnidades(rs.getInt("unidades"));
                linea.setSubtotal(rs.getDouble("subtotal"));
                
            }
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return linea;
    }

    @Override
    public ArrayList<LineaPedido> listarPorPedido(int idPedido) {
        ArrayList<LineaPedido> lineas = new ArrayList<>();
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_LINEAPEDIDO_POR_PEDIDO(?)}");
            cs.setInt("_id_pedido", idPedido);
            rs = cs.executeQuery();
            while(rs.next()){
                LineaPedido linea = new LineaPedido();
                
                linea.setId_linea_pedido(rs.getInt("id_linea_pedido")); 
                
                linea.setItem(new ItemVendible());
                linea.getItem().setIdItemVendible(rs.getInt("id_item_vendible"));
                linea.getItem().setNombre(rs.getString("nombre"));
                linea.getItem().setDescripcion(rs.getString("descripcion"));
                linea.getItem().setPrecio(rs.getDouble("precio"));
                linea.getItem().setEstado(true);
                                
                linea.setUnidades(rs.getInt("unidades"));
                linea.setSubtotal(rs.getDouble("subtotal"));
                lineas.add(linea);
            }
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return lineas;
    }
    
}
