
namespace Reciclaje
{
    partial class frCrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCrearUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRut = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.lbVer = new System.Windows.Forms.Label();
            this.gbPermisos = new System.Windows.Forms.GroupBox();
            this.checkVisita = new System.Windows.Forms.CheckBox();
            this.checkEstandar = new System.Windows.Forms.CheckBox();
            this.lbSesion = new System.Windows.Forms.Label();
            this.gbPermisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo Electronico";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(12, 45);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(170, 23);
            this.tbNombre.TabIndex = 1;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(209, 45);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(170, 23);
            this.tbApellido.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Apellido";
            // 
            // tbRut
            // 
            this.tbRut.Location = new System.Drawing.Point(12, 91);
            this.tbRut.MaxLength = 12;
            this.tbRut.Name = "tbRut";
            this.tbRut.PlaceholderText = "Sin guion y Puntos";
            this.tbRut.Size = new System.Drawing.Size(208, 23);
            this.tbRut.TabIndex = 3;
            this.tbRut.TextChanged += new System.EventHandler(this.tbRut_TextChanged);
            this.tbRut.VisibleChanged += new System.EventHandler(this.tbRut_VisibleChanged);
            this.tbRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRut_KeyPress);
            this.tbRut.Validated += new System.EventHandler(this.tbRut_Validar);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(12, 137);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.PlaceholderText = "correo@correo.com";
            this.tbCorreo.Size = new System.Drawing.Size(367, 23);
            this.tbCorreo.TabIndex = 4;
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(12, 182);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(367, 23);
            this.tbClave.TabIndex = 5;
            this.tbClave.UseSystemPasswordChar = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btGuardar.Image")));
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardar.Location = new System.Drawing.Point(12, 258);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(373, 43);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.Image = global::Reciclaje.Properties.Resources.eye16;
            this.lbVer.Location = new System.Drawing.Point(360, 164);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(19, 15);
            this.lbVer.TabIndex = 7;
            this.lbVer.Text = "    ";
            this.lbVer.Click += new System.EventHandler(this.lbVer_Click);
            // 
            // gbPermisos
            // 
            this.gbPermisos.Controls.Add(this.checkVisita);
            this.gbPermisos.Controls.Add(this.checkEstandar);
            this.gbPermisos.Location = new System.Drawing.Point(12, 211);
            this.gbPermisos.Name = "gbPermisos";
            this.gbPermisos.Size = new System.Drawing.Size(373, 41);
            this.gbPermisos.TabIndex = 8;
            this.gbPermisos.TabStop = false;
            this.gbPermisos.Text = "Permisos Usuarios";
            // 
            // checkVisita
            // 
            this.checkVisita.AutoSize = true;
            this.checkVisita.Location = new System.Drawing.Point(114, 16);
            this.checkVisita.Name = "checkVisita";
            this.checkVisita.Size = new System.Drawing.Size(71, 19);
            this.checkVisita.TabIndex = 1;
            this.checkVisita.Text = "Visitante";
            this.checkVisita.UseVisualStyleBackColor = true;
            // 
            // checkEstandar
            // 
            this.checkEstandar.AutoSize = true;
            this.checkEstandar.Checked = true;
            this.checkEstandar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEstandar.Location = new System.Drawing.Point(6, 16);
            this.checkEstandar.Name = "checkEstandar";
            this.checkEstandar.Size = new System.Drawing.Size(71, 19);
            this.checkEstandar.TabIndex = 0;
            this.checkEstandar.Text = "Estandar";
            this.checkEstandar.UseVisualStyleBackColor = true;
            // 
            // lbSesion
            // 
            this.lbSesion.AutoSize = true;
            this.lbSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSesion.Location = new System.Drawing.Point(12, 9);
            this.lbSesion.Name = "lbSesion";
            this.lbSesion.Size = new System.Drawing.Size(10, 15);
            this.lbSesion.TabIndex = 9;
            this.lbSesion.Text = " ";
            // 
            // frCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 313);
            this.Controls.Add(this.lbSesion);
            this.Controls.Add(this.gbPermisos);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbRut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frCrearUsuario_FormClosed);
            this.Load += new System.EventHandler(this.frCrearUsuario_Load);
            this.gbPermisos.ResumeLayout(false);
            this.gbPermisos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRut;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.GroupBox gbPermisos;
        private System.Windows.Forms.CheckBox checkEstandar;
        private System.Windows.Forms.CheckBox checkVisita;
        private System.Windows.Forms.Label lbSesion;
    }
}