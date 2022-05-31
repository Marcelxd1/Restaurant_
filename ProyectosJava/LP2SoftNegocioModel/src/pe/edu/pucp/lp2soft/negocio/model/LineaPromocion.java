package pe.edu.pucp.lp2soft.negocio.model;

public class LineaPromocion {
    private int idLineaPromocion;
    private int unidades;
    private Producto producto;
    private boolean estado;

    public LineaPromocion() {
    }
    
    public LineaPromocion(int idLineaPromocion, int unidades, Producto producto, Promocion promocion, boolean estado) {
        this.idLineaPromocion = idLineaPromocion;
        this.unidades = unidades;
        this.producto = producto;
        this.estado = estado;
    }
    
    
    //SETTERS Y GETTERS 
    public int getIdLineaPromocion() {
        return this.idLineaPromocion;
    }
	public void setIdLineaPromocion(int idLineaPromocion) {
        this.idLineaPromocion = idLineaPromocion;
    }

    public int getUnidades() {
        return this.unidades;
    }
    public void setUnidades(int unidades) {
        this.unidades = unidades;
    }

    public Producto getProducto() {
		return producto;
	}
	public void setProducto(Producto producto) {
		this.producto = producto;
	}
    
    //METODSO Y PROCEDIMIENTOS 

    /**
     * @return the estado
     */
    public boolean isEstado() {
        return estado;
    }

    /**
     * @param estado the estado to set
     */
    public void setEstado(boolean estado) {
        this.estado = estado;
    }
}