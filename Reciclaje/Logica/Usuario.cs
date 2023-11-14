using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclaje.Logica
{
    public class Usuario
    {
        public String Nombre, Correo, Rut, Clave;
        public int Permiso;
        public Usuario() { }

        public Usuario(string nombreCompleto, string correo, string rut, string clave, int permiso)
        {
            Nombre = nombreCompleto;
            Correo = correo;
            Rut = rut;
            Clave = clave;
            Permiso = permiso;
        }

        public Usuario(string nombre, string correo, string rut, int permiso)
        {
            Nombre = nombre;
            Correo = correo;
            Rut = rut;
            Permiso = permiso;
        }
        public Usuario(string nombre, string correo, string rut)
        {
            Nombre = nombre;
            Correo = correo;
            Rut = rut;
        }
    }
}
