package pe.edu.pucp.lp2soft.caja.model;


public class Gasto extends Transaccion{
    private int idGasto;
    private String item;
    private double precio;
    private int cantidad;
    private String descripcion;

    public Gasto(){}
    
    public Gasto(String item,double precio,
            int cantidad, String descripcion) {
        super();
        this.item = item;
        this.precio = precio;
        this.cantidad = cantidad;
        this.descripcion = descripcion;
    }
    
    public int getIdGasto() {
        return idGasto;
    }

    public void setIdGasto(int idGasto) {
        this.idGasto = idGasto;
    }

    public String getItem() {
        return item;
    }

    public void setItem(String item) {
        this.item = item;
    }

    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }


    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }
    
    
}
