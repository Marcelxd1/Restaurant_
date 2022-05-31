package pe.edu.pucp.lp2soft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2soft.user.dao.AsistenciaDAO;
import pe.edu.pucp.lp2soft.user.mysql.AsistenciaMySQL;
import pe.edu.pucp.lp2soft.usuario.model.Asistencia;


@WebService(serviceName = "UserWS")
public class UserWS {

    private AsistenciaDAO daoAsistencia = new AsistenciaMySQL();

    @WebMethod(operationName = "asistenciaEntrada")
    public int asistenciaEntrada(@WebParam(name = "idUsuario") int idUsuario) {
        int resultado = 0;
        try{
            resultado= daoAsistencia.registrarAsistencia(idUsuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "asistenciaSalida")
    public int asistenciaSalida(@WebParam(name = "idUsuario") int idUsuario) {
        int resultado = 0;
        try{
            resultado= daoAsistencia.registrarSalida(idUsuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarAsistencias")
    public ArrayList<Asistencia> listarAsistencias() {
        ArrayList<Asistencia> asistencias = new ArrayList<>();
        try{
            asistencias= daoAsistencia.listarAsistencia();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return asistencias;
    }

    @WebMethod(operationName = "eliminarAsistencia")
    public int eliminarAsistencia(@WebParam(name = "idUsuario") int idUsuario) {
        int resultado = 0;
        try{
            resultado= daoAsistencia.eliminarAsistencia(idUsuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
