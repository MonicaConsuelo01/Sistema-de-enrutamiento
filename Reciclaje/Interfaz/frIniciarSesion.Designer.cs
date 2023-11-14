
namespace Reciclaje
{
    partial class frIniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frIniciarSesion));
            this.btIniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.lbVer = new System.Windows.Forms.Label();
            this.chSesion = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btIniciarSesion
            // 
            this.btIniciarSesion.Location = new System.Drawing.Point(12, 130);
            this.btIniciarSesion.Name = "btIniciarSesion";
            this.btIniciarSesion.Size = new System.Drawing.Size(210, 37);
            this.btIniciarSesion.TabIndex = 2;
            this.btIniciarSesion.Text = "Iniciar Sesion";
            this.btIniciarSesion.UseVisualStyleBackColor = true;
            this.btIniciarSesion.Click += new System.EventHandler(this.btIniciarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "RUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(12, 27);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PlaceholderText = "Sin guion y Puntos";
            this.tbNombre.Size = new System.Drawing.Size(210, 23);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNombre_KeyDown);
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            this.tbNombre.Validated += new System.EventHandler(this.tbNombre_Validated);
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(12, 76);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(210, 23);
            this.tbContrasenia.TabIndex = 1;
            this.tbContrasenia.UseSystemPasswordChar = true;
            this.tbContrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbContrasenia_KeyDown);
            this.tbContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContrasenia_KeyPress);
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.BackColor = System.Drawing.Color.Transparent;
            this.lbVer.ForeColor = System.Drawing.Color.Transparent;
            this.lbVer.Image = ((System.Drawing.Image)(resources.GetObject("lbVer.Image")));
            this.lbVer.Location = new System.Drawing.Point(199, 58);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(19, 15);
            this.lbVer.TabIndex = 6;
            this.lbVer.Text = "    ";
            this.lbVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbVer.Click += new System.EventHandler(this.label3_Click);
            // 
            // chSesion
            // 
            this.chSesion.AutoSize = true;
            this.chSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chSesion.Location = new System.Drawing.Point(67, 105);
            this.chSesion.Name = "chSesion";
            this.chSesion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chSesion.Size = new System.Drawing.Size(155, 19);
            this.chSesion.TabIndex = 5;
            this.chSesion.Text = "Mantener Sesion Abierta";
            this.chSesion.UseMnemonic = false;
            this.chSesion.UseVisualStyleBackColor = true;
            // 
            // frIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 174);
            this.Controls.Add(this.chSesion);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btIniciarSesion);
            this.Name = "frIniciarSesion";
            this.Text = "Iniciar Sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frIniciarSesion_FormClosing);
            this.Load += new System.EventHandler(this.frIniciarSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIniciarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.CheckBox chSesion;
    }
}