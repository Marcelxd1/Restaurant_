/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.lp2soft.negocio.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.model.Mesa;

/**
 *
 * @author DaytonCuellarSolis
 */
public interface MesaDAO {

    ArrayList<Mesa> listarTodas();

    int insertar(Mesa presentacion);

    int modificar(Mesa presentacion);

    int eliminar(int idPpesentacion);

    Mesa listarPorId(int idPresentacion);
}
