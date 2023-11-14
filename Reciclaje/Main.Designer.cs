
namespace Reciclaje
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btCamiones = new System.Windows.Forms.Button();
            this.btRutas = new System.Windows.Forms.Button();
            this.btIniciarSesion = new System.Windows.Forms.Button();
            this.lbSesionActual = new System.Windows.Forms.Label();
            this.btCerrarSesion = new System.Windows.Forms.Button();
            this.btConductor = new System.Windows.Forms.Button();
            this.btAsignarRuta = new System.Windows.Forms.Button();
            this.btInforme = new System.Windows.Forms.Button();
            this.btUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCamiones
            // 
            this.btCamiones.Enabled = false;
            this.btCamiones.FlatAppearance.BorderSize = 5;
            this.btCamiones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCamiones.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCamiones.Image = ((System.Drawing.Image)(resources.GetObject("btCamiones.Image")));
            this.btCamiones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCamiones.Location = new System.Drawing.Point(12, 135);
            this.btCamiones.Name = "btCamiones";
            this.btCamiones.Size = new System.Drawing.Size(99, 92);
            this.btCamiones.TabIndex = 0;
            this.btCamiones.Text = "Vehiculos";
            this.btCamiones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCamiones.UseVisualStyleBackColor = true;
            this.btCamiones.Click += new System.EventHandler(this.btCamiones_Click);
            // 
            // btRutas
            // 
            this.btRutas.BackColor = System.Drawing.SystemColors.Control;
            this.btRutas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btRutas.Enabled = false;
            this.btRutas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btRutas.FlatAppearance.BorderSize = 5;
            this.btRutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btRutas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRutas.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRutas.Image = ((System.Drawing.Image)(resources.GetObject("btRutas.Image")));
            this.btRutas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRutas.Location = new System.Drawing.Point(12, 233);
            this.btRutas.Name = "btRutas";
            this.btRutas.Size = new System.Drawing.Size(99, 92);
            this.btRutas.TabIndex = 1;
            this.btRutas.Text = "Mapa";
            this.btRutas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRutas.UseVisualStyleBackColor = true;
            this.btRutas.Click += new System.EventHandler(this.btRutas_Click);
            this.btRutas.MouseEnter += new System.EventHandler(this.btRutas_MouseEnter);
            this.btRutas.MouseLeave += new System.EventHandler(this.btRutas_MouseLeave);
            // 
            // btIniciarSesion
            // 
            this.btIniciarSesion.FlatAppearance.BorderSize = 5;
            this.btIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btIniciarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btIniciarSesion.Location = new System.Drawing.Point(562, 12);
            this.btIniciarSesion.Name = "btIniciarSesion";
            this.btIniciarSesion.Size = new System.Drawing.Size(106, 36);
            this.btIniciarSesion.TabIndex = 2;
            this.btIniciarSesion.Text = "Iniciar Sesion";
            this.btIniciarSesion.UseVisualStyleBackColor = true;
            this.btIniciarSesion.Click += new System.EventHandler(this.btIniciarSesion_Click);
            // 
            // lbSesionActual
            // 
            this.lbSesionActual.AutoSize = true;
            this.lbSesionActual.Location = new System.Drawing.Point(12, 12);
            this.lbSesionActual.Name = "lbSesionActual";
            this.lbSesionActual.Size = new System.Drawing.Size(0, 15);
            this.lbSesionActual.TabIndex = 4;
            // 
            // btCerrarSesion
            // 
            this.btCerrarSesion.Enabled = false;
            this.btCerrarSesion.FlatAppearance.BorderSize = 5;
            this.btCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCerrarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCerrarSesion.Location = new System.Drawing.Point(562, 54);
            this.btCerrarSesion.Name = "btCerrarSesion";
            this.btCerrarSesion.Size = new System.Drawing.Size(106, 36);
            this.btCerrarSesion.TabIndex = 5;
            this.btCerrarSesion.Text = "Cerrar Sesion";
            this.btCerrarSesion.UseVisualStyleBackColor = true;
            this.btCerrarSesion.Click += new System.EventHandler(this.btCerrarSesion_Click);
            // 
            // btConductor
            // 
            this.btConductor.Enabled = false;
            this.btConductor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btConductor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btConductor.Image = ((System.Drawing.Image)(resources.GetObject("btConductor.Image")));
            this.btConductor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btConductor.Location = new System.Drawing.Point(12, 37);
            this.btConductor.Name = "btConductor";
            this.btConductor.Size = new System.Drawing.Size(99, 92);
            this.btConductor.TabIndex = 6;
            this.btConductor.Text = "Conductores";
            this.btConductor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConductor.UseVisualStyleBackColor = true;
            this.btConductor.Click += new System.EventHandler(this.btConductor_Click);
            // 
            // btAsignarRuta
            // 
            this.btAsignarRuta.Enabled = false;
            this.btAsignarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAsignarRuta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAsignarRuta.Image = ((System.Drawing.Image)(resources.GetObject("btAsignarRuta.Image")));
            this.btAsignarRuta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAsignarRuta.Location = new System.Drawing.Point(12, 331);
            this.btAsignarRuta.Name = "btAsignarRuta";
            this.btAsignarRuta.Size = new System.Drawing.Size(99, 92);
            this.btAsignarRuta.TabIndex = 7;
            this.btAsignarRuta.Text = "Asignar Ruta";
            this.btAsignarRuta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAsignarRuta.UseVisualStyleBackColor = true;
            this.btAsignarRuta.Click += new System.EventHandler(this.btAsignarRuta_Click);
            // 
            // btInforme
            // 
            this.btInforme.Enabled = false;
            this.btInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInforme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btInforme.Image = ((System.Drawing.Image)(resources.GetObject("btInforme.Image")));
            this.btInforme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btInforme.Location = new System.Drawing.Point(562, 331);
            this.btInforme.Name = "btInforme";
            this.btInforme.Size = new System.Drawing.Size(99, 92);
            this.btInforme.TabIndex = 8;
            this.btInforme.Text = "Informes";
            this.btInforme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btInforme.UseVisualStyleBackColor = true;
            this.btInforme.Click += new System.EventHandler(this.btInforme_Click);
            // 
            // btUsuario
            // 
            this.btUsuario.Enabled = false;
            this.btUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btUsuario.Image")));
            this.btUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btUsuario.Location = new System.Drawing.Point(562, 233);
            this.btUsuario.Name = "btUsuario";
            this.btUsuario.Size = new System.Drawing.Size(99, 92);
            this.btUsuario.TabIndex = 9;
            this.btUsuario.Text = "Usuarios";
            this.btUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btUsuario.UseVisualStyleBackColor = true;
            this.btUsuario.Click += new System.EventHandler(this.btUsuario_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(180)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(680, 447);
            this.Controls.Add(this.btUsuario);
            this.Controls.Add(this.btInforme);
            this.Controls.Add(this.btAsignarRuta);
            this.Controls.Add(this.btConductor);
            this.Controls.Add(this.btCerrarSesion);
            this.Controls.Add(this.lbSesionActual);
            this.Controls.Add(this.btIniciarSesion);
            this.Controls.Add(this.btRutas);
            this.Controls.Add(this.btCamiones);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCamiones;
        private System.Windows.Forms.Button btRutas;
        private System.Windows.Forms.Button btIniciarSesion;
        private System.Windows.Forms.Label lbSesionActual;
        private System.Windows.Forms.Button btCerrarSesion;
        private System.Windows.Forms.Button btConductor;
        private System.Windows.Forms.Button btAsignarRuta;
        private System.Windows.Forms.Button btInforme;
        private System.Windows.Forms.Button btUsuario;
    }
}