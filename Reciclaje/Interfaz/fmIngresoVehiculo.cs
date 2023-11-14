using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Reciclaje.Interfaz;
using System.Windows.Forms;
using Reciclaje.Logica;

namespace Reciclaje
{    
    public partial class fmIngresoVehiculo : Form
    {
        public static int Permiso;
        private Rutinas R = new Rutinas();
        private Controlador C = new Controlador();
        List<Vehiculo> ListaVehiculos;
        public fmIngresoVehiculo()
        {
            InitializeComponent();
            ListaVehiculos = new List<Vehiculo>();      
            //ListView 
            iniciarListView();
            recuperar();
            //ComboBox
            cargarCombox();
        }
        private void iniciarListView() {
            lvVehiculos.View = View.Details;
            lvVehiculos.GridLines = true;
            lvVehiculos.Columns.Add("Patente", 65);
            lvVehiculos.Columns.Add("Tipo Vehiculo", 100);
            lvVehiculos.Columns.Add("Capacidad", 65);
            lvVehiculos.Columns.Add("Combustible", 65);
            lvVehiculos.Columns.Add("Comsumo", 65);
            lvVehiculos.Columns.Add("Emision", 65);
            lvVehiculos.FullRowSelect = true;
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            limpiar();
            tbPatente.Focus();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {            
            if (validar())
            {
                registro(0);
                recuperar();
            }            
        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro de modificar registro " + tbPatente.Text, "Modificar", MessageBoxButtons.YesNo);
            if (validar())
            {
                if (dialogResult == DialogResult.Yes) 
                {
                    registro(1);
                    recuperar();
                }                    
            }
        }
        private void recuperar() {
            Controlador c = new Controlador();
            var listado = c.recuperarVehiculo();
            lvVehiculos.Clear();
            ListViewItem item;
            string[] arr = new string[6];
            iniciarListView();
            if (listado.Count > 0)
            {
                foreach (Vehiculo vehiculo in listado)
                {                    
                    arr[0] = vehiculo.stPatente;
                    arr[1] = vehiculo.stTipo;
                    arr[2] = vehiculo.inPeso.ToString();
                    arr[3] = vehiculo.stCombustible;
                    arr[4] = vehiculo.doConsumoEnergetico.ToString();
                    arr[5] = vehiculo.inEmision.ToString();
                    item = new ListViewItem(arr);
                    lvVehiculos.Items.Add(item);
                }
            }
        }
        private bool validar() {
            bool blResultado = false;
            int cont = 0;
            if (Permiso < 1) {
                MessageBox.Show("Permisos Insuficientes para la operacion");
                return false;
            }
            if (R.esPatente(tbPatente.Text.Trim())){//1
                cont = cont + 1;
                tbPatente.BackColor = Color.White;
            }
            else{
                tbPatente.BackColor = Color.RosyBrown;
            }
            if (R.esNumero(tbCapacidad.Text)){//2
                cont = cont + 1;
                tbCapacidad.BackColor = Color.White;
            }
            else{
                tbCapacidad.BackColor = Color.RosyBrown;
            }
            if (R.esDecimal(tbConsumo.Text)){//3
                cont = cont + 1;
                tbConsumo.BackColor = Color.White;
            }
            else{
                tbConsumo.BackColor = Color.RosyBrown;
            }
            if (R.esNumero(tbEmision.Text)){//4
                cont = cont + 1;
                tbEmision.BackColor = Color.White;
            }
            else{
                tbEmision.BackColor = Color.RosyBrown;
            }
            if (cbTipoVehiculo.Text != ""){//5
                cont = cont + 1;
                cbTipoVehiculo.BackColor = Color.White;
            }else{
                cbTipoVehiculo.BackColor = Color.RosyBrown;
            }
            if (cbCombustible.Text != ""){//6
                cont = cont + 1;
                cbCombustible.BackColor = Color.White;
            }else{
                cbCombustible.BackColor = Color.RosyBrown;
            }
            if (cont == 6){
                blResultado = true;
            }
            return blResultado;
        }
        private void registro(int op) {
            String stPatente = tbPatente.Text;
            int inPesoTotal = int.Parse(tbCapacidad.Text.Trim());
            int inEmision = int.Parse(tbEmision.Text.Trim());
            String stConsumo = tbConsumo.Text.Trim().Replace(".",",");
            double doConsumo = double.Parse(stConsumo);
            Vehiculo vehiculo = new Vehiculo(stPatente, inPesoTotal,cbTipoVehiculo.Text,cbCombustible.Text,doConsumo,inEmision);            
            if (op == 0 && C.crearVehiculo(vehiculo) == 0)
            {
                MessageBox.Show("El vehiculo "+ stPatente + " Existe");
            }
            if (op == 1 && C.modificarVehiculo(vehiculo) < 1)
            {
                MessageBox.Show("El vehiculo no existe");
            }

        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            
            if (Permiso < 1) 
            {
                MessageBox.Show("Permisos insuficientes para realizar la operacion");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Seguro de eliminar registro " + tbPatente.Text, "Eliminar", MessageBoxButtons.YesNo);
                if (R.esPatente(tbPatente.Text.Trim()))
                {
                    if (dialogResult == DialogResult.Yes)
                    {
                        Vehiculo vehiculo = new Vehiculo(tbPatente.Text.Trim());
                        if (C.eliminarVehiculo(vehiculo) < 1)
                        {
                            MessageBox.Show("El vehiculo no existe");
                        }
                        limpiar();
                        recuperar();
                    }
                }
            }
        }
        private void cargarCombox() {  
            cbCombustible.Items.Clear();
            cbTipoVehiculo.Items.Clear();
            var listaTipo = C.recuperarVehiculoTipo();
            var listaCombustible = C.recuperarVehiculoCombustible();
            foreach (string tipo in listaTipo) {
                cbTipoVehiculo.Items.Add(tipo);
            }
            foreach (string comb in listaCombustible) {
                cbCombustible.Items.Add(comb);
            }
        }     
        private void tbCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().ToUpper().Equals("."))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbEmision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }
        private void tbRut_keyPress(object sender, KeyPressEventArgs e) { }
        private void btConductor_Click(object sender, EventArgs e) { }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void lvVehiculos_SelectedIndexChanged(object sender, EventArgs e) { }
        private void tbRut_Validated(object sender, EventArgs e) { }
        private void gbxDatos_Enter(object sender, EventArgs e) { }

        private void lvVehiculos_Click(object sender, EventArgs e)
        {
            var seleccion = lvVehiculos.SelectedItems[0];            
            tbPatente.Text = seleccion.SubItems[0].Text;
            cbTipoVehiculo.Text = seleccion.SubItems[1].Text;
            tbCapacidad.Text = seleccion.SubItems[2].Text;
            cbCombustible.Text = seleccion.SubItems[3].Text;             
            tbConsumo.Text = seleccion.SubItems[4].Text;
            tbEmision.Text = seleccion.SubItems[5].Text;
        }
        private void limpiar() {
            tbPatente.Text = "";
            cbTipoVehiculo.Text =  "";
            tbCapacidad.Text = "";
            cbCombustible.Text = "";
            tbConsumo.Text = "";
            tbEmision.Text = "";
        }
        
    }
}
