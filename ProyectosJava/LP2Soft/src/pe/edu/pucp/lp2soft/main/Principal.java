package pe.edu.pucp.lp2soft.main;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2soft.caja.dao.GastoDAO;
import pe.edu.pucp.lp2soft.caja.dao.LineaPedidoDAO;
import pe.edu.pucp.lp2soft.caja.model.Pedido;
import pe.edu.pucp.lp2soft.caja.mysql.PedidoMySQL;
import pe.edu.pucp.lp2soft.caja.dao.PedidoDAO;
import pe.edu.pucp.lp2soft.caja.model.Gasto;
import pe.edu.pucp.lp2soft.caja.model.LineaPedido;
import pe.edu.pucp.lp2soft.caja.mysql.GastoMySQL;
import pe.edu.pucp.lp2soft.caja.mysql.LineaPedidoMySQL;
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
//        int resultado;
//        PromocionDAO daoPromo= new PromocionMySQL();
//        ArrayList<Promocion> lista;
//        lista= daoPromo.listarTodos();
//        for (Promocion promocion : lista) {
//            System.out.println(promocion.getIdItemVendible()+"-"+promocion.getNombre()+"-"+ promocion.getDescripcion() );
//        }
//************************************************************************************************************
// RESTAURANTE
//************************************************************************************************************ 
        Restaurante res1 = new Restaurante("ASAS-2323","CEVICHERIA","123213213","AV JAVIER PRADO",4294.2);
        Restaurante res2 = new Restaurante("ADFO-2173","POLLERIA","988787","AV NOSE",3000.0);
        RestauranteDAO res = new RestauranteMySQL();
//        
//        //INSERTAR -------------------------------------------------------------
//        resultado=res.insertar(res1);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado RESTAURANTE correctamente ");
//        } else {
//            System.out.println(" NO se ha insertado RESTAURANTE ");
//        }
//        resultado=res.insertar(res2);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado RESTAURANTE2 correctamente ");
//        } else {
//            System.out.println(" NO se ha insertado RESTAURANTE2 ");
//        }
//        
//        //MODIFICAR -------------------------------------------------------------
//        res1.setDineroActual(8000.00);
//        res1.setDireccion("AV OTRA DIRECCION");
//        resultado = res.modificar(res1);
//        if (resultado == 1) {
//            System.out.println("Se ha modificado RESTAURANTE1 correctamente ");
//        } else {
//            System.out.println(" NO se ha modificado RESTAURANTE1 ");
//        }
//        
//        //ELIMINAR -------------------------------------------------------------
//        resultado = res.eliminar(res2.getId_restaurante());
//        if (resultado == 1) {
//            System.out.println("Se ha eliminado RESTAURANTE2 correctamente ");
//        } else {
//            System.out.println(" NO se ha eliminado RESTAURANTE2 ");
//        }
//        
//        //LISTAR -----------------------------------------------------------------
//        ArrayList<Restaurante> restaurantes = res.listarTodas();
//        for(Restaurante r : restaurantes) {
//        System.out.println(r.getRuc() + " - "+ r.getNombre() + " - " + r.getDireccion() +
//                " - " +  r.getDineroActual());
//        }
//        System.out.println("----------------------------------------------------------\n");
//
////************************************************************************************************************
// MESAS
//************************************************************************************************************        
        Mesa mes1 = new Mesa(); //4 sillas
        mes1.setIdMesa(26);
        Mesa mes2 = new Mesa(6); //6 sillas
        Mesa mes3 = new Mesa(5); //5 sillas
        Mesa mes4 = new Mesa(8); //8 sillas
        MesaDAO m1 = new MesaMySQL();
