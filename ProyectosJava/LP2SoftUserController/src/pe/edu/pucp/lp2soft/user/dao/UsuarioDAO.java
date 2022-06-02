

package pe.edu.pucp.lp2soft.user.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;
public interface UsuarioDAO {
    ArrayList<Usuario> listarTodas();
    int insertar(Usuario usuario);
    int modificar(Usuario usuario);
    int eliminiar(int idUsuario);
    Usuario listarPorId(int idUsuario);
    ArrayList<Usuario> listarXNombre(String nombre);
    Usuario verificarUsuario (Usuario usuario);
    int modificarDatos (Usuario usuario);
}
