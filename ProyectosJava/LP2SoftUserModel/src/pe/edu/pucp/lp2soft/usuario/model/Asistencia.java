/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.usuario.model;

import java.util.ArrayList;
import java.util.Date;

/**
 *
 * Axel Romero (20172469)
 */
public class Asistencia {
    private int id_asistencia ; 
    private Date hora_inicio ; 
    private Date hora_fin;
    private Date fecha ; 
    
    private ArrayList<Usuario> usuarios ; 

    public int getId_asistencia() {
        return id_asistencia;
    }

    public void setId_asistencia(int id_asistencia) {
        this.id_asistencia = id_asistencia;
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

    public ArrayList<Usuario> getUsuarios() {
        return usuarios;
    }

    public void setUsuarios(ArrayList<Usuario> usuarios) {
        this.usuarios = usuarios;
    }
    
    
}
