/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.usuario.model;

/**
 *
 * Axel Romero (20172469)
 */
public class Rol {
    private int id_rol ; 
    private String descripcion ; 

    public Rol(String descripcion) {
        this.descripcion = descripcion;
    }
    
    
    public int getId_rol() {
        return id_rol;
    }

    public void setId_rol(int id_rol) {
        this.id_rol = id_rol;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    
    
}
