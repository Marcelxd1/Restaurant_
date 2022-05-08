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
        ArrayList<Persona> personas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PERSONAS()}");
            rs = cs.executeQuery();
            while (rs.next()){
                Persona persona = new Persona();
                persona.setId_persona(rs.getInt("id_persona"));
                persona.setNombre(rs.getString("nombre"));
                persona.setApellido_paterno(rs.getString("apellido_paterno"));
                persona.setDNI(rs.getString("DNI"));
                persona.setTipo('P');
                
             
                personas.add(persona);
            }
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return personas ;
    }

    @Override
    public int insertarPersona(Persona persona) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
           
            cs = con.prepareCall("{call INSERTAR_PERSONA(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_persona", java.sql.Types.INTEGER);
            cs.setString("_fid_tipo",String.valueOf(persona.getTipo()));
            cs.setString("_nombre", persona.getNombre());
            cs.setString("_apellido_paterno", persona.getApellido_paterno());
            cs.setString("_apellido_materno", persona.getApellido_materno());
            cs.setString("_DNI", persona.getDNI());
            cs.executeUpdate();
            persona.setId_persona(cs.getInt("_id_persona"));
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
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_PERSONA(?,?,?,?)}");
            cs.setInt("_id_persona",persona.getId_persona());
            cs.setString("_nombre" , persona.getNombre());
            cs.setString("_apellido_paterno" , persona.getApellido_paterno());
            cs.setString("_DNI" , persona.getDNI());
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
    public int eliminar(int idPersona) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_PERSONA(?)}");
            cs.setInt("_id_persona",idPersona);
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
    public Persona listarPorId(int idPersona) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int insertarEmpresa(Persona persona) {
        int resultado = 0 ; 
        try {
            con = DBManager.getInstance().getConnection();
           
            cs = con.prepareCall("{call INSERTAR_EMPRESA(?,?,?)}");
            cs.registerOutParameter("_id_persona", java.sql.Types.INTEGER);
            cs.setString("_razon_social",String.valueOf('E'));
            cs.setString("_ruc", persona.getNombre());
            cs.executeUpdate();
            persona.setId_persona(cs.getInt("_id_persona"));
            resultado = 1 ; 
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado ; 
    }

}
