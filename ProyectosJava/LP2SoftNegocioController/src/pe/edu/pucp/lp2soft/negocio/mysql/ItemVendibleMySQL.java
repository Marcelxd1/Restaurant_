package pe.edu.pucp.lp2soft.negocio.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.negocio.dao.ItemVendibleDAO;
import pe.edu.pucp.lp2soft.negocio.model.ItemVendible;

public class ItemVendibleMySQL implements ItemVendibleDAO{

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public ArrayList<ItemVendible> listarXNombre(String nombre) {
        ArrayList<ItemVendible> items = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ITEMVENDIBLE_X_NOMBRE(?)}");
            cs.setString("_nombre",nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                ItemVendible itemVendible = new ItemVendible();
                itemVendible.setIdItemVendible(rs.getInt("id_item_vendible"));
                itemVendible.setNombre(rs.getString("nombre"));
                itemVendible.setPrecio(rs.getDouble("precio"));
                itemVendible.setDescripcion(rs.getString("descripcion"));
                items.add(itemVendible); 
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return items;
    }
    
}
