/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.user.mysql;

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
    @Override
    public ArrayList<Rol> listarTodas() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int insertar(Rol rol) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            String sql = "INSERT INTO rol (descripcion) values(?)";
            ps = con.prepareStatement(sql) ;
            ps.setString(1, rol.getDescripcion());
            ps.executeUpdate();
            sql = "SELECT @@last_insert_id as id";
            ps = con.prepareStatement(sql);
            rs = ps.executeQuery();
            rs.next() ;
            rol.setId_rol(rs.getInt("id"));
            
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
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int eliminar(int idRol) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public Rol listarPorId(int idRol) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

}
