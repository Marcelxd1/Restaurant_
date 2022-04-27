package pe.edu.pucp.lp2soft.negocio.model;

class Tipo_Comida{
    private int id_tipoComida;
    private String nombre;
    private String descripcion;

    //CONSTRUCTORES ---------------------------------------
    public Tipo_Comida(){};

    public Tipo_Comida(int id_tipoComida, String nombre, String descripcion){
        this.id_tipoComida = id_tipoComida;
        this.nombre = nombre;
        this.descripcion = descripcion;
    }

    //SETTERS Y GETTERS -----------------------------------
    public int getId_tipoComida() {
        return id_tipoComida;
    }

    public void setId_tipoComida(int id_tipoComida) {
        this.id_tipoComida = id_tipoComida;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    
}