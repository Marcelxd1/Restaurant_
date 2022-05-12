

package pe.edu.pucp.lp2soft.user.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;
public interface UsuarioDAO {
    ArrayList<Usuario> listarTodas();
    int insertar(Usuario usuario);
    int modificar(Usuario usuario);
    int elminiar(int idUsuario);
    Usuario listarPorId(int idUsuario);
}
