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
import pe.edu.pucp.lp2soft.caja.model.LineaPedido;
import pe.edu.pucp.lp2soft.caja.model.Pedido;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.negocio.model.ItemVendible;
import pe.edu.pucp.lp2soft.negocio.model.Mesa;
import pe.edu.pucp.lp2soft.user.dao.PersonaDAO;
import pe.edu.pucp.lp2soft.user.dao.RestauranteDAO;
import pe.edu.pucp.lp2soft.user.dao.UsuarioDAO;
import pe.edu.pucp.lp2soft.user.mysql.PersonaMySQL;
import pe.edu.pucp.lp2soft.user.mysql.RestauranteMySQL;
import pe.edu.pucp.lp2soft.user.mysql.UsuarioMySQL;
import pe.edu.pucp.lp2soft.usuario.model.Persona;
import pe.edu.pucp.lp2soft.usuario.model.Restaurante;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;

/**
 *
 * Jhosep Huaricallo Quispe
 * 20170398
 * necesita de user y negocio tambien para reconocer las clases propias de estos en caja model 
 * necesita de listapor ID de persona y usuario
 * talvez sea lento por las conexiones a BD
 */
public class PedidoMySQL implements PedidoDAO {

    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    //falta para que tambien muestre la transaccion
    @Override
    public ArrayList<Pedido> listarTodas() {
        ArrayList<Pedido> pedidos= new ArrayList<>();
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PEDIDOS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Pedido pedido = new Pedido();
                pedido.setIdPedido(rs.getInt("id_transaccion"));//el heredado
                
                RestauranteDAO daorest=new RestauranteMySQL() ;
                int idrest=rs.getInt("fid_restaurante");
                Restaurante restaurante= daorest.listarPorId(idrest);
                pedido.setRestaurante(restaurante);
                pedido.setTotal(rs.getDouble("total"));
                pedido.setFecha(rs.getDate("fecha"));
                Mesa mesa= new Mesa();
                mesa.setIdMesa(rs.getInt("id_mesa"));                
                mesa.setEstado(rs.getBoolean("activo"));
                mesa.setNumero(rs.getInt("capacidad"));
                pedido.setMesa(mesa);
                pedido.setTipoPago(rs.getString("fid_tipo_pago").charAt(0));
                UsuarioDAO daouser= new UsuarioMySQL();
                PersonaDAO daopersona= new PersonaMySQL();
                int idmesero=rs.getInt("fid_mesero");
                int idcajero=rs.getInt("fid_cajero");
                int idcliente=rs.getInt("fid_cliente");
                Usuario mesero = daouser.listarPorId(idmesero);
                Usuario cajero= daouser.listarPorId(idcajero);
                Persona cliente= daopersona.listarPorId(idcliente);
                //insertamos los objetos obtenidos
                pedido.setMesero(mesero);
                pedido.setCajero(cajero);
                pedido.setCliente(cliente);
                pedido.setTipoPedido(rs.getString("fid_tipo_pedido").charAt(0));
                pedido.setTipoComprobante(rs.getString("fid_tipo_comprobante").charAt(0));
                pedido.setNumeroComprobante(rs.getInt("numero_comprobante"));
                pedido.setEstado(rs.getString("fid_estado_pedido").charAt(0));
                cs=con.prepareCall("{call LISTAR_LINEA_PEDIDO()}"); 
                
                pedido.setList_lineaPedido(new ArrayList<>());
                ResultSet subrs = cs.executeQuery();
                while (subrs.next()) {
                    LineaPedido linea=new LineaPedido();
                    linea.setId_linea_pedido(subrs.getInt("id_linea_pedido"));
                    ItemVendible item= new ItemVendible();
                    item.setIdItemVendible(subrs.getInt("id_item_vendible"));
                    item.setNombre(subrs.getString("nombre"));
                    item.setPrecio(subrs.getDouble("precio"));
                    item.setDescripcion(subrs.getString("descripcion"));
                    linea.setItem(item); 
                    
                    linea.setPedido(pedido);//el mismo que los contiene
                    
                    linea.setUnidades(subrs.getInt("unidades"));
                    linea.setSubtotal(subrs.getInt("subtotal"));
                    pedido.getList_lineaPedido().add(linea);//agregar linea a la lista de lineas
                }
                pedidos.add(pedido);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return pedidos;
    }
    
    
    @Override
    public ArrayList<Pedido> listarPedidoTransaccion() {
        ArrayList<Pedido> pedidos= new ArrayList<>();
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PEDIDOS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Pedido pedido = new Pedido();
                pedido.setIdPedido(rs.getInt("id_transaccion"));//el heredado
                
                pedido.setRestaurante(new Restaurante());
                pedido.getRestaurante().setId_restaurante(rs.getInt("fid_restaurante")); 
                
                pedido.setTotal(rs.getDouble("total"));
                pedido.setFecha(rs.getDate("fecha"));
                Mesa mesa= new Mesa();
                mesa.setIdMesa(rs.getInt("id_mesa"));                
                mesa.setEstado(rs.getBoolean("activo"));
                mesa.setNumero(rs.getInt("capacidad"));
                pedido.setMesa(mesa);
                pedido.setTipoPago(rs.getString("fid_tipo_pago").charAt(0));
                
                pedido.setCajero(new Usuario());
                pedido.getCajero().setId_usuario(rs.getInt("fid_cajero")); 
                pedido.setMesero(new Usuario());
                pedido.getMesero().setId_usuario(rs.getInt("fid_mesero")); 
                pedido.setCliente(new Persona());
                pedido.getCliente().setId_persona(rs.getInt("fid_cliente")); 
                
                pedido.setTipoPedido(rs.getString("fid_tipo_pedido").charAt(0));
                pedido.setTipoComprobante(rs.getString("fid_tipo_comprobante").charAt(0));
                pedido.setNumeroComprobante(rs.getInt("numero_comprobante"));
                pedido.setEstado(rs.getString("fid_estado_pedido").charAt(0));
                
                pedidos.add(pedido);
            }
        }catch(Exception ex){
        System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return pedidos;
    }

    @Override
    public int insertar(Pedido pedido){
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            
            
            cs = con.prepareCall("{call INSERTAR_PEDIDO(?,?,?,?, ?,?,?,?, ?,?,?,?, ?)}");
            cs.registerOutParameter("_id_transaccion", java.sql.Types.INTEGER);
            cs.setInt("_fid_restaurante", pedido.getRestaurante().getId_restaurante());
            cs.setDouble("_total", pedido.getTotal());
            cs.setDate("_fecha", new java.sql.Date(pedido.getFecha().getTime()));
            
            cs.setInt("_fid_mesa", pedido.getMesa().getIdMesa());
            cs.setString("_fid_tipo_pago", String.valueOf(pedido.getTipoPago()));//es un caracter
            
            cs.setInt("_fid_mesero", pedido.getMesero().getId_usuario());
            cs.setInt("_fid_cajero", pedido.getCajero().getId_usuario());
            cs.setString("_fid_tipo_pedido", String.valueOf(pedido.getTipoPedido()));//caracter
            cs.setInt("_fid_cliente", pedido.getCliente().getId_persona());
            cs.setString("_fid_tipo_comprobante", String.valueOf(pedido.getTipoComprobante()));
            
            cs.setInt("_numero_comprobante", pedido.getNumeroComprobante());
            cs.setString("_fid_estado_pedido", String.valueOf(pedido.getEstado()));
            
            cs.executeUpdate();
            
            pedido.setIdPedido(cs.getInt("_id_transaccion"));
            //Datos lineaPedido
            for (LineaPedido linea : pedido.getList_lineaPedido()) {
                cs = con.prepareCall("{call INSERTAR_LINEA_PEDIDO(?,?,?,?, ?)}");
                cs.registerOutParameter("_id_linea_pedido", java.sql.Types.INTEGER);
                cs.setInt("_fid_itemVendible", linea.getItem().getIdItemVendible());
                cs.setInt("_fid_pedido", pedido.getIdPedido());
                cs.setInt("_unidades", linea.getUnidades());
                cs.setDouble("_subtotal", linea.getSubtotal());
                cs.executeUpdate();
                linea.setId_linea_pedido(cs.getInt("_id_linea_pedido"));
            }
            
            resultado = 1;
        } catch (Exception ex) {System.out.println(ex.getMessage());} finally 
        { try { con.close();} catch (Exception ex) {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Pedido pedido) {
        
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            //valores en transaccion
            cs = con.prepareCall("{call MODIFICAR_PEDIDO(?,?,?,?, ?,?,?,?, ?,?,?,?, ?)}");
            cs.setInt("_id_pedido", pedido.getIdPedido());
            cs.setInt("_fid_restaurante", pedido.getRestaurante().getId_restaurante());
            cs.setDouble("_total", pedido.getTotal());
            cs.setDate("_fecha", new java.sql.Date(pedido.getFecha().getTime()));
            
            cs.setInt("_fid_mesa", pedido.getMesa().getIdMesa());
            cs.setString("_fid_tipo_pago", String.valueOf(pedido.getTipoPago()));//es un caracter
            cs.setInt("_fid_mesero", pedido.getMesero().getId_usuario());
            cs.setInt("_fid_cajero", pedido.getCajero().getId_usuario());
            
            cs.setString("_fid_tipo_pedido", String.valueOf(pedido.getTipoPedido()));//caracter
            cs.setInt("_fid_cliente", pedido.getCliente().getId_persona());
            cs.setString("_fid_tipo_comprobante", String.valueOf(pedido.getTipoComprobante()));
            cs.setInt("_numero_comprobante", pedido.getNumeroComprobante());
            
            cs.setString("_fid_estado_pedido", String.valueOf(pedido.getEstado()));//caracter
            cs.executeUpdate();
            
            //Datos lineaPedido
            for (LineaPedido linea : pedido.getList_lineaPedido()) {
                cs = con.prepareCall("{call MODIFICAR_LINEA_PEDIDO(?,?,?,?,?)}");
                cs.setInt("_id_linea_pedido", java.sql.Types.INTEGER);
                cs.setInt("_fid_itemVendible", linea.getItem().getIdItemVendible());
                cs.setInt("_fid_pedido", linea.getPedido().getIdPedido());
                cs.setInt("_unidades", linea.getUnidades());
                cs.setDouble("_subtotal", linea.getSubtotal());
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
    
    @Override
    public int eliminar(int idPedido) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_PEDIDO(?)}");
            cs.setInt("_id_transaccion", idPedido);//////////////////
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
        Pedido pedido = null;
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_PEDIDO_POR_ID(?)}");
            cs.setInt("_id_pedido", idPedido);
            rs = cs.executeQuery();
            if(rs.next()){
                pedido = new Pedido();
                pedido.setIdPedido(idPedido);
                
                RestauranteDAO daores = new RestauranteMySQL();
                pedido.setRestaurante(daores.listarPorId(rs.getInt("fid_restaurante")));
                pedido.setTotal(rs.getDouble("total"));
                pedido.setFecha(rs.getDate("fecha"));
                pedido.setActivo(true);
                
                pedido.setMesa(new Mesa());
                pedido.getMesa().setIdMesa(rs.getInt("id_mesa"));
                pedido.getMesa().setEstado(true);
                pedido.getMesa().setNumero(rs.getInt("capacidad"));
                
                //producto.setTipoProducto(rs.getString("fid_tipo_producto").charAt(0));
                pedido.setTipoPago(rs.getString("fid_tipo_pago").charAt(0));
                
                UsuarioDAO mesero = new UsuarioMySQL();                             UsuarioDAO cajero = new UsuarioMySQL();     
                pedido.setMesero(mesero.listarPorId(rs.getInt("fid_mesero")));      pedido.setCajero(cajero.listarPorId(rs.getInt("fid_cajero"))); 
                
                pedido.setTipoPedido(rs.getString("fid_tipo_pedido").charAt(0));
                
                PersonaDAO cliente = new PersonaMySQL();
                pedido.setCliente(cliente.listarPorId(rs.getInt("fid_cliente")));
                pedido.setTipoComprobante(rs.getString("fid_tipo_comprobante").charAt(0));
                pedido.setNumeroComprobante(rs.getInt("numero_comprobante"));
                pedido.setTipoComprobante(rs.getString("fid_estado_pedido").charAt(0));
                
            }
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return pedido;
    }

    @Override
    public Pedido listarPorMesa(int idMesa) {
        Pedido pedido = null;
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_PEDIDO_POR_MESA(?)}");
            cs.setInt("_fid_mesa", idMesa);
            rs = cs.executeQuery();
            if(rs.next()){
                pedido = new Pedido();
                pedido.setIdPedido(rs.getInt("id_transaccion"));
                RestauranteDAO daores = new RestauranteMySQL();
                pedido.setRestaurante(daores.listarPorId(rs.getInt("fid_restaurante")));
                pedido.setTotal(rs.getDouble("total"));
                pedido.setFecha(rs.getDate("fecha"));
                pedido.setActivo(true);
                
                pedido.setMesa(new Mesa());
                pedido.getMesa().setIdMesa(rs.getInt("id_mesa"));
                pedido.getMesa().setEstado(true);
                pedido.getMesa().setNumero(rs.getInt("capacidad"));
                
                //producto.setTipoProducto(rs.getString("fid_tipo_producto").charAt(0));
                pedido.setTipoPago(rs.getString("fid_tipo_pago").charAt(0));
                
                UsuarioDAO mesero = new UsuarioMySQL();                             
                UsuarioDAO cajero = new UsuarioMySQL();     
                pedido.setMesero(mesero.listarPorId(rs.getInt("fid_mesero")));      
                pedido.setCajero(cajero.listarPorId(rs.getInt("fid_cajero"))); 
                
                pedido.setTipoPedido(rs.getString("fid_tipo_pedido").charAt(0));
                
                PersonaDAO cliente = new PersonaMySQL();
                pedido.setCliente(cliente.listarPorId(rs.getInt("fid_cliente")));
                pedido.setTipoComprobante(rs.getString("fid_tipo_comprobante").charAt(0));
                pedido.setNumeroComprobante(rs.getInt("numero_comprobante"));
                pedido.setTipoComprobante(rs.getString("fid_estado_pedido").charAt(0));
                
            }
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return pedido;
    }

    @Override
    public ArrayList<Pedido> listarPedidosPendientes() {
        ArrayList<Pedido> pedidos= new ArrayList<>();
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PEDIDOS_PENDIENTES()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Pedido pedido = new Pedido();
                pedido.setIdPedido(rs.getInt("id_transaccion"));
                Mesa mesa = new Mesa();
                mesa.setIdMesa(rs.getInt("id_mesa"));
                pedido.setMesa(mesa);
                pedido.setTipoPedido(rs.getString("fid_tipo_pedido").charAt(0));
                pedido.setEstado(rs.getString("fid_estado_pedido").charAt(0));
                pedidos.add(pedido);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return pedidos;
    }

    @Override
    public int modificarEstado(int idPedido , char estado) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            //valores en transaccion
            cs = con.prepareCall("{call MODIFICAR_ESTADO_PEDIDO(?,?)}");
            cs.setInt("_idPedido", idPedido);
            cs.setString("_estado", String.valueOf(estado));
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
}
