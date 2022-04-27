import java.util.ArrayList;
import pe.edu.pucp.lp2soft.caja.model.Transaccion;
import pe.edu.pucp.lp2soft.negocio.model.ItemVendible;
import pe.edu.pucp.lp2soft.negocio.model.Mesa;

class Restaurante{
    private int ruc ; 
    private String nombre ;
    private int telefono ; 
    private String direccion ; 
    private ArrayList<Transaccion> list_transaccion;//los ingresos y egresos
    private ArrayList<ItemVendible> list_itemVendible;//la carta
    private ArrayList<Mesa> list_mesas;
    private float dineroActual;
    
    //CONSTRUCTOR 
    public Restaurante() {}
	public Restaurante(int ruc, String nombre, int telefono, String direccion) {
        this.ruc = ruc;
        this.nombre = nombre;
        this.telefono = telefono;
        this.direccion = direccion;
    }
    
    //SETTERS Y GETTERS 
    public int getRuc() {
        return ruc;
    }
    public void setRuc(int ruc) {
        this.ruc = ruc;
    }

    public String getNombre() {
        return nombre;
    }
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getTelefono() {
        return telefono;
    }
    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    public String getDireccion() {
        return direccion;
    }
    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public ArrayList<Transaccion> getList_transaccion() {
        return this.list_transaccion;
    }
    public void setList_transaccion(ArrayList<Transaccion> list_lineaPedido) {
        this.list_transaccion = list_lineaPedido;
    }
    
    public ArrayList<ItemVendible> getList_itemVendible() {
		return list_itemVendible;
	}
	public void setList_itemVendible(ArrayList<ItemVendible> list_itemVendible) {
		this.list_itemVendible = list_itemVendible;
	}
    public ArrayList<Mesa> getList_Mesa() {
		return list_mesas;
	}
	public void setList_Mesa(ArrayList<Mesa> list_mesas) {
		this.list_mesas = list_mesas;
	}
    public float getDineroActual() {
        return dineroActual;
    }
    public void setDineroActual(float dineroActual) {
        this.dineroActual = dineroActual;
    }
    //METODOS

}