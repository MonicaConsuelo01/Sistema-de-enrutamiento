using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using Reciclaje.Logica;
using System.Data;

namespace Reciclaje.Conexion
{
    class Gestor 
    {
        public Gestor() { }
        private Conexion con = Conexion.getInstancia();
        public int crearBD() {
            return con.crearBD();
        }
        public int crudConductor(int crud,Conductor conductor) {
            int inResultado = 0;
            SQLiteConnection conexion = con.CrearConexion();
            SQLiteCommand comando = conexion.CreateCommand();
            try
            {
                if (crud == 0 && existeTabla(1, conductor.stRut) == false)
                {//insertar
                    conexion.Open();
                    comando.CommandText = "INSERT INTO conductor (rut,nombre,celular) VALUES (@rut,@nombre,@celular);";
                    comando.Parameters.AddWithValue("@rut", conductor.stRut);
                    comando.Parameters.AddWithValue("@nombre", conductor.stNombre);
                    comando.Parameters.AddWithValue("@celular", conductor.stCelular);
                    inResultado = comando.ExecuteNonQuery();
                }
                if (crud == 1 && existeTabla(1, conductor.stRut))
                { //modificar
                    conexion.Open();
                    comando.CommandText = "UPDATE conductor SET nombre = @nombre ,celular = @celular WHERE rut = @rut;";
                    comando.Parameters.AddWithValue("@rut", conductor.stRut);
                    comando.Parameters.AddWithValue("@nombre", conductor.stNombre);
                    comando.Parameters.AddWithValue("@celular", conductor.stCelular);
                    inResultado = comando.ExecuteNonQuery();
                }
                if (crud == 2 && existeTabla(1, conductor.stRut))
                {//eliminar
                    conexion.Open();
                    comando.CommandText = "DELETE FROM conductor WHERE rut = @rut;";
                    comando.Parameters.AddWithValue("@rut", conductor.stRut);
                    inResultado = comando.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                inResultado = -1;
                throw (e);
            }
            finally
            {
                conexion.Close();
            }
            return inResultado;
        }

        public int crudVehiculos(int crud,Vehiculo vehiculo) {
            int inResultado = 0;
            SQLiteConnection conexion = con.CrearConexion();
            SQLiteCommand comando = conexion.CreateCommand();
            try
            {//patente VARCHAR(8), capacidad INT, tipo VARCHAR(30),combustible VARCHAR(20),consumo DOUBLE,emision INT" +
                if (crud == 0 && existeTabla(2, vehiculo.stPatente) == false)
                {//insertar
                    conexion.Open();
                    comando.CommandText = "INSERT INTO vehiculo (patente,capacidad,tipo,combustible,consumo,emision) " +
                        "VALUES (@patente,@capacidad,@tipo,@combustible,@consumo,@emision);";
                    comando.Parameters.AddWithValue("@patente", vehiculo.stPatente);
                    comando.Parameters.AddWithValue("@capacidad", vehiculo.inPeso);
                    comando.Parameters.AddWithValue("@tipo", vehiculo.stTipo);
                    comando.Parameters.AddWithValue("@combustible", vehiculo.stCombustible);
                    comando.Parameters.AddWithValue("@consumo", vehiculo.doConsumoEnergetico);
                    comando.Parameters.AddWithValue("@emision", vehiculo.inEmision);
                    inResultado = comando.ExecuteNonQuery();
                }
                if (crud == 1 && existeTabla(2, vehiculo.stPatente))
                { //modificar
                    conexion.Open();
                    comando.CommandText = 
                        "UPDATE vehiculo SET capacidad = @capacidad, tipo = @tipo, combustible = @combustible, consumo = @consumo, emision = @emision " +
                        "WHERE patente = @patente;";
                    comando.Parameters.AddWithValue("@patente", vehiculo.stPatente);
                    comando.Parameters.AddWithValue("@capacidad", vehiculo.inPeso);
                    comando.Parameters.AddWithValue("@tipo", vehiculo.stTipo);
                    comando.Parameters.AddWithValue("@combustible", vehiculo.stCombustible);
                    comando.Parameters.AddWithValue("@consumo", vehiculo.doConsumoEnergetico);
                    comando.Parameters.AddWithValue("@emision", vehiculo.inEmision);
                    inResultado = comando.ExecuteNonQuery();
                }
                if (crud == 2 && existeTabla(2, vehiculo.stPatente))
                {//eliminar
                    conexion.Open();
                    comando.CommandText = "DELETE FROM vehiculo WHERE patente = @patente;";
                    comando.Parameters.AddWithValue("@patente",vehiculo.stPatente);
                    inResultado = comando.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                inResultado = -1;
                throw (e);
            }
            finally
            {
                conexion.Close();
            }
            return inResultado;
        }

        public int crudUsuario(int crud, Usuario usuario) {
            int inResultado = 0;
            SQLiteConnection conexion = con.CrearConexion();
            SQLiteCommand comando = conexion.CreateCommand();
            try {
                if (crud == 0 && existeTabla(0,usuario.Rut)== false)
                {//insertar
                    conexion.Open();
                    comando.CommandText = "INSERT INTO usuario (rut,nombre,clave,correo,permiso) VALUES (@rut,@nombre,@clave,@correo,@permiso);";
                    comando.Parameters.AddWithValue("@rut",usuario.Rut);
                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@clave", usuario.Clave);
                    comando.Parameters.AddWithValue("@correo", usuario.Correo);
                    comando.Parameters.AddWithValue("@permiso", usuario.Permiso);
                    inResultado = comando.ExecuteNonQuery();
                }
                if (crud == 1){ }//modificar
                if (crud == 2){ }//eliminar
            }
            catch (Exception e) {
                inResultado = -1;
                throw (e);
            }
            finally{
                conexion.Close();                
            }
            return inResultado;
        }

        public int crearRuta(Rutas ruta, List<Marcador> marcadores ) {
            int inResultado = 0;
            SQLiteConnection conexion = con.CrearConexion();
            SQLiteCommand cmd1 = conexion.CreateCommand();
            SQLiteCommand cmd2 = conexion.CreateCommand();
            conexion.Open();
            var transac = conexion.BeginTransaction();
            try
            {
                cmd1.CommandText = "INSERT INTO ruta (id,descripcion,duracion,distancia,cantidadPuntos) VALUES (@id,@descripcion,@duracion,@distancia,@cantidadPuntos);";
                cmd1.Parameters.AddWithValue("@id", ruta.stIdRuta);
                cmd1.Parameters.AddWithValue("@descripcion", ruta.stDescripcion);
                cmd1.Parameters.AddWithValue("@duracion", ruta.inDuracion);
                cmd1.Parameters.AddWithValue("@distancia", ruta.doDistancia);
                cmd1.Parameters.AddWithValue("@cantidadPuntos", ruta.inCantidadPuntos);
                inResultado = cmd1.ExecuteNonQuery();
                cmd2.CommandText = "INSERT INTO marcador (id,idRuta,longitud,latitud,peso) VALUES (@id,@idRuta,@longitud,@latitud,@peso);";
                foreach (Marcador marcador in marcadores) {
                    cmd2.Parameters.AddWithValue("@id",marcador.inId);
                    cmd2.Parameters.AddWithValue("@idRuta", marcador.stIdRuta);
                    cmd2.Parameters.AddWithValue("@longitud", marcador.doLongitud);
                    cmd2.Parameters.AddWithValue("@latitud", marcador.doLatitud);
                    cmd2.Parameters.AddWithValue("@peso", marcador.inPeso);
                    inResultado = cmd2.ExecuteNonQuery();
                }
                transac.Commit();
            }
            catch (Exception e) {
                transac.Rollback();
                return -1;
            }
            finally
            {
                conexion.Close();
            }

            return inResultado;
        }
        public int modificarRuta(Rutas ruta, List<Marcador> marcadores)
        {
            int inResultado = 0;
            SQLiteConnection conexion = con.CrearConexion();
            SQLiteCommand cmd1 = conexion.CreateCommand();
            SQLiteCommand cmd2 = conexion.CreateCommand();
            SQLiteCommand cmd3 = conexion.CreateCommand();
            conexion.Open();
            var transac = conexion.BeginTransaction();
            try
            {
                cmd1.CommandText = "UPDATE ruta SET descripcion = @descripcion, duracion = @duracion, distancia = @distancia,cantidadPuntos = @cantidadPuntos  WHERE id = @id;";                                 
                cmd1.Parameters.AddWithValue("@id", ruta.stIdRuta);
                cmd1.Parameters.AddWithValue("@descripcion", ruta.stDescripcion);
                cmd1.Parameters.AddWithValue("@duracion", ruta.inDuracion);
                cmd1.Parameters.AddWithValue("@distancia", ruta.doDistancia);
                cmd1.Parameters.AddWithValue("@cantidadPuntos", ruta.inCantidadPuntos);
                inResultado = cmd1.ExecuteNonQuery();
                cmd3.CommandText = "DELETE FROM marcador WHERE idRuta = @idRuta;"; 
                cmd3.Parameters.AddWithValue("@id", ruta.stIdRuta);
                inResultado = cmd3.ExecuteNonQuery();
                foreach (Marcador marcador in marcadores)
                {
                    cmd2.CommandText = "INSERT INTO marcador (id,idRuta,longitud,latitud,peso) VALUES (@id,@idRuta,@longitud,@latitud,@peso);";
                    cmd2.Parameters.AddWithValue("@id", marcador.inId);
                    cmd2.Parameters.AddWithValue("@idRuta", marcador.stIdRuta);
                    cmd2.Parameters.AddWithValue("@longitud", marcador.doLongitud);
                    cmd2.Parameters.AddWithValue("@latitud", marcador.doLatitud);
                    cmd2.Parameters.AddWithValue("@peso", marcador.inPeso);
                    inResultado = cmd2.ExecuteNonQuery();
                }
                transac.Commit();
            }
            catch (Exception e)
            {
                transac.Rollback();
                return -1;
            }
            finally
            {
                conexion.Close();
            }

            return inResultado;
        }
        public int eliminarRuta(Rutas ruta)
        {
            int inResultado = 0;
            SQLiteConnection conexion = con.CrearConexion();
            SQLiteCommand cmd1 = conexion.CreateCommand();
            SQLiteCommand cmd2 = conexion.CreateCommand();
            conexion.Open();
            var transac = conexion.BeginTransaction();
            try
            {
                cmd2.CommandText = "DELETE FROM marcador WHERE idRuta = @idRuta;";
                cmd2.Parameters.AddWithValue("@idRuta", ruta.stIdRuta);
                cmd1.CommandText = "DELETE FROM ruta WHERE id = @id;";
                cmd1.Parameters.AddWithValue("@id", ruta.stIdRuta);              
                inResultado = cmd2.ExecuteNonQuery();
                inResultado = cmd1.ExecuteNonQuery();
                transac.Commit();
            }
            catch (Exception e)
            {
                transac.Rollback();
                return -1;
            }
            finally
            {
                conexion.Close();
            }

            return inResultado;
        }
        public int crudRecorrido(int crud,Recorrido recorrido) {
            //id VARCHAR(10) PRIMARY KEY, idRuta VARCHAR(10),rutConductor VARCHAR(20),patente VARCHAR(8),material VARCHAR(30),fecha DATE, duracionFinal INT,distanciaFinal double, cantidadRecoleccion INT,consumoEnergeticoFinal DOUBLE,emisionFinal DOUBLE,estado INT
            //string stIdRecorrido,string stIdRuta,string stRutConductor,string stPatente,string stMaterial, string stFecha, int inDuracionFinal,double doDistanciaFinal,double doConsumoFinal,int inEmisionFinal,int inCantidadRecoleccion,int inEstado
            int inResultado = 0;
            SQLiteConnection conexion = con.CrearConexion();
            SQLiteCommand comando = conexion.CreateCommand();
            try
            {
                if (crud == 0 && existeTabla(6, recorrido.stIdRecorrido) == false)
                {//insertar
                    conexion.Open();                    
                    comando.CommandText = "INSERT INTO recorrido (id, idRuta ,rutConductor ,patente ,material ,fecha , duracionFinal ,distanciaFinal ,consumoEnergeticoFinal ,cantidadRecoleccion, emisionFinal , estado) " +
                        "VALUES (@id, @idRuta ,@rutConductor ,@patente ,@material ,@fecha ,@duracionFinal ,@distanciaFinal ,@consumoEnergeticoFinal,@cantidadRecoleccion,@emisionFinal , @estado);";
                    comando.Parameters.AddWithValue("@id", recorrido.stIdRecorrido);
                    comando.Parameters.AddWithValue("@idRuta", recorrido.stIdRuta);
                    comando.Parameters.AddWithValue("@rutConductor", recorrido.stRutConductor);
                    comando.Parameters.AddWithValue("@patente", recorrido.stPatente);
                    comando.Parameters.AddWithValue("@material", recorrido.stMaterial);
                    comando.Parameters.AddWithValue("@fecha", recorrido.stFecha);
                    comando.Parameters.AddWithValue("@duracionFinal", recorrido.inDuracionFinal);
                    comando.Parameters.AddWithValue("@distanciaFinal", recorrido.doDistanciaFinal);
                    comando.Parameters.AddWithValue("@cantidadRecoleccion", recorrido.inCantidadRecoleccion);
                    comando.Parameters.AddWithValue("@consumoEnergeticoFinal", recorrido.doConsumoFinal);
                    comando.Parameters.AddWithValue("@emisionFinal", recorrido.inEmisionFinal);
                    comando.Parameters.AddWithValue("@estado", recorrido.inEstado);
                    inResultado = comando.ExecuteNonQuery();
                }
                if (crud == 1) { }//modificar
                if (crud == 2) { }//eliminar
            }
            catch (Exception e)
            {
                inResultado = -1;
                throw (e);
            }
            finally
            {
                conexion.Close();
            }

            return inResultado;
        }
        public List<String> recuperarCodigos(int op)
        {
            String codigo = "";
            if (op == 0) { codigo = "vt00"; }//vehiculo tipo
            if (op == 1) { codigo = "vc00"; }//vehiculo combustible
            if (op == 2) { codigo = "rm00"; }//ruta material
            List<String> listado = new List<String>();
            SQLiteConnection conexion = con.CrearConexion();
            conexion.Open();
            SQLiteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT descripcion FROM codigo WHERE cod = @cod";
            comando.Parameters.AddWithValue("@cod", codigo);
            SQLiteDataReader dtRead = comando.ExecuteReader();                         
            while (dtRead.Read())
            {
               listado.Add(dtRead.GetString(0));                   
            }
            return listado;
        }

        public List<Recorrido> recuperarRecorridoPor(String stfechas,String stCondicion = null ) {
            List<Recorrido> listado = new List<Recorrido>();
            Recorrido recorrido;
            string stCmd = "SELECT ruta.id,conductor.rut,nombre,vehiculo.patente,capacidad,cantidadRecoleccion,material,distanciaFinal,duracionFinal,emisionFinal ,recorrido.fecha FROM recorrido " +
                "INNER JOIN conductor ON  recorrido.rutConductor == conductor.rut " +
                "INNER JOIN vehiculo ON recorrido.patente == vehiculo.patente " +
                "INNER JOIN ruta ON recorrido.idRuta == ruta.id " + stfechas;
            SQLiteConnection conexion = con.CrearConexion();            
            conexion.Open();            
            SQLiteCommand comando = conexion.CreateCommand();
            if (stCondicion != null) {
                stCmd = stCmd + stCondicion;
            }
            comando.CommandText = stCmd;
            SQLiteDataReader dtRead = comando.ExecuteReader();
            while (dtRead.Read())            
            {
                recorrido = new Recorrido(dtRead.GetString(0), dtRead.GetString(1), dtRead.GetString(2), dtRead.GetString(3),dtRead.GetInt32(4),dtRead.GetInt32(5),dtRead.GetString(6),dtRead.GetDouble(7),dtRead.GetInt32(8),dtRead.GetDouble(9),dtRead.GetString(10));
                listado.Add(recorrido);
            }
            return listado;
        }
        public List<object> recuperarDatos(string stTabla,string stCondicion = null) {
            List<object> listadoObj = new List<object>();
            SQLiteConnection conexion = con.CrearConexion();
            conexion.Open();
            SQLiteCommand comando = conexion.CreateCommand();
            if (stCondicion != null){//Exclusivo para recuperar Marcadores asociados a una ruta
                comando.CommandText = "SELECT * FROM " + stTabla + " WHERE idRuta = @idRuta;";
                comando.Parameters.AddWithValue("@idRuta", stCondicion);
            }
            else            {
                comando.CommandText = "SELECT * FROM " + stTabla;
            }
            SQLiteDataReader dtRead = comando.ExecuteReader();
            if (stTabla== "conductor") 
            {
                Conductor conductor;
                while (dtRead.Read())
                {
                    conductor = new Conductor(dtRead.GetString(0), dtRead.GetString(1),dtRead.GetString(2));
                    listadoObj.Add(conductor);
                }

            }
            if (stTabla == "vehiculo")
            {
                Vehiculo vehiculo;
                while (dtRead.Read())
                {//Vehiculo(string stPatente, int inPeso, string stTipo, string stTipoCombustible, double doConsumoEnergetico, int inEmision)
                    vehiculo = new Vehiculo(dtRead.GetString(0),dtRead.GetInt32(1),dtRead.GetString(2),dtRead.GetString(3), dtRead.GetDouble(4), dtRead.GetInt32(5));
                    listadoObj.Add(vehiculo);
                }
            }
            if (stTabla == "marcador")
            {//id INT NOT NULL, idRuta VARCHAR(10) NOT NULL, longitud DOUBLE, latitud DOUBLE, peso INT
                Marcador marcador;
                while (dtRead.Read())
                {
                    marcador = new Marcador(dtRead.GetInt32(0),dtRead.GetString(1),dtRead.GetDouble(2),dtRead.GetDouble(3),dtRead.GetInt32(4));
                    listadoObj.Add(marcador);
                }
            }
            if (stTabla == "ruta")
            {//id VARCHAR(10) NOT NULL PRIMARY KEY, descripcion VARCHAR(30), duracion INT,distancia DOUBLE,cantidadPuntos INT"
                Rutas ruta;
                while (dtRead.Read())
                {
                    ruta = new Rutas(dtRead.GetString(0),dtRead.GetString(1),dtRead.GetInt32(2),dtRead.GetDouble(3),dtRead.GetInt32(4));
                    listadoObj.Add(ruta);
                }
            }
            if (stTabla == "recorrido")
            {//id VARCHAR(10),idRuta VARCHAR(10),rutConductor VARCHAR(20),patente VARCHAR(8),material VARCHAR(30),fecha DATE, duracionFinal INT,distanciaFinal double,cantidadRecoleccion INT,consumoEnergeticoFinal DOUBLE,emisionFinal DOUBLE,estado INT,          
                Recorrido recorrido;                
                while (dtRead.Read())
                {
                    recorrido = new Recorrido(dtRead.GetString(0), dtRead.GetString(1), dtRead.GetString(2), dtRead.GetString(3), dtRead.GetString(4), dtRead.GetString(5), dtRead.GetInt32(6), dtRead.GetDouble(7), dtRead.GetDouble(8), dtRead.GetInt32(9), dtRead.GetInt32(10), dtRead.GetInt32(11));
                    listadoObj.Add(recorrido);
                }
            }
            return listadoObj;
        }

        public String recuperarUltimoRegistro(String stTabla) {
            String stResultado = "";
            SQLiteConnection conexion = con.CrearConexion();
            conexion.Open();
            SQLiteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM "+stTabla+" WHERE id=(SELECT max(id) FROM "+stTabla+")";
            SQLiteDataReader dtRead = comando.ExecuteReader();
            while (dtRead.Read())
            {
                stResultado = dtRead.GetString(0);
            }
            return stResultado;
        }
        public Usuario recuperarDatoUsuario(string stRut) {
            String stNombre = "", stCorreo = "";
            int inPermiso = 0;
            SQLiteConnection conexion = con.CrearConexion();
            conexion.Open();
            SQLiteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT nombre,correo,permiso FROM usuario WHERE rut = @rut;";
            comando.Parameters.AddWithValue("@rut", stRut);
            SQLiteDataReader dtRead = comando.ExecuteReader();      
            while (dtRead.Read())
            {            
                stNombre = dtRead.GetString(0);
                stCorreo = dtRead.GetString(1);
                inPermiso = dtRead.GetInt32(2);
            }
            Usuario usuario = new Usuario(stNombre, stCorreo, stRut,inPermiso);
            return usuario;
        }
        public string recuperarUsuario()
        {
            String stRut = "";
            SQLiteConnection conexion = con.CrearConexion();
            conexion.Open();
            SQLiteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT rut FROM usuarioTemp;";
            SQLiteDataReader dtRead = comando.ExecuteReader();
            while (dtRead.Read())
            {
                stRut = dtRead.GetString(0);
            }            
            return stRut;
        }
        public int crearSesion(string stRut) {
            int inResultado = 0;
            SQLiteConnection conexion = con.CrearConexion();
            SQLiteCommand comando = conexion.CreateCommand();
            conexion.Open();
            comando.CommandText = "INSERT INTO usuarioTemp (rut) VALUES (@rut);";
            comando.Parameters.AddWithValue("@rut", stRut);
            inResultado = comando.ExecuteNonQuery();
            return inResultado;
        }
        public int eliminarSesion()
        {
            int inResultado = 0;
            SQLiteConnection conexion = con.CrearConexion();
            conexion.Open();
            SQLiteCommand comando = conexion.CreateCommand();
            comando.CommandText = "DELETE FROM usuarioTemp;";
            inResultado = comando.ExecuteNonQuery();
            conexion.Close();               
            return inResultado;
        }
        /// <summary>
        /// Funcion <c>existeTabla</c> Busca coincidencias en la tabla escogida con <paramref name="op"/> de la bd 
        /// (Usuario 0|Conductor 1|Vehiculo 2|Login 3|Sesion 4|Ruta 5|Recorrido 6|Recorridos Usuario 7)
        /// </summary>
        /// <param name="op">Parametro op indica la tabla a consultar</param>
        /// <param name="parametro">Parametro tipo String obligatorio</param>
        /// <param name="parametro2">Parametro  tipo String opcional</param>
        /// <returns></returns>
        public bool existeTabla(int op,String parametro,String parametro2 = null) {
            bool blResultado = false;
            SQLiteConnection conexion = con.CrearConexion();
            conexion.Open();
            SQLiteCommand comando = conexion.CreateCommand();
            if (op == 0)//USUARIO
            {
                comando.CommandText = "SELECT COUNT(*) FROM usuario WHERE rut = @rut;";
                comando.Parameters.AddWithValue("@rut", parametro);
            }
            else if (op == 1)//CONDUCTOR
            {
                comando.CommandText = "SELECT COUNT(*) FROM conductor WHERE rut = @rut;";
                comando.Parameters.AddWithValue("@rut", parametro);
            }
            else if (op == 2)//VEHICULO
            {
                comando.CommandText = "SELECT COUNT(*) FROM vehiculo WHERE patente = @patente;";
                comando.Parameters.AddWithValue("@patente", parametro);
            }
            else if (op == 3)//Usuario Clave
            {
                comando.CommandText = "SELECT COUNT(*) FROM usuario WHERE rut = @rut AND clave = @clave;";
                comando.Parameters.AddWithValue("@rut", parametro);
                comando.Parameters.AddWithValue("@clave", parametro2);
            }
            else if (op == 4)//UsuarioActivo 
            {
                comando.CommandText = "SELECT COUNT(*) FROM usuarioTemp;";
            }
            else if (op == 5)//RUTA
            {
                comando.CommandText = "SELECT COUNT(*) FROM ruta WHERE idRuta = @idRuta;";
                comando.Parameters.AddWithValue("@idRuta", parametro);
            }
            else if (op == 6)//RECORRIDO
            {
                comando.CommandText = "SELECT COUNT(*) FROM recorrido WHERE id = @idRecorrido;";
                comando.Parameters.AddWithValue("@idRecorrido", parametro);
            }
            else if (op == 7)//usuario_recorrido
            {
                comando.CommandText = "SELECT COUNT(*) FROM usuario_recorrido WHERE rut = @rut AND idRecorrido = @idRecorrido;";
                comando.Parameters.AddWithValue("@rut", parametro);
                comando.Parameters.AddWithValue("@idRecorrido", parametro2);
            }
            if (op == 9)//USUARIOs Existen
            {
                comando.CommandText = "SELECT COUNT(*) FROM usuario;";
            }
            SQLiteDataReader dtRead = comando.ExecuteReader();
            
            while (dtRead.Read())
            {
                int inResul = dtRead.GetInt32(0);

                if (inResul > 0)
                {
                    blResultado = true;
                }
            }            
            dtRead.Close();
            conexion.Close();
            return blResultado;
        }

    }
}
