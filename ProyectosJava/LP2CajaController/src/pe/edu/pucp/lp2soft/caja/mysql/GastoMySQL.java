package pe.edu.pucp.lp2soft.caja.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.caja.dao.GastoDAO;
import pe.edu.pucp.lp2soft.caja.model.Gasto;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.usuario.model.Restaurante;


public class GastoMySQL implements GastoDAO{
    
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public ArrayList<Gasto> listarTodas() {
        ArrayList<Gasto> gastos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_GASTOS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Gasto gasto = new Gasto();
                gasto.setId_transaccion(rs.getInt("id_transaccion"));
                gasto.setItem(rs.getString("item"));
                gasto.setFecha(rs.getDate("fecha"));
                gasto.setPrecio(rs.getDouble("precio"));
                gasto.setCantidad(rs.getInt("cantidad"));
                gasto.setTotal(rs.getDouble("total"));
                gasto.setDescripcion(rs.getString("descripcion"));
                gasto.setRestaurante(new Restaurante());
                gasto.getRestaurante().setId_restaurante(rs.getInt("id_Restaurante"));
                gasto.getRestaurante().setNombre(rs.getString("nombre"));
                gasto.getRestaurante().setDineroActual(rs.getDouble("dineroActual"));
                gastos.add(gasto);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return gastos;
    }

    @Override
    public int insertar(Gasto gasto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_GASTO(?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_transaccion", java.sql.Types.INTEGER);
            cs.setInt("_fid_restaurante", gasto.getRestaurante().getId_restaurante());
            cs.setString("_item", gasto.getItem());
            cs.setDouble("_precio", gasto.getPrecio());
            cs.setInt("_cantidad", gasto.getCantidad());
            cs.setDouble("_total",gasto.getCantidad()*gasto.getPrecio());
            cs.setString("_descripcion", gasto.getDescripcion());
            cs.executeUpdate();
            gasto.setId_transaccion(cs.getInt("_id_transaccion"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Gasto gasto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_GASTO(?,?,?,?,?,?,?)}");
            cs.setInt("_id_transaccion",gasto.getId_transaccion());
            cs.setBoolean("_activo", gasto.isActivo());
            cs.setString("_item", gasto.getItem());
            cs.setDouble("_precio", gasto.getPrecio());
            cs.setInt("_cantidad", gasto.getCantidad());
            cs.setDouble("_total",gasto.getCantidad()*gasto.getPrecio());
            cs.setString("_descripcion", gasto.getDescripcion());
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
    public int eliminar(int IdGasto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_GASTO(?)}");
            cs.setInt("_id_transaccion", IdGasto);
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }        
}