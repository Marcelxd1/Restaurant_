package pe.edu.pucp.lp2soft.caja.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2soft.caja.dao.TransaccionesDAO;
import pe.edu.pucp.lp2soft.caja.model.Transaccion;
import pe.edu.pucp.lp2soft.config.DBManager;

public class TransaccionesMySQL implements TransaccionesDAO{

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    @Override
    public ArrayList<Transaccion> listarTodas() {
        ArrayList<Transaccion> transas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_TRANSACCIONES()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Transaccion tra = new Transaccion();
                tra.setId_transaccion(rs.getInt("id_transaccion"));
                tra.setTipo(rs.getString("tipo").charAt(0));
                tra.setFecha(rs.getDate("fecha"));
                tra.setTotal(rs.getDouble("total"));
                transas.add(tra);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return transas;
    }
    
    @Override
    public ArrayList<Transaccion> listarTodasXFechas(Date f1,Date f2) {
        ArrayList<Transaccion> transas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_TRANSACCIONES_X_FECHAS(?,?)}");
            cs.setDate("fecha1", new java.sql.Date(f1.getTime()));
            cs.setDate("fecha2", new java.sql.Date(f2.getTime()));
            rs = cs.executeQuery();
            while(rs.next()){
                Transaccion tra = new Transaccion();
                tra.setId_transaccion(rs.getInt("id_transaccion"));
                tra.setTipo(rs.getString("tipo").charAt(0));
                tra.setFecha(rs.getDate("fecha"));
                tra.setTotal(rs.getDouble("total"));
                transas.add(tra);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return transas;
    }
    
}