//        
//        //INSERTAR -------------------------------------------------------------
//        resultado = m1.insertar(mes1);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado MESA1 correctamente ");
//        } else {
//            System.out.println(" NO se ha insertado MESA1 ");
//        }
//        resultado = m1.insertar(mes2);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado MESA2 correctamente ");
//        } else {
//            System.out.println(" NO se ha insertado MESA2 ");
//        }
//        resultado = m1.insertar(mes3);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado MESA3 correctamente ");
//        } else {
//            System.out.println(" NO se ha insertado MESA3 ");
//        }
//        resultado = m1.insertar(mes4);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado MESA4 correctamente ");
//        } else {
//            System.out.println(" NO se ha insertado MESA4 ");
//        }
//        
//        //MODIFICAR -------------------------------------------------------------
//        mes1.setDisponible(false);//ocupada
//        mes1.setNumero(2);//cambia cantidad de sillas
//        mes2.setDisponible(false);//ocupada
//        resultado = m1.modificar(mes1);
//        if (resultado == 1) {
//            System.out.println("Se ha modificado MESA1 correctamente ");
//        } else {
//            System.out.println(" NO se ha modificado MESA1 ");
//        }
//        resultado = m1.modificar(mes2);
//        if (resultado == 1) {
//            System.out.println("Se ha modificado MESA2 correctamente ");
//        } else {
//            System.out.println(" NO se ha modificado MESA2 ");
//        }
//        
//        //ELIMINAR -------------------------------------------------------------
//        resultado = m1.eliminar(mes4.getIdMesa());
//        if (resultado == 1) {
//            System.out.println("Se ha eliminado MESA 4 correctamente ");
//        } else {
//            System.out.println(" NO se ha eliminado MESA 4 ");
//        }
//        
//        //LISTAR -----------------------------------------------------------------
//        ArrayList<Mesa> mesas = m1.listarTodas();
//        for(Mesa m : mesas) {
//        System.out.println(m.getIdMesa()+ ") " + m.getNumero() + " - Disponible: " + m.isDisponible());
//        }
//        System.out.println("----------------------------------------------------------\n");
//        
//************************************************************************************************************
// CATEGORIAS COMIDAS 
//************************************************************************************************************  
        Categoria cat1 = new Categoria("Pollos", "todo tipo de pollo ");
        Categoria cat2 = new Categoria("Parrilleros", "las parrillas ");
        Categoria cat3 = new Categoria("Gaseo", "aguas con gas ");        
        Categoria cat4 = new Categoria("Licores", "aguas con licor xd");        
//
//        //INSERTAR -------------------------------------------------------------
//        CategoriaDAO daoCat = new CategoriaMySQL();
//        resultado = daoCat.insertar(cat1);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente la CATEGORIA");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar la CATEGORIA");
//        }
//        resultado = daoCat.insertar(cat2);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente la CATEGORIA2");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar la CATEGORIA2");
//        }
//        resultado = daoCat.insertar(cat3);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente la CATEGORIA3");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar la CATEGORIA3");
//        }
//        resultado = daoCat.insertar(cat4);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente la CATEGORIA4");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar la CATEGORIA4");
//        }
//        
//        //MODIFICAR -------------------------------------------------------------
//        cat1.setDescripcion("Pollos a la brasa");
//        cat3.setNombre("Gaseosas");
//        resultado = daoCat.modificar(cat1);
//        if (resultado == 1) {
//            System.out.println("Se ha modificado correctamente la CATEGORIA 1");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de modificado la CATEGORIA 1");
//        }
//        resultado = daoCat.modificar(cat3);
//        if (resultado == 1) {
//            System.out.println("Se ha modificado correctamente la CATEGORIA 3");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de modificado la CATEGORIA 3");
//        }
//        
//        //ELIMINAR -------------------------------------------------------------
//        resultado = daoCat.eliminar(cat4.getIdCategoria());
//        if (resultado == 1) {
//            System.out.println("Se ha eliminado CATEGORIA 4 correctamente ");
//        } else {
//            System.out.println(" NO se ha eliminado CATEGORIA 4 ");
//        }
//        
//        //LISTAR -----------------------------------------------------------------
//        ArrayList<Categoria> categorias = daoCat.listarTodas();
//        for(Categoria c : categorias) {
//            System.out.println(c.getNombre() + " - " + c.getDescripcion());
//        }
//        System.out.println("----------------------------------------------------------\n");
//        
////************************************************************************************************************
//// COMIDAS Y BEBIDAS
////************************************************************************************************************  
        Producto producto = new Producto("1/4 Pollo a la Brasa", 19.2, "con papas y ensalada", 'C', null); //platillo
        Producto producto2 = new Producto("Chuletas a la parrilla", 31.2, "con papas sancochadas", 'C', null);//platillo
        Producto producto3 = new Producto("Inka Kola", 3.5, "gaseosa descartable", 'B', "2.5L");//bebida
        Producto producto4 = new Producto("Mojito", 13.0, "una copa mediana", 'B', "1/2L");//bebida
        ProductoDAO daoProd = new ProductoMySQL();
        
        producto.setCategoria(cat1);
        producto2.setCategoria(cat2);
        producto3.setCategoria(cat3);
        producto4.setCategoria(cat4);
