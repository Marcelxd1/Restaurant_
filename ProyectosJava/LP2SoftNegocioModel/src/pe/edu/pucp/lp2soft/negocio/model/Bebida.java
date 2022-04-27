package pe.edu.pucp.lp2soft.negocio.model;

public class Bebida extends Producto{
    private int idBebida;
    private Presentacion presentacion;

    public Bebida(String nombre, boolean estado, float precio, String descripcion) {
        super(nombre, estado, precio, descripcion);
    }

    public int getIdBebida() {
        return idBebida;
    }

    public void setIdBebida(int idBebida) {
        this.idBebida = idBebida;
    }

    public Presentacion getPresentacion() {
        return presentacion;
    }

    public void setPresentacion(Presentacion presentacion) {
        this.presentacion = presentacion;
    }
    
}
