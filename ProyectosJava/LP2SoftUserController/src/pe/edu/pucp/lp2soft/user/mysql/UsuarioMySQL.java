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
import pe.edu.pucp.lp2soft.user.dao.UsuarioDAO;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;

/**
 *
 * 
 */
public class UsuarioMySQL implements UsuarioDAO {
    private Connection con ; 
    private ResultSet st ;
    private PreparedStatement ps ;
    
    @Override
    public ArrayList<Usuario> listarTodas() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int insertar(Usuario usuario) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            String sql = "INSERT INTO usuario(id_usuario, fid_rol,fid_restaurante,usuario,password,estado,salario,telefono) values(?,?,?,?,?,?,?,?)";
            ps = con.prepareStatement(sql);
            ps.setInt(1, usuario.getPersona().getId_persona());
            ps.setInt(2, usuario.getRol().getId_rol());
            ps.setInt(3, usuario.getRestaurante().getId_restaurante());
            ps.setString(4, usuario.getUsuario());
            ps.setString(5, usuario.getPassword());
            ps.setBoolean(6, true);
            ps.setDouble(7, usuario.getSalario());
            ps.setString(8, usuario.getTelefono());
            ps.executeUpdate();
            resultado = 1 ; 
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado ; 
    }

    @Override
    public int modificar(Usuario bebida) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int eliminar(int idBebida) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public Usuario listarPorId(int idBebida) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

}
