/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.lp2soft.negocio.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.model.Promocion;

/**
 *
 * @author yosep
 */
public interface PromocionDAO {
    int insertar(Promocion promocion);
    int modificar(Promocion promocion);
    int eliminar(int idPromocion);
    ArrayList<Promocion> listarTodos();
}
