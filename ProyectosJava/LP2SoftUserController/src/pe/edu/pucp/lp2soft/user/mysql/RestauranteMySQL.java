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
import pe.edu.pucp.lp2soft.usuario.model.Restaurante;

/**
 *
 * Axel Romero (20172469)
 */
public class RestauranteMySQL implements RestauranteDAO {
    private Connection con ; 
    private ResultSet rs ;
    private PreparedStatement ps ;
    private CallableStatement cs ;
    
    @Override
    public ArrayList<Restaurante> listarTodas() {
        ArrayList<Restaurante> restaurantes = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_RESTAURANTE_TODAS()}");
            rs = cs.executeQuery();
            while (rs.next()){
                Restaurante rest = new Restaurante();
                rest.setId_restaurante(rs.getInt("id_restaurante"));
                rest.setNombre(rs.getString("nombre"));
                rest.setRuc(rs.getString("ruc"));
                restaurantes.add(rest);
            }
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return restaurantes ;
    }

    @Override
    public int insertar(Restaurante restaurante) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_RESTAURANTE(?,?,?,?,?,?)}");

            cs.registerOutParameter("_id_rest", java.sql.Types.INTEGER);
            cs.setString("_ruc", restaurante.getRuc());
            cs.setString("_nombre", restaurante.getNombre());
            cs.setString("_telefono", restaurante.getTelefono());
            cs.setString("_direccion", restaurante.getDireccion());
            cs.setDouble("_dineroActual", restaurante.getDineroActual());
            cs.executeUpdate();
            restaurante.setId_restaurante(cs.getInt("_id_rest"));
            
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
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_RESTAURANTE(?,?,?,?,?)}");
            cs.setInt("_id_restaurante",restaurante.getId_restaurante());
            cs.setString("_ruc" , restaurante.getRuc());
            cs.setString("_nombre" , restaurante.getNombre());
            cs.setString("_telefono" , restaurante.getTelefono());
            cs.setString("_direccion" , restaurante.getDireccion());
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
    public int eliminar(int idRestaurante) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public Restaurante listarPorId(int idRestaurante) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
}