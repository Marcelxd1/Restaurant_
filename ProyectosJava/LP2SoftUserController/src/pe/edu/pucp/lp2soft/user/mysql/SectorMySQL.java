package pe.edu.pucp.lp2soft.user.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.user.dao.SectorDAO;
import pe.edu.pucp.lp2soft.usuario.model.Actividad;
import pe.edu.pucp.lp2soft.usuario.model.Sector;


public class SectorMySQL implements SectorDAO{

    private Connection con ; 
    private ResultSet rs ;
    private CallableStatement cs ;
    @Override
    public ArrayList<Sector> listarSectores() {
        ArrayList<Sector> sectores = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_SECTORES()}");
            rs = cs.executeQuery();
            while (rs.next()){
                Sector sector = new Sector();
                sector.setId_sector(rs.getInt("id_sector"));
                sector.setDescripcion(rs.getString("descripcion"));
                sectores.add(sector);
            }
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return sectores ;
    }

    @Override
    public ArrayList<Actividad> listarAcvXsector(int idSector) {
        ArrayList<Actividad> actividades = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ACTIVIDAD_POR_SECTOR(?)}");
            cs.setInt("_fid_sector", idSector);
            rs = cs.executeQuery();
            while (rs.next()){
                Actividad actividad = new Actividad();
                actividad.setId_actividad(rs.getInt("id_actividad"));
                actividad.setDescripcion(rs.getString("descripcion"));
                actividades.add(actividad);
            }
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return actividades ;
    }

}
