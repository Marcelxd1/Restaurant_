package pe.edu.pucp.lp2soft.negocio.model;

public class Mesa {

    private int idMesa;
    private boolean estado;
    private int numero;

    //CONSTRUCTOR 
    public Mesa() {}

    public Mesa(int numero) {
        this.numero = numero;
    }

    //SETTERS Y GETTERS 
    public int getIdMesa() {
        return this.idMesa;
    }

    public void setIdMesa(int idMesa) {
        this.idMesa = idMesa;
    }

    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

    

    public int getNumero() {
        return this.numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    //METODOS Y PROCEDIMIENTOS ;
}
