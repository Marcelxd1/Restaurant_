package pe.edu.pucp.lp2soft.usuario.model;

import java.util.Date;

public class Asistencia {
    private int id_asistencia ;
    private Usuario usuario;
    private Date hora_inicio ; 
    private Date hora_fin;
    private Date fecha ; 
    private boolean activo;
    
    public Asistencia(){this.activo=true;}
    public int getId_asistencia() {
        return id_asistencia;
    }

    public void setId_asistencia(int id_asistencia) {
        this.id_asistencia = id_asistencia;
    }

    public Usuario getUsuario() {
        return usuario;
    }

    public void setUsuario(Usuario usuario) {
        this.usuario = usuario;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    

    public Date getHora_inicio() {
        return hora_inicio;
    }

    public void setHora_inicio(Date hora_inicio) {
        this.hora_inicio = hora_inicio;
    }

    public Date getHora_fin() {
        return hora_fin;
    }

    public void setHora_fin(Date hora_fin) {
        this.hora_fin = hora_fin;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }  
    
}
