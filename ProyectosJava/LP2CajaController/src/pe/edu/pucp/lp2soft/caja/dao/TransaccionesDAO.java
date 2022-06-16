package pe.edu.pucp.lp2soft.caja.dao;


import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2soft.caja.model.Transaccion;

public interface TransaccionesDAO {
    ArrayList<Transaccion> listarTodas();
    ArrayList<Transaccion> listarTodasXFechas(Date f1,Date f2);
}
