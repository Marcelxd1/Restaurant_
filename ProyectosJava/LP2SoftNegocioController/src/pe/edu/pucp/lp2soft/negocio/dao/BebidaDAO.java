package pe.edu.pucp.lp2soft.negocio.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.model.Bebida;

public interface BebidaDAO {
    ArrayList<Bebida> listarTodas();
    int insertar(Bebida bebida);
    int modificar(Bebida bebida);
    int eliminar(int idBebida);
    Bebida listarPorId(int idBebida);
}
