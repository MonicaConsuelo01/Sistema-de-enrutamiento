using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Reciclaje.Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reciclaje
{
    public partial class Mapa : Form
    {
        public static int Permiso;
        private Controlador C = new Controlador();
        private bool blFlag = true;
        public GMapMarker puntoInicio;
        public List<GMapMarker> puntosRuta = new List<GMapMarker>();
        public List<GMapMarker> puntosOrdenados = new List<GMapMarker>();
        //Marcadores
        public GMapOverlay overlayMarcadores = new GMapOverlay("Marcador");
        //Rutas
        public GMapOverlay overlayRutas = new GMapOverlay("Rutas");
        public GMapControl App;
        Rutinas R;
        double distancia = 0;
        int tiempo = 0;
        public Mapa()
        {
            InitializeComponent();
            R = new Rutinas();
            NuevoNombreRuta();
            // App Connection
            this.App = gMapControl1;
            this.App.MapProvider = GMapProviders.GoogleMap;
            GMapProviders.GoogleMap.ApiKey = Llave.KEY;
            this.App.Overlays.Add(overlayMarcadores);
            this.App.Overlays.Add(overlayRutas);
        }

        /// <summary>
        /// Se cargan los datos del control de GMAP(Mapa)
        /// </summary>
        private void gMapControl1_Load(object sender, EventArgs e)
        {
            double doLatInicial = -29.9604961;//Coquimbo
            double doLngInicial = -71.3343523;//Coquimbo
            this.App.DragButton = MouseButtons.Left;
            this.App.CanDragMap = true;
            this.App.Position = new PointLatLng(doLatInicial, doLngInicial);
            this.App.MinZoom = 0;
            this.App.MaxZoom = 24;
            this.App.Zoom = 14;
            this.App.AutoScroll = true;
        }

        public void agregarMarcador(PointLatLng punto, string text)
        {
            GMarkerGoogle gMarker = null;
            var Color = GMarkerGoogleType.black_small;
            gMarker = new GMarkerGoogle(punto, Color);
            puntosRuta.Add(gMarker);
            gMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            gMarker.ToolTipText = text;
            overlayMarcadores.Markers.Add(gMarker);
        }

        public void borrarMarcador(GMapMarker gMarker)
        {
            String text = gMarker.ToolTipText;
            if (text.Contains("Inicio"))
            {
                puntoInicio = null;
            }
            else
            {
                puntosRuta.Remove(gMarker);
            }
            blFlag = true;
            overlayMarcadores.Markers.Remove(gMarker);
        }

        private void NuevoNombreRuta() {
            String stNuevaRuta = C.recuperarIdRuta();
            DateTime now = DateTime.Now;
            String anno = now.Year.ToString();
            anno = anno.Substring(2, 2);
            String mes = now.Month.ToString();
            if (stNuevaRuta == "") {
                tbNombreR.Text = anno + mes + "000001";
            }
            else
            {
                if (R.esNumero(stNuevaRuta))
                {
                    if (stNuevaRuta.Substring(2, 2) == mes)
                    {
                        double numero = double.Parse(stNuevaRuta);
                        numero = numero + 1;
                        tbNombreR.Text = numero.ToString();
                    }
                    else
                    {
                        tbNombreR.Text = anno + mes + "000001";
                    }
                }
            }

        }

        private void OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                borrarMarcador(item);
            }
        }

        private void gMapControl1_DoubleClick(object sender, MouseEventArgs e)
        {
            PointLatLng p = App.FromLocalToLatLng(e.X, e.Y);
            int numero = puntosRuta.Count;
            overlayRutas.Clear();
            gMapControl1.Refresh();
            if (e.Button == MouseButtons.Left)
            {
                if (puntoInicio == null)
                {
                    GMarkerGoogle gMarker = new GMarkerGoogle(p, GMarkerGoogleType.arrow);
                    gMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    gMarker.ToolTipText = "Inicio Ruta";
                    puntoInicio = gMarker;
                    overlayMarcadores.Markers.Add(gMarker);
                }
                else
                {
                    agregarMarcador(p, numero + "");
                }
                blFlag = false;
            }
        }
        private void btCrearRuta_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            simularRuta();
            Cursor = Cursors.Default;
        }
        public void simularRuta(){
            if (puntoInicio != null && puntosRuta.Count > 0)
            {
                blFlag = false;
                String stNombre = tbNombreR.Text;
                Pen Lapiz;
                Lapiz = new Pen(Color.Black, 3);
                Lapiz.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                Lapiz.Alignment = System.Drawing.Drawing2D.PenAlignment.Right;
                crearRutas(puntosRuta, stNombre, Lapiz);
            }
        }

        public void crearRutas(List<GMapMarker> puntos,String nombre,Pen Color) {
            Tuple<List<GMapRoute>, int, double, List<GMapMarker>> tuplaResultados;
            overlayRutas.Clear();
            if (checkVuelta.Checked) {
                tuplaResultados = R.ordenarPuntos(nombre, puntos, puntoInicio,puntoInicio);
            }
            else
            {
                tuplaResultados = R.ordenarPuntos(nombre,puntos, puntoInicio);
            }
            
            foreach (GMapRoute ruta in tuplaResultados.Item1) {
                ruta.Stroke = Color;                              
                MapRoute R = (MapRoute)ruta;
                overlayRutas.Routes.Add(ruta);
            }
            tiempo = tuplaResultados.Item2;
            tbTiempo.Text = tuplaResultados.Item2 + " Minutos";
            distancia = tuplaResultados.Item3;
            tbDistancia.Text = tuplaResultados.Item3 + " Kilometros";
            puntosOrdenados = tuplaResultados.Item4;
            ordenarGMarkers(puntosOrdenados);
        }
        private void ordenarGMarkers(List<GMapMarker> puntos) {
            overlayMarcadores.Clear();            
            int inContador = 1;
            puntoInicio = puntos.FirstOrDefault();
            var puntoFin = puntos.LastOrDefault();
            puntosRuta = puntos;
            puntos.Remove(puntoInicio);            
            puntos.Remove(puntoFin);            
            puntoInicio.ToolTipText = "Punto Inicio";
            puntoFin.ToolTipText = "Punto Fin";
            
            overlayMarcadores.Markers.Add(puntoInicio);
            foreach (var punto in puntos) {
                punto.ToolTipText = inContador + "";
                overlayMarcadores.Markers.Add(punto);
                inContador += 1;
            }
            overlayMarcadores.Markers.Add(puntoFin);
        }
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar() {
            puntosRuta.Clear();
            puntosOrdenados.Clear();
            puntoInicio = null;
            overlayMarcadores.Clear();
            overlayRutas.Clear();
            gMapControl1.Refresh();
            tbDistancia.Text = "";
            tbTiempo.Text = "";
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (Permiso > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Seguro desea guardar la ruta?", "Guardar Ruta", MessageBoxButtons.YesNo);
                if (validar())
                {
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (puntosOrdenados.Count == 0) { btCrearRuta.PerformClick(); }
                        if (blFlag) { btCrearRuta.PerformClick(); }
                        guardar();
                    }
                }
            }
            else { MessageBox.Show("Permisos Insuficientes para la operacion"); 
            }
           
            
        }
        private void guardar() {
            Rutas ruta;
            List<Marcador> marcadores = new List<Marcador>();
            Marcador marcador;
            var rand = new Random();
            if (checkVuelta.Checked) {
                ruta = new Rutas(tbNombreR.Text,"1", tiempo, distancia, puntosOrdenados.Count);
            }
            else
            {
                ruta = new Rutas(tbNombreR.Text, "0", tiempo, distancia, puntosOrdenados.Count);
            }            
            int cont = 1;
            int peso = rand.Next(2, 15) * 10;//Peso aleatorizado entre 20 a 150 kg
            PointLatLng latLng = puntoInicio.Position;
            marcador = new Marcador(0, tbNombreR.Text, latLng.Lat, latLng.Lng, peso);
            marcadores.Add(marcador);
            foreach (var punto in puntosOrdenados) {
                peso = rand.Next(2, 15)*10;//Peso aleatorizado entre 20 a 150 kg
                latLng = punto.Position;                
                marcador = new Marcador(cont, tbNombreR.Text, latLng.Lat, latLng.Lng, peso);
                marcadores.Add(marcador);
                cont += 1;
            }
            if (checkVuelta.Checked)
            {
                peso = rand.Next(2, 15) * 10;//Peso aleatorizado entre 20 a 150 kg
                latLng = puntoInicio.Position;
                marcador = new Marcador(cont, tbNombreR.Text, latLng.Lat, latLng.Lng, peso);
                marcadores.Add(marcador);
            }
            if (C.crearRuta(ruta, marcadores) == 1)
            {
                MessageBox.Show("La ruta "+ tbNombreR.Text + " se ingreso correctamente");
            }
            else 
            {
                MessageBox.Show("PROBLEMAS AL INGRESAR LA RUTA");
            }
            NuevoNombreRuta();

        }

        private void recuperar() { 
        }

        private bool validar() {
            
            bool blResultado = true;
            if (puntoInicio == null) {
                MessageBox.Show("Ingrese al menos dos puntos al mapa");
                return false;
            }
            if (puntosRuta.Count == 0) {
                MessageBox.Show("Ingrese al menos dos puntos al mapa");
                return false;
            }
            if (tbNombreR.Text == "") {
                MessageBox.Show("Debe tener un nombre de ruta");
                return false;
            }
            return blResultado;
        }

        private void btAsignar_Click(object sender, EventArgs e) {
            
        }
        //REFERENCIAS SIN USO
        private void label3_Click(object sender, EventArgs e) { }
        private void tbLng_TextChanged(object sender, EventArgs e) { }
        
        private void gMapControl1_KeyDown(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e){ }

        private void label4_Click(object sender, EventArgs e) { }

        private void gbEscoger_Enter(object sender, EventArgs e) { }

        private void OnRouteEnter(GMapRoute item) { }

        private void tbLat_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)     {        }
        private void MouseDown(object sender, MouseEventArgs e) { }
    }
}
