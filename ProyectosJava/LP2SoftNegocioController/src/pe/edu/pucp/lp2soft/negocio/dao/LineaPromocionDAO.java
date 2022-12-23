/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.lp2soft.negocio.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.model.LineaPromocion;

/**
 *
 * @author yosep
 */
public interface LineaPromocionDAO {
    int insertar(LineaPromocion linea,int idPromo);
    int modificar(LineaPromocion linea,int idPromo);
    int eliminar(int idLinea);
    ArrayList<LineaPromocion> listarTodos( int idPromo);
}
