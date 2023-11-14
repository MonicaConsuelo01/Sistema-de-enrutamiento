using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclaje
{
    class Vehiculo
    {
        public String stPatente;
        public int inPeso;
        public String stTipo;
        public String stCombustible;
        public double doConsumoEnergetico;
        public int inEmision;
        public Vehiculo() { }
        public Vehiculo(String stPatente)
        {
            this.stPatente = stPatente;
        }
        public Vehiculo(String stPatente, int inPeso, String stTipo, String stTipoCombustible, double doConsumoEnergetico, int inEmision)
        {
            this.stPatente = stPatente;
            this.inPeso = inPeso;
            this.stTipo = stTipo;
            this.stCombustible = stTipoCombustible;
            this.doConsumoEnergetico = doConsumoEnergetico;
            this.inEmision = inEmision;
        }

        
    }
}
