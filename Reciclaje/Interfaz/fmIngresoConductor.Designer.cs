
namespace Reciclaje.Interfaz
{
    partial class fmIngresoConductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmIngresoConductor));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvConductor = new System.Windows.Forms.ListView();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.tbRut = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvConductor);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btAgregar);
            this.splitContainer1.Panel2.Controls.Add(this.btModificar);
            this.splitContainer1.Panel2.Controls.Add(this.btEliminar);
            this.splitContainer1.Panel2.Controls.Add(this.btGuardar);
            this.splitContainer1.Panel2.Controls.Add(this.tbCelular);
            this.splitContainer1.Panel2.Controls.Add(this.tbRut);
            this.splitContainer1.Panel2.Controls.Add(this.tbNombre);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(523, 308);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // lvConductor
            // 
            this.lvConductor.HideSelection = false;
            this.lvConductor.Location = new System.Drawing.Point(12, 12);
            this.lvConductor.Name = "lvConductor";
            this.lvConductor.Size = new System.Drawing.Size(226, 276);
            this.lvConductor.TabIndex = 9;
            this.lvConductor.UseCompatibleStateImageBehavior = false;
            this.lvConductor.ItemActivate += new System.EventHandler(this.lvConductor_ItemActivate);
            this.lvConductor.Click += new System.EventHandler(this.lvConductor_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btAgregar.Image")));
            this.btAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAgregar.Location = new System.Drawing.Point(24, 12);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(100, 40);
            this.btAgregar.TabIndex = 5;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Image = ((System.Drawing.Image)(resources.GetObject("btModificar.Image")));
            this.btModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btModificar.Location = new System.Drawing.Point(140, 12);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 40);
            this.btModificar.TabIndex = 6;
            this.btModificar.Text = "Modificar";
            this.btModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btEliminar.Image")));
            this.btEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEliminar.Location = new System.Drawing.Point(24, 248);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(216, 44);
            this.btEliminar.TabIndex = 4;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btGuardar.Image")));
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardar.Location = new System.Drawing.Point(24, 196);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(216, 48);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(24, 169);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.PlaceholderText = "Opcional \"987654321\"";
            this.tbCelular.Size = new System.Drawing.Size(216, 23);
            this.tbCelular.TabIndex = 2;
            this.tbCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCelular_KeyPress);
            // 
            // tbRut
            // 
            this.tbRut.Location = new System.Drawing.Point(24, 77);
            this.tbRut.Name = "tbRut";
            this.tbRut.PlaceholderText = "Sin guion y Puntos";
            this.tbRut.Size = new System.Drawing.Size(216, 23);
            this.tbRut.TabIndex = 0;
            this.tbRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRut_KeyPress);
            this.tbRut.Validated += new System.EventHandler(this.tbRut_Validated);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(24, 123);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(216, 23);
            this.tbNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // fmIngresoConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 308);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "fmIngresoConductor";
            this.Text = "fmIngresoConductor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvConductor;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.TextBox tbRut;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btAgregar;
    }
}