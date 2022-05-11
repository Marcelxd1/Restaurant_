/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.usuario.model;

/**
 *
 * Axel Romero (20172469)
 */
public class Usuario extends Persona {
    private int id_usuario ; 
    private String usuario ; 
    private String password ;
    private boolean estado ; 
    //private String imagen ; 
    private double salario ; 
    private String telefono ; 
    private Rol rol ; 
    private Restaurante restaurante ; 
    
    public Usuario(){}

    public Usuario(String usuario, String password, double salario, String telefono, String nombre, String apellido_paterno, String apellido_materno, String DNI, char tipo) {
        super(nombre, apellido_paterno, apellido_materno, DNI, tipo);
        this.usuario = usuario;
        this.password = password;
        this.salario = salario;
        this.telefono = telefono;
    }
        
   
    public int getId_usuario() {
        return id_usuario;
    }

    public void setId_usuario(int id_usuario) {
        this.id_usuario = id_usuario;
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public Rol getRol() {
        return rol;
    }

    public void setRol(Rol rol) {
        this.rol = rol;
    }

    public Restaurante getRestaurante() {
        return restaurante;
    }

    public void setRestaurante(Restaurante restaurante) {
        this.restaurante = restaurante;
    }

    
}
