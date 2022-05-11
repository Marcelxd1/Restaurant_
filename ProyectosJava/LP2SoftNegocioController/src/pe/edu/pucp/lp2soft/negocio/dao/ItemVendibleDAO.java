package pe.edu.pucp.lp2soft.negocio.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.model.ItemVendible;

public interface ItemVendibleDAO {
    ArrayList<ItemVendible> listarXNombre(String nombre);
}
