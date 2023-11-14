using Reciclaje.Logica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Reciclaje
{
    public partial class frIniciarSesion : Form
    {
        Controlador c = new Controlador();
        private Rutinas R = new Rutinas();
        public String rut;
        public bool blBandera = false;
        public frIniciarSesion()
        {
            InitializeComponent();
        }


        private void frIniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            String stUser = tbNombre.Text.Replace(".", "").Trim();
            String stPasw = tbContrasenia.Text;

            if (ValidarUsuario(stUser, stPasw))
            {
                blBandera = true;
                this.rut = stUser;
                if (chSesion.Checked)
                {
                    c.eliminarSesion();
                    c.crearSesion(stUser);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos de usuario no encontrados");
            }
        }

        private bool ValidarUsuario(String Usuario, String Contrasenia)
        {
            bool blResultado = false;
            if (c.verificarUsuario(Usuario, Contrasenia) > 0)
            {
                blResultado = true;
            }
            return blResultado;
        }

        private void btCrearUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void frIniciarSesion_FormClosing(object sender, FormClosingEventArgs e)
        {


        }
        private void label3_Click(object sender, EventArgs e)
        {
            Color col = lbVer.BackColor;
            if (tbContrasenia.UseSystemPasswordChar)
            {
                tbContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                tbContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void tbContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbNombre_Validated(object sender, EventArgs e)
        {
            tbNombre.Text = R.formatearRut(tbNombre.Text);
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btIniciarSesion.PerformClick();
            }
        }

        private void tbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbContrasenia.Focus();
            }
        }
    }
}
