package pe.edu.pucp.lp2soft.user.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.user.dao.AsistenciaDAO;
import pe.edu.pucp.lp2soft.usuario.model.Asistencia;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;

/**
 *
 * @author axeli
 */
public class AsistenciaMySQL implements AsistenciaDAO {
     private Connection con ; 
    private ResultSet rs ;
    private CallableStatement cs ;
    @Override
    public ArrayList<Asistencia> listarAsistencia() {
        ArrayList<Asistencia> asistencias = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ASISTENCIA()}");
            rs = cs.executeQuery();
            while (rs.next()){
                Asistencia asist = new Asistencia();
                asist.setId_asistencia(rs.getInt("id_asistencia"));
                asist.setHora_inicio(rs.getTime("hora_inicio"));
                asist.setHora_fin(rs.getTime("hora_fin"));
                asist.setFecha(rs.getDate("fecha"));
                asist.setUsuario(new Usuario());
                asist.getUsuario().setId_usuario(rs.getInt("id_usuario"));
                asist.getUsuario().setNombre(rs.getString("nombre"));
                asist.getUsuario().setDNI(rs.getString("DNI"));
                asistencias.add(asist);
            }
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return asistencias ;
    }

    @Override
    public int registrarAsistencia(Asistencia asistencia) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_ASISTENCIA_ENTRADA(?,?)}");
            cs.registerOutParameter("_id_asistencia", java.sql.Types.INTEGER);
            cs.setInt("_fid_usuario", asistencia.getUsuario().getId_usuario());
            cs.executeUpdate();
            asistencia.setId_asistencia(cs.getInt("_id_asistencia"));
            resultado = 1 ; 
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado ; 
    }
    @Override
    public int registrarSalida(int idAsistencia ) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call REGISTRAR_ASISTENCIA_SALIDA(?)}");
            cs.setInt("_id_asistencia",idAsistencia);
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
    public int eliminarAsistencia(int idAsistencia) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_ASISTENCIA(?)}");
            cs.setInt("_id_asistencia", idAsistencia);
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
