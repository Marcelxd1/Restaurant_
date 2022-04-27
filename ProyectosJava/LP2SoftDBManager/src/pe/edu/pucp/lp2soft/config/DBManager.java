package pe.edu.pucp.lp2soft.config;

import java.sql.Connection;
import java.sql.DriverManager;

public class DBManager {
    private static DBManager dbManager;
    private String url = "jdbc:mysql://database-ta.cdae0cnqvkjt.us-east-1.rds.amazonaws.com:3306/Restaurante";
    private String user = "admin1";
    private String password = "marcelta123";
    private Connection con;
    
    public Connection getConnection(){
        try{
            //Registramos el Driver de conexion
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(url, user,password);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return con;
    }
    
    private synchronized static void createInstance(){
        if(dbManager==null){
            dbManager = new DBManager();
        }
    }
    
    public static DBManager getInstance(){
        if(dbManager == null)
            createInstance();
        return dbManager;
    }
}