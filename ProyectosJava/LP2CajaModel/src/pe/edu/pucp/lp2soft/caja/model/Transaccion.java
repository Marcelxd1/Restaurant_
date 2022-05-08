package pe.edu.pucp.lp2soft.caja.model;

import java.util.Date;
import pe.edu.pucp.lp2soft.usuario.model.Restaurante;

public class Transaccion {
    private int id_transaccion;
    private Restaurante restaurante;
    private float total; 
    private Date fecha;
    //private char tipo_transaccion;esto no 
    //esto de abajo con polimorfismo
//    private Gasto gasto;
//    private Pedido pedido;
//    private String decripcion;

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
    public float getTotal() {
        return total;
    }

    /**
     * @param total the total to set
     */
    public void setTotal(float total) {
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
    
    
    
    
}