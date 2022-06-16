package pe.edu.pucp.lp2soft.caja.dao;
import pe.edu.pucp.lp2soft.caja.model.LineaPedido;

import java.util.ArrayList;

public interface LineaPedidoDAO {
    int insertar(LineaPedido lineaPedido);
    int modificar(LineaPedido lineaPedido);
    int eliminar(int idLineaPedido);
    ArrayList<LineaPedido> listarTodas();
    LineaPedido listarPorId(int idLineaPedido);
    ArrayList<LineaPedido> listarPorPedido(int idPedido);
    ArrayList<LineaPedido>listarPedidoXMesa(int idPedido);
}

