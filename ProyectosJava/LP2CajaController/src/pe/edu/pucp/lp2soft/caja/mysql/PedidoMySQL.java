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
        //necesita un query con todos los valores de la tabla pedido , las columnas de la tabla mesa y las columnas de transaccion
        //listaLineaPedido necesita de un query con las columnas de linea pedido y las columnas de itemVendible
        ArrayList<Pedido> pedidos= new ArrayList<>();
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PEDIDOS_TODOS()}");
            rs = cs.executeQuery();//se espera un select 
            
            while(rs.next()){
                Pedido pedido = new Pedido();
                pedido.setId_transaccion(rs.getInt("id_pedido"));//el heredado
                
                
                Mesa mesa= new Mesa();//crea nueva mesa para cada pedido 
                mesa.setIdMesa(rs.getInt("id_mesa"));
                mesa.setEstado(rs.getBoolean("activo"));
                mesa.setNumero(rs.getInt("capacidad"));
                pedido.setMesa(mesa);
                
                pedido.setTipoPago((char) rs.getInt("fid_tipo_pago"));
                
                //listar mesero, cajero y cliente? 
                //la lista seria muy grande para el Procedure, (cada atributo de estos)
                UsuarioDAO daouser= new UsuarioMySQL();
                PersonaDAO daopersona= new PersonaMySQL();
                int idmesero=rs.getInt("fid_mesero");
                int idcajero=rs.getInt("fid_cajero");
                int idcliente=rs.getInt("fid_cliente");
                
                Usuario mesero = daouser.buscarPorId(idmesero);// deberia de dar un objeto
                if(mesero==null)System.out.println("ERROR ENCONTRANDO USUARIO ");
                Usuario cajero= daouser.buscarPorId(idcajero);
                if(cajero==null)System.out.println("ERROR ENCONTRANDO USUARIO ");
                Persona cliente= daopersona.buscarPorId(idcliente);
                if(cliente==null)System.out.println("ERROR ENCONTRANDO USUARIO ");
                
                //insertamos los objetos obtenidos
                pedido.setMesero(mesero);
                pedido.setCajero(cajero);
                pedido.setCliente(cliente);
                
                
                pedido.setTipoPedido((char) rs.getInt("fid_tipo_pedido"));
                pedido.setTipoComprobante((char) rs.getInt("fid_tipo_comprobante"));
                pedido.setNumeroComprobante(rs.getInt("numero_comprobante"));
                pedido.setEstado((char) rs.getInt("estado"));
                
                //datos en transaccion
                pedido.setFecha(rs.getDate("fecha"));
                
                //cargar restaurante
                RestauranteDAO daorest=new RestauranteMySQL() ;
                int idrest=rs.getInt("fid_restaurante");
                Restaurante restaurante= daorest.listarPorId(idrest);
                
                pedido.setRestaurante(restaurante);
                pedido.setTotal(rs.getDouble("total"));
                
                //lista de linea_pedido
                //lista todas las lineas que tienen el mismod fid_pedido
                cs=con.prepareCall("{call LISTAR_LINEA_PEDIDO(?)}"); 
                cs.setInt("_id_pedido", pedido.getId_transaccion());
                //ahora te devuelve un query con solo las lineas que usan el pedido 
                
                ResultSet subrs = cs.executeQuery();
                while (subrs.next()) {
                    LineaPedido linea=new LineaPedido();
                    linea.setId_linea_pedido(subrs.getInt("id_linea_pedido"));
                    
                    ItemVendible item= new ItemVendible();
                    item.setDescripcion(subrs.getString("descripcion"));
                    item.setEstado(subrs.getBoolean("estado"));
                    item.setIdItemVendible(subrs.getInt("id_item_vendible"));
                    item.setNombre(subrs.getString("nombre"));
                    item.setPrecio(subrs.getDouble("precio"));
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
                cs.setInt("_fid_itemVendible", linea.getItem().getIdItemVendible());
                cs.setInt("_fid_pedido", linea.getPedido().getIdPedido());
                cs.setInt("_unidades", linea.getUnidades());
                cs.setDouble("_subtotal", linea.getSubtotal());
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
