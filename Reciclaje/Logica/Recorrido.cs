using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclaje.Logica
{   

    class Recorrido
    {       
        public string stIdRecorrido, stIdRuta, stRutConductor, stPatente, stMaterial, stFecha,stNombre;
        public int inDuracionFinal,inEstado,inCantidadRecoleccion,inCapacidad;
        public double doDistanciaFinal, doConsumoFinal, inEmisionFinal;

        public Recorrido() { }        
        public Recorrido(string stIdRecorrido, string stIdRuta, string stRutConductor, string stPatente, string stMaterial, string stFecha, int inDuracionFinal, double doDistanciaFinal, double doConsumoFinal, double inEmisionFinal,int inCantidadRecoleccion, int inEstado)
        {
            this.stIdRecorrido = stIdRecorrido;
            this.stIdRuta = stIdRuta;
            this.stRutConductor = stRutConductor;
            this.stPatente = stPatente;
            this.stMaterial = stMaterial;
            this.stFecha = stFecha;
            this.inDuracionFinal = inDuracionFinal;
            this.doDistanciaFinal = doDistanciaFinal;
            this.doConsumoFinal = doConsumoFinal;
            this.inEmisionFinal = inEmisionFinal;
            this.inCantidadRecoleccion = inCantidadRecoleccion;
            this.inEstado = inEstado;
        }
        public Recorrido(string stIdRuta, string stRutConductor, string stNombre, string stPatente, int inCapacidad, int inCantidadRecoleccion, string stMaterial, double doDistanciaFinal, int inDuracionFinal, double inEmisionFinal, string stFecha)
        {
            this.stIdRuta = stIdRuta;
            this.stRutConductor = stRutConductor;
            this.stNombre = stNombre;
            this.stPatente = stPatente;
            this.inCapacidad = inCapacidad;
            this.inCantidadRecoleccion = inCantidadRecoleccion;
            this.stMaterial = stMaterial;
            this.doDistanciaFinal = doDistanciaFinal;
            this.inDuracionFinal = inDuracionFinal;
            this.inEmisionFinal = inEmisionFinal;
            this.stFecha = stFecha;
        }
    }
}
