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
        int resultado;
/*
  PARA PROBAR USUARIOS, COMIDAS, Y TODOS LOS TIPOS SIN CLASE, PRIMERO AGREGARLOS MANUALMENTE EN LA BASE DE DATOS      
*/        
//************************************************************************************************************
// RESTAURANTE
//************************************************************************************************************ 
        Restaurante res1 = new Restaurante("ASAS-2323","CEVICHERIA","123213213","AV NOSE",4294.2);
        RestauranteDAO res = new RestauranteMySQL();
        resultado=res.insertar(res1);
        if (resultado == 1) {
            System.out.println("Se ha insertado RESTAURANTE correctamente ");
        } else {
            System.out.println(" NO se ha insertado RESTAURANTE ");
        }

//************************************************************************************************************
// MESAS
//************************************************************************************************************        
        Mesa mes1 = new Mesa(4); //4 sillas
        MesaDAO m1 = new MesaMySQL();
        resultado = m1.insertar(mes1);
        if (resultado == 1) {
            System.out.println("Se ha insertado MESA correctamente ");
        } else {
            System.out.println(" NO se ha insertado MESA ");
        }
        
//************************************************************************************************************
// CATEGORIAS COMIDAS 
//************************************************************************************************************  
        Categoria cat1 = new Categoria("Pollos", "todo tipo de pollo ");
        Categoria cat2 = new Categoria("Parrilleros", "las parrillas ");
        Categoria cat3 = new Categoria("Gaseosas", "aguas con gas ");        

        CategoriaDAO daoCat = new CategoriaMySQL();
        resultado = daoCat.insertar(cat1);
        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente la CATEGORIA");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar la CATEGORIA");
        }
        resultado = daoCat.insertar(cat2);
        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente la CATEGORIA2");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar la CATEGORIA2");
        }
        resultado = daoCat.insertar(cat3);
        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente la CATEGORIA3");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar la CATEGORIA3");
        }
//************************************************************************************************************
// COMIDAS Y BEBIDAS
//************************************************************************************************************  
        Producto producto = new Producto("1/4 Pollo a la Brasa", 19.2, "con papas y ensalada", 'C', null); //platillo
        Producto producto2 = new Producto("Chuletas a la parrilla", 31.2, "con papas sancochadas", 'C', null);//platillo
        Producto producto3 = new Producto("Inka Kola", 3.5, "gaseosa descartable", 'B', "2.5L");//bebida
        ProductoDAO daoProd = new ProductoMySQL();
        
        producto.setCategoria(cat1);
        producto2.setCategoria(cat2);
        producto3.setCategoria(cat3);

        resultado = daoProd.insertar(producto);
        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente el PRODUCTO");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar el PRODUCTO");
        }
        resultado = daoProd.insertar(producto2);
        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente el PRODUCTO2");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar el PRODUCTO2");
        }
        resultado = daoProd.insertar(producto3);
        if (resultado == 1) {
            System.out.println("Se ha insertado correctamente el PRODUCTO3");
        } else {
            System.out.println("Ha ocurrido un error al momento de insertar el PRODUCTO3");
        }
        

