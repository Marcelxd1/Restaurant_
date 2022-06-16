package pe.edu.pucp.lp2soft.services;

import java.awt.Image;
import java.sql.Connection;
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
    public byte[] generarBoletaVenta(@WebParam(name = "idMesa") int idMesa) {
        byte[] reporteBytes = null;
        try{
            Connection con = DBManager.getInstance().getConnection();
            JasperReport reporte = 
                    (JasperReport) JRLoader.loadObject(ReporteWS.class.getResource("/pe/edu/pucp/lp2soft/reports/Boleta.jasper"));
            String rutaImagen = ReporteWS.class.getResource("/pe/edu/pucp/lp2soft/img/LA_CAMPIÑA.jpg").getPath();
            Image imagen = (new ImageIcon(rutaImagen)).getImage();
            HashMap hm = new HashMap();
            hm.put("ParamLogo",imagen);
            hm.put("IdPedido", idMesa);
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm,con);
            con.close();
            reporteBytes = JasperExportManager.exportReportToPdf(jp);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return reporteBytes;
    }
}
