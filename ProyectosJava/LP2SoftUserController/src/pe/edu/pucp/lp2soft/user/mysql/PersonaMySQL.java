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
import pe.edu.pucp.lp2soft.user.dao.PersonaDAO;
import pe.edu.pucp.lp2soft.usuario.model.Persona;

/**
 *
 * Axel Romero (20172469)
 */
public class PersonaMySQL implements PersonaDAO {
    private Connection con ; 
    private ResultSet rs ;
    private PreparedStatement ps ;
    private CallableStatement cs ; 
    @Override
    public ArrayList<Persona> listarTodas() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int insertar(Persona persona) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            
            cs = con.prepareCall("{call INSERTAR_PERSONA(?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_persona", java.sql.Types.INTEGER);
            cs.setString("_nombre", persona.getNombre());
            cs.setString("_apellidoPat", persona.getApellido_paterno());
            cs.setString("_apellidoMat", persona.getApellido_materno());
            cs.setString("_DNI", persona.getDNI());
            cs.setString("_tipo", String.valueOf(persona.getTipo()));
            cs.setString("_razon_social", persona.getRazon_social());
            cs.setString("_RUC", persona.getRuc());
            cs.executeUpdate();
            persona.setId_persona(cs.getInt("_id_persona"));
            
            
//            String sql = "INSERT INTO persona(nombre,apellido_paterno,apellido_materno,DNI,tipo,razon_social,RUC) values(?,?,?,?,?,?,?)";
//            ps = con.prepareStatement(sql);
//            ps.setString(1, persona.getNombre());
//            ps.setString(2, persona.getApellido_paterno());
//            ps.setString(3, persona.getApellido_materno());
//            ps.setString(4, persona.getDNI());
//            ps.setString(5 ,String.valueOf(persona.getTipo()));
//            ps.setString(6, persona.getRazon_social());
//            ps.setString(7, persona.getRuc());
//            ps.executeUpdate();
//            sql = "SELECT @@last_insert_id as id " ; 
//            ps = con.prepareStatement(sql);
//            rs = ps.executeQuery();
//            rs.next() ;
//            persona.setId_persona(rs.getInt("id"));
            resultado = 1 ; 
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado ; 
    }

    @Override
    public int modificar(Persona persona) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int eliminar(int idPersona) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public Persona listarPorId(int idPersona) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

}
