package pe.edu.pucp.lp2soft.caja.model;

public class Gasto extends Transaccion{

    private int id_gastos;
    private String descripcion ; 

    //SETTERS Y GETTERS --------------------------
    public int getId_gastos() {
        return id_gastos;
    }
    public void setId_gastos(int id_gastos) {
        this.id_gastos = id_gastos;
    }

    public String getDescripcion() {
        return descripcion;
    }
    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    //METODOS Y PROCEDIMIENTOS 
}
