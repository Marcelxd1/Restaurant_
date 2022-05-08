/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2soft.user.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.time.LocalDateTime;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.user.dao.AsistenciaDAO;
import pe.edu.pucp.lp2soft.usuario.model.Persona;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;

/**
 *
 * @author axeli
 */
public class AsistenciaMySQL implements AsistenciaDAO {
     private Connection con ; 
    private ResultSet rs ;
    private PreparedStatement ps ;
    private CallableStatement cs ;
    @Override
    public ArrayList<Persona> listarAsistencia() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int registrarAsistencia(Usuario usuario) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call REGISTRAR_ASISTENCIA_ENTRADA(?,?)}");
            cs.registerOutParameter("_id_asistencia", java.sql.Types.INTEGER);
            cs.setInt("_fid_usuario",usuario.getId_usuario());
            cs.executeUpdate();
            usuario.setId_asistencia(cs.getInt("_id_asistencia"));
            
            resultado = 1 ; 
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado ; 
    }
    @Override
    public int registrarSalida(Usuario usuario) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call REGISTRAR_ASISTENCIA_SALIDA(?)}");
            cs.setInt("_id_asistencia",usuario.getId_asistencia());
            cs.executeUpdate();
            resultado = 1 ; 
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado ; 
    }

    @Override
    public int eliminarAsistencia(Usuario usuario) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
