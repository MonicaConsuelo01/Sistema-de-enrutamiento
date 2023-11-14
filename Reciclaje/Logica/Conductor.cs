using System;

namespace Reciclaje.Logica
{
    class Conductor
    {
        public string stRut;
        public string stNombre;
        public string stCelular;
        public Conductor() { }

        public Conductor(string stRut, string stNombre, string stCelular)
        {
            this.stRut = stRut;
            this.stNombre = stNombre;
            this.stCelular = stCelular;
        }

        public Conductor(string stRut)
        {
            this.stRut = stRut;
        }
        public String getRut()
        {
            return this.stRut;
        }
        public String getNombre()
        {
            return this.stNombre;
        }
        public String getCelular()
        {
            return this.stCelular;
        }

    }
}
