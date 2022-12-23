package pe.edu.pucp.lp2soft.negocio.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.negocio.dao.CategoriaDAO;
import pe.edu.pucp.lp2soft.negocio.model.Categoria;

public class CategoriaMySQL implements CategoriaDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public ArrayList<Categoria> listarTodas(){
        ArrayList<Categoria> categorias = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CATEGORIAS_TODAS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Categoria categoria = new Categoria();
                categoria.setIdCategoria(rs.getInt("id_categoria"));
                categoria.setNombre(rs.getString("nombre"));
                categoria.setDescripcion(rs.getString("descripcion"));
                categoria.setActivo(true);
                categorias.add(categoria);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return categorias;
    }
    
    @Override
    public int insertar(Categoria categoria){
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_CATEGORIA(?,?,?)}");
            cs.registerOutParameter("_id_categoria", java.sql.Types.INTEGER);
            cs.setString("_nombre", categoria.getNombre());
            cs.setString("_descripcion", categoria.getDescripcion());
            cs.executeUpdate();
            categoria.setIdCategoria(cs.getInt("_id_categoria"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Categoria categoria) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_CATEGORIA(?,?,?)}");
            cs.setInt("_id_categoria", categoria.getIdCategoria());
            cs.setString("_nombre", categoria.getNombre());
            cs.setString("_descripcion", categoria.getDescripcion());
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    //activo = 0
    @Override
    public int eliminar(int id_categoria) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_CATEGORIA(?)}");
            cs.setInt("_id_categoria", id_categoria);
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
    public Categoria buscarPorId(int id_categoria) {
        Categoria categoria = null;
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_CATEGORIA_POR_ID(?)}");
            cs.setInt("_id_categoria", id_categoria);
            rs = cs.executeQuery();
            if(rs.next()){
                categoria = new Categoria();
                categoria.setIdCategoria(id_categoria);
                categoria.setNombre(rs.getString("nombre"));
                categoria.setActivo(true);
            }
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return categoria;
    }
    
    
}
