package pe.edu.pucp.lp2soft.negocio.model;

public class Mesa{
    private int idMesa; 
    private int estado ; 
    private int numero ;

    //CONSTRUCTOR 
    public Mesa(){
        estado = 0;      //se crea como activo
        numero = 0;
    }

    //SETTERS Y GETTERS 
    public int getIdMesa() {
        return this.idMesa;
    }
    public void setIdMesa(int idMesa) {
        this.idMesa = idMesa;
    }

    public int getEstado() {
        return this.estado;
    }
    
    public void setEstado(int estado) {
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