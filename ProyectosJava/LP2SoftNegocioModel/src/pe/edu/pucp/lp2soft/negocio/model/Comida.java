package pe.edu.pucp.lp2soft.negocio.model;

public class Comida extends Producto{
    private int idComida;
    //private Tipo_Comida tipo_comida;
    //a
    public Comida(String nombre, boolean estado, double precio, String descripcion) {
        super(nombre, estado, precio, descripcion);
    }
    
    public Comida(){};

    public int getIdComida() {
        return idComida;
    }

    public void setIdComida(int idComida) {
        this.idComida = idComida;
    }
    
}
