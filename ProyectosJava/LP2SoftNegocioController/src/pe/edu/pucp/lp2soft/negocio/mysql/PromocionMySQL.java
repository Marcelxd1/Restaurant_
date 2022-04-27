/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.negocio.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.negocio.dao.PromocionDAO;
import pe.edu.pucp.lp2soft.negocio.model.LineaPromocion;
import pe.edu.pucp.lp2soft.negocio.model.Promocion;

/**
 *
 * Jhosep Huaricallo Quispe
 * 20170398
 */
//FALTA LA LISTA DE COMIDAS
public class PromocionMySQL implements PromocionDAO{
    private Connection con; 
    private CallableStatement cs;
    private ResultSet rs;

    /* private int idItemVendible;
    private String nombre;
    private boolean estado; 
    private double precio;
    private String descripcion;*/
    @Override
    public int insertar(Promocion promocion) {
        int resultado = 0;
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PROMOCION(?,?,?,?,?)}");
            cs.registerOutParameter("_id_ItemVendible", java.sql.Types.INTEGER);
            cs.setString("_nombre", promocion.getNombre());
            cs.setDouble("_precio", promocion.getPrecio());
            cs.setString("_descripcion", promocion.getDescripcion());
            cs.setBoolean("_estado", promocion.isEstado());
            cs.executeUpdate();
            promocion.setIdItemVendible(cs.getInt("_id_ItemVendible"));
            
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Promocion promocion) {
       int resultado = 0;
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_PROMOCION(?,?,?,?,?)}");
            
            cs.setInt("_id_ItemVendible", promocion.getIdItemVendible());
            cs.setString("_nombre", promocion.getNombre());
            cs.setDouble("_precio", promocion.getPrecio());
            cs.setString("_descripcion", promocion.getDescripcion());
            cs.setBoolean("_estado", promocion.isEstado());
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
    public int eliminar(int idPromocion) {
        int resultado = 0;
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_PROMOCION(?)}");
            cs.setInt("_id_ItemVendible", idPromocion);
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
    public ArrayList<Promocion> listarTodos() {
        ArrayList<Promocion> promociones= new ArrayList<>();
        try{
            con= DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_EMPLEADOS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Promocion promocion = new Promocion();
                promocion.setIdItemVendible(rs.getInt("id_item_vendible"));
                promocion.setNombre(rs.getString("nombre"));
                promocion.setPrecio(rs.getDouble("precio"));
                promocion.setDescripcion(rs.getString("descripcion"));
                promocion.setEstado(rs.getBoolean("estado"));
                //promocion.setEstado(True);
               
                //promocion.setLista_de_Comidas(new ArrayList<>());
                
                promociones.add(promocion);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return promociones; 
    }
    
    
    
}