//        
//        //INSERTAR -------------------------------------------------------------
//        resultado = daoProd.insertar(producto);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente el PRODUCTO");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar el PRODUCTO");
//        }
//        resultado = daoProd.insertar(producto2);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente el PRODUCTO 2");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar el PRODUCTO 2");
//        }
//        resultado = daoProd.insertar(producto3);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente el PRODUCTO 3");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar el PRODUCTO 3");
//        }
//        resultado = daoProd.insertar(producto4);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado correctamente el PRODUCTO 4");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de insertar el PRODUCTO 4");
//        }
//        
//        //MODIFICAR -------------------------------------------------------------
//        producto.setNombre("1/2 Pollo a la Brasa");
//        producto2.setPrecio(35);
//        resultado = daoProd.modificar(producto);
//        if (resultado == 1) {
//            System.out.println("Se ha modificado correctamente la PRODUCTO 1");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de modificado la PRODUCTO 1");
//        }
//        resultado = daoProd.modificar(producto2);
//        if (resultado == 1) {
//            System.out.println("Se ha modificado correctamente la PRODUCTO 2");
//        } else {
//            System.out.println("Ha ocurrido un error al momento de modificado la PRODUCTO 2");
//        }
//        
//        //ELIMINAR -------------------------------------------------------------
//        resultado = daoProd.eliminar(producto4.getIdItemVendible());
//        if (resultado == 1) {
//            System.out.println("Se ha eliminado PRODUCTO 4 correctamente ");
//        } else {
//            System.out.println(" NO se ha eliminado PRODUCTO 4 ");
//        }
//        
//        //LISTAR -----------------------------------------------------------------
//        ArrayList<Producto> productos = daoProd.listarTodas();
//        for(Producto p : productos) {
//            System.out.println(p.getCategoria().getNombre()+ ")   " + p.getNombre() + " - " + p.getPrecio() + " - " + p.getDescripcion());
//        }
//        
//        System.out.println("Busqueda por nombre: 'a la'");
//        ArrayList<Producto> prod = daoProd.listarXNombre("a la"); 
//        for(Producto p : prod) {
//            System.out.println(p.getCategoria().getNombre()+ ")   " +p.getNombre() + " - " + p.getPrecio() + " - " + p.getDescripcion());
//        }
//        
//        System.out.println("----------------------------------------------------------\n");
//        
//
////************************************************************************************************************
//// PROMOCIONES
////************************************************************************************************************         
//        PromocionDAO daoPromo = new PromocionMySQL();
//        //AGREGANDO PROMOCIONES 
//        Promocion promocion1= new Promocion(new ArrayList<>(), "Combo Parrillero", 200.00, "Pollo a la Brasa con Chuleta a la Parrilla"); 
//        Promocion promocion2= new Promocion(new ArrayList<>(), "Combo Maritimo", 100.00, "ceviche y Chicharron de mariscos"); 
//        Promocion promocion3= new Promocion(new ArrayList<>(), "Combo Veranito", 100.00, "KFC criollo"); 
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
//        
//        //MOSTRAR PROMOCION
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
//        }
//        //probar todos los campos
//        System.out.println("----------------------------------------------------------\n"); 
//************************************************************************************************************
// ROLES
//************************************************************************************************************  
        Rol rol1 = new Rol("ADMIN");
        Rol rol2 = new Rol("CAJA");
        Rol rol3 = new Rol("MESERO");
        Rol rol4 = new Rol("COCINERO");
