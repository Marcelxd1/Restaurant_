/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.lp2soft.negocio.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.negocio.dao.MesaDAO;
import pe.edu.pucp.lp2soft.negocio.model.Categoria;
import pe.edu.pucp.lp2soft.negocio.model.Mesa;
import pe.edu.pucp.lp2soft.negocio.model.Producto;

public class MesaMySQL implements MesaDAO {

    private Connection con;
    private ResultSet rs;
    private PreparedStatement ps;
    private CallableStatement cs;

    @Override
    public ArrayList<Mesa> listarTodas() {
        ArrayList<Mesa> mesas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_MESA()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Mesa mesa = new Mesa();
                mesa.setIdMesa(rs.getInt("id_mesa"));
                mesa.setNumero(rs.getInt("capacidad"));
                mesa.setEstado(1);
                mesas.add(mesa);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return mesas;
    }

    @Override
    public int insertar(Mesa mesa) {
        int resultado = 0;
        //System.out.println(mesa.getId_personaje());
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_MESA(?,?,?)}");
            cs.registerOutParameter("_id_mesa", java.sql.Types.INTEGER);
            cs.setInt("_capacidad", mesa.getNumero());
            cs.setInt("_activo", mesa.getEstado());
            cs.executeUpdate();
            mesa.setIdMesa(cs.getInt("_id_mesa"));
            resultado = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int modificar(Mesa mesa) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_MESA(?,?)}");
            cs.setInt("_id_mesa", mesa.getIdMesa());
            cs.setInt("_capacidad", mesa.getNumero());
            cs.executeUpdate();
            resultado = 1;
            
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int eliminar(int idmesa) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_MESA(?)}");
            cs.setInt("_id_mesa", idmesa);
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public Mesa listarPorId(int idmesa) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
}