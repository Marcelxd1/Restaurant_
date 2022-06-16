/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.lp2soft.caja.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.caja.model.Pedido;
/**
 *
 * @author DaytonCuellarSolis
 */
public interface PedidoDAO {
    ArrayList<Pedido> listarTodas();
    
    ArrayList<Pedido> listarPedidoTransaccion();
    
    int insertar(Pedido pedido);

    int modificar(Pedido pedido);

    int eliminar(int idPedido);

    Pedido listarPorId(int idPedido);
    
    Pedido listarPorMesa(int idMesa);

    ArrayList<Pedido> listarPedidosPendientes();
    int modificarEstado(int idPedido , char estado);
    
}
