import java.util.ArrayList;
class Usuario{
	private static int i = 1;
    private int id_usuario;
	private String nombre;
	private String apellido;
	private String correo;
    private String usuario;
	private String password;
	private int telefono;
	private boolean estado;
	private int DNI;
    private byte[] imagen;
    private float salario;    
    private ArrayList<HistorialAsistencia> hist_asistencia; 
    private Restaurante restaurante;

    //CONSTRUCTORES ----------------------------------------------
    public Usuario(){
        id_usuario = i;
        i++;
        estado = true;  //el usuario se inicializa como activo
        salario = 0;
    }

	// SETTERS Y GETTERS ---------------------------------------------------
    public int getId_usuario(){
		return id_usuario;
    }
    public void setId_usuario(int id_usuario){
		this.id_usuario = id_usuario;
    }

	public String getNombre(){
		return nombre;
    }
    public void setNombre(String nombre){
        this.nombre = nombre;
    }

    public String getApellido(){
        return apellido;
    }
    public void setApellido(String apellido){
        this.apellido = apellido;
    }

    public String getCorreo(){
            return correo;
    }
    public void setCorreo( String correo){
        this.correo = correo;
    }

    
	public String getUsuario() {
		return usuario;
	}
	public void setUsuario(String usuario) {
		this.usuario = usuario;
	}

    public String getPassword(){
            return password;
    }
    public void setPassword(String password){
        this.password = password;
    }

    public int getTelefono(){
            return telefono;
    }
    public void setTelefono(int telefono){
        this.telefono = telefono;
    }

    public boolean getEstado(){
            return estado;
    }
    public void setEstado(boolean estado){
        this.estado = estado;
    }

    public int getDNI(){
        return DNI;
    }
    public void setDNI(int DNI){
        this.DNI = DNI;
    }

    public byte[] getImagen(){
        return imagen;
    }
    public void setImagen(byte[] imagen){
        this.imagen = imagen;
    }

    public float getSalario(){
        return salario;
    }
    public void setSalario(float salario){
        this.salario = salario;
    }

    public ArrayList<HistorialAsistencia> getHist_asistencia(){
        return hist_asistencia;
    }
    public void setHist_asistencia(ArrayList<HistorialAsistencia> hist_asistencia){
        this.hist_asistencia = hist_asistencia;
    }

    public Restaurante getRestaurante() {
		return restaurante;
	}
	public void setRestaurante(Restaurante restaurante) {
		this.restaurante = restaurante;
	}
    
    // METODOS  ---------------------------------------------------
    public void RegistrarAsistencia(){

    }

}