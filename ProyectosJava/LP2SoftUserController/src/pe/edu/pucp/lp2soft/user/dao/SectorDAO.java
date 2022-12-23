package pe.edu.pucp.lp2soft.user.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.usuario.model.Actividad;
import pe.edu.pucp.lp2soft.usuario.model.Sector;


public interface SectorDAO {
    
    ArrayList<Sector> listarSectores();
    ArrayList<Actividad> listarAcvXsector( int idSector);
}
