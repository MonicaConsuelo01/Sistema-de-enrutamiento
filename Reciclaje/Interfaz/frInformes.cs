using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Reciclaje.Logica;

namespace Reciclaje.Interfaz
{
    public partial class frInformes : Form
    {
        Controlador C = new Controlador();
        private List<Conductor> listaConductor = new List<Conductor>();
        private List<Vehiculo> listaVehiculo = new List<Vehiculo>();
        public frInformes()
        {
            InitializeComponent();
            cargarCombo();
            inicializarListView();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            recuperar();
        }
        private void cargarCombo()
        {            
            cbVehiculo.Items.Clear();
            cbMaterial.Items.Clear();
            cbConductor.Items.Clear();
            var listadoVehiculo = C.recuperarVehiculo();
            if (listadoVehiculo.Count > 0)
            {
                foreach (Vehiculo vehiculo in listadoVehiculo)
                {
                    listaVehiculo.Add(vehiculo); 
                    cbVehiculo.Items.Add(vehiculo.stPatente);
                }
            }
            var listadoConductor = C.recuperarConductor();
            if (listadoConductor.Count > 0)
            {
                foreach (Conductor conductor in listadoConductor)
                {
                    listaConductor.Add(conductor);
                    cbConductor.Items.Add(conductor.stRut);
                }
            }
            var listaMaterial = C.recuperarListaMaterial();
            if (listaMaterial.Count > 0)
            {
                foreach (String material in listaMaterial)
                {
                    cbMaterial.Items.Add(material);
                }
            }
        }
        private void recuperar()
        {
            String fecha = " WHERE recorrido.fecha BETWEEN '"+datePickInicio.Text+"' AND '"+datePickFin.Text+"' ";
            String stCondicion = "";
            List<Recorrido> listado = new List<Recorrido>();
            if (checkConductor.Checked == false && cbConductor.Text != "") {
                stCondicion = stCondicion + " AND conductor.rut = '" + cbConductor.Text+"'";
            }
            if (checkVehiculo.Checked == false && cbVehiculo.Text != "") {
                stCondicion = stCondicion + " AND vehiculo.patente = '" + cbVehiculo.Text+"'";
            }
            if (checkMaterial.Checked == false && cbMaterial.Text != "") {
                stCondicion = stCondicion + "AND material = '" + cbMaterial.Text+"'";
            }
            if (stCondicion == "")
            {
                listado = C.recuperarRecorrido(fecha);
            }
            else {
                listado = C.recuperarRecorrido(fecha, stCondicion);
            }
            
            lvResultado.Clear();
            ListViewItem item;
            string[] arr = new string[11];
            inicializarListView();
            if (listado.Count > 0)
            {
                foreach (Recorrido recorrido in listado)
                {
                    arr[0] = recorrido.stIdRuta;
                    arr[1] = recorrido.stRutConductor;
                    arr[2] = recorrido.stNombre;
                    arr[3] = recorrido.stPatente;
                    arr[4] = recorrido.inCapacidad.ToString();
                    arr[5] = recorrido.inCantidadRecoleccion.ToString();
                    arr[6] = recorrido.stMaterial;
                    arr[7] = recorrido.doDistanciaFinal.ToString();
                    arr[8] = recorrido.inDuracionFinal.ToString();
                    arr[9] = recorrido.inEmisionFinal.ToString();
                    arr[10] = recorrido.stFecha;                    
                    item = new ListViewItem(arr);
                    lvResultado.Items.Add(item);
                }
            }
        }
        private void inicializarListView() {
            lvResultado.Columns.Clear();
            lvResultado.View = View.Details;
            lvResultado.GridLines = true;
            lvResultado.Columns.Add("ID RUTA", 85);
            lvResultado.Columns.Add("RUT", 80);
            lvResultado.Columns.Add("NOMBRE", 85);
            lvResultado.Columns.Add("PATENTE", 65);
            lvResultado.Columns.Add("CAPACIDAD", 65);
            lvResultado.Columns.Add("RECOLECCION TOTAL", 100);
            lvResultado.Columns.Add("MATERIAL", 65);
            lvResultado.Columns.Add("DISTANCIA TOTAL", 85);
            lvResultado.Columns.Add("DURACION FINAL", 85);
            lvResultado.Columns.Add("EMISION", 75);
            lvResultado.Columns.Add("FECHA", 75);
            lvResultado.FullRowSelect = true;
        }
        private void nombreConductor()
        {
            if (listaConductor.Count != 0)
            {
                foreach (Conductor conductor in listaConductor)
                {
                    if (conductor.stRut == cbConductor.Text)
                    {
                        tbNombreConductor.Text = conductor.stNombre;
                        break;
                    }
                }
            }
        }
        private void tipoVehiculo()
        {
            if (listaVehiculo.Count != 0)
            {
                foreach (Vehiculo vehiculo in listaVehiculo)
                {
                    if (vehiculo.stPatente == cbVehiculo.Text)
                    {
                        tbTipoVehiculo.Text = vehiculo.stTipo;                        
                        break;
                    }
                }
            }
        }

        private void cbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoVehiculo();
        }

        private void cbConductor_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreConductor();
        }
    }
}
