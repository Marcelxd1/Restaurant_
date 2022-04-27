package pe.edu.pucp.lp2soft.caja.model;

import java.util.Date;

public class Transaccion {
    private int id_transaccion;
    private float monto;
    private Date fecha;
    private Boolean tipo_transaccion;
    private Gasto gasto;
    private Pedido pedido;
    private String decripcion; 
    //deberia tener 1 resturante 
    
    //SETTERS Y GETTERS  ---------------------------------------
    public int getId_transaccion() {
		return id_transaccion;
	}
	public void setId_transaccion(int id_transaccion) {
		this.id_transaccion = id_transaccion;
	}

    public float getMonto() {
        return monto;
    }
    public void setMonto(float monto) {
        this.monto = monto;
    }

    public Date getFecha() {
        return fecha;
    }
    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public Boolean getTipo_transaccion() {
		return tipo_transaccion;
	}
	public void setTipo_transaccion(Boolean tipo_transaccion) {
		this.tipo_transaccion = tipo_transaccion;
	}

    public Gasto getGasto() {
		return gasto;
	}
	public void setGasto(Gasto gasto) {
		this.gasto = gasto;
	}

    public Pedido getPedido() {
		return pedido;
	}
	public void setPedido(Pedido pedido) {
		this.pedido = pedido;
	}
    
    public String getDecripcion() {
        return decripcion;
    }
	public void setDecripcion(String decripcion) {
        this.decripcion = decripcion;
    }
}
