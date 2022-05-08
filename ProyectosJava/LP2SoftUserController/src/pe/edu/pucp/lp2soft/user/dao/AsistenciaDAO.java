/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2soft.user.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.usuario.model.Persona;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;

/**
 *
 * @author axeli
 */
public interface AsistenciaDAO {
    ArrayList<Persona> listarAsistencia();
    int registrarAsistencia(Usuario usuario);
    int registrarSalida(Usuario usuario );
    int eliminarAsistencia(Usuario usuario); 
}
