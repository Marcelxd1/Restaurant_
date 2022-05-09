package pe.edu.pucp.lp2soft.main;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2soft.caja.dao.GastoDAO;
import pe.edu.pucp.lp2soft.caja.model.Pedido;
import pe.edu.pucp.lp2soft.caja.mysql.PedidoMySQL;
import pe.edu.pucp.lp2soft.caja.dao.PedidoDAO;
import pe.edu.pucp.lp2soft.caja.model.Gasto;
import pe.edu.pucp.lp2soft.caja.mysql.GastoMySQL;
import pe.edu.pucp.lp2soft.negocio.dao.CategoriaDAO;
import pe.edu.pucp.lp2soft.negocio.dao.MesaDAO;
import pe.edu.pucp.lp2soft.negocio.dao.ProductoDAO;
import pe.edu.pucp.lp2soft.negocio.dao.PromocionDAO;
import pe.edu.pucp.lp2soft.negocio.model.Categoria;
import pe.edu.pucp.lp2soft.negocio.model.LineaPromocion;
import pe.edu.pucp.lp2soft.negocio.model.Mesa;
import pe.edu.pucp.lp2soft.negocio.model.Producto;
import pe.edu.pucp.lp2soft.negocio.model.Promocion;
import pe.edu.pucp.lp2soft.negocio.mysql.CategoriaMySQL;
import pe.edu.pucp.lp2soft.negocio.mysql.MesaMySQL;
import pe.edu.pucp.lp2soft.negocio.mysql.ProductoMySQL;
import pe.edu.pucp.lp2soft.negocio.mysql.PromocionMySQL;
import pe.edu.pucp.lp2soft.user.dao.AsistenciaDAO;
import pe.edu.pucp.lp2soft.user.dao.PersonaDAO;
import pe.edu.pucp.lp2soft.user.dao.RestauranteDAO;
import pe.edu.pucp.lp2soft.user.dao.RolDAO;
import pe.edu.pucp.lp2soft.user.dao.UsuarioDAO;
import pe.edu.pucp.lp2soft.user.mysql.AsistenciaMySQL;
import pe.edu.pucp.lp2soft.user.mysql.PersonaMySQL;
import pe.edu.pucp.lp2soft.user.mysql.RestauranteMySQL;
import pe.edu.pucp.lp2soft.user.mysql.RolMySQL;
import pe.edu.pucp.lp2soft.user.mysql.UsuarioMySQL;
import pe.edu.pucp.lp2soft.usuario.model.Asistencia;
import pe.edu.pucp.lp2soft.usuario.model.Persona;
import pe.edu.pucp.lp2soft.usuario.model.Restaurante;
import pe.edu.pucp.lp2soft.usuario.model.Rol;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;

