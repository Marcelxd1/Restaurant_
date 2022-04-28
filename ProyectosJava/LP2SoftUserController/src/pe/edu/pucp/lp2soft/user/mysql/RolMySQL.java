/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.user.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.user.dao.RolDAO;
import pe.edu.pucp.lp2soft.usuario.model.Rol;

/**
 *
 * Axel Romero (20172469)
 */
public class RolMySQL implements RolDAO{
    private Connection con ; 
    private ResultSet rs ;
    private PreparedStatement ps ;
    private CallableStatement cs  ;
    @Override
    public ArrayList<Rol> listarTodas() {
        ArrayList<Rol> roles = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ROL_TODAS()}");
            rs = cs.executeQuery();
            while (rs.next()){
                Rol rol = new Rol();
                rol.setId_rol(rs.getInt("id_rol"));
                rol.setDescripcion(rs.getString("descripcion"));
                rol.setActivo(true);
                roles.add(rol);
            }
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return roles ;
    }

    @Override
    public int insertar(Rol rol) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_ROL(?,?)}");
            cs.registerOutParameter("_id_rol", java.sql.Types.INTEGER);
            cs.setString("_descripcion", rol.getDescripcion());
            cs.executeUpdate();
            rol.setId_rol(cs.getInt("_id_rol"));  
            resultado  = 1; 
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado ;
    }

    @Override
    public int modificar(Rol rol) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_ROL(?,?)}");
            cs.setInt("_idRol",rol.getId_rol());
            cs.setString("_descripcion" , rol.getDescripcion());
            cs.executeUpdate();
            resultado  = 1; 
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado ;
    }

    @Override
    public int eliminar(int idRol) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_ROL(?)}");
            cs.setInt("_idRol",idRol);
            cs.executeUpdate();
            resultado  = 1; 
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado ;
    }

    @Override
    public Rol listarPorId(int idRol) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

}
