package pe.edu.pucp.lp2soft.negocio.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.model.Presentacion;

public interface PresentacionDAO {
    ArrayList<Presentacion> listarTodas();
    int insertar(Presentacion presentacion);
    int modificar(Presentacion presentacion);
    int eliminar(int idPpesentacion);
    Presentacion listarPorId(int idPresentacion);
}
