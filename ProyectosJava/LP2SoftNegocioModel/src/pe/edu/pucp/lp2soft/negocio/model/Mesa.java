package pe.edu.pucp.lp2soft.negocio.model;

public class Mesa {

    private int idMesa;
    private boolean estado;
    private boolean disponible;
    private int capacidad;
    private int numMesa;

    //CONSTRUCTOR 
    public Mesa() {}

    public Mesa(int capacidad) {
        this.capacidad = capacidad;
        this.estado = true;
        this.disponible = true;
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

    public int getCapacidad() {
        return this.capacidad;
    }

    public void setCapacidad(int capacidad) {
        this.capacidad = capacidad;
    }

    public boolean isDisponible() {
        return disponible;
    }

    public void setDisponible(boolean disponible) {
        this.disponible = disponible;
    }

    public int getNumMesa() {
        return numMesa;
    }

    public void setNumMesa(int numMesa) {
        this.numMesa = numMesa;
    }
    
}
