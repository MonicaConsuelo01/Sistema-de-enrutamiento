using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Reciclaje.Logica;
using Reciclaje.Interfaz;
using System.Linq;

namespace Reciclaje
{
    public partial class fmCrearRuta : Form
    {
        public static int Permiso;
        private Recorrido recorrido;
        private bool blRecorrido = false;
        private Controlador C = new Controlador();
        private Rutinas R = new Rutinas();
        private List<Conductor> listaConductor = new List<Conductor>();
        private List<Vehiculo> listaVehiculo = new List<Vehiculo>();
        private Vehiculo vehiculoActual;
        private List<Rutas> listaRutas = new List<Rutas>();
        private Rutas rutaActual;
        public fmCrearRuta()
        {
            InitializeComponent();
            cargarCombox();
            cargarComboConductor();
            cargarComboVehiculo();
            cargarComboRuta();
            cbRutas.SelectedIndex = 0;
        }
        private void cargarComboConductor()
        {
            var listado = C.recuperarConductor();
            cbConductor.Items.Clear();
            listaConductor.Clear();
            if (listado.Count > 0)
            {
                foreach (Conductor conductor in listado)
                {
                    cbConductor.Items.Add(conductor.stRut);
                    listaConductor.Add(conductor);
                }
            }
        }
        private void cargarComboRuta() {
            var listado = C.recuperarRuta();
            cbRutas.Items.Clear();
            if (listado.Count > 0) {
                foreach (Rutas rutas in listado) {
                    cbRutas.Items.Add(rutas.stIdRuta);
                    listaRutas.Add(rutas);
                }
            }
        }
        private void cargarComboVehiculo() {
            var listado = C.recuperarVehiculo();
            cbVehiculos.Items.Clear();
            listaVehiculo.Clear();
            if (listado.Count > 0)
            {
                foreach (Vehiculo vehiculo in listado)
                {
                    cbVehiculos.Items.Add(vehiculo.stPatente);
                    listaVehiculo.Add(vehiculo);
                }
            }
        }

        private void btConductor_Click(object sender, EventArgs e)
        {
            var nuevoConductor = new fmIngresoConductor();
            fmIngresoConductor.Permiso = Permiso;
            nuevoConductor.ShowDialog();
            cargarComboConductor();
        }

        private void nombreConductor() {
            if (listaConductor.Count != 0) {
                foreach (Conductor conductor in listaConductor) {
                    if (conductor.stRut == cbConductor.Text) {
                        tbNombreConductor.Text = conductor.stNombre;
                        break;
                    }
                }
            }
        }
        private void capacidadVehiculo() {
            if (listaVehiculo.Count != 0) {
                foreach (Vehiculo vehiculo in listaVehiculo) {
                    if (vehiculo.stPatente == cbVehiculos.Text) {
                        tbCapacidad.Text = vehiculo.inPeso + " Kilogramos";
                        tbTipoVehiculo.Text = vehiculo.stTipo;
                        vehiculoActual = vehiculo;
                        break;
                    }
                }
            }
        }
        private void cantidadPuntosRutas()
        {
            if (listaRutas.Count != 0)
            {
                foreach (Rutas rutas in listaRutas)
                {
                    if (rutas.stIdRuta == cbRutas.Text)
                    {
                        tbParadas.Text = rutas.inCantidadPuntos + "";
                        tbTiempoAproxSin.Text = rutas.inDuracion + " Minutos";
                        tbDistanciaRuta.Text = rutas.doDistancia + " Kilometros";
                        rutaActual = rutas;
                        break;
                    }
                }
            }
        }

        private void cargarCombox()
        {
            cbMaterial.Items.Clear();
            var listaMaterial = C.recuperarListaMaterial();
            foreach (string tipo in listaMaterial)
            {
                cbMaterial.Items.Add(tipo);
            }
        }

