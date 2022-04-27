/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.main;

import pe.edu.pucp.lp2soft.user.dao.PersonaDAO;
import pe.edu.pucp.lp2soft.user.dao.RestauranteDAO;
import pe.edu.pucp.lp2soft.user.dao.RolDAO;
import pe.edu.pucp.lp2soft.user.dao.UsuarioDAO;
import pe.edu.pucp.lp2soft.user.mysql.PersonaMySQL;
import pe.edu.pucp.lp2soft.user.mysql.RestauranteMySQL;
import pe.edu.pucp.lp2soft.user.mysql.RolMySQL;
import pe.edu.pucp.lp2soft.user.mysql.UsuarioMySQL;
import pe.edu.pucp.lp2soft.usuario.model.Persona;
import pe.edu.pucp.lp2soft.usuario.model.Restaurante;
import pe.edu.pucp.lp2soft.usuario.model.Rol;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;

/**
 *
 * 
 */
public class Principal {
    public static void main(String[] args) {
        Rol rol1 = new Rol("cajero");
        Restaurante rest1 = new Restaurante("123456", "POLLERIA", "353433", "sanisidro123", 0);
        Persona pers1 = new Persona("axel", "romero", "chambi", "70201028", 'P', " ", " ");
        Usuario us1 = new Usuario("axelin", "123", true, 6666.0, "98765432");
       
        us1.setRestaurante(rest1);
        us1.setPersona(pers1);
        us1.setRol(rol1);
        int resultado = 0 ; 
        RolDAO daoRol = new RolMySQL();
        resultado  = daoRol.insertar(rol1);
        if (resultado == 1){
            System.out.println("Se ha registrado el rol correctamente ");
        }
        else{
            System.out.println(" NO Se ha registrado el rol correctamente ");
        }
        RestauranteDAO daoRestaurante = new RestauranteMySQL();
        resultado = daoRestaurante.insertar(rest1);
        if (resultado == 1){
            System.out.println("Se ha registrado en la tabla restaurante correctamente ");
        }
        else{
            System.out.println(" NO Se ha registrado en la tabla restaurante correctamente ");
        }
        
        PersonaDAO daoPersona = new PersonaMySQL();
        resultado = daoPersona.insertar(pers1);
        if (resultado == 1){
            System.out.println("Se ha registrado en la tabla persona correctamente ");
        }
        else{
            System.out.println(" NO Se ha registrado en la tabla persona correctamente ");
        }
        
        UsuarioDAO daoUsuario = new UsuarioMySQL();
        resultado = daoUsuario.insertar(us1);
        if (resultado == 1){
            System.out.println("Se ha registrado en la tabla USUARIO correctamente ");
        }
        else{
            System.out.println(" NO Se ha registrado en la tabla USUARIO correctamente ");
        }
    }
}
