/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.user.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.usuario.model.Restaurante;

/**
 *
 * Axel Romero (20172469)
 */
public interface RestauranteDAO {
    ArrayList<Restaurante> listarTodas();
    int insertar(Restaurante restaurante);
    int modificar(Restaurante restaurante);
    int eliminar(int idRestaurante);
    Restaurante listarPorId(int idRestaurante);
}
