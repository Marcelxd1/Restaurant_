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
import pe.edu.pucp.lp2soft.user.dao.RestauranteDAO;
import pe.edu.pucp.lp2soft.usuario.model.Restaurante;

/**
 *
 * Axel Romero (20172469)
 */
public class RestauranteMySQL implements RestauranteDAO {
    private Connection con ; 
    private ResultSet rs ;
    private PreparedStatement ps ;
    
    @Override
    public ArrayList<Restaurante> listarTodas() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int insertar(Restaurante restaurante) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            String sql = "INSERT INTO restaurante (ruc,nombre,telefono,direccion,dineroActual) values(?,?,?,?,?)";
            ps = con.prepareStatement(sql) ;
            ps.setString(1,restaurante.getRuc());
            ps.setString(2, restaurante.getNombre());
            ps.setString(3, restaurante.getTelefono());
            ps.setString(4, restaurante.getDireccion());
            ps.setDouble(5,0.0 );
            ps.executeUpdate();
            sql = "SELECT @@last_insert_id as id";
            ps = con.prepareStatement(sql);
            rs = ps.executeQuery();
            rs.next() ;
            restaurante.setId_restaurante(rs.getInt("id"));
            
            resultado  = 1; 
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado ;
    }

    @Override
    public int modificar(Restaurante restaurante) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int eliminar(int idRestaurante) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public Restaurante listarPorId(int idRestaurante) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

}
