package pe.edu.pucp.lp2soft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2soft.user.dao.AsistenciaDAO;
import pe.edu.pucp.lp2soft.user.dao.PersonaDAO;
import pe.edu.pucp.lp2soft.user.dao.UsuarioDAO;
import pe.edu.pucp.lp2soft.user.mysql.AsistenciaMySQL;
import pe.edu.pucp.lp2soft.user.mysql.PersonaMySQL;
import pe.edu.pucp.lp2soft.user.mysql.UsuarioMySQL;
import pe.edu.pucp.lp2soft.usuario.model.Asistencia;
import pe.edu.pucp.lp2soft.usuario.model.Persona;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;


@WebService(serviceName = "UserWS")
public class UserWS {

    private AsistenciaDAO daoAsistencia = new AsistenciaMySQL();
    private UsuarioDAO daoUsuario = new UsuarioMySQL();
    private PersonaDAO daoPersona = new PersonaMySQL();
    
    //ASISTENCIA =========================================================================

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

    //USUARIO =========================================================================
    
    @WebMethod(operationName = "insertarUsuario")
    public int insertarUsuario(@WebParam(name = "Usuario") Usuario usuario) {
        int resultado = 0;
        try{
            resultado= daoUsuario.insertar(usuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarUsuario")
    public int modificarUsuario(@WebParam(name = "Usuario") Usuario usuario) {
        int resultado = 0;
        try{
            resultado= daoUsuario.modificar(usuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "elminarUsuario")
    public int elminarUsuario(@WebParam(name = "idUsuario") int idUsuario) {
        int resultado = 0;
        try{
            resultado= daoUsuario.eliminiar(idUsuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTodosUsuarios")
    public ArrayList<Usuario> listarTodosUsuarios() {
        ArrayList<Usuario> usuarios = new ArrayList<>();
        try{
            usuarios= daoUsuario.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return usuarios;
    }
    
    @WebMethod(operationName = "listarUsuariosXNombre")
    public ArrayList<Usuario> listarUsuariosXNombre(@WebParam(name = "nombre") String nombre) {
        ArrayList<Usuario> usuarios = new ArrayList<>();
        try{
            usuarios= daoUsuario.listarXNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return usuarios;
    }
    
    //CLIENTE  PERSONA=========================================================================
    @WebMethod(operationName = "insertarPersona")
    public int insertarPersona(@WebParam(name = "Persona") Persona persona) {
        int resultado = 0;
        try{
            resultado= daoPersona.insertarPersona(persona);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarPersona")
    public int modificarPersona(@WebParam(name = "Persona") Persona persona) {
        int resultado = 0;
        try{
            resultado= daoPersona.modificarPersona(persona);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "elminarPersona")
    public int elminarPersona(@WebParam(name = "idPersona") int idPersona) {
        int resultado = 0;
        try{
            resultado= daoPersona.eliminarPersona(idPersona);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPersona")
    public ArrayList<Persona> listarPersona() {
        ArrayList<Persona> personas = new ArrayList<>();
        try{
            personas= daoPersona.listarPersonas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return personas;
    }
    
    @WebMethod(operationName = "insertarEmpresa")
    public int insertarEmpresa(@WebParam(name = "Persona") Persona persona) {
        int resultado = 0;
        try{
            resultado= daoPersona.insertarEmpresa(persona);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarEmpresa")
    public int modificarEmpresa(@WebParam(name = "Persona") Persona persona) {
        int resultado = 0;
        try{
            resultado= daoPersona.modificarEmpresa(persona);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "listarEmpresa")
    public ArrayList<Persona> listarEmpresa() {
        ArrayList<Persona> personas = new ArrayList<>();
        try{
            personas= daoPersona.listarEmpresas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return personas;
    }
    
    @WebMethod(operationName = "listarPersonasTodas")
    public ArrayList<Persona> listarPersonasTodas() {
        ArrayList<Persona> personas = new ArrayList<>();
        try{
            personas= daoPersona.listarPersonasTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return personas;
    }
    
}
