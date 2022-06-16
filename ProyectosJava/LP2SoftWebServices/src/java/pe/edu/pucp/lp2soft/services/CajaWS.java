
package pe.edu.pucp.lp2soft.services;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2soft.caja.dao.GastoDAO;
import pe.edu.pucp.lp2soft.caja.dao.LineaPedidoDAO;
import pe.edu.pucp.lp2soft.caja.dao.PedidoDAO;
<<<<<<< HEAD
import pe.edu.pucp.lp2soft.caja.model.Gasto;
import pe.edu.pucp.lp2soft.caja.model.LineaPedido;
import pe.edu.pucp.lp2soft.caja.model.Pedido;
import pe.edu.pucp.lp2soft.caja.mysql.GastoMySQL;
import pe.edu.pucp.lp2soft.caja.mysql.LineaPedidoMySQL;
import pe.edu.pucp.lp2soft.caja.mysql.PedidoMySQL;
=======
import pe.edu.pucp.lp2soft.caja.dao.TransaccionesDAO;
import pe.edu.pucp.lp2soft.caja.model.Gasto;
import pe.edu.pucp.lp2soft.caja.model.LineaPedido;
import pe.edu.pucp.lp2soft.caja.model.Pedido;
import pe.edu.pucp.lp2soft.caja.model.Transaccion;
import pe.edu.pucp.lp2soft.caja.mysql.GastoMySQL;
import pe.edu.pucp.lp2soft.caja.mysql.LineaPedidoMySQL;
import pe.edu.pucp.lp2soft.caja.mysql.PedidoMySQL;
import pe.edu.pucp.lp2soft.caja.mysql.TransaccionesMySQL;
>>>>>>> 7f091ad87dd90617e298d0471659c3b714ff2f8c


@WebService(serviceName = "CajaWS")
public class CajaWS {
    
    private GastoDAO daoGasto= new GastoMySQL();
<<<<<<< HEAD
    private PedidoDAO daoPedido= new PedidoMySQL();
    private LineaPedidoDAO daoLineaPedido= new LineaPedidoMySQL();

=======
    private PedidoDAO daoPedido = new PedidoMySQL();
    private LineaPedidoDAO daoLineaPedido = new LineaPedidoMySQL();
    private TransaccionesDAO daoTra = new TransaccionesMySQL();
    
>>>>>>> 7f091ad87dd90617e298d0471659c3b714ff2f8c
    @WebMethod(operationName = "insertarGasto")
    public int insertarGasto(@WebParam(name = "Gasto") Gasto gasto) {
        int resultado = 0;
        try{
            resultado= daoGasto.insertar(gasto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarGasto")
    public int modificarGasto(@WebParam(name = "Gasto") Gasto gasto) {
        int resultado = 0;
        try{
            resultado=daoGasto.modificar(gasto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarGasto")
    public int eliminarGasto(@WebParam(name = "idGasto") int idGasto) {
        int resultado = 0;
        try{
            resultado=daoGasto.eliminar(idGasto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTodosGastos")
    public ArrayList<Gasto> listarTodosGastos() {
        ArrayList<Gasto> gastos = new ArrayList<>();
        try{
            gastos=daoGasto.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return gastos;
    }
    
    
    @WebMethod(operationName = "listarGastosXNombre")
    public ArrayList<Gasto> listarGastosXNombre(@WebParam(name = "nombre") String nombre) {
        ArrayList<Gasto> gastos = new ArrayList<>();
        try{
            gastos=daoGasto.listarXNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return gastos;
    }
    
<<<<<<< HEAD
    //------------------------------PEDIDO------------------------------  
    @WebMethod(operationName = "insertarPedido")
    public int insertarPedido(@WebParam(name = "Pedido") Pedido pedido) {
        int resultado = 0;
        try{
            resultado= daoPedido.insertar(pedido);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarPedido")
    public int modificarPedido(@WebParam(name = "Pedido") Pedido pedido) {
        int resultado = 0;
        try{
            resultado=daoPedido.modificar(pedido);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarPedido")
    public int eliminarPedido(@WebParam(name = "idPedido") int idPedido) {
        int resultado = 0;
        try{
            resultado=daoPedido.eliminar(idPedido);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTodosPedido")
    public ArrayList<Pedido> listarTodosPedido() {
        ArrayList<Pedido> pedidos = new ArrayList<>();
        try{
            pedidos=daoPedido.listarTodas();
=======
    @WebMethod(operationName = "listarTransacciones")
    public ArrayList<Transaccion> listarTransacciones() {
        ArrayList<Transaccion> transacciones = new ArrayList<>();
        try{
            transacciones= daoTra.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return transacciones;
    }
    
    @WebMethod(operationName = "listarTransaccionesXFecha")
    public ArrayList<Transaccion> listarTransaccionesXFecha(Date f1, Date f2) {
        ArrayList<Transaccion> transacciones = new ArrayList<>();
        try{
            transacciones= daoTra.listarTodasXFechas(f1, f2);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return transacciones;
    }
    
    @WebMethod(operationName = "ListarPedidosTransaccion")
    public ArrayList<Pedido> ListarPedidosTransaccion() {
        ArrayList<Pedido> pedidos = new ArrayList<>();
        try{
            pedidos=daoPedido.listarPedidoTransaccion();
>>>>>>> 7f091ad87dd90617e298d0471659c3b714ff2f8c
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return pedidos;
    }
    
<<<<<<< HEAD
    //--------------------------LINEA PEDIDO--------------------------
    @WebMethod(operationName = "insertarLineaPedido")
    public int insertarLineaPedido(@WebParam(name = "LineaPedido") LineaPedido lineaPedido) {
        int resultado = 0;
        try{
            resultado= daoLineaPedido.insertar(lineaPedido);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarLineaPedido")
    public int modificarLineaPedido(@WebParam(name = "LineaPedido") LineaPedido lineaPedido) {
        int resultado = 0;
        try{
            resultado=daoLineaPedido.modificar(lineaPedido);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarLineaPedido")
    public int eliminarLineaPedido(@WebParam(name = "idLineaPedido") int idLineaPedido) {
        int resultado = 0;
        try{
            resultado=daoLineaPedido.eliminar(idLineaPedido);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTodosLineaPedido")
    public ArrayList<LineaPedido> listarTodosLineaPedido() {
        ArrayList<LineaPedido> lineaPedidos = new ArrayList<>();
        try{
            lineaPedidos=daoLineaPedido.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lineaPedidos;
    }
    
    
=======
    @WebMethod(operationName = "BuscarPedidoXMesa")
    public Pedido BuscarPedidoXMesa(@WebParam(name = "idPedido") int idPedido) {
        Pedido pedido = new Pedido();
        try{
            pedido=daoPedido.listarPorMesa(idPedido);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return pedido;
    }
    
    @WebMethod(operationName = "listarLineaPXPedido")
    public ArrayList<LineaPedido> listarLineaPXPedido(@WebParam(name = "idPedido") int idPedido) {
        ArrayList<LineaPedido> lineas = new ArrayList<>();
        try{
            lineas=daoLineaPedido.listarPorPedido(idPedido);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lineas;
    }
>>>>>>> 7f091ad87dd90617e298d0471659c3b714ff2f8c
}
