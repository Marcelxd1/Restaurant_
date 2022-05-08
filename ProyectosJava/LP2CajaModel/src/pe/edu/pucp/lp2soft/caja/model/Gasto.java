package pe.edu.pucp.lp2soft.caja.model;

public class Gasto extends Transaccion{

    //private int id_gastos;
    //id transaccion deberia de ser heredado y no deberia haber id_gastos
    private String item;//es la descripcion
    private int subtotal;//el subtotal solo sirve con las unidades( cantidades del producto) 
    private int unidades;
    
    public Gasto(int id_gastos, String descripcion ,String tipo_transaccion) {
        //this.id_gastos = id_gastos;
        this.item = descripcion;
    }
    
    //SETTERS Y GETTERS --------------------------

    public String getItem() {
        return item;
    }
    public void setItem(String item) {
        this.item = item;
    }

    //METODOS Y PROCEDIMIENTOS 

    /**
     * @return the subtotal
     */
    public int getSubtotal() {
        return subtotal;
    }

    /**
     * @param subtotal the subtotal to set
     */
    public void setSubtotal(int subtotal) {
        this.subtotal = subtotal;
    }

    /**
     * @return the unidades
     */
    public int getUnidades() {
        return unidades;
    }

    /**
     * @param unidades the unidades to set
     */
    public void setUnidades(int unidades) {
        this.unidades = unidades;
    }
}
