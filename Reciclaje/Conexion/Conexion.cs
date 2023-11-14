using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Reciclaje.Conexion
{
    class Conexion
    {
        private String stPathDB = "./bd_Reciclaje.db";
        private static Conexion Con = null;
        private SQLiteConnection Conn;
        private SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Conexion() 
        {
            //CrearConexion();
        }

        public SQLiteConnection CrearConexion() 
        {
            SQLiteConnection cad = new SQLiteConnection();
            try
            {
                cad.ConnectionString = "Data Source=" + this.stPathDB;

            }
            catch (Exception e) 
            {
                cad = null;
                throw e;
            }
            return cad;
        }

        public static Conexion getInstancia() 
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            
            return Con;
        }

        public int crearBD() {
            int resultado = 0;
            String querrydb = 
            "CREATE TABLE usuario(" +
            "rut VARCHAR(20) NOT NULL PRIMARY KEY, nombre VARCHAR(100),correo VARCHAR(100) NOT NULL ,clave VARCHAR(20) NOT NULL, permiso INT NOT NULL" +
            ");" +
            "CREATE TABLE usuarioTemp(" +
            "rut VARCHAR(20) NOT NULL " +
            ");" +
            "CREATE TABLE conductor(" +
            "rut VARCHAR(20) NOT NULL PRIMARY KEY, nombre VARCHAR(100), celular VARCHAR(13)" +
            ");" +        
            "CREATE TABLE vehiculo(" +
            "patente VARCHAR(8) NOT NULL PRIMARY KEY, capacidad INT, tipo VARCHAR(30),combustible VARCHAR(20),consumo DOUBLE,emision INT" +            
            ");" +
            "CREATE TABLE ruta(" +
            "id VARCHAR(10) NOT NULL PRIMARY KEY, descripcion VARCHAR(30), duracion INT,distancia DOUBLE, cantidadPuntos INT" +
            ");" +
            "CREATE TABLE marcador(" +
            "id INT NOT NULL, idRuta VARCHAR(10) NOT NULL, longitud DOUBLE, latitud DOUBLE, peso INT," +
            "PRIMARY KEY(id, idRuta)," +
            "FOREIGN KEY(idRuta) REFERENCES ruta(id)" +
            ");" +
            "CREATE TABLE recorrido("+
            "id VARCHAR(10) PRIMARY KEY, idRuta VARCHAR(10),rutConductor VARCHAR(20),patente VARCHAR(8),material VARCHAR(30),fecha DATE, duracionFinal INT,distanciaFinal double, cantidadRecoleccion INT,consumoEnergeticoFinal DOUBLE,emisionFinal DOUBLE,estado INT," +
            "FOREIGN KEY(idRuta) REFERENCES ruta(id),"+
            "FOREIGN KEY(rutConductor) REFERENCES conductor(rut),"+
            "FOREIGN KEY(patente) REFERENCES vehiculo(patente)"+
            "); "+
            "CREATE TABLE usuario_recorrido(" +
            "rut VARCHAR(20), idRecorrido VARCHAR(10)," +
            "PRIMARY KEY(rut,idRecorrido)," +
            "FOREIGN KEY(rut) REFERENCES usuario(rut)," +
            "FOREIGN KEY (idRecorrido) REFERENCES recorrido(id)" +
            ");" +
            "CREATE TABLE codigo(" +
            "cod VARCHAR(4) NOT NULL," +
            "descripcion VARCHAR(30) NOT NULL" +
            ");" +
            "INSERT INTO codigo VALUES('vt00','CAMION 3/4');"+
            "INSERT INTO codigo VALUES('vt00','CAMION LIVIANO');"+
            "INSERT INTO codigo VALUES('vt00','CAMION HEAVY DUTY');"+
            "INSERT INTO codigo VALUES('vt00','CAMION PLUMA');"+
            "INSERT INTO codigo VALUES('vt00','CAMION TOLVA 8x4');"+
            "INSERT INTO codigo VALUES('vt00','CAMION TOLVA 8x6');"+
            "INSERT INTO codigo VALUES('vt00','CAMION TOLVA 8x8');"+
            "INSERT INTO codigo VALUES('vc00','DIESEL');"+
            "INSERT INTO codigo VALUES('vc00','GASOLINA');"+
            "INSERT INTO codigo VALUES('rm00','ALUMINIO');"+
            "INSERT INTO codigo VALUES('rm00','CARTON');"+
            "INSERT INTO codigo VALUES('rm00','TRETAPACK');"+
            "INSERT INTO codigo VALUES('rm00','PET');"+
            "INSERT INTO codigo VALUES('rm00','VIDRIO');";

            if (!System.IO.File.Exists(stPathDB))
            {
                SQLiteConnection.CreateFile(stPathDB);
                SQLiteConnection conexion = new SQLiteConnection(@"Data Source=" + stPathDB);
                conexion.Open();
                SQLiteCommand comando = new SQLiteCommand(querrydb, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                resultado = 1;
            }
            else {
                Console.WriteLine("No se pudo crear la base de datos");
                return 0 ;
            }
            return resultado;
                
        }



    }
}
