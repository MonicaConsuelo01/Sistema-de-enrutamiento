using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using Reciclaje.Logica;
using Reciclaje.Interfaz;

namespace Reciclaje
{
    public partial class Main : Form
    {
        public Usuario gbUsuario;
        public int gbPermiso;
        private Controlador controlador = new Controlador();
        public Main()
        {
            InitializeComponent();
            btCerrarSesion.Location = btIniciarSesion.Location;
            btIniciarSesion.Show();
            btCerrarSesion.Hide();
            btUsuario.Hide();
            Color col = btCerrarSesion.BackColor;
            btRutas.BackColor = Color.FromArgb(90, col.R, col.G, col.B);
            btIniciarSesion.BackColor = Color.FromArgb(90, col.R, col.G, col.B); 
            btCamiones.BackColor = Color.FromArgb(90, col.R, col.G, col.B);
            btCerrarSesion.BackColor = Color.FromArgb(90, col.R, col.G, col.B);
            btConductor.BackColor = Color.FromArgb(90, col.R, col.G, col.B);
            btAsignarRuta.BackColor = Color.FromArgb(90, col.R, col.G, col.B);
            btInforme.BackColor = Color.FromArgb(90, col.R, col.G, col.B);

        }
        private void RevisarSesion() {
            if (controlador.sesionExiste())
            {
                string rut = controlador.usuarioAlmacenado();
                SetUsuario(controlador.recuperarUsuario(rut));
                gbPermiso = gbUsuario.Permiso;
                lbSesionActual.Text = "Usuario Actual :" + gbUsuario.Nombre;
                btIniciarSesion.Enabled = false;
                btIniciarSesion.Hide();
                btCerrarSesion.Show();
                btCerrarSesion.Enabled = true;
                if (gbPermiso > 0) 
                {
                    btCamiones.Enabled = true;
                    btRutas.Enabled = true;
                    btConductor.Enabled = true;
                    btAsignarRuta.Enabled = true;
                }                
                btInforme.Enabled = true;                
                if (gbPermiso > 2) {
                    btUsuario.Show();
                    btUsuario.Enabled = true;
                }
            }
            else 
            {
                lbSesionActual.Text = "Se requiere iniciar sesion";
            }
        }        

        private void btCamiones_Click(object sender, EventArgs e)
        {
            var Vehiculos = new fmIngresoVehiculo();
            fmIngresoVehiculo.Permiso = gbPermiso;
            Vehiculos.ShowDialog();
        }

        private void btRutas_Click(object sender, EventArgs e)
        {
            var Rutas = new Mapa();
            Mapa.Permiso = gbPermiso;
            Rutas.ShowDialog();
        }
        private void btConductor_Click(object sender, EventArgs e)
        {
            var Conductor = new fmIngresoConductor();
            fmIngresoConductor.Permiso = gbPermiso;
            Conductor.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Controlador c = new Controlador();
            c.crearBD();
            if (c.existenUsuarios())
            {
                RevisarSesion();
            }
            else {
                var nuevoUsuario = new frCrearUsuario();                
                nuevoUsuario.ShowDialog();                
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            var nuevaSesion = new frIniciarSesion();
            nuevaSesion.ShowDialog();
            SetUsuario(controlador.recuperarUsuario(nuevaSesion.rut));
            if (gbUsuario != null && nuevaSesion.blBandera)
            {
                lbSesionActual.Text = "Usuario Actual :" + gbUsuario.Nombre;
                gbPermiso = gbUsuario.Permiso;
                btIniciarSesion.Enabled = false;
                btIniciarSesion.Hide();
                btCerrarSesion.Show();
                btCerrarSesion.Enabled = true;
                btInforme.Enabled = true;
                if (gbPermiso > 0)
                {
                    btCamiones.Enabled = true;
                    btRutas.Enabled = true;
                    btConductor.Enabled = true;
                    btAsignarRuta.Enabled = true;                  
                }
                if (gbPermiso > 2)
                {
                    btUsuario.Show();
                    btUsuario.Enabled = true;
                }
            }
        }
        private void SetUsuario(Usuario nuevoUsuario) {
            gbUsuario = nuevoUsuario;
        }
        private void btCerrarSesion_Click(object sender, EventArgs e)
        {
            gbUsuario = null;
            controlador.eliminarSesion();           
            btIniciarSesion.Enabled = true;
            btIniciarSesion.Show();
            btCerrarSesion.Hide();
            btCerrarSesion.Enabled = false;
            btCamiones.Enabled = false;
            btRutas.Enabled = false;
            btConductor.Enabled = false;
            btAsignarRuta.Enabled = false;
            btInforme.Enabled = false;
            lbSesionActual.Text = "Se requiere iniciar sesion";
            btUsuario.Hide();
            btUsuario.Enabled = false;           
        }
        private void btAsignarRuta_Click(object sender, EventArgs e)
        {
            var crearRuta = new fmCrearRuta();
            fmCrearRuta.Permiso = gbPermiso;
            crearRuta.ShowDialog();
        }

        private void btInforme_Click(object sender, EventArgs e)
        {
            var informes = new frInformes();
            informes.ShowDialog();
        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            var nuevoUsuario = new frCrearUsuario();
            nuevoUsuario.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e) { }
        private void btRutas_MouseEnter(object sender, EventArgs e) { }
        private void btRutas_MouseLeave(object sender, EventArgs e) { }
    }
}