//        
//        //INSERTAR -------------------------------------------------------------
//        RolDAO daoRol = new RolMySQL();
//        resultado = daoRol.insertar(rol1);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado el ROL correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado el ROL correctamente ");
//        }
//        resultado = daoRol.insertar(rol2);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado el ROL 2 correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado el ROL 2 correctamente ");
//        }
//        resultado = daoRol.insertar(rol3);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado el ROL 3 correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado el ROL 3 correctamente ");
//        }
//        resultado = daoRol.insertar(rol4);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado el ROL 4 correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado el ROL 4 correctamente ");
//        }
//
//        //INSERTAR -------------------------------------------------------------
//        rol1.setDescripcion("ADMINISTRADOR");
//        rol2.setDescripcion("CAJERO");
//        resultado = daoRol.modificar(rol1);
//        if (resultado == 1) {
//            System.out.println("Se ha modificado el ROL correctamente ");
//        } else {
//            System.out.println(" NO Se ha modificado el ROL correctamente ");
//        }
//        resultado = daoRol.modificar(rol2);
//        if (resultado == 1) {
//            System.out.println("Se ha modificado el ROL 2 correctamente ");
//        } else {
//            System.out.println(" NO Se ha modificado el ROL 2 correctamente ");
//        }
//        
//         //ELIMINAR -------------------------------------------------------------
//        resultado = daoRol.eliminar(rol4.getId_rol());
//        if (resultado == 1) {
//            System.out.println("Se ha eliminado ROL 4 correctamente ");
//        } else {
//            System.out.println(" NO se ha eliminado ROL 4 ");
//        }
//        
//        //LISTAR -----------------------------------------------------------------
//        ArrayList<Rol> roles = daoRol.listarTodas();
//        for(Rol r : roles) {
//            System.out.println(r.getId_rol() + ") " + r.getDescripcion());
//        }
//        
//        System.out.println("----------------------------------------------------------\n");
//************************************************************************************************************
// PERSONAS
//************************************************************************************************************  
        Usuario us1 = new Usuario("psanchez", "asd1234", 1200.0, "9878842", "PEDRO", "PEREZ", "SANCHEZ", "9989893", 'N');
        Persona empresa = new Persona("EMPRESA ABC", "123-ASD", "2344412312", 'J');
        Usuario mesero1= new Usuario("Parmando", "asd1234", 1500.0, "9881234", "Armando", "Paredes", "gomez", "9989885", 'N');
        Usuario cajero1= new Usuario("sdrick", "asd1234", 3000.0, "9878842", "RICK", "SANCHEZ", "PEREZ", "9934893", 'N');
        Usuario cajero2= new Usuario("sdreik", "asl1234", 3000.0, "9878842", "MIKE", "LOPEZ", "GONZALEZ", "9934893", 'N');
        Persona cliente= new Persona("gaston", "acurio", "ddddd", "8128313", 'N');
        us1.setRol(rol1);
        us1.setRestaurante(res1);
        mesero1.setRestaurante(res1);
        cajero1.setRestaurante(res1);
        cajero2.setRestaurante(res1);
        mesero1.setRol(rol3);
        cajero1.setRol(rol2);
        cajero2.setRol(rol2);
        
