
package pe.edu.pucp.lp2soft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2soft.caja.dao.GastoDAO;
import pe.edu.pucp.lp2soft.caja.model.Gasto;
import pe.edu.pucp.lp2soft.caja.mysql.GastoMySQL;


@WebService(serviceName = "CajaWS")
public class CajaWS {
    
    private GastoDAO daoGasto= new GastoMySQL();

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
}
