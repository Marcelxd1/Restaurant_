package pe.edu.pucp.lp2soft.caja.model;

import pe.edu.pucp.lp2soft.negocio.model.ItemVendible;

class LineaPedido{
    private int id_linea_pedido;
    private int unidades;
    private float subtotal;
    private Pedido pedido;
    private ItemVendible item; //no seria un array? o era de un solo producto?
    //en cualquier caso es mejor que el atribute aqui para pasarlo rapido a pedido 
    //Linea depenede de Item entonces caja depende de Negocio
       
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

    public float getSubtotal() {
        return subtotal;
    }
    public void setSubtotal(float subtotal) {
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

	
    //METODOS Y PROCEDIMIENTOS 

}