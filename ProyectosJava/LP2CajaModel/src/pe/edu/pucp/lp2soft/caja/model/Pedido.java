package pe.edu.pucp.lp2soft.caja.model;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.model.Mesa;

public class Pedido extends Transaccion {

    private int idPedido;
    private float total;
    private Boolean paraLlevar;
    private Boolean paraMesa;
    private ArrayList<LineaPedido> list_lineaPedido;
    private Mesa mesa;
    private String tipoComprobante;

    //private Restaurante rest;
    public Pedido(int idPedido, float total, Mesa mesa, String tipoComprobante, String tipo_transaccion) {
        super(tipo_transaccion);
        this.idPedido = idPedido;
        this.total = total;
        this.mesa = mesa;
        this.tipoComprobante = tipoComprobante;
    }

    //CONSTRUCTORES ----------------------------------------------
    /*public Pedido() {
        total = 0;
        paraLlevar = false;     //inicializa en un pedido para no llevar
        paraMesa = false;       //inicializa en un pedido para no comer en restaurante
    }*/

    // SETTERS Y GETTERS ---------------------------------------------------
    public int getIdPedido() {
        return this.idPedido;
    }

    public void setIdPedido(int idPedido) {
        this.idPedido = idPedido;
    }

    public float getTotal() {
        return this.total;
    }

    public void setTotal(float total) {
        this.total = total;
    }

    public Boolean getParaLlevar() {
        return this.paraLlevar;
    }

    public void setParaLlevar(Boolean paraLlevar) {
        this.paraLlevar = paraLlevar;
    }

    public Boolean getParaMesa() {
        return this.paraMesa;
    }

    public void setParaMesa(Boolean paraMesa) {
        this.paraMesa = paraMesa;
    }

    public Mesa getMesa() {
        return this.mesa;
    }

    public void setMesa(Mesa mesas) {
        this.mesa = mesas;
    }

    public ArrayList<LineaPedido> getList_lineaPedido() {
        return this.list_lineaPedido;
    }

    public void setList_lineaPedido(ArrayList<LineaPedido> list_lineaPedido) {
        this.list_lineaPedido = list_lineaPedido;
    }

    /**
     * @return the tipoComprobante
     */
    public String getTipoComprobante() {
        return tipoComprobante;
    }

    /**
     * @param tipoComprobante the tipoComprobante to set
     */
    public void setTipoComprobante(String tipoComprobante) {
        this.tipoComprobante = tipoComprobante;
    }
}
