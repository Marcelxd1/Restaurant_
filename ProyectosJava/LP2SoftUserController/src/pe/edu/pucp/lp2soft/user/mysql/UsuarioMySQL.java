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
import pe.edu.pucp.lp2soft.user.dao.RestauranteDAO;
import pe.edu.pucp.lp2soft.user.dao.UsuarioDAO;
import pe.edu.pucp.lp2soft.usuario.model.Restaurante;
import pe.edu.pucp.lp2soft.usuario.model.Rol;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;

/**
 *
 * 
 */
public class UsuarioMySQL implements UsuarioDAO {
    private Connection con ; 
    private ResultSet rs ;
    private PreparedStatement ps ;
    private CallableStatement cs; 
    
    @Override
    public ArrayList<Usuario> listarTodas() {
        ArrayList<Usuario> usuarios = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_USUARIOS()}");
            rs = cs.executeQuery();
            while (rs.next()){
                Usuario usuario = new Usuario();
                usuario.setId_usuario(rs.getInt("id_usuario"));
                usuario.setUsuario(rs.getString("usuario"));
                usuario.setSalario(rs.getInt("salario"));
                usuario.setTelefono(rs.getString("telefono"));             
                usuarios.add(usuario);
            }
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return usuarios ;
    }

    @Override
    public int insertar(Usuario usuario) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PERSONA(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_persona", java.sql.Types.INTEGER);
            cs.setString("_fid_tipo",String.valueOf(usuario.getTipo()));
            cs.setString("_nombre", usuario.getNombre());
            cs.setString("_apellido_paterno", usuario.getApellido_paterno());
            cs.setString("_apellido_materno", usuario.getApellido_materno());
            cs.setString("_DNI", usuario.getDNI());
            cs.executeUpdate();
            usuario.setId_usuario(cs.getInt("_id_persona"));
            usuario.setId_persona(cs.getInt("_id_persona"));
            
            cs = con.prepareCall("{call INSERTAR_USUARIO(?,?,?,?,?,?,?)}");
            cs.setInt("_id_usuario",usuario.getId_persona());
            cs.setInt("_fid_rol", usuario.getRol().getId_rol());
            cs.setInt("_fid_restaurante", usuario.getRestaurante().getId_restaurante());
            cs.setString("_usuario", usuario.getUsuario());
            cs.setString("_password", usuario.getPassword());
            cs.setDouble("_salario", usuario.getSalario());
            cs.setString("_telefono", usuario.getTelefono());
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
    public int modificar(Usuario usuario) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_USUARIO(?)}");
            cs.setInt("_id_usuario", usuario.getId_usuario());
            cs.setString("_usuario", usuario.getUsuario());
            cs.setString("_password", usuario.getPassword());
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
    public int eliminar(int idUsuario) {
       int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_USUARIO(?)}");
            cs.setInt("_id_usuario",idUsuario);
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
    public Usuario listarPorId(int idUsuario) {
        Usuario usuario = null;
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_USUARIO_POR_ID(?)}");
            cs.setInt("_id_usuario", idUsuario);
            rs = cs.executeQuery();
            if(rs.next()){
                usuario = new Usuario();
                usuario.setId_persona(idUsuario);
                
                usuario.setNombre(rs.getString("nombre"));
                usuario.setApellido_paterno(rs.getString("apellido_paterno"));
                usuario.setApellido_materno(rs.getString("apellido_materno"));
                usuario.setDNI(rs.getString("DNI"));
                
                usuario.setTipo(rs.getString("fid_tipo").charAt(0));
                usuario.setRazon_social(rs.getString("razon_social"));
                usuario.setRuc(rs.getString("RUC"));
                
                usuario.setRol(new Rol());
                usuario.getRol().setId_rol(rs.getInt("id_rol"));
                usuario.getRol().setDescripcion(rs.getString("descripcion"));
                usuario.getRol().setActivo(true);
                
                RestauranteDAO daorest = new RestauranteMySQL();
                usuario.setRestaurante(daorest.listarPorId(rs.getInt("fid_restaurante")));
                
                usuario.setUsuario(rs.getString("usuario"));
                usuario.setPassword(rs.getString("password"));
                usuario.setSalario(rs.getDouble("salario"));
                usuario.setTelefono(rs.getString("telefono"));
                
            }
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return usuario;
    }

}
