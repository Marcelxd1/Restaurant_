package pe.edu.pucp.lp2soft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2soft.negocio.dao.ProductoDAO;
import pe.edu.pucp.lp2soft.negocio.dao.PromocionDAO;
import pe.edu.pucp.lp2soft.negocio.model.Producto;
import pe.edu.pucp.lp2soft.negocio.model.Promocion;
import pe.edu.pucp.lp2soft.negocio.mysql.ProductoMySQL;
import pe.edu.pucp.lp2soft.negocio.mysql.PromocionMySQL;


@WebService(serviceName = "NegocioWS")
public class NegocioWS {
    
    private PromocionDAO daoPromo= new PromocionMySQL();
    
    private ProductoDAO daoProducto= new ProductoMySQL();
    
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
            System.out.println(listaPromos);
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
    
}
     