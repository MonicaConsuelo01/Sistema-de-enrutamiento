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
    public partial class fmIngresoConductor : Form
    {
        public static int Permiso;
        private Rutinas R = new Rutinas();
        private Controlador C = new Controlador();
        public fmIngresoConductor()
        {
            InitializeComponent();
            lvGenerar();
            recuperar();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {          
        }
        private void recuperar() {
            Controlador c = new Controlador();
            var listado = c.recuperarConductor();
            lvConductor.Clear();
            ListViewItem item;
            string[] arr = new string[3];
            lvGenerar();
            if (listado.Count > 0) {
                foreach (Conductor conductor in listado)                    
                {
                    arr[0] = conductor.stNombre;
                    arr[1] = conductor.stRut;
                    arr[2] = conductor.stCelular;
                    item = new ListViewItem(arr);
                    lvConductor.Items.Add(item);
                }            
            }
            lvConductor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void lvGenerar() {

            lvConductor.View = View.Details;
            lvConductor.GridLines = true;
            lvConductor.Columns.Add("Nombre");
            lvConductor.Columns.Add("RUT");
            lvConductor.Columns.Add("Celular");
            lvConductor.FullRowSelect = true;
            lvConductor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvConductor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            registro(0);
        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            registro(1);
        }
        public void registro(int op) {            
            if (validar())
            {
                String stRut = tbRut.Text.Replace(".", "").Trim();
                Conductor conductor =
                    new Conductor(stRut, tbNombre.Text, tbCelular.Text);

                if (op == 0 && C.crearConductor(conductor) == 0)
                {
                    MessageBox.Show("El conductor Existe");
                }
                if (op == 1 && C.modificarConductor(conductor) < 1)
                {
                    MessageBox.Show("El conductor no existe");
                }
            }
            recuperar();
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro de eliminar registro "+tbRut.Text, "Eliminar", MessageBoxButtons.YesNo);
            if (validar())
            {            
                if(dialogResult == DialogResult.Yes)
                {
                    String stRut = tbRut.Text.Replace(".", "").Trim();
                    Conductor conductor =
                        new Conductor(stRut);
                    if (C.eliminarConductor(conductor) < 1)
                    {
                        MessageBox.Show("El conductor no existe");
                    }
                    recuperar();
                    tbNombre.Text = "";
                    tbRut.Text = "";
                    tbCelular.Text = "";
                    tbRut.Focus();
                }                
            }            
        }
        private bool validar() {
            bool blResultado = false;
            int cont = 0;
            if (Permiso < 1) {                
                MessageBox.Show("Permisos insuficientes para realizar la operacion");
                return false;
            }
            if (tbNombre.Text.Trim().Length != 0){
                cont = cont + 1;
                tbNombre.BackColor = Color.White;
            }
            else {
                tbNombre.BackColor= Color.RosyBrown;                
            }
            if (R.esRut(tbRut.Text.Replace(".", "").Trim())){
                cont = cont + 1;
                tbRut.BackColor = Color.White;
            }
            else {
                tbRut.BackColor = Color.RosyBrown;
            }

            if (tbCelular.Text == "" || tbCelular.Text.Length == 9) {
                cont = cont + 1;
                tbCelular.BackColor = Color.White;
            }
            else {
                tbCelular.BackColor = Color.RosyBrown; 
            }
            if(cont == 3) {
                blResultado = true;
            }

            return blResultado;
        }

        private void tbRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().ToUpper().Equals("K"))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().ToUpper().Equals("-"))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void tbRut_Validated(object sender, EventArgs e)
        {
            tbRut.Text = R.formatearRut(tbRut.Text);
        }

        private void tbCelular_KeyPress(object sender, KeyPressEventArgs e)
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
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void lvConductor_ItemActivate(object sender, EventArgs e){}

        private void lvConductor_Click(object sender, EventArgs e)
        {
            var seleccion = lvConductor.SelectedItems[0];
            tbNombre.Text = seleccion.SubItems[0].Text;
            tbRut.Text = seleccion.SubItems[1].Text;
            tbCelular.Text = seleccion.SubItems[2].Text;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbRut.Text = "";
            tbCelular.Text = "";
            tbRut.Focus();
        }
    }
}
