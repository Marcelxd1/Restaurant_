package pe.edu.pucp.lp2soft.negocio.mysql;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.dao.BebidaDAO;
import pe.edu.pucp.lp2soft.negocio.model.Bebida;

public class BebidaMySQL implements BebidaDAO {

    private Connection con;
    private ResultSet rs;
    private PreparedStatement ps;
    @Override
    public ArrayList<Bebida> listarTodas() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int insertar(Bebida bebida) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int modificar(Bebida bebida) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idBebida) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public Bebida listarPorId(int idBebida) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

}
