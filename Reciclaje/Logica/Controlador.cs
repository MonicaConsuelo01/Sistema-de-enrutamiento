using System;
using System.Collections.Generic;
using System.Text;
using Reciclaje.Conexion;
namespace Reciclaje.Logica
{
    class Controlador
    {
        private Gestor G = new Gestor();
        public Controlador() { }
        //GESTIONAR SESIONES LOCALES
        public int crearSesion(string stRut)
        {
            return G.crearSesion(stRut);
        }
        public void eliminarSesion()
        {
            G.eliminarSesion();
        }
        public bool sesionExiste()
        {
            bool blResultado = false;
            blResultado = G.existeTabla(4, "");
            return blResultado;
        }
        //CRUD USUARIO
        public bool existenUsuarios()
        {
            return G.existeTabla(9, "");
        }
        public int crearUsuario(Usuario usuario) {            
            return G.crudUsuario(0, usuario); 
        }
        public string usuarioAlmacenado()
        {
            return G.recuperarUsuario();
        }
        public int verificarUsuario(String rut, String clave)
        {
            if (G.existeTabla(3, rut, clave))
            {
                return 1;
            }
            return 0;
        }
        public Usuario recuperarUsuario(String stRut)
        {
            return G.recuperarDatoUsuario(stRut);
        }
        
        //CRUD CONDUCTOR
        public int crearConductor(Conductor conductor) {
            return G.crudConductor(0,conductor);
        }
        public int modificarConductor(Conductor conductor)
        {
            return G.crudConductor(1, conductor);
        }
        public int eliminarConductor(Conductor conductor)
        {
            return G.crudConductor(2, conductor);
        }
        public List<object> recuperarConductor()
        {
            return G.recuperarDatos("conductor");
        }
        //CRUD VEHICULO
        public List<object> recuperarVehiculo()
        {
            return G.recuperarDatos("vehiculo");
        }
        public int crearVehiculo(Vehiculo vehiculo) {
            return G.crudVehiculos(0,vehiculo);
        }
        public int modificarVehiculo(Vehiculo vehiculo){
            return G.crudVehiculos(1, vehiculo);
        }
        public int eliminarVehiculo(Vehiculo vehiculo){
            return G.crudVehiculos(2, vehiculo);
        }
        public int existeVehiculo(Vehiculo vehiculo) {
            if (G.existeTabla(2,vehiculo.stPatente)) { return 1; }
            else { return 0; }
        }
        //Rutas        
        public List<object> recuperarRuta() {
            return G.recuperarDatos("ruta");
        }
        public String recuperarIdRuta() {
            return G.recuperarUltimoRegistro("ruta");
        }        
        public int crearRuta(Rutas ruta, List<Marcador> marcadores) {            
            return G.crearRuta(ruta,marcadores);
        }
        public int modificarRuta(Rutas ruta, List<Marcador> marcadores) {
            return G.modificarRuta(ruta,marcadores);
        }
        public int eliminarRuta(Rutas ruta) {
            return G.eliminarRuta(ruta);
        }
        //Marcadores
        public List<object> recuperarMarcadoresRuta(String idRuta) {
            return G.recuperarDatos("marcador",idRuta);
        }

        //Recorrido
        public int crearRecorrido(Recorrido recorrido) {
            return G.crudRecorrido(0,recorrido);
        }
        public String recuperarIdRecorrido()
        {
            return G.recuperarUltimoRegistro("recorrido");
        }
        public List<Recorrido> recuperarRecorrido(String stFecha, String stCondicion = null) {
            return G.recuperarRecorridoPor(stFecha,stCondicion);
        }
        //
        public List<String> recuperarVehiculoTipo() {
            return G.recuperarCodigos(0);
        }
        public List<String> recuperarVehiculoCombustible()
        {
            return G.recuperarCodigos(1);
        }
        public List<String> recuperarListaMaterial()
        {
            return G.recuperarCodigos(2);
        }
        public int crearBD() {
            G.crearBD();
            return 0;
        }
    }
}