public class Principal {
    public static void main(String[] args) throws Exception {

//        Categoria cat1 = new Categoria("Pollos", "todo tipo de pollo ");
//        Categoria cat2 = new Categoria("Parrilleros", "las parrillas ");
//        Categoria cat3 = new Categoria("Gaseosas", "aguas con gas ");
//        Producto producto = new Producto("1/4 Pollo a la Brasa", true, 19.2, "con papas y ensalada", 'C', null);
//        Producto producto2 = new Producto("Chuletas a la parrilla", true, 31.2, "con papas sancochadas", 'C', null);
//        Producto producto3 = new Producto("Inka Kola", true, 3.5, "gaseosa descartable", 'B', "2.5L");
//        ProductoDAO daoProd = new ProductoMySQL();
//        CategoriaDAO daoCat = new CategoriaMySQL();
//        PromocionDAO daoPromo = new PromocionMySQL();
        int resultado;
        //AGREGANDO CATEGORIAS--------------------------------------------------------------
//        resultado = daoCat.insertar(cat1);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente la categoria");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar la categoria");
//        }
//
//        resultado = daoCat.insertar(cat2);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente la categoria2");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar la categoria2");
//        }
//
//        resultado = daoCat.insertar(cat3);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente la categoria3");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar la categoria3");
//        }
//
//        producto.setCategoria(cat1);
//        producto2.setCategoria(cat2);
//        producto3.setCategoria(cat3);
//
//        //AGREGANDO PRODUCTOS ---------------------------------------------------------------------------------------
//        resultado = daoProd.insertar(producto);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente el producto");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar el producto");
//        }
//
//        resultado = daoProd.insertar(producto2);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente el producto2");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar el producto2");
//        }
//
//        resultado = daoProd.insertar(producto3);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente el producto3");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar el producto3");
//        }
//
//        //--------------------------------------------------------------------------------------------
//        Rol rol1 = new Rol("Cajero");
//        Restaurante rest1 = new Restaurante("123456", "POLLERIA", "353433", "sanisidro123", 0);
//        Usuario us1 = new Usuario("axelin", "123", 3333.00, "987654321", "axel", "romero", "chambi", "72121233", 'P');
//        us1.setRestaurante(rest1);
//        us1.setRol(rol1);
//        RolDAO daoRol = new RolMySQL();
//        resultado = daoRol.insertar(rol1);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado el rol correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado el rol correctamente ");
//        }
//        RestauranteDAO daoRestaurante = new RestauranteMySQL();
//        resultado = daoRestaurante.insertar(rest1);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado en la tabla restaurante correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado en la tabla restaurante correctamente ");
//        }
//
//        UsuarioDAO daoUsuario = new UsuarioMySQL();
//        resultado = daoUsuario.insertar(us1);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado en la tabla USUARIO correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado en la tabla USUARIO correctamente ");
//        }
//            AsistenciaDAO daoAsistencia = new AsistenciaMySQL();
//        resultado = daoAsistencia.registrarAsistencia(us1);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado la asistencia de entrada correctamente ");
//        } else {
//            System.out.println("NO se  ha registrado la asistencia de entrada  ");
//        }
//        resultado = daoAsistencia.registrarSalida(us1);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado la salida correctamente ");
//        } else {
//            System.out.println("NO se  ha registrado la salida de entrada  ");
//        }
//          ArrayList<Asistencia> asistencias = daoAsistencia.listarAsistencia();
//          long  diferencia;
//          SimpleDateFormat sdf = new SimpleDateFormat("HH:mm:ss");
//          for (int i = 0 ; i < asistencias.size();i++){
//              diferencia =  asistencias.get(i).getHora_fin().getTime() - asistencias.get(i).getHora_inicio().getTime();
//              System.out.println(asistencias.get(i).getFid_id_usuario()+ " " + asistencias.get(i).getHora_inicio() + " " + asistencias.get(i).getHora_fin()
//                           +" " + asistencias.get(i).getFecha()+" "  + sdf.format(diferencia));
//          }
//        ArrayList<Rol> roles = daoRol.listarTodas();
//        for (int i = 0; i < roles.size(); i++) {
//            System.out.println(roles.get(i).getId_rol() + ". " + roles.get(i).getDescripcion());
//        }
//
//        roles.get(2).setDescripcion("CAMBIAZO");
//        resultado = daoRol.modificar(roles.get(2));
//        if (resultado == 1) {
//            System.out.println("Se ha modificado en la tabla rol correctamente ");
//        } else {
//            System.out.println(" NO se ha modificado en la tabla rol ");
//        }
//
//        resultado = daoRol.eliminar(20);
//        if (resultado == 1) {
//            System.out.println("Se ha eliminado el id 20  en la tabla rol");
//        } else {
//            System.out.println(" NO se ha eliminado nada en la tabla rol ");
//        }
//        roles = daoRol.listarTodas();
//        for (int i = 0; i < roles.size(); i++) {
//            System.out.println(roles.get(i).getId_rol() + ". " + roles.get(i).getDescripcion());
//        }
//
//        ArrayList<Persona> personas = daoPersona.listarTodas();
//        ArrayList<Usuario> usuarios = daoUsuario.listarTodas();
//        for (int i = 0; i < usuarios.size(); i++) {
//
//            System.out.println(personas.get(i).getId_persona() + " "
//                    + personas.get(i).getNombre() + "  " + usuarios.get(i).getUsuario());
//
//        }
//        //AGREGANDO PROMOCIONES 
//        Promocion promocion1= new Promocion(new ArrayList<>(), "Combo Parrillero", true, 200.00, "Pollo a la Brasa con Chuleta a la Parrilla"); 
//        Promocion promocion2= new Promocion(new ArrayList<>(), "Combo Maritimo", true, 100.00, "ceviche y Chicharron de mariscos"); 
//        Promocion promocion3= new Promocion(new ArrayList<>(), "Combo Veranito", true, 100.00, "no somos cevicheria o si? "); 
//        
//        //no puede hacerse aca porque aca el producto tiene un ID 0 es cuando se hace insert donde se le da el ID 
//        LineaPromocion lin11=new LineaPromocion(0, 4, producto, promocion1, true);
//        LineaPromocion lin12=new LineaPromocion(0, 2, producto2, promocion1, true);
//        LineaPromocion lin13=new LineaPromocion(0, 1, producto3, promocion1, true);
//        
//        promocion1.getLista_de_Comidas().add(lin11);
//        promocion1.getLista_de_Comidas().add(lin12);
//        promocion1.getLista_de_Comidas().add(lin13);
//        
//        resultado = daoPromo.insertar(promocion1);
//        if(resultado==1)
//            System.out.println("Se ha insertado correctamente la promocion 1");
//        else
//            System.out.println("Ha ocurrido un error al momento de insertar el producto");
//    
//        resultado = daoPromo.insertar(promocion2);
//        if(resultado==1)
//            System.out.println("Se ha insertado correctamente la promocion 2");
//        else
//            System.out.println("Ha ocurrido un error al momento de insertar el producto2");
//    
//        resultado = daoPromo.insertar(promocion3);
//        if(resultado==1)
//            System.out.println("Se ha insertado correctamente la promocion 3");
//        else
//            System.out.println("Ha ocurrido un error al momento de insertar el producto3");
//        
//        //MODIFICANDO PROMOCIONES
//        promocion1.setPrecio(300.00); 
//        resultado= daoPromo.modificar(promocion1);
//        if(resultado==1)
//            System.out.println("Se ha modificado correctamente la promocion 1");
//        else
//            System.out.println("Ha ocurrido un error al momento de modificar el producto1 ");
//        
//        //"ELIMINANDO" PROMOCIONES 
//        System.out.println("id de la promo: "+promocion3.getIdItemVendible());
//        resultado= daoPromo.eliminar(promocion3.getIdItemVendible());
//        if(resultado==1)
//            System.out.println("Se ha eliminado correctamente la promocion 3");
//        else
//            System.out.println("Ha ocurrido un error al momento de eliminar el producto 3");        
        
        //MOSTRAR PROMOCION
//        System.out.println("mostrando promociones.....");
//        ArrayList<Promocion> lista; //resultado
//        lista = daoPromo.listarTodos();
//        for (Promocion promo : lista) {
//            System.out.println(promo.getIdItemVendible()+ "-" + promo.getNombre() + " "
//                    + promo.getPrecio() + " " + promo.getDescripcion() + " "+ promo.isEstado());
//            
//            
//        }
//        ArrayList<LineaPromocion> lista_de_Comidas = promocion1.getLista_de_Comidas();
//        System.out.println("mostrando promocion 1 .....");
//        for(LineaPromocion linea: lista_de_Comidas){
//            System.out.println(linea.getIdLineaPromocion()+ " "+ linea.getProducto().getNombre()+ " - "
//            + linea.getUnidades()+ ", "+ linea.getProducto().getIdItemVendible() );

    //*************************
    //PROBANDO GASTOS
    //***************************+
    Restaurante res1 = new Restaurante("aasdasd","CEVICHERIA","123213213","AV NOSE",4294.2);
    RestauranteDAO res = new RestauranteMySQL();
    resultado=res.insertar(res1);
    if (resultado == 1) {
        System.out.println("Se ha insertado rest correctamente ");
    } else {
        System.out.println(" NO se ha insertado res ");
    }
    SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
    Gasto gasto1 = new Gasto("Pollos",15.5,4,"1 KG");
    Gasto gasto2 = new Gasto("Papas",10,2,"1/2 KG");
    gasto1.setRestaurante(res1);
    gasto2.setRestaurante(res1);
    GastoDAO gastoDao = new GastoMySQL();
    resultado = gastoDao.insertar(gasto1);
    if (resultado == 1) {
        System.out.println("Se ha insertado gasto1 correctamente ");
    } else {
        System.out.println(" NO se ha insertado gasto1 ");
    }
    
    System.out.println("DINERO ACTUAL: " + res1.getDineroActual() + "\n===============================================");
    
    resultado = gastoDao.insertar(gasto2);
    
    if (resultado == 1) {
        System.out.println("Se ha insertado gasto2 correctamente ");
    } else {
        System.out.println(" NO se ha insertado gasto2 ");
    }
    ArrayList<Gasto> gastos; //resultado
    gastos = gastoDao.listarTodas();
    for(Gasto g : gastos) {
        System.out.println(g.getRestaurante().getNombre()+ " - " + g.getRestaurante().getDineroActual() + ": \n" + 
                "\t" + sdf.format(g.getFecha()) + " - " +g.getItem() + " \n\t " + g.getCantidad() + " * " + g.getPrecio() + " = " + g.getTotal());
    }
    }