//        
//        //INSERTAR -----------------------------------------------------------------
//        PersonaDAO daoPersona= new PersonaMySQL();
//        resultado= daoPersona.insertarPersona(cliente);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado en la tabla CLIENTE correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado en la tabla CLIENTE correctamente ");
//        }
//        resultado= daoPersona.insertarEmpresa(empresa);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado en la tabla EMPRESA correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado en la tabla EMPRESA correctamente ");
//        }
//        UsuarioDAO daoUsuario = new UsuarioMySQL();
//        resultado = daoUsuario.insertar(us1);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado en la tabla USUARIO correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado en la tabla USUARIO correctamente ");
//        }
//        resultado = daoUsuario.insertar(mesero1);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado en la tabla MESERO correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado en la tabla MESERO correctamente ");
//        }
//        resultado = daoUsuario.insertar(cajero1);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado en la tabla CAJERO correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado en la tabla CAJERO correctamente ");
//        }
//        
//        resultado = daoUsuario.insertar(cajero2);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado en la tabla CAJERO2 correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado en la tabla CAJERO2 correctamente ");
//        }
//        
//        //MODIFICAR -----------------------------------------------------------------
//        us1.setUsuario("NUEVOUSUARIO");
//        resultado = daoUsuario.modificar(us1);
//        if (resultado == 1) {
//            System.out.println("Se ha modifcado en la tabla USUARIO correctamente ");
//        } else {
//            System.out.println(" NO Se ha modifcado en la tabla USUARIO correctamente ");
//        }
//        
//        //ELIMINAR -----------------------------------------------------------------
//        resultado = daoUsuario.elminiar(cajero2.getId_usuario());
//        if (resultado == 1) {
//            System.out.println("Se ha eliminado en la tabla CAJERO2 correctamente ");
//        } else {
//            System.out.println(" NO Se ha eliminado en la tabla CAJERO2 correctamente ");
//        }
//        
//
//        //LISTAR -----------------------------------------------------------------       
//        ArrayList<Usuario> usuarios = daoUsuario.listarTodas();
//        for (int i = 0; i < usuarios.size(); i++) {
//
//            System.out.println(usuarios.get(i).getId_usuario() + " "
//                    + usuarios.get(i).getNombre() + "  " + usuarios.get(i).getUsuario());
//
//        }
//        System.out.println("----------------------------------------------------------\n");        
////************************************************************************************************************
//// ASISTENCIAS
////************************************************************************************************************        
//        Asistencia asistencia = new Asistencia();
//        Asistencia asistencia1 = new Asistencia();
//        asistencia.setUsuario(us1);
//        asistencia1.setUsuario(mesero1);
//        
//        //REGISTRAR -----------------------------------------------------------------
//        AsistenciaDAO daoAsistencia = new AsistenciaMySQL();
//        resultado = daoAsistencia.registrarAsistencia(asistencia);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado en la tabla ASISTENCIA correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado en la tabla ASISTENCIA correctamente ");
//        }
//        resultado = daoAsistencia.registrarAsistencia(asistencia1);
//        if (resultado == 1) {
//            System.out.println("Se ha registrado en la tabla ASISTENCIA1 correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado en la tabla ASISTENCIA1 correctamente ");
//        }
//        
//        //LISTAR -----------------------------------------------------------------
//        SimpleDateFormat sdf1 = new SimpleDateFormat("dd-MM-yyyy");
//        SimpleDateFormat sdf2 = new SimpleDateFormat("HH:mm:ss");
//        ArrayList<Asistencia> asistencias = daoAsistencia.listarAsistencia();
//        for(Asistencia a : asistencias) {
//            System.out.println(a.getUsuario().getNombre() + ": " + sdf1.format(a.getFecha()) + " - INICIO: " +
//                    sdf2.format(a.getHora_inicio()) + " - FIN: " );
//        }
//        
//        //MODIFICAR -----------------------------------------------------------------
//        resultado = daoAsistencia.registrarSalida(us1.getId_usuario());
//        if (resultado == 1) {
//            System.out.println("Se ha registrado SALIDA en la tabla ASISTENCIA correctamente ");
//        } else {
//            System.out.println(" NO Se ha registrado SALIDA en la tabla ASISTENCIA correctamente ");
//        }
//        System.out.println("----------------------------------------------------------\n");     
////************************************************************************************************************
//// GASTOS
////************************************************************************************************************           
//        Gasto gasto1 = new Gasto("Pollos",15.5,4,"1 KG");
//        Gasto gasto2 = new Gasto("Papas",10,2,"1/2 KG");
//        gasto1.setRestaurante(res1);
//        gasto2.setRestaurante(res1);
//        GastoDAO gastoDao = new GastoMySQL();
//        //INSERTAR -----------------------------------------------------------------
//        System.out.println("DINERO ACTUAL: " + res1.getDineroActual() + "\n ======");
//        resultado = gastoDao.insertar(gasto1);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado GASTO1 correctamente ");
//        } else {
//            System.out.println(" NO se ha insertado GASTO1 ");
//        }
//        resultado = gastoDao.insertar(gasto2);
//        if (resultado == 1) {
//            System.out.println("Se ha insertado GASTO2 correctamente ");
//        } else {
//            System.out.println(" NO se ha insertado GASTO2 ");
//        }
//        
//        //MODIFICAR -----------------------------------------------------------------
//        gasto1.setItem("Pavos");
//        resultado = gastoDao.modificar(gasto1);
//        if (resultado == 1) {
//            System.out.println("Se ha modificado GASTO1 correctamente ");
//        } else {
//            System.out.println(" NO se ha modificado GASTO1 ");
//        }
//        
//        //ELIMINAR -----------------------------------------------------------------
//        
//        
//        //LISTAR -------------------------------------------------------------------
//        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
//        ArrayList<Gasto> gastos; //resultado
//        gastos = gastoDao.listarTodas();
//        for(Gasto g : gastos) {
//            System.out.println(g.getRestaurante().getNombre()+ " - " + g.getRestaurante().getDineroActual() + ": \n" + 
//                "\t" + sdf.format(g.getFecha()) + " - " +g.getItem() + " \n\t " + g.getCantidad() + " * " + g.getPrecio() + " = " + g.getTotal());
//        }
//        System.out.println("----------------------------------------------------------\n"); 
//************************************************************************************************************
// PEDIDOS
//************************************************************************************************************        
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        mesero1.setId_usuario(4);
        cajero1.setId_usuario(5);
        cliente.setId_persona(2);
        Pedido pedido = new Pedido(mes1, 'E', mesero1, cajero1, 'L', cliente, 'B', 256362, 'P',
                        new ArrayList<>(), res1, formato.parse("24-12-2022"), true, 'P');
        res1.setId_restaurante(1);
        pedido.calcularTotal();
        
        //INSERTAR PEDIDO
        PedidoDAO pedidoDao = new PedidoMySQL();
