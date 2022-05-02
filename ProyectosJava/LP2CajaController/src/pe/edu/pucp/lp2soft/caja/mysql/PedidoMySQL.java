/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.lp2soft.caja.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.caja.dao.PedidoDAO;
import pe.edu.pucp.lp2soft.caja.model.Pedido;
import pe.edu.pucp.lp2soft.config.DBManager;

/**
 *
 * @author DaytonCuellarSolis
 */
public class PedidoMySQL implements PedidoDAO {

    private Connection con;
    private ResultSet rs;
    private PreparedStatement ps;
    private CallableStatement cs;

    @Override
    public ArrayList<Pedido> listarTodas() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int insertar(Pedido pedido){
        int resultado = 0;
        //System.out.println(mesa.getId_personaje());
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PEDIDO(?,?,?,?)}");
            cs.registerOutParameter("_id_pedido", java.sql.Types.INTEGER);
            cs.setInt("_fid_restaurante", 1);
            cs.setFloat("_total", pedido.getTotal());
            cs.setString("_tipo", String.valueOf(pedido.getTipo_transaccion()));
            //AGREGAR EL FOR DE LINEA DE PEDIDO
            cs.executeUpdate();
            pedido.setIdPedido(cs.getInt("_id_pedido"));
            resultado = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int modificar(Pedido pedido) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int eliminar(int idPedido) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public Pedido listarPorId(int idPedido) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
}
