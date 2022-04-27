package pe.edu.pucp.lp2soft.negocio.model;

public class Producto extends ItemVendible{
    private int idProducto;
    private char tipoProducto;
    private String presentacion;
    private Categoria categoria;

    public Producto(String nombre,boolean estado, double precio, String descripcion,
            char tipoProducto, String presentacion) {
        super(nombre, estado, precio, descripcion);
        this.tipoProducto = tipoProducto;
        this.presentacion = presentacion;
    }
    
    public Producto(){};
    

    public int getIdProducto() {
        return idProducto;
    }

    public void setIdProducto(int idProducto) {
        this.idProducto = idProducto;
    }

    public char getTipoProducto() {
        return tipoProducto;
    }

    public void setTipoProducto(char tipoProducto) {
        this.tipoProducto = tipoProducto;
    }

    public String getPresentacion() {
        return presentacion;
    }

    public void setPresentacion(String presentacion) {
        this.presentacion = presentacion;
    }

    public Categoria getCategoria() {
        return categoria;
    }

    public void setCategoria(Categoria categoria) {
        this.categoria = categoria;
    }
    
        
}
