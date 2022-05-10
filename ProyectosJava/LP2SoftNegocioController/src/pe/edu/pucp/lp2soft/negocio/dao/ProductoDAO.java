package pe.edu.pucp.lp2soft.negocio.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.model.Producto;

public interface ProductoDAO {
    ArrayList<Producto> listarTodas();
    int insertar(Producto producto);
    int modificar(Producto producto);
    int eliminar(int idProducto);
}
