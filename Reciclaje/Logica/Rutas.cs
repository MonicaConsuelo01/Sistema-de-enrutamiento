using GMap.NET;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclaje.Logica
{
    class Rutas
    {
        public String stIdRuta;
        public String stDescripcion;
        public int inDuracion;
        public double doDistancia;
        public List<Marcador> listMarcador;
        public int inCantidadPuntos;
        public Rutas() { }

        public Rutas(string stIdRuta, string stDescripcion, int inDuracion, double doDistancia, List<Marcador> listMarcador,int inCantidadPuntos)
        {
            this.stIdRuta = stIdRuta;
            this.stDescripcion = stDescripcion;
            this.inDuracion = inDuracion;
            this.doDistancia = doDistancia;
            this.listMarcador = listMarcador;
            this.inCantidadPuntos = inCantidadPuntos;
        }

        public Rutas(string stIdRuta, string stDescripcion, int inDuracion, double doDistancia, int inCantidadPuntos) 
        {
            this.stIdRuta = stIdRuta;
            this.stDescripcion = stDescripcion;
            this.inDuracion = inDuracion;
            this.doDistancia = doDistancia;
            this.inCantidadPuntos = inCantidadPuntos;
        }

        public Rutas(string stIdRuta, string stDescripcion, int inDuracion, double doDistancia)
        {
            this.stIdRuta = stIdRuta;
            this.stDescripcion = stDescripcion;
            this.inDuracion = inDuracion;
            this.doDistancia = doDistancia;
        }
    }
}
