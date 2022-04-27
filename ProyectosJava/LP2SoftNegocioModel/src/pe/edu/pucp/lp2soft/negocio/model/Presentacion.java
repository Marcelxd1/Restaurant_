package pe.edu.pucp.lp2soft.negocio.model;

public class Presentacion {
    private int idPresentacion;
    private String descripcion;

    public Presentacion(String descripcion) {
        this.descripcion = descripcion;
    }
    

    public int getIdPresentacion() {
        return idPresentacion;
    }

    public void setIdPresentacion(int idPresentacion) {
        this.idPresentacion = idPresentacion;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    
    
    
}
