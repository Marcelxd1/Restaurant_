/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.user.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.usuario.model.Persona;

/**
 *
 *
 */
public interface PersonaDAO {
    ArrayList<Persona> listarPersonasTodas();
    ArrayList<Persona> listarPersonasXnombre(String nombre);
    int insertarPersona(Persona persona);
    int modificarPersona(Persona persona);
    int eliminarPersona(int idPersona);
    ArrayList<Persona> listarEmpresas();
    int insertarEmpresa(Persona persona );
    int modificarEmpresa(Persona persona);
    Persona listarPorId(int idPersona);
    ArrayList<Persona> listarClientesXNombre(String nombre, int sector,int actividad);
}
