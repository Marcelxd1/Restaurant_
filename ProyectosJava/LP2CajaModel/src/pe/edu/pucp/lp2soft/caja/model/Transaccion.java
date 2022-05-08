package pe.edu.pucp.lp2soft.caja.model;

import java.util.Date;

public class Transaccion {
    private int id_transaccion;
    private float total;
    private Date fecha;
    private String tipo_transaccion;
    private Gasto gasto;
    private Pedido pedido;
    private String decripcion;

    //deberia tener 1 resturante 
    public Transaccion(String tipo_transaccion) {
        this.tipo_transaccion = tipo_transaccion;
    }
    //SETTERS Y GETTERS  ---------------------------------------
    public int getId_transaccion() {
        return id_transaccion;
    }

    public void setId_transaccion(int id_transaccion) {
        this.id_transaccion = id_transaccion;
    }

    public float getTotal() {
        return total;
    }

    public void setTotal(float total) {
        this.total = total;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public String getTipo_transaccion() {
        return tipo_transaccion;
    }

    public void setTipo_transaccion(String tipo_transaccion) {
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