        private void cbConductor_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreConductor();
        }
        private void cbVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            capacidadVehiculo();
        }
        private void cbRutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantidadPuntosRutas();
        }
        private void btVehiculo_Click(object sender, EventArgs e)
        {
            var nuevoVehiculo = new fmIngresoVehiculo();
            fmIngresoVehiculo.Permiso = Permiso;
            nuevoVehiculo.ShowDialog();
            cargarComboVehiculo();
        }
        private void btRuta_Click(object sender, EventArgs e)
        {
            var crearRuta = new Mapa();
            Mapa.Permiso = Permiso;
            crearRuta.ShowDialog();
            cargarComboRuta();
        }

        private void btSimular_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Simular();
            }            
        }
        private void Simular() {
            List<Marcador> marcadores = new List<Marcador>();
            var listaObj = C.recuperarMarcadoresRuta(cbRutas.Text);
            int inKilosTotales = 0;
            foreach (Marcador marcador in listaObj)
            {
                marcadores.Add(marcador);
                double a = marcador.doLatitud;
                inKilosTotales = inKilosTotales + marcador.inPeso;
            }
            Tuple<int, double> tuple = R.calcularDuracionDistanciaTotalAproximado(marcadores, rutaActual.inDuracion, rutaActual.doDistancia, vehiculoActual.inPeso, rutaActual.inCantidadPuntos);
            int tiempo = tuple.Item1;
            double distancia = tuple.Item2;
            //doConsumoTotal, doEmisionTotal
            Tuple<double, double> huellaC = R.calcularHuellaCarbono(distancia, vehiculoActual.doConsumoEnergetico, vehiculoActual.inEmision);
            tbTiempoAproxCon.Text = tiempo + " Minutos";
            tbDistanciaRecorrida.Text = distancia + " Kilometros";
            tbEmisionTotal.Text = huellaC.Item1 + " Lt / Km";
            tbHuellaCarbon.Text = huellaC.Item2 / 1000 + " Kgr / Km";
            tbRecolectado.Text = inKilosTotales + " Kilogramos";
            String idRecorrido = NuevoNombreRecorrido();
            recorrido = new Recorrido(idRecorrido, rutaActual.stIdRuta, cbConductor.Text, vehiculoActual.stPatente, cbMaterial.Text, dtFecha.Text, tiempo, distancia, huellaC.Item1, huellaC.Item2 / 1000, inKilosTotales, 0);
            blRecorrido = true;
        }

        private bool validar() {
            bool blFlag = true;
            Color cDefault = tbCapacidad.BackColor;
            Color cError = Color.RosyBrown;
            if (cbRutas.Text == "") { 
                blFlag = false;
                cbRutas.BackColor = cError;
            }
            else { 
                cbRutas.BackColor = cDefault; 
            }
            if (cbConductor.Text == "")
            {
                blFlag = false;
                cbConductor.BackColor = cError;
            }
            else { 
                cbConductor.BackColor = cDefault; 
            }
            if (cbVehiculos.Text == "")
            {
                blFlag = false;
                cbVehiculos.BackColor = cError;
            }
            else
            {
                cbVehiculos.BackColor = cDefault; 
            }
            if (cbMaterial.Text == "")
            {
                blFlag = false;
                cbMaterial.BackColor = cError;
            }
            else 
            { 
                cbMaterial.BackColor = cDefault;
            }
            return blFlag;
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e){}

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (Permiso > 0)
            {
                if (validar())
                {
                    if (blRecorrido == true)
                    {
                        crearRecorrido();
                    }
                    else
                    {
                        Simular();
                        crearRecorrido();
                    }
                }
            }
            else
            {
                MessageBox.Show("Permisos insuficientes para realizar la operacion");
            }
                        
        }
        private void crearRecorrido() 
        {
            DialogResult dialogResult = MessageBox.Show("Seguro desea guardar el recorrido asociado a la ruta " + recorrido.stIdRuta + ", vehiculo " + recorrido.stPatente + " y conductor " + recorrido.stRutConductor + " ?", "Guardar Recorrido", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (C.crearRecorrido(recorrido) == 1)
                {
                    MessageBox.Show("Se a ingresado correctamente el recorrido");
                }
                else
                {
                    MessageBox.Show("A ocurrido un error");
                }
            }
        }
        private String NuevoNombreRecorrido()
        {
            String result = "";
            String stNuevaRuta = C.recuperarIdRecorrido();
            if (stNuevaRuta == "")
            {
                result = "00000000";
            }
            else
            {
                if (R.esNumero(stNuevaRuta))
                {
                    var i = int.Parse(stNuevaRuta) + 1;
                    result = i.ToString();
                    while (result.Length < "00000000".Length) {
                        result = "0" + result;
                    }
                    //stNuevaRuta = "0"+i;
                }
            }
            return result;
        }
    }
}
