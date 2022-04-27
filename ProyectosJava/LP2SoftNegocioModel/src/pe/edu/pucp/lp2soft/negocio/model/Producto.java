package pe.edu.pucp.lp2soft.negocio.model;

public class Producto extends ItemVendible{
    private int idProducto;
    //private ArrayList<LineaPromocion> combosDisponibles;//incluidoEn

    public Producto(String nombre, boolean estado, double precio, String descripcion) {
        super(nombre, estado, precio, descripcion);
    }
    
    public Producto(){};

    public int getIdProducto() {
        return idProducto;
    }

    public void setIdProducto(int idProducto) {
        this.idProducto = idProducto;
    }
    
}