////        resultado = pedidoDao.insertar(pedido);
//        if (resultado == 1) System.out.println("Se ha insertado pedido correctamente ");
        
//        
//        ///////////////////////////////////////////////////////////////////////////////////////////////////
        
        LineaPedido linea1 = new LineaPedido();
        linea1.setItem(new Producto());
        linea1.getItem().setIdItemVendible(1);
        linea1.setUnidades(2);
        linea1.setSubtotal(30);
        LineaPedido linea12 = new LineaPedido();
        linea12.setItem(new Producto());
        linea12.getItem().setIdItemVendible(2); 
        linea12.setUnidades(2);
        linea12.setSubtotal(10);
        pedido.getList_lineaPedido().add(linea1);
        pedido.getList_lineaPedido().add(linea12);
        int resultado = pedidoDao.insertar(pedido);
        if (resultado == 1) System.out.println("Se ha insertado pedido correctamente ");
        else System.out.println(" NO se ha insertado pedido ");
//        
//        //INSERTAR LINEA PEDIDO
//        LineaPedidoDAO lineaDao = new LineaPedidoMySQL();
//        resultado = lineaDao.insertar(linea1);
//        if (resultado == 1) System.out.println("Se ha insertado LineaPedido correctamente ");
//        else System.out.println(" NO se ha insertado LineaPedido ");
//        
//        //MODIFICAR PEDIDO/LINEA PEDIDO
//        pedido.getList_lineaPedido().add(linea1);
//        pedido.calcularTotal();
//        resultado = pedidoDao.modificar(pedido);
//        if (resultado == 1) System.out.println("Se ha modificado pedido correctamente ");
//        else System.out.println(" NO se ha modificado pedido ");
//        
//        //ELIMINAR PEDIDO
//        resultado = pedidoDao.eliminar(pedido.getIdPedido());
//        if (resultado == 1) System.out.println("Se ha elminado pedido correctamente ");
//        else System.out.println(" NO se ha elminado pedido ");
//        
//        //Listando todas las areas registradas
//        ArrayList<Pedido> pedidos = pedidoDao.listarTodas();
//        for(int i=0;i<pedidos.size();i++){
//            System.out.println("I: " + pedidos.get(i).getIdPedido() + "   el id es: " + pedidos.get(i).getCajero().getNombre() + 
//                    ". \nLa mesa tiene " + pedidos.get(i).getMesa().getNumero());
//        }
//        System.out.println("Se ha listado pedido correctamente ");
//        ArrayList<LineaPedido> lineas = lineaDao.listarTodas();
//        for(int i=0;i<lineas.size();i++){
//            System.out.println("Id es: " + lineas.get(i).getId_linea_pedido() + " Producto: " + lineas.get(i).getItem().getNombre() + 
//                    ". \nCantidad: " + lineas.get(i).getUnidades());
//        }
//        System.out.println("Se ha listado lista_pedido correctamente ");
    
    }
}
