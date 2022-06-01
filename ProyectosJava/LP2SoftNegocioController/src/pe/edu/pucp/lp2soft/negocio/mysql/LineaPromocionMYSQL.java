package pe.edu.pucp.lp2soft.negocio.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.negocio.dao.LineaPromocionDAO;
import pe.edu.pucp.lp2soft.negocio.model.LineaPromocion;

/**
 *
 * necesario?
 */
public class LineaPromocionMYSQL implements LineaPromocionDAO{
    private Connection con; 
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(LineaPromocion linea, int idPromo) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
//        int resultado = 0;
//        try{
//            con= DBManager.getInstance().getConnection();
//            cs= con.prepareCall("{call INSERTAR_LINEA_PROMOCION(?,?,?,?)}");
//            cs.registerOutParameter("_idLineaPromocion", java.sql.Types.INTEGER);
//            cs.setInt("_unidades", linea.getUnidades());
//            cs.setInt("_fid_promocion", idpromo);
//            cs.setInt("_fid_producto", linea.getProducto().getIdItemVendible());
//            linea.setEstado(true); 
//
//            cs.executeUpdate();
//            linea.setIdLineaPromocion(cs.getInt("_idLineaPromocion"));//Este es el generado
//
//        }catch(Exception ex){
//            System.out.println(ex.getMessage());
//        }finally{
//            try{con.close();}catch(Exception ex)
//            {System.out.println(ex.getMessage());}
//        }
//        return resultado;
    }

    @Override
    public int modificar(LineaPromocion linea, int idPromo) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int eliminar(int idLinea, int idPromo) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public ArrayList<LineaPromocion> listarTodos( int idPromo) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
    
    
}
