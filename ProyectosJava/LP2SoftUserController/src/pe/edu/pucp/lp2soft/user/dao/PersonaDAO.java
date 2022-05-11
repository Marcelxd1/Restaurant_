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
    ArrayList<Persona> listarTodas();
    int insertarPersona(Persona persona);
    int insertarEmpresa(Persona persona );
    int modificar(Persona persona);
    int eliminar(int idPersona);
    Persona buscarPorId(int idPersona);
}
