
package pe.edu.pucp.lp2soft.negocio.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.model.Categoria;

public interface CategoriaDAO {
    ArrayList<Categoria> listarTodas();
    int insertar(Categoria categoria);
    int modificar(Categoria categoria);
    int eliminar(int id_categoria);
    Categoria buscarPorId(int id_categoria);
}
