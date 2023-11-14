
namespace Reciclaje
{
    partial class fmIngresoVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmIngresoVehiculo));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.tbEmision = new System.Windows.Forms.TextBox();
            this.lbConsumoE = new System.Windows.Forms.Label();
            this.tbConsumo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCombustible = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCapacidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.lbPatente = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.lvVehiculos = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxDatos.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.gbxDatos);
            this.splitContainer1.Panel1.Controls.Add(this.btEliminar);
            this.splitContainer1.Panel1.Controls.Add(this.btModificar);
            this.splitContainer1.Panel1.Controls.Add(this.btGuardar);
            this.splitContainer1.Panel1.Controls.Add(this.btAgregar);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvVehiculos);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(792, 393);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbxDatos
            // 
            this.gbxDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxDatos.Controls.Add(this.tbEmision);
            this.gbxDatos.Controls.Add(this.lbConsumoE);
            this.gbxDatos.Controls.Add(this.tbConsumo);
            this.gbxDatos.Controls.Add(this.label6);
            this.gbxDatos.Controls.Add(this.cbCombustible);
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Controls.Add(this.cbTipoVehiculo);
            this.gbxDatos.Controls.Add(this.label5);
            this.gbxDatos.Controls.Add(this.tbCapacidad);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Controls.Add(this.tbPatente);
            this.gbxDatos.Controls.Add(this.lbPatente);
            this.gbxDatos.Location = new System.Drawing.Point(12, 58);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(291, 276);
            this.gbxDatos.TabIndex = 4;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            this.gbxDatos.Enter += new System.EventHandler(this.gbxDatos_Enter);
            // 
            // tbEmision
            // 
            this.tbEmision.Location = new System.Drawing.Point(139, 237);
            this.tbEmision.Name = "tbEmision";
            this.tbEmision.Size = new System.Drawing.Size(134, 23);
            this.tbEmision.TabIndex = 17;
            this.tbEmision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmision_KeyPress);
            // 
            // lbConsumoE
            // 
            this.lbConsumoE.AutoSize = true;
            this.lbConsumoE.Location = new System.Drawing.Point(6, 197);
            this.lbConsumoE.Name = "lbConsumoE";
            this.lbConsumoE.Size = new System.Drawing.Size(99, 15);
            this.lbConsumoE.TabIndex = 16;
            this.lbConsumoE.Text = "Consumo(km/Lt)";
            // 
            // tbConsumo
            // 
            this.tbConsumo.Location = new System.Drawing.Point(139, 194);
            this.tbConsumo.Name = "tbConsumo";
            this.tbConsumo.Size = new System.Drawing.Size(134, 23);
            this.tbConsumo.TabIndex = 5;
            this.tbConsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbConsumo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Emision (gr/Km)";
            // 
            // cbCombustible
            // 
            this.cbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCombustible.FormattingEnabled = true;
            this.cbCombustible.Location = new System.Drawing.Point(139, 151);
            this.cbCombustible.Name = "cbCombustible";
            this.cbCombustible.Size = new System.Drawing.Size(134, 23);
            this.cbCombustible.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Combustible";
            // 
            // cbTipoVehiculo
            // 
            this.cbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoVehiculo.FormattingEnabled = true;
            this.cbTipoVehiculo.Items.AddRange(new object[] {
            "Camion 3/4",
            "Camion Simple",
            "Camion Articulado"});
            this.cbTipoVehiculo.Location = new System.Drawing.Point(139, 65);
            this.cbTipoVehiculo.Name = "cbTipoVehiculo";
            this.cbTipoVehiculo.Size = new System.Drawing.Size(134, 23);
            this.cbTipoVehiculo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Vehiculo";
            // 
            // tbCapacidad
            // 
            this.tbCapacidad.Location = new System.Drawing.Point(139, 108);
            this.tbCapacidad.Name = "tbCapacidad";
            this.tbCapacidad.Size = new System.Drawing.Size(134, 23);
            this.tbCapacidad.TabIndex = 3;
            this.tbCapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCapacidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capacidad Total (KG)";
            // 
            // tbPatente
            // 
            this.tbPatente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPatente.Location = new System.Drawing.Point(139, 22);
            this.tbPatente.MaxLength = 6;
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(134, 23);
            this.tbPatente.TabIndex = 1;
            // 
            // lbPatente
            // 
            this.lbPatente.AutoSize = true;
            this.lbPatente.Location = new System.Drawing.Point(6, 25);
            this.lbPatente.Name = "lbPatente";
            this.lbPatente.Size = new System.Drawing.Size(47, 15);
            this.lbPatente.TabIndex = 0;
            this.lbPatente.Text = "Patente";
            // 
            // btEliminar
            // 
            this.btEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btEliminar.Image")));
            this.btEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEliminar.Location = new System.Drawing.Point(12, 340);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(89, 41);
            this.btEliminar.TabIndex = 7;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Image = global::Reciclaje.Properties.Resources.repairing32;
            this.btModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btModificar.Location = new System.Drawing.Point(107, 340);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(89, 41);
            this.btModificar.TabIndex = 8;
            this.btModificar.Text = "Modificar";
            this.btModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btGuardar.Image")));
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardar.Location = new System.Drawing.Point(202, 340);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(89, 41);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btAgregar.Image")));
            this.btAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAgregar.Location = new System.Drawing.Point(12, 12);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(118, 40);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Nuevo";
            this.btAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // lvVehiculos
            // 
            this.lvVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVehiculos.HideSelection = false;
            this.lvVehiculos.Location = new System.Drawing.Point(11, 12);
            this.lvVehiculos.Name = "lvVehiculos";
            this.lvVehiculos.Size = new System.Drawing.Size(455, 369);
            this.lvVehiculos.TabIndex = 0;
            this.lvVehiculos.UseCompatibleStateImageBehavior = false;
            this.lvVehiculos.SelectedIndexChanged += new System.EventHandler(this.lvVehiculos_SelectedIndexChanged);
            this.lvVehiculos.Click += new System.EventHandler(this.lvVehiculos_Click);
            // 
            // fmIngresoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 393);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fmIngresoVehiculo";
            this.Text = "Vehiculo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.ListView lvVehiculos;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.Label lbPatente;
        private System.Windows.Forms.TextBox tbCapacidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbConsumo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCombustible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.TextBox tbEmision;
        private System.Windows.Forms.Label lbConsumoE;
    }
}