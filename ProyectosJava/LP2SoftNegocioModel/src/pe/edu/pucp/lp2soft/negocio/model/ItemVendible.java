package pe.edu.pucp.lp2soft.negocio.model;


public class ItemVendible {
    private int idItemVendible;
    private String nombre;
    private boolean estado; 
    private double precio;
    private String descripcion;

    public ItemVendible(String nombre, boolean estado, double precio, String descripcion) {
        this.nombre = nombre;
        this.estado = estado;
        this.precio = precio;
        this.descripcion = descripcion;
    }
    
    public ItemVendible(){};
    
    public int getIdItemVendible() {
        return idItemVendible;
    }

    public void setIdItemVendible(int idItemVendible) {
        this.idItemVendible = idItemVendible;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    
    
	
}
