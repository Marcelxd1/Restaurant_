package pe.edu.pucp.lp2soft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2soft.user.dao.AsistenciaDAO;
import pe.edu.pucp.lp2soft.user.dao.PersonaDAO;
import pe.edu.pucp.lp2soft.user.dao.RestauranteDAO;
import pe.edu.pucp.lp2soft.user.dao.RolDAO;
import pe.edu.pucp.lp2soft.user.dao.SectorDAO;
import pe.edu.pucp.lp2soft.user.dao.UsuarioDAO;
import pe.edu.pucp.lp2soft.user.mysql.AsistenciaMySQL;
import pe.edu.pucp.lp2soft.user.mysql.PersonaMySQL;
import pe.edu.pucp.lp2soft.user.mysql.RestauranteMySQL;
import pe.edu.pucp.lp2soft.user.mysql.RolMySQL;
import pe.edu.pucp.lp2soft.user.mysql.SectorMySQL;
import pe.edu.pucp.lp2soft.user.mysql.UsuarioMySQL;
import pe.edu.pucp.lp2soft.usuario.model.Actividad;
import pe.edu.pucp.lp2soft.usuario.model.Asistencia;
import pe.edu.pucp.lp2soft.usuario.model.Persona;
import pe.edu.pucp.lp2soft.usuario.model.Restaurante;
import pe.edu.pucp.lp2soft.usuario.model.Rol;
import pe.edu.pucp.lp2soft.usuario.model.Sector;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;


@WebService(serviceName = "UserWS")
public class UserWS {

    private AsistenciaDAO daoAsistencia = new AsistenciaMySQL();
    private UsuarioDAO daoUsuario = new UsuarioMySQL();
    private PersonaDAO daoPersona = new PersonaMySQL();
    private RolDAO daoRol = new RolMySQL();
    private RestauranteDAO daoREst = new RestauranteMySQL();
    private SectorDAO daoSector = new SectorMySQL();
    
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

    @WebMethod(operationName = "listarAsistenciasUsuario")
    public ArrayList<Asistencia> listarAsistenciasUsuario(int idUsuario) {
        ArrayList<Asistencia> asistencias = new ArrayList<>();
        try{
            asistencias= daoAsistencia.listarAsistenciaUsuario(idUsuario);
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
    
    @WebMethod(operationName = "modificarUsuarioTodos")
    public int modificarUsuarioTodos(@WebParam(name = "Usuario") Usuario usuario) {
        int resultado = 0;
        try{
            resultado= daoUsuario.modificarTodo(usuario);
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
    public ArrayList<Usuario> listarUsuariosXNombre(@WebParam(name = "nombre") String nombre,
            @WebParam(name = "rol") int rol) {
        ArrayList<Usuario> usuarios = new ArrayList<>();
        try{
            usuarios= daoUsuario.listarXNombre(nombre,rol);
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
    public ArrayList<Persona> listarPersona(String nombre) {
        ArrayList<Persona> personas = new ArrayList<>();
        try{
            personas= daoPersona.listarPersonasXnombre(nombre); 
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return personas;
    }
    
    
    @WebMethod(operationName = "listarClienteXNombre")
    public ArrayList<Persona> listarClienteXNombre(@WebParam(name = "nombre") String nombre,
            @WebParam(name = "sector")int sector,@WebParam(name = "actividad")int actividad) {
        ArrayList<Persona> personas = new ArrayList<>();
        try{
            personas = daoPersona.listarClientesXNombre(nombre,sector,actividad);
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
    
    @WebMethod(operationName = "verificarCuentaUsuario")
    public Usuario verificarCuentaUsuario(@WebParam(name = "usuario") Usuario usuario) {
        Usuario user = new Usuario() ; 
        try{
            user = daoUsuario.verificarUsuario(usuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return user ;
    }
    
    @WebMethod(operationName = "buscarPersonaPorIdUsuario")
    public Persona buscarPersonaPorIdUsuario(@WebParam(name = "id_usuario") int id_usuario) {
        Persona persona  = new Persona(); 
        try{
            persona = daoPersona.listarPorId(id_usuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return persona ;
    }
    
    @WebMethod(operationName = "buscarRolPorId")
    public Rol buscarRolPorId(@WebParam(name = "id_rol") int id_rol) {
        Rol rol  = new Rol(); 
        try{
           rol = daoRol.listarPorId(id_rol); 
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return rol ;
    }
    
    @WebMethod(operationName = "listarRolTodos")
    public ArrayList<Rol> listarRolTodos() {
        ArrayList<Rol> roles = new ArrayList<>();
        try{
            roles= daoRol.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return roles;
    }
    
    
    @WebMethod(operationName = "modificarDatosUsuario")
    public int modificarDatosUsuario(@WebParam(name = "usuario") Usuario usuario) {
        int resultado = 0;
        try{
            resultado= daoUsuario.modificarDatos(usuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "verificarUsuario")
    public int verificarUsuario(@WebParam(name = "dni") int dni , @WebParam(name = "apellido_paterno") String apellido_paterno  ) {
        int resultado = 0;
        try{
            resultado= daoUsuario.validarRecuperarContrasenia(dni, apellido_paterno);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "cambiarContrasenia")
    public int cambiarContrasenia(@WebParam(name = "id_persona") int id_persona , @WebParam(name = "password") String password  ) {
        int resultado = 0;
        try{
            resultado= daoUsuario.cambiarContrasenia(id_persona, password);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "BuscaRestaurante")
    public Restaurante BuscaRestaurante(@WebParam(name = "id_persona") int id_rest ) {
        Restaurante res = new Restaurante();
        try{
            res= daoREst.listarPorId(id_rest);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return res;
    }
    
    //=====================================================================================
    
    @WebMethod(operationName = "listarSectores")
    public ArrayList<Sector> listarSectores() {
        ArrayList<Sector> sectores = new ArrayList<>();
        try{
            sectores= daoSector.listarSectores();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return sectores;
    }
    
    @WebMethod(operationName = "listarActividadesXSector")
    public ArrayList<Actividad> listarActividadesXSector(int idSector) {
        ArrayList<Actividad> actividades = new ArrayList<>();
        try{
            actividades= daoSector.listarAcvXsector(idSector);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return actividades;
    }
}
