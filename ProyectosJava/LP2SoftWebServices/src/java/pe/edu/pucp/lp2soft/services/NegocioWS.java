package pe.edu.pucp.lp2soft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2soft.negocio.dao.CategoriaDAO;
import pe.edu.pucp.lp2soft.negocio.dao.ItemVendibleDAO;
import pe.edu.pucp.lp2soft.negocio.dao.LineaPromocionDAO;
import pe.edu.pucp.lp2soft.negocio.dao.MesaDAO;
import pe.edu.pucp.lp2soft.negocio.dao.ProductoDAO;
import pe.edu.pucp.lp2soft.negocio.dao.PromocionDAO;
import pe.edu.pucp.lp2soft.negocio.model.Categoria;
import pe.edu.pucp.lp2soft.negocio.model.ItemVendible;
import pe.edu.pucp.lp2soft.negocio.model.LineaPromocion;
import pe.edu.pucp.lp2soft.negocio.model.Mesa;
import pe.edu.pucp.lp2soft.negocio.model.Producto;
import pe.edu.pucp.lp2soft.negocio.model.Promocion;
import pe.edu.pucp.lp2soft.negocio.mysql.CategoriaMySQL;
import pe.edu.pucp.lp2soft.negocio.mysql.ItemVendibleMySQL;
import pe.edu.pucp.lp2soft.negocio.mysql.LineaPromocionMYSQL;
import pe.edu.pucp.lp2soft.negocio.mysql.MesaMySQL;
import pe.edu.pucp.lp2soft.negocio.mysql.ProductoMySQL;
import pe.edu.pucp.lp2soft.negocio.mysql.PromocionMySQL;


@WebService(serviceName = "NegocioWS")
public class NegocioWS {
    
    private PromocionDAO daoPromo= new PromocionMySQL();
    
    private ProductoDAO daoProducto= new ProductoMySQL();
    
    private CategoriaDAO daoCategoria = new CategoriaMySQL();
    
    private LineaPromocionDAO daolineaPromo = new LineaPromocionMYSQL();
    
    private MesaDAO daoMesa = new MesaMySQL();
    
    private ItemVendibleDAO daoItem = new ItemVendibleMySQL();
    // MESA ==========================================================================
    
