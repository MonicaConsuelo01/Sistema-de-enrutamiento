using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Reciclaje.Logica;
namespace Reciclaje
{
    public partial class frCrearUsuario : Form
    {
        private Rutinas R = new Rutinas();
        private Controlador C = new Controlador();
        private bool blFlag = false;
        public frCrearUsuario()
        {
            InitializeComponent();
            primerUsuario();
        }

        private void primerUsuario() {
            if (!C.existenUsuarios()) {
                checkEstandar.Enabled = false;
                checkVisita.Enabled = false;
                this.FormBorderStyle = FormBorderStyle.None;
                this.btGuardar.Text = "Guardar Administrador";
                this.lbSesion.Text = "Obligatorio Ingresar Administrador";
                blFlag = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            String stNombre = tbNombre.Text.Trim() + " " + tbApellido.Text.Trim();
            String stRut = tbRut.Text.Replace(".", "").Trim();
            //
            int resultado = crearUsuario(stRut,stNombre);
            if (resultado == 1)
            {
                MessageBox.Show("Usuario Creado Correctamente");
                this.blFlag = false;
                this.Close();
            }
            else if (resultado == 0)
            {
                MessageBox.Show("El usuario ya existe");
            }
            else if (resultado == -1) 
            {
                MessageBox.Show("Error al conectar a la base de datos");                
            }
            
        }
        private int crearUsuario(String rut,String nombre) {
            int inPermiso  = 0;
            if (!R.esRut(rut))
            {
                MessageBox.Show("El rut ingresado no es valido o esta vacio");
                tbRut.Focus();
                return 2;
            }
            if (!R.esCorreo(tbCorreo.Text.Trim()))
            {
                MessageBox.Show("El correo ingresado no es valido o esta vacio");
                tbCorreo.Focus();
                return 2;
            }
            if (tbClave.Text.Trim() == "") {
                MessageBox.Show("La clave no puede estar vacia");
                tbClave.Focus();
                return 2;
            }
            if (nombre.Trim() == "" && tbNombre.Text.Trim() == "")
            {
                MessageBox.Show("El nombre no puede estar vacio");
                tbNombre.Focus();
                return 2;
            }
            if (blFlag) {
                inPermiso = 3;
            }
            else if (checkEstandar.Checked) 
            {
                inPermiso = 1;
            }
            else if (checkVisita.Checked)
            {
                inPermiso = 0;
            }

            Usuario usuario = new Usuario(nombre, tbCorreo.Text, rut, tbClave.Text,inPermiso);
            Controlador c = new Controlador();
            int resultado = c.crearUsuario(usuario);
            return resultado;
        }



        private void tbRut_Validar(object sender, EventArgs e)
        {

            tbRut.Text = R.formatearRut(tbRut.Text);

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


        private void tbRut_VisibleChanged(object sender, EventArgs e) {}
        private void tbRut_TextChanged(object sender, EventArgs e) {}
        private void tbRut_KeyDown(object sender, KeyEventArgs e) {}

        private void lbVer_Click(object sender, EventArgs e)
        {
            if (tbClave.UseSystemPasswordChar)
            {
                tbClave.UseSystemPasswordChar = false;
            }
            else
            {
                tbClave.UseSystemPasswordChar = true;
            }
        }

        private void frCrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void frCrearUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (blFlag) {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
