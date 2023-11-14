using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using GMap.NET.WindowsForms.Markers;

namespace Reciclaje.Logica
{
    public class Rutinas
    {
        public Rutinas() {}        
        public Tuple<List<GMapRoute>, int, double, List<GMapMarker>> ordenarPuntos(String nombre,List<GMapMarker> ListaPuntos, GMapMarker marcadorInicio,GMapMarker marcadorFin = null) {
            Tuple<List<GMapRoute>, int, double, List<GMapMarker>> resultado; 
            List<GMapRoute> ListaRuta = new List<GMapRoute>();
            List<GMapMarker> ListaPuntosOrdenados = new List<GMapMarker>();            
            int inMinutos = 0; 
            int inContador = 0;
            int inMinutoTotal = 0;
            double doDistancia = 0;
            double doDistanciaTotal = 0;
            GMapRoute mrRuta = null;
            GMapMarker gmMarcador = null;
            Tuple<int, MapRoute,double> tupla;
            ListaPuntosOrdenados.Add(marcadorInicio);
            // IMPORTANTE Subir los minutos a 1 en caso de ser 0 / HECHO
            while (ListaPuntos.Count != 0) { 
                foreach (GMapMarker punto in ListaPuntos) {
                    tupla = minutosEntreMarcadores(ListaPuntosOrdenados[inContador],punto);
                    if (inMinutos == 0)//primera iteracion
                    {
                        inMinutos = tupla.Item1;
                        mrRuta = new GMapRoute(tupla.Item2.Points,nombre);
                        doDistancia = tupla.Item3;
                        gmMarcador = punto;
                    }
                    else if (inMinutos > tupla.Item1)
                    {                        
                        inMinutos = tupla.Item1;
                        mrRuta = new GMapRoute(tupla.Item2.Points, nombre);
                        doDistancia = tupla.Item3;
                        gmMarcador = punto;
                    }
                    else if (inMinutos == tupla.Item1) {
                        double doDistancia2 = tupla.Item3;
                        if (doDistancia>doDistancia2) {
                            inMinutos = tupla.Item1;
                            mrRuta = new GMapRoute(tupla.Item2.Points, nombre);
                            doDistancia = doDistancia2;
                            gmMarcador = punto;
                        }
                    }                   
                }                               
                ListaPuntosOrdenados.Add(gmMarcador);
                ListaPuntos.Remove(gmMarcador);
                if (inMinutos == 0)
                {
                    inMinutoTotal = 1 + inMinutoTotal;
                }
                else {
                    inMinutoTotal = inMinutos + inMinutoTotal;
                }
                doDistanciaTotal = doDistanciaTotal + doDistancia;
                inMinutos = 0;
                ListaRuta.Add(mrRuta);
                inContador = inContador + 1;
            }
            ListaPuntosOrdenados.Add(ListaPuntosOrdenados.LastOrDefault());
            if (marcadorFin != null)
            {
                tupla = minutosEntreMarcadores(ListaPuntosOrdenados.LastOrDefault(), marcadorFin);                
                inMinutos = tupla.Item1;
                mrRuta = new GMapRoute(tupla.Item2.Points, nombre);
                doDistanciaTotal = doDistanciaTotal + tupla.Item3;
                if (inMinutos == 0)
                {
                    inMinutoTotal = 1 + inMinutoTotal;
                }
                else
                {
                    inMinutoTotal = inMinutos + inMinutoTotal;
                }
                ListaRuta.Add(mrRuta);
            }
            resultado = Tuple.Create(ListaRuta,inMinutoTotal,doDistanciaTotal, ListaPuntosOrdenados);
            return resultado;
        }
        /// <summary>
        /// Retorna la Duracion, la ruta y la distancia entre dos marcadores de mapa
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        private Tuple<int, MapRoute,double> minutosEntreMarcadores(GMapMarker A, GMapMarker B) 
        {
            Tuple<int, MapRoute, double> minutosRuta;
            PointLatLng P1 =  A.Position;
            PointLatLng P2 = B.Position;            
            MapRoute ruta = GoogleMapProvider.Instance.GetRoute(P1, P2, false, false, 15);
            String stDuracion = ruta.Duration;
            double doDistancia = ruta.Distance;
            int inDuracion = duracionMinutosTotal(stDuracion);                                   
            minutosRuta = Tuple.Create(inDuracion, ruta, doDistancia);
            return minutosRuta;
        }
        public Tuple<int, double> TiempoDistanciaIdaVuelta(PointLatLng P1, PointLatLng P2)
        {
            Tuple<int, double> minutosRuta;
            GoogleMapProvider.Instance.ApiKey  = Llave.KEY;
            MapRoute ida = GoogleMapProvider.Instance.GetRoute(P1, P2, false, false, 15);
            String stDuracionIda = ida.Duration;
            double doDistanciaIda = ida.Distance;
            MapRoute vuelta = GoogleMapProvider.Instance.GetRoute(P2, P1, false, false, 13);
            String stDuracionVuelta = vuelta.Duration;
            double doDistanciaVuelta = vuelta.Distance;                 
            int inDuracionIda = duracionMinutosTotal(stDuracionIda);
            int inDuracionVuelta = duracionMinutosTotal(stDuracionVuelta);
            minutosRuta = Tuple.Create(inDuracionIda+ inDuracionVuelta, doDistanciaIda+ doDistanciaVuelta);
            return minutosRuta;
        }
        /// <summary>
        /// Recibe una cadena de tiempo y devuelve su duracion en minutos (formato cadena "00 hour 00 min")
        /// </summary>
        /// <param name="stDuracion"></param>
        /// <returns></returns>
        public int duracionMinutosTotal(String stDuracion) {
            int inDuracion = 0;
            String[] array;
            if (stDuracion.Contains("min") && stDuracion.Contains("hour"))
            {
                stDuracion = Regex.Replace(stDuracion, "hour|hours", ",");
                stDuracion = Regex.Replace(stDuracion, "[a-z]", "");
                stDuracion = Regex.Replace(stDuracion, " ", "");
                stDuracion = stDuracion.Trim();
                array = stDuracion.Split(",");
                inDuracion = (int.Parse(array[0]) * 60) + int.Parse(array[1]);
            }
            else if (stDuracion.Contains("hour"))
            {
                stDuracion = Regex.Replace(stDuracion, "hour|hours", "");
                stDuracion = Regex.Replace(stDuracion, "[a-z]", "");
                stDuracion = Regex.Replace(stDuracion, " ", "");
                stDuracion = stDuracion.Trim();
                inDuracion = (int.Parse(stDuracion) * 60);
            }
            else 
            {
                stDuracion = Regex.Replace(stDuracion, "[a-z]", "");
                stDuracion = stDuracion.Trim();
                inDuracion = int.Parse(stDuracion);
            }
            return inDuracion;
        }
        /// <summary>
        /// Valida que el valor ingresado sea un Numero entero positivo
        /// </summary>
        /// <param name="stCadena"></param>
        /// <returns></returns>
        public bool esNumero(String stCadena) {
            bool blRespuesta = false ;
            stCadena = stCadena.Trim();
            if (stCadena.Length == 0) { return false; }            
            if (Regex.IsMatch(stCadena, "^[0-9]*$")) { blRespuesta = true; }
            return blRespuesta;
        }
        /// <summary>
        /// Valida que el valor ingresado sea un Numero con o sin Decimales positivo
        /// </summary>
        /// <param name="stCadena"></param>
        /// <returns></returns>
        public bool esDecimal(String stCadena)
        {
            bool blRespuesta = false;
            stCadena = stCadena.Trim();
            if (stCadena.Length == 0) { return false; }
            if (Regex.IsMatch(stCadena, "^[0-9]+(.{1}[0-9]*)?$")) { blRespuesta = true; }
            return blRespuesta;
        }
        /// <summary>
        /// Valida el formato y si el rut ingresado es valido
        /// </summary>
        /// <param name="stCadena"></param>
        /// <returns></returns>
        public bool esRut(String stCadena) 
        {            
            stCadena = stCadena.Trim();
            if (stCadena.Length == 0) { return false; }
            String pattern = "^[1-9]{1}[0-9]+-[0-9kK]{1}$";
            if (Regex.IsMatch(stCadena, pattern) == false) return false;            
            String[] stringRut = stCadena.Split("-");            
            return stringRut[1].ToLower().Equals(digitoValidador(stringRut[0]));
        }
        /// <summary>
        /// Valida el formato de la cadena ingresada (aaaa11)
        /// </summary>
        /// <param name="stCadena"></param>
        /// <returns></returns>
        public bool esPatente(String stCadena) {
            String patron = "^[a-zA-Z]{4}[0-9]{2}$";
            return Regex.IsMatch(stCadena, patron);
        }
        private static String digitoValidador(String rut)
        {
            double M = 0, S = 1, T = double.Parse(rut);
            for (; T != 0; T = Math.Floor(T / 10))
            {
                S = (S + T % 10 * (9 - M++ % 6)) % 11;
            }
            return (S > 0) ? (S - 1)+"" : "k";
        }
        /// <summary>
        /// Valida el formato de la cadena ingresada (aaa@bbb.cc)
        /// </summary>
        /// <param name="stCadena"></param>
        /// <returns></returns>
        public bool esCorreo(String stCadena) {
            String patron = "^([0-9a-zA-Z]+[-._+&])*[0-9a-zA-Z]+@([-0-9a-zA-Z]+[.])+[a-zA-Z]{2,6}$";
            return Regex.IsMatch(stCadena, patron);
        }
        public string formatearRut(string rut)
        {
            int cont = 0;
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }
        public Tuple<double,double> calcularHuellaCarbono(double distancia,double consumoEnergetico ,double emision) {
            Tuple<double, double> resultado;
            double doConsumoTotal = 0;
            double doEmisionTotal = 0;
            doConsumoTotal = distancia * consumoEnergetico;//km * km/lt
            doEmisionTotal = doConsumoTotal * emision;// km/lt * gr/km
            resultado = Tuple.Create(doConsumoTotal, doEmisionTotal);
            return resultado;
        }
        /// <summary>
        /// Retorna el Tiempo y la distancia total de una ruta existente tomando en cuenta la capacidad del vehiculo y los kg de los marcadores
        /// </summary>
        /// <param name="marcadores"></param>
        /// <param name="tiempo"></param>
        /// <param name="distancia"></param>
        /// <param name="carga"></param>
        /// <param name="cantidadPuntos"></param>
        /// <returns></returns>
        public Tuple<int, double> calcularDuracionDistanciaTotalAproximado(List<Marcador>marcadores, int tiempo,double distancia,int carga,int cantidadPuntos) {
            int inTiempoTotal = 0;
            double doDistanciaTotal = 0;
            int inCapacidadActual = carga;
            int inContador = 0;
            Tuple<int,double> tuplaResultado;
            Tuple<int, double> tuplaRes;
            PointLatLng latLongActual;
            Marcador Fin = marcadores[marcadores.Count-1];
            PointLatLng latLongFinal = new PointLatLng(Fin.doLongitud, Fin.doLatitud);
            foreach (Marcador marcador in marcadores) 
            {
                latLongActual = new PointLatLng(marcador.doLongitud, marcador.doLatitud);
                if ((inCapacidadActual - marcador.inPeso) > 0)
                {
                    inCapacidadActual = inCapacidadActual - marcador.inPeso;
                }
                else 
                {                        
                    if (latLongActual == latLongFinal){}
                    else {
                        tuplaRes = TiempoDistanciaIdaVuelta(latLongActual , latLongFinal);
                        inTiempoTotal = inTiempoTotal + tuplaRes.Item1;
                        doDistanciaTotal = doDistanciaTotal + tuplaRes.Item2;
                    }
                    inCapacidadActual = carga;
                    cantidadPuntos = cantidadPuntos + 2;                    
                }
                inContador = inContador + 1;
            }
            inTiempoTotal = inTiempoTotal + (cantidadPuntos * 3) + tiempo;
            doDistanciaTotal = doDistanciaTotal + distancia;
            tuplaResultado = Tuple.Create(inTiempoTotal,doDistanciaTotal);
            return tuplaResultado;
        }


    }
}
