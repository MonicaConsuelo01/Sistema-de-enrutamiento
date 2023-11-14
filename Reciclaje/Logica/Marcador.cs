using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclaje.Logica
{
    public class Marcador
    {
        public int inId;
        public String stIdRuta;
        public Double doLatitud;
        public Double doLongitud;
        public int inPeso;

        public Marcador() { }

        public Marcador(int inId, string stIdRuta, double doLatitud, double doLongitud, int inPeso)
        {
            this.inId = inId;
            this.stIdRuta = stIdRuta;
            this.doLatitud = doLatitud;
            this.doLongitud = doLongitud;
            this.inPeso = inPeso;
        }
    }
}