//************************************************************************************************************
// PROMOCIONES
//************************************************************************************************************         
        PromocionDAO daoPromo = new PromocionMySQL();
        //AGREGANDO PROMOCIONES 
        Promocion promocion1= new Promocion(new ArrayList<>(), "Combo Parrillero", 200.00, "Pollo a la Brasa con Chuleta a la Parrilla"); 
        Promocion promocion2= new Promocion(new ArrayList<>(), "Combo Maritimo", 100.00, "ceviche y Chicharron de mariscos"); 
        Promocion promocion3= new Promocion(new ArrayList<>(), "Combo Veranito", 100.00, "KFC criollo"); 
        
        //no puede hacerse aca porque aca el producto tiene un ID 0 es cuando se hace insert donde se le da el ID 
        LineaPromocion lin11=new LineaPromocion(0, 4, producto, promocion1, true);
        LineaPromocion lin12=new LineaPromocion(0, 2, producto2, promocion1, true);
        LineaPromocion lin13=new LineaPromocion(0, 1, producto3, promocion1, true);
        
        promocion1.getLista_de_Comidas().add(lin11);
        promocion1.getLista_de_Comidas().add(lin12);
        promocion1.getLista_de_Comidas().add(lin13);
        
        resultado = daoPromo.insertar(promocion1);
        if(resultado==1)
            System.out.println("Se ha insertado correctamente la promocion 1");
        else
            System.out.println("Ha ocurrido un error al momento de insertar el producto");
    
        resultado = daoPromo.insertar(promocion2);
        if(resultado==1)
            System.out.println("Se ha insertado correctamente la promocion 2");
        else
            System.out.println("Ha ocurrido un error al momento de insertar el producto2");
    
        resultado = daoPromo.insertar(promocion3);
        if(resultado==1)
            System.out.println("Se ha insertado correctamente la promocion 3");
        else
            System.out.println("Ha ocurrido un error al momento de insertar el producto3");
        
        //MODIFICANDO PROMOCIONES
        promocion1.setPrecio(300.00); 
        resultado= daoPromo.modificar(promocion1);
        if(resultado==1)
            System.out.println("Se ha modificado correctamente la promocion 1");
        else
            System.out.println("Ha ocurrido un error al momento de modificar el producto1 ");
        
        //"ELIMINANDO" PROMOCIONES 
        System.out.println("id de la promo: "+promocion3.getIdItemVendible());
        resultado= daoPromo.eliminar(promocion3.getIdItemVendible());
        if(resultado==1)
            System.out.println("Se ha eliminado correctamente la promocion 3");
        else
            System.out.println("Ha ocurrido un error al momento de eliminar el producto 3");        
        
        //MOSTRAR PROMOCION
        System.out.println("mostrando promociones.....");
        ArrayList<Promocion> lista; //resultado
        lista = daoPromo.listarTodos();
        for (Promocion promo : lista) {
            System.out.println(promo.getIdItemVendible()+ "-" + promo.getNombre() + " "
                    + promo.getPrecio() + " " + promo.getDescripcion() + " "+ promo.isEstado());
            
            
        }
        ArrayList<LineaPromocion> lista_de_Comidas = promocion1.getLista_de_Comidas();
        System.out.println("mostrando promocion 1 .....");
        for(LineaPromocion linea: lista_de_Comidas){
            System.out.println(linea.getIdLineaPromocion()+ " "+ linea.getProducto().getNombre()+ " - "
            + linea.getUnidades()+ ", "+ linea.getProducto().getIdItemVendible() );        
        
//************************************************************************************************************
// ROLES
//************************************************************************************************************  
        Rol rol1 = new Rol("ADMINISTRADOR");
        Rol rol2 = new Rol("CAJERO");
        Rol rol3 = new Rol("MESERO");
        Rol rol4 = new Rol("COCINERO");
        
        RolDAO daoRol = new RolMySQL();
        resultado = daoRol.insertar(rol1);
        if (resultado == 1) {
            System.out.println("Se ha registrado el rol correctamente ");
        } else {
            System.out.println(" NO Se ha registrado el rol correctamente ");
        }
        
        resultado = daoRol.insertar(rol2);
        if (resultado == 1) {
            System.out.println("Se ha registrado el rol2 correctamente ");
        } else {
            System.out.println(" NO Se ha registrado el rol2 correctamente ");
        }
        
        resultado = daoRol.insertar(rol3);
        if (resultado == 1) {
            System.out.println("Se ha registrado el rol3 correctamente ");
        } else {
            System.out.println(" NO Se ha registrado el rol3 correctamente ");
        }
        
        resultado = daoRol.insertar(rol4);
        if (resultado == 1) {
            System.out.println("Se ha registrado el rol4 correctamente ");
        } else {
            System.out.println(" NO Se ha registrado el rol4 correctamente ");
        }

//************************************************************************************************************
// PERSONAS
//************************************************************************************************************  
        Usuario us1 = new Usuario("psanchez", "asd1234", 1200.0, "9878842", "PEDRO", "PEREZ", "SANCHEZ", "9989893", 'N');
        //Persona per1 = new Persona("Empresa ABC", null, null, null,) NO SE PUEDE AGREGAR EMPRESAS!!!!!!!!!!!!!!!!!!!!!
        
        us1.setRol(rol1);
        us1.setRestaurante(res1);
        
        UsuarioDAO daoUsuario = new UsuarioMySQL();
        resultado = daoUsuario.insertar(us1);
        if (resultado == 1) {
            System.out.println("Se ha registrado en la tabla USUARIO correctamente ");
        } else {
            System.out.println(" NO Se ha registrado en la tabla USUARIO correctamente ");
        }
        
//************************************************************************************************************
// ASISTENCIAS
//************************************************************************************************************        
        Asistencia asistencia = new Asistencia();
        asistencia.setUsuario(us1);
        
        AsistenciaDAO daoAsistencia = new AsistenciaMySQL();
        resultado = daoAsistencia.registrarAsistencia(asistencia);
        if (resultado == 1) {
            System.out.println("Se ha registrado en la tabla ASISTENCIA correctamente ");
        } else {
            System.out.println(" NO Se ha registrado en la tabla ASISTENCIA correctamente ");
        }
        
//************************************************************************************************************
// GASTOS
//************************************************************************************************************           
        Gasto gasto1 = new Gasto("Pollos",15.5,4,"1 KG");
        Gasto gasto2 = new Gasto("Papas",10,2,"1/2 KG");
        gasto1.setRestaurante(res1);
        gasto2.setRestaurante(res1);
        GastoDAO gastoDao = new GastoMySQL();
        //System.out.println("DINERO ACTUAL: " + res1.getDineroActual() + "\n===============================================");
        resultado = gastoDao.insertar(gasto1);
        if (resultado == 1) {
            System.out.println("Se ha insertado GASTO1 correctamente ");
        } else {
            System.out.println(" NO se ha insertado GASTO1 ");
        }
        resultado = gastoDao.insertar(gasto2);
        if (resultado == 1) {
            System.out.println("Se ha insertado GASTO2 correctamente ");
        } else {
            System.out.println(" NO se ha insertado GASTO2 ");
        }
        

        
        
        
        


        
       
//
//        
//
//        
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


    //*************************
    //PROBANDO GASTOS
    //***************************+
//    ArrayList<Gasto> gastos; //resultado
//    gastos = gastoDao.listarTodas();
//    for(Gasto g : gastos) {
//        System.out.println(g.getRestaurante().getNombre()+ " - " + g.getRestaurante().getDineroActual() + ": \n" + 
//                "\t" + sdf.format(g.getFecha()) + " - " +g.getItem() + " \n\t " + g.getCantidad() + " * " + g.getPrecio() + " = " + g.getTotal());
//    }
        
        
    }

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
}
