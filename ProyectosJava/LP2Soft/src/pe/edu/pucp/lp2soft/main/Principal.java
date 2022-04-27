package pe.edu.pucp.lp2soft.main;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.dao.CategoriaDAO;
import pe.edu.pucp.lp2soft.negocio.dao.ProductoDAO;
import pe.edu.pucp.lp2soft.negocio.model.Categoria;
import pe.edu.pucp.lp2soft.negocio.model.Producto;
import pe.edu.pucp.lp2soft.negocio.mysql.CategoriaMySQL;
import pe.edu.pucp.lp2soft.negocio.mysql.ProductoMySQL;

public class Principal {
    public static void main(String[] args) throws Exception{
        Categoria cat1 = new Categoria("Pollos","todo tipo de pollo :v");
        Categoria cat2 = new Categoria("Parrilleros","las parrillas :v");
        Categoria cat3 = new Categoria("Gaseosas","aguas con gas :v");
        Producto producto = new Producto("1/4 Pollo a la Brasa",true,19.2,"con papas y ensalada",'C'," ");
        Producto producto2 = new Producto("Chuletas a la parrilla",true,31.2,"con papas sancochadas",'C'," ");
        Producto producto3 = new Producto("Inka Kola",true,3.5,"gaseosa descartable",'B',"2.5L");
        
        ProductoDAO daoProd = new ProductoMySQL();
        CategoriaDAO daoCat = new CategoriaMySQL();
        
        //AGREGANDO CATEGORIAS--------------------------------------------------------------
        int resultado = daoCat.insertar(cat1);
        if(resultado==1)
            System.out.println("Se ha insertado correctamente la categoria");
        else
            System.out.println("Ha ocurrido un error al momento de insertar la categoria");
    
        resultado = daoCat.insertar(cat2);
        if(resultado==1)
            System.out.println("Se ha insertado correctamente la categoria2");
        else
            System.out.println("Ha ocurrido un error al momento de insertar la categoria2");
    
        resultado = daoCat.insertar(cat3);
        if(resultado==1)
            System.out.println("Se ha insertado correctamente la categoria3");
        else
            System.out.println("Ha ocurrido un error al momento de insertar la categoria3");
        
        
        producto.setCategoria(cat1);
        producto2.setCategoria(cat2);
        producto3.setCategoria(cat3);
        
        
        //AGREGANDO PRODUCTOS ---------------------------------------------------------------------------------------
        resultado = daoProd.insertar(producto);
        if(resultado==1)
            System.out.println("Se ha insertado correctamente el producto");
        else
            System.out.println("Ha ocurrido un error al momento de insertar el producto");
    
        resultado = daoProd.insertar(producto2);
        if(resultado==1)
            System.out.println("Se ha insertado correctamente el producto2");
        else
            System.out.println("Ha ocurrido un error al momento de insertar el producto2");
    
        resultado = daoProd.insertar(producto3);
        if(resultado==1)
            System.out.println("Se ha insertado correctamente el producto3");
        else
            System.out.println("Ha ocurrido un error al momento de insertar el producto3");
    
//        //AGREGANDO PRODUCTOS ---------------------------------------------------------------------------------------
//        
//        ArrayList<Producto> productos = daoProd.listarTodas();
//        for(Producto p : productos)
//            System.out.println(p.getNombre() + " - S/." + p.getPrecio() + " - " + p.getDescripcion() + " - " + p.getCategoria().getNombre());

        
        
    }
}
