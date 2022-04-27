package pe.edu.pucp.lp2soft.negocio.model;

public class LineaPromocion {
    private int idLineaPromocion;
    private int unidades;
    private Producto producto;
    private Promocion promocion;
    
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

    public Promocion getPromocion() {
		return promocion;
	}
	public void setPromocion(Promocion promocion) {
		this.promocion = promocion;
	}
    
    //METODSO Y PROCEDIMIENTOS 
}