    @WebMethod(operationName = "insertarMesa")
    public int insertarMesa(@WebParam(name = "mesa")Mesa mesa){
        int resultado = 0;
        try{
            resultado=daoMesa.insertar(mesa);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarMesa")
    public int modificarMesa(@WebParam(name = "mesa")Mesa mesa){
        int resultado = 0;
        try{
            resultado=daoMesa.modificar(mesa);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarMesa")
    public int eliminarMesa(@WebParam(name = "idmesa")int idmesa){
        int resultado = 0;
        try{
            resultado=daoMesa.eliminar(idmesa);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTodasMesa")
    public ArrayList<Mesa> listarTodasMesa(){
        ArrayList<Mesa> resultado= new ArrayList<>() ;
        try{
            resultado=daoMesa.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    // LINEAPROMOCION ==========================================================================
    
    @WebMethod(operationName = "insertarLineaPromo")
    public int insertarLineaPromo(@WebParam(name = "Linea")LineaPromocion linea,@WebParam(name = "idPromo")int idPromo ){
        int resultado = 0;
        try{
            resultado=daolineaPromo.insertar(linea,idPromo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarLineaPromo")
    public int modificarLineaPromo(@WebParam(name = "Linea")LineaPromocion linea,@WebParam(name = "idPromo")int idPromo ){
        int resultado = 0;
        try{
            resultado=daolineaPromo.modificar(linea,idPromo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarLineaPromo")
    public int eliminarLineaPromo(@WebParam(name = "idlinea")int idlinea,@WebParam(name = "idPromo")int idPromo ){
        int resultado = 0;
        try{
            resultado=daolineaPromo.eliminar(idlinea,idPromo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "listarTodosLineaPromo")
    public ArrayList<LineaPromocion> listarTodosLineaPromo(@WebParam(name = "idPromo")int idPromo ){
        ArrayList<LineaPromocion> resultado= new ArrayList<>() ;
        try{
            resultado=daolineaPromo.listarTodos(idPromo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    // PROMOCION ==========================================================================
    
    @WebMethod(operationName = "insertarPromocion")
    public int insertarPromocion(@WebParam(name = "Promocion") Promocion promocion) {
        
        int resultado = 0;
        try{
            resultado=daoPromo.insertar(promocion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarPromocion")
    public int modificarPromocion(@WebParam(name = "Promocion") Promocion promocion) {
        int resultado = 0;
        try{
            resultado=daoPromo.modificar(promocion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarPromocion")
    public int eliminarPromocion(@WebParam(name = "idPromocion") int idPromocion) {
        int resultado = 0;
        try{
            resultado=daoPromo.eliminar(idPromocion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTodasPromociones")
    public ArrayList<Promocion> listarTodasPromociones() {
        ArrayList<Promocion> listaPromos = new ArrayList<>();
        try{
            listaPromos=daoPromo.listarTodos();
            //System.out.println(listaPromos);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return listaPromos;
    }
    
    //este solo lista la procion pero no la linea
    @WebMethod(operationName = "listarPromociones_X_nombre")
    public ArrayList<Promocion> listarPromociones_X_nombre(@WebParam(name = "idPromocion") String idnom) {
        ArrayList<Promocion> listaPromos = new ArrayList<>();
        try{
            listaPromos=daoPromo.listarTodosXID_nombre(idnom);
            //System.out.println(listaPromos);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return listaPromos;
    }
    
    // PRODUCTO ========================================================================== 
    

    @WebMethod(operationName = "insertarProducto")
    public int insertarProducto(@WebParam(name = "Producto") Producto producto) {
        int resultado = 0;
        try{
            resultado= daoProducto.insertar(producto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "modificarProducto")
    public int modificarProducto(@WebParam(name = "Producto") Producto producto) {
        int resultado = 0;
        try{
            resultado= daoProducto.modificar(producto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "eliminarProducto")
    public int eliminarProducto(@WebParam(name = "idProducto") int idProducto) {
        int resultado = 0;
        try{
            resultado= daoProducto.eliminar(idProducto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodosProductos")
    public ArrayList<Producto> listarTodosProductos() {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            productos = daoProducto.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return productos;
    }
    
    @WebMethod(operationName = "listarProductoXNombre")
    public ArrayList<Producto> listarProductoXNombre(@WebParam(name = "nombre") String nombre) {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            productos = daoProducto.listarXNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return productos;
    }
    
    @WebMethod(operationName = "listarProductoXCategoria")
    public ArrayList<Producto> listarProductoXCategoria(@WebParam(name = "nombre") String nombre) {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            productos = daoProducto.listarXCategoria(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return productos;
    }
    
    // CATEGORIA ========================================================================== 
    @WebMethod(operationName = "insertarCategoria")
    public int insertarCategoria(@WebParam(name = "Categoria") Categoria categoria) {
        int resultado = 0;
        try{
            resultado= daoCategoria.insertar(categoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "modificarCategoria")
    public int modificarCategoria(@WebParam(name = "Categoria") Categoria categoria) {
        int resultado = 0;
        try{
            resultado= daoCategoria.modificar(categoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "eliminarCategoria")
    public int eliminarCategoria(@WebParam(name = "idCategoria") int idCategoria) {
        int resultado = 0;
        try{
            resultado= daoCategoria.eliminar(idCategoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodasCategorias")
    public ArrayList<Categoria> listarTodasCategorias() {
        ArrayList<Categoria> categorias = new ArrayList<>();
        try{
            categorias = daoCategoria.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return categorias;
    }
    
    // ITEM VENDIBLE ========================================================================== 
    @WebMethod(operationName = "listarTodosItemsXNombre")
    public ArrayList<ItemVendible> listarTodosItemsXNombre(@WebParam(name = "nombre") String nombre) {
        ArrayList<ItemVendible> items = new ArrayList<>();
        try{
            items = daoItem.listarXNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return items;
    }
    
    
}
     