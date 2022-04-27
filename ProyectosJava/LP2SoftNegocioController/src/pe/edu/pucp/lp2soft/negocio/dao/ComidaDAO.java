package pe.edu.pucp.lp2soft.negocio.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.model.Comida;

public interface ComidaDAO {
    ArrayList<Comida> listarTodas();
    int insertar(Comida comida);
    int modificar(Comida comida);
    int eliminar(int idComida);
    Comida listarPorId(int idComida);
}
