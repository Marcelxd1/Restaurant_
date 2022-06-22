package pe.edu.pucp.lp2soft.services;

import java.awt.Image;
import java.sql.Connection;
import java.sql.Date;
import java.util.HashMap;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.lp2soft.config.DBManager;


@WebService(serviceName = "ReporteWS")
public class ReporteWS {

    
    @WebMethod(operationName = "generarBoletaVenta")
    public byte[] generarBoletaVenta( int idPedido, String cajero, String mesero, String cliente,String DNIRUC) {
        byte[] reporteBytes = null;
        try{
            Connection con = DBManager.getInstance().getConnection();
            JasperReport reporte = 
                    (JasperReport) JRLoader.loadObject(ReporteWS.class.getResource("/pe/edu/pucp/lp2soft/reports/Boleta.jasper"));
            String rutaImagen = ReporteWS.class.getResource("/pe/edu/pucp/lp2soft/img/LA_CAMPIÑA.jpg").getPath();
            rutaImagen = rutaImagen.replace("%20", " ");
            Image imagen = (new ImageIcon(rutaImagen)).getImage();
            HashMap hm = new HashMap();
            hm.put("ParamLogo",imagen);
            hm.put("IdPedido",idPedido);
            hm.put("Cajero",cajero);
            hm.put("Mesero",mesero);
            hm.put("Cliente",cliente);
            hm.put("DNIRUC",DNIRUC);
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm,con);
            con.close();
            reporteBytes = JasperExportManager.exportReportToPdf(jp);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return reporteBytes;
    }
    
    @WebMethod(operationName = "generarFacturaVenta")
    public byte[] generarFacturaVenta( int idPedido, String cajero, String mesero, String cliente,String DNIRUC) {
        byte[] reporteBytes = null;
        try{
            Connection con = DBManager.getInstance().getConnection();
            JasperReport reporte = 
                    (JasperReport) JRLoader.loadObject(ReporteWS.class.getResource("/pe/edu/pucp/lp2soft/reports/Factura.jasper"));
            String rutaImagen = ReporteWS.class.getResource("/pe/edu/pucp/lp2soft/img/LA_CAMPIÑA.jpg").getPath();
            rutaImagen = rutaImagen.replace("%20", " ");
            Image imagen = (new ImageIcon(rutaImagen)).getImage();
            HashMap hm = new HashMap();
            hm.put("ParamLogo",imagen);
            hm.put("IdPedido", idPedido);
            hm.put("Cajero",cajero);
            hm.put("Mesero",mesero);
            hm.put("Cliente",cliente);
            hm.put("DNIRUC",DNIRUC);
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm,con);
            con.close();
            reporteBytes = JasperExportManager.exportReportToPdf(jp);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return reporteBytes;
    }
    
    @WebMethod(operationName = "generarReporteAsistencia")
    public byte[] generarReporteAsistencia( String fechaini, String fechafin ) {
        byte[] reporteBytes= null;
        try {
            Connection con= DBManager.getInstance().getConnection();
            JasperReport reporte = (JasperReport)JRLoader.loadObject(ReporteWS.class.getResource("/pe/edu/pucp/lp2soft/reports/ReporteAsistencia.jasper"));
            Date fini, ffin; 
            fini = java.sql.Date.valueOf(fechaini);
            ffin = java.sql.Date.valueOf(fechafin);
            HashMap hm = new HashMap();// aqui entraria la imagen
            hm.put("fechaIni", fini);
            hm.put("fechaFin", ffin);
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm, con);
            con.close();
            reporteBytes = JasperExportManager.exportReportToPdf(jp);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return reporteBytes;
    }
    
    @WebMethod(operationName = "generarReportePlatosMasVendidos")
    public byte[] generarReportePlatosMasVendidos( String fechaini, String fechafin ) {
        byte[] reporteBytes= null;
        try {
            Connection con= DBManager.getInstance().getConnection();
            JasperReport reporte = (JasperReport)JRLoader.loadObject(ReporteWS.class.getResource("/pe/edu/pucp/lp2soft/reports/ReportePlatosVendidos.jasper"));
            Date fini, ffin; 
            fini = java.sql.Date.valueOf(fechaini);
            ffin = java.sql.Date.valueOf(fechafin);
            HashMap hm = new HashMap();// aqui entraria la imagen
            hm.put("fechaIni", fini);
            hm.put("fechaFin", ffin);
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm, con);
            con.close();
            reporteBytes = JasperExportManager.exportReportToPdf(jp);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return reporteBytes;
    }
}
