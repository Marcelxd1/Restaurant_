package pe.edu.pucp.lp2soft.negocio.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.negocio.dao.ComidaDAO;
import pe.edu.pucp.lp2soft.negocio.model.Comida;

public class ComidaMySQL implements ComidaDAO{

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    @Override
    public ArrayList<Comida> listarTodas() {
        ArrayList<Comida> comidas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_AREAS_TODAS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Comida comida = new Comida();
                comida.setIdComida(rs.getInt("id_comida"));
                comida.setIdItemVendible(rs.getInt("id_comida"));
                comida.setIdProducto(rs.getInt("id_comida"));
                comida.setNombre(rs.getString("nombre"));
                comida.setEstado(true);
                comida.setDescripcion(rs.getString("descripcion"));
                comidas.add(comida);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return comidas;
    }

    @Override
    public int insertar(Comida comida) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_COMIDA(?,?,?,?,?)}");
            cs.registerOutParameter("_id_comida", java.sql.Types.INTEGER);
            cs.setString("_nombre", comida.getNombre());
            cs.setDouble("_precio", comida.getPrecio());
            cs.setString("_descripcion", comida.getDescripcion());
            cs.setBoolean("_descripcion", comida.isEstado());
            cs.executeUpdate();
            comida.setIdComida(cs.getInt("_id_area"));
            comida.setIdItemVendible(cs.getInt("_id_area"));
            comida.setIdProducto(cs.getInt("_id_area"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Comida comida) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_AREA(?,?,?,?,?)}");
            cs.setInt("_id_comida", comida.getIdComida());
            cs.setString("_nombre", comida.getNombre());
            cs.setDouble("_precio", comida.getPrecio());
            cs.setString("_descripcion", comida.getDescripcion());
            cs.setBoolean("_descripcion", comida.isEstado());
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
    public int eliminar(int idComida) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_AREA(?)}");
            cs.setInt("_id_comida", idComida);
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
    public Comida listarPorId(int idComida) {
        Comida comida = null;
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_AREA_POR_ID(?)}");
            cs.setInt("_id_comida", idComida);
            rs = cs.executeQuery();
            if(rs.next()){
                comida = new Comida();
                comida.setIdComida(idComida);
                comida.setNombre(rs.getString("nombre"));
                comida.setEstado(true);
            }
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return comida;
    }

}
