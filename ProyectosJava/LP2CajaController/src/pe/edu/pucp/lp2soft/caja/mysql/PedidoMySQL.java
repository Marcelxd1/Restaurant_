/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.lp2soft.caja.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.caja.dao.PedidoDAO;
import pe.edu.pucp.lp2soft.caja.model.LineaPedido;
import pe.edu.pucp.lp2soft.caja.model.Pedido;
import pe.edu.pucp.lp2soft.caja.model.Transaccion;
import pe.edu.pucp.lp2soft.config.DBManager;

/**
 *
 * Jhosep Huaricallo Quispe
 * 20170398
 * necesita de user y negocio tambien para reconocer las clases propias de estos en caja model 
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
        try {
            con = DBManager.getInstance().getConnection();
            //valores en transaccion
            cs = con.prepareCall("{call INSERTAR_TRANSACCION(?,?,?,?)}");
            cs.registerOutParameter("_id_transaccion", java.sql.Types.INTEGER);
            cs.setInt("_fid_restaurante", pedido.getRestaurante().getId_restaurante());
            cs.setDouble("_total", pedido.getTotal());
            cs.setDate("_fecha", new java.sql.Date(pedido.getFecha().getTime()));
            cs.executeUpdate();
            pedido.setId_transaccion(cs.getInt("_id_transaccion"));
            //pedido comparte id con transaccion-> la hereda a nivel de BD
            //id pedido no deberia existir en java
            
            //datos Pedido
            cs = con.prepareCall("{call INSERTAR_PEDIDO(?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_pedido", pedido.getId_transaccion());//////////////////
            cs.setInt("_fid_mesa", pedido.getMesa().getIdMesa());
            cs.setInt("_fid_tipo_pago", pedido.getTipoPago());//es un caracter
            cs.setInt("_fid_mesero", pedido.getMesero().getId_usuario());//se deberia heredar el idPersona en usuario? en lugar de idUsuario
            cs.setInt("_fid_cajero", pedido.getCajero().getId_usuario());
            cs.setInt("_fid_tipo_pedido", pedido.getTipoPedido());//caracter
            cs.setInt("_fid_cliente", pedido.getCliente().getId_persona());
            cs.setInt("_fid_tipo_comprobante", pedido.getTipoComprobante());
            cs.setInt("_numero_comprobante", pedido.getNumeroComprobante());
            cs.setInt("_estado", pedido.getEstado());//caracter
            cs.executeUpdate();
            
            
            //Datos lineaPedido
            for (LineaPedido linea : pedido.getList_lineaPedido()) {
                cs = con.prepareCall("{call INSERTAR_LINEA_PEDIDO(?,?,?,?,?)}");
                cs.registerOutParameter("_id_linea_pedido", java.sql.Types.INTEGER);
                cs.setInt("fid_itemVendible", linea.getItem().getIdItemVendible());
                cs.setInt("fid_pedido", linea.getPedido().getIdPedido());
                cs.setInt("unidades", linea.getUnidades());
                cs.setDouble("subtotal", linea.getSubtotal());
                cs.executeUpdate();
                linea.setId_linea_pedido(cs.getInt("_id_linea_pedido"));

            }
            
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
        //modifica transacion tambien y las lineas asociadas
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            //valores en transaccion
            cs = con.prepareCall("{call MODIFICAR_TRANSACCION(?,?,?,?)}");
            cs.setInt("_id_transaccion", pedido.getId_transaccion());
            cs.setInt("_fid_restaurante", pedido.getRestaurante().getId_restaurante());
            cs.setDouble("_total", pedido.getTotal());
            cs.setDate("_fecha", new java.sql.Date(pedido.getFecha().getTime()));
            cs.executeUpdate();
            
            //datos Pedido
            cs = con.prepareCall("{call MODIFICAR_PEDIDO(?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_pedido", pedido.getId_transaccion());//////////////////
            cs.setInt("_fid_mesa", pedido.getMesa().getIdMesa());
            cs.setInt("_fid_tipo_pago", pedido.getTipoPago());//es un caracter
            cs.setInt("_fid_mesero", pedido.getMesero().getId_usuario());//se deberia heredar el idPersona en usuario? en lugar de idUsuario
            cs.setInt("_fid_cajero", pedido.getCajero().getId_usuario());
            cs.setInt("_fid_tipo_pedido", pedido.getTipoPedido());//caracter
            cs.setInt("_fid_cliente", pedido.getCliente().getId_persona());
            cs.setInt("_fid_tipo_comprobante", pedido.getTipoComprobante());
            cs.setInt("_numero_comprobante", pedido.getNumeroComprobante());
            cs.setInt("_estado", pedido.getEstado());//caracter
            cs.executeUpdate();
            
            //Datos lineaPedido
            for (LineaPedido linea : pedido.getList_lineaPedido()) {
                cs = con.prepareCall("{call INSERTAR_LINEA_PEDIDO(?,?,?,?,?)}");
                cs.setInt("_id_linea_pedido", java.sql.Types.INTEGER);
                cs.setInt("fid_itemVendible", linea.getItem().getIdItemVendible());
                cs.setInt("fid_pedido", linea.getPedido().getIdPedido());
                cs.setInt("unidades", linea.getUnidades());
                cs.setDouble("subtotal", linea.getSubtotal());
                cs.executeUpdate();

            }
            
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
    
    //un Procedure que desactive las lineasPedido si se desactiva un pedido
    //y las transancciones tambien supongo
    @Override
    public int eliminar(int idPedido) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_PEDIDO(?)}");
            cs.setInt("_id_pedido", idPedido);//////////////////
            cs.executeUpdate();
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
    public Pedido listarPorId(int idPedido) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
}
