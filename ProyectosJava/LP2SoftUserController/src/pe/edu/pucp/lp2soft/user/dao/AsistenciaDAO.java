/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2soft.user.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.usuario.model.Asistencia;


/**
 *
 * @author axeli
 */
public interface AsistenciaDAO {
    ArrayList<Asistencia> listarAsistencia();
    int registrarAsistencia(int idUsuario);
    int registrarSalida(int idUsuario);
    int eliminarAsistencia(int idUsuario); 
}
