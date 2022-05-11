package pe.edu.pucp.lp2soft.caja.model;

import java.util.Date;
import pe.edu.pucp.lp2soft.usuario.model.Restaurante;

public class Transaccion {
    private int id_transaccion;
    private Restaurante restaurante;
    private double total; 
    private Date fecha;
    private boolean activo;
    private char tipo;
    
    public Transaccion(){activo=true;}

    public Transaccion(Restaurante restaurante, Date fecha, boolean activo, char tipo) {
        //this.id_transaccion = id_transaccion;
        this.restaurante = restaurante;
        this.fecha = fecha;
        this.activo = activo;
        this.tipo = tipo;
    }
    
    
    /**
     * @return the id_transaccion
     */
    public int getId_transaccion() {
        return id_transaccion;
    }

    /**
     * @param id_transaccion the id_transaccion to set
     */
    public void setId_transaccion(int id_transaccion) {
        this.id_transaccion = id_transaccion;
    }

    /**
     * @return the restaurante
     */
    public Restaurante getRestaurante() {
        return restaurante;
    }

    /**
     * @param restaurante the restaurante to set
     */
    public void setRestaurante(Restaurante restaurante) {
        this.restaurante = restaurante;
    }

    /**
     * @return the total
     */
    public double getTotal() {
        return total;
    }

    /**
     * @param total the total to set
     */
    public void setTotal(double total) {
        this.total = total;
    }

    /**
     * @return the fecha
     */
    public Date getFecha() {
        return fecha;
    }

    /**
     * @param fecha the fecha to set
     */
    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public char getTipo() {
        return tipo;
    }

    public void setTipo(char tipo) {
        this.tipo = tipo;
    }
    
    
    
    
}