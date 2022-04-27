/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.user.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.usuario.model.Rol;

/**
 *
 * Axel Romero (20172469)
 */
public interface RolDAO {
    ArrayList<Rol> listarTodas();
    int insertar(Rol rol);
    int modificar(Rol rol);
    int eliminar(int idRol);
    Rol listarPorId(int idRol);
}
