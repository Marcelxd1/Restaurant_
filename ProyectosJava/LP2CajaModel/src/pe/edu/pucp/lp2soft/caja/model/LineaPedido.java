package pe.edu.pucp.lp2soft.caja.model;

import pe.edu.pucp.lp2soft.negocio.model.ItemVendible;

public class LineaPedido{
    private int id_linea_pedido;
    private ItemVendible item; //solo hay 1 tipo de item
    private Pedido pedido;//esta por gusto creo porque pedido si puede llegar aqui a travez de la lista 
    private int unidades;//se repite
    private double subtotal;
    private boolean activo;

    public LineaPedido() {
    }
    
    public LineaPedido( ItemVendible item, int unidades) {
        //Pedido pedido
        //this.id_linea_pedido = id_linea_pedido;
        this.item = item;
        //this.pedido = pedido;
        this.unidades = unidades;
        this.subtotal= unidades*item.getPrecio();
        //this.subtotal = subtotal;mal
        
    }
    
	public LineaPedido(ItemVendible item, Pedido pedido, int unidades){
        this.item = item;
        this.pedido = pedido;
        this.unidades = unidades;
    }
    
    //SETTERS Y GETTERS 
    public int getId_linea_pedido() {
        return id_linea_pedido;
    }
	public void setId_linea_pedido(int id_linea_pedido) {
        this.id_linea_pedido = id_linea_pedido;
    }

    public int getUnidades() {
        return unidades;
    }
    public void setUnidades(int unidades) {
        this.unidades = unidades;
    }

    public double getSubtotal() {
        return subtotal;
    }
    public void setSubtotal(double subtotal) {
        this.subtotal = subtotal;
    }

    public Pedido getPedido() {
		return pedido;
	}
	public void setPedido(Pedido pedido) {
		this.pedido = pedido;
	}

    public ItemVendible getItem() {
		return item;
	}
	public void setItem(ItemVendible item) {
		this.item = item;
	}
        
       

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

}