        /////////////////////////////////////////////////////////
//        //AGREGANDO MESAS ---------------------------------------------------------------------
//        Mesa mes1 = new Mesa(1, 1, 3);
//        //Creamos un dao de conexión
//        MesaDAO persDao = new MesaMySQL();
//        //Insertamos el area en la base de datos
//        resultado = persDao.insertar(mes1);
//        //persDao.insertar(pers1);
//        //Verificando la inserción en la base de datos
//
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente la Mesa");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar la mesa");
       // }
        //int resultado;
        //Mesa mes1 = new Mesa(1, 1, 3);
        /*Pedido ped1 = new Pedido(1, 100, mes1, "B", "I");
        PedidoDAO pedDao = new PedidoMySQL();
        //Insertamos el area en la base de datos
        resultado = pedDao.insertar(ped1);
        //persDao.insertar(pers1);
        //Verificando la inserción en la base de datos

        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente la Transaccion");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar la mesa");
        }*/
        //Mesa mes1 = new Mesa(1, 1, 3);
//        Pedido ped1 = new Pedido(1, 100, mes1, "B", "I");
//        PedidoDAO pedDao = new PedidoMySQL();
//        //Insertamos el area en la base de datos
//        resultado = pedDao.insertar(ped1);
//        //persDao.insertar(pers1);
//        //Verificando la inserción en la base de datos
//
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente la Transaccion");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar la mesa");
//        }
    
    //AGREGAR PEDIDO
    //int idPedido, float total, Mesa mesa, String tipoComprobante, String tipo_transaccion
    /*Mesa mes1 = new Mesa(1, 1, 3);
    Pedido ped1 = new Pedido(1, 100, mes1, "B", "I");*/

 /* Mesa mes1 = new Mesa(1, 1, 3);
        Pedido ped1 = new Pedido(1, 100, mes1, "B", "I");
        PedidoDAO pedDao = new PedidoMySQL();
        //Insertamos el area en la base de datos
        resultado = pedDao.insertar(ped1);
        //persDao.insertar(pers1);
        //Verificando la inserción en la base de datos

        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente la Transaccion");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar la mesa");
        }*/
}
