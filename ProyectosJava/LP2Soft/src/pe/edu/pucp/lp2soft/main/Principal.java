package pe.edu.pucp.lp2soft.main;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.dao.CategoriaDAO;
import pe.edu.pucp.lp2soft.negocio.dao.MesaDAO;
import pe.edu.pucp.lp2soft.negocio.dao.ProductoDAO;
import pe.edu.pucp.lp2soft.negocio.model.Categoria;
import pe.edu.pucp.lp2soft.negocio.model.Mesa;
import pe.edu.pucp.lp2soft.negocio.model.Producto;
import pe.edu.pucp.lp2soft.negocio.mysql.CategoriaMySQL;
import pe.edu.pucp.lp2soft.negocio.mysql.MesaMySQL;
import pe.edu.pucp.lp2soft.negocio.mysql.ProductoMySQL;
import pe.edu.pucp.lp2soft.user.dao.PersonaDAO;
import pe.edu.pucp.lp2soft.user.dao.RestauranteDAO;
import pe.edu.pucp.lp2soft.user.dao.RolDAO;
import pe.edu.pucp.lp2soft.user.dao.UsuarioDAO;
import pe.edu.pucp.lp2soft.user.mysql.PersonaMySQL;
import pe.edu.pucp.lp2soft.user.mysql.RestauranteMySQL;
import pe.edu.pucp.lp2soft.user.mysql.RolMySQL;
import pe.edu.pucp.lp2soft.user.mysql.UsuarioMySQL;
import pe.edu.pucp.lp2soft.usuario.model.Persona;
import pe.edu.pucp.lp2soft.usuario.model.Restaurante;
import pe.edu.pucp.lp2soft.usuario.model.Rol;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;

public class Principal {

    public static void main(String[] args) throws Exception {
        Categoria cat1 = new Categoria("Pollos", "todo tipo de pollo :v");
        Categoria cat2 = new Categoria("Parrilleros", "las parrillas :v");
        Categoria cat3 = new Categoria("Gaseosas", "aguas con gas :v");
        Producto producto = new Producto("1/4 Pollo a la Brasa", true, 19.2, "con papas y ensalada", 'C', " ");
        Producto producto2 = new Producto("Chuletas a la parrilla", true, 31.2, "con papas sancochadas", 'C', " ");
        Producto producto3 = new Producto("Inka Kola", true, 3.5, "gaseosa descartable", 'B', "2.5L");
        ProductoDAO daoProd = new ProductoMySQL();
        CategoriaDAO daoCat = new CategoriaMySQL();

        //AGREGANDO CATEGORIAS--------------------------------------------------------------
        int resultado = daoCat.insertar(cat1);
        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente la categoria");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar la categoria");
        }

        resultado = daoCat.insertar(cat2);
        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente la categoria2");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar la categoria2");
        }

        resultado = daoCat.insertar(cat3);
        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente la categoria3");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar la categoria3");
        }

        producto.setCategoria(cat1);
        producto2.setCategoria(cat2);
        producto3.setCategoria(cat3);

        //AGREGANDO PRODUCTOS ---------------------------------------------------------------------------------------
        resultado = daoProd.insertar(producto);
        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente el producto");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar el producto");
        }

        resultado = daoProd.insertar(producto2);
        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente el producto2");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar el producto2");
        }

        resultado = daoProd.insertar(producto3);
        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente el producto3");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar el producto3");
        }

        Rol rol1 = new Rol("cajero");
        Restaurante rest1 = new Restaurante("123456", "POLLERIA", "353433", "sanisidro123", 0);
        Persona pers1 = new Persona("axel", "romero", "chambi", "70201028", 'P', " ", " ");
        Usuario us1 = new Usuario("axelin", "123", true, 6666.0, "98765432");

        us1.setRestaurante(rest1);
        us1.setPersona(pers1);
        us1.setRol(rol1);
        RolDAO daoRol = new RolMySQL();
        resultado = daoRol.insertar(rol1);
        if (resultado == 1) {
            System.out.println("Se ha registrado el rol correctamente ");
        } else {
            System.out.println(" NO Se ha registrado el rol correctamente ");
        }
        RestauranteDAO daoRestaurante = new RestauranteMySQL();
        resultado = daoRestaurante.insertar(rest1);
        if (resultado == 1) {
            System.out.println("Se ha registrado en la tabla restaurante correctamente ");
        } else {
            System.out.println(" NO Se ha registrado en la tabla restaurante correctamente ");
        }

        PersonaDAO daoPersona = new PersonaMySQL();
        resultado = daoPersona.insertar(pers1);
        if (resultado == 1) {
            System.out.println("Se ha registrado en la tabla persona correctamente ");
        } else {
            System.out.println(" NO Se ha registrado en la tabla persona correctamente ");
        }

        UsuarioDAO daoUsuario = new UsuarioMySQL();
        resultado = daoUsuario.insertar(us1);
        if (resultado == 1) {
            System.out.println("Se ha registrado en la tabla USUARIO correctamente ");
        } else {
            System.out.println(" NO Se ha registrado en la tabla USUARIO correctamente ");
        }

        //AGREGANDO MESAS ---------------------------------------------------------------------
        Mesa mes1 = new Mesa(1,1,3);
        //Creamos un dao de conexión
        MesaDAO persDao = new MesaMySQL();
        //Insertamos el area en la base de datos
         resultado = persDao.insertar(mes1);
        //persDao.insertar(pers1);
        //Verificando la inserción en la base de datos

        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente la Mesa");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar la mesa");
        }
    }
}
