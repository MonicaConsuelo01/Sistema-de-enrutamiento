
namespace Reciclaje.Interfaz
{
    partial class frInformes
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lvResultado = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNombreConductor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTipoVehiculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkMaterial = new System.Windows.Forms.CheckBox();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkConductor = new System.Windows.Forms.CheckBox();
            this.checkVehiculo = new System.Windows.Forms.CheckBox();
            this.cbConductor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.datePickFin = new System.Windows.Forms.DateTimePicker();
            this.datePickInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.lvResultado);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 368);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lvResultado
            // 
            this.lvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvResultado.HideSelection = false;
            this.lvResultado.Location = new System.Drawing.Point(3, 3);
            this.lvResultado.Name = "lvResultado";
            this.lvResultado.Size = new System.Drawing.Size(897, 360);
            this.lvResultado.TabIndex = 0;
            this.lvResultado.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tbNombreConductor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbTipoVehiculo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkMaterial);
            this.panel1.Controls.Add(this.cbMaterial);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkConductor);
            this.panel1.Controls.Add(this.checkVehiculo);
            this.panel1.Controls.Add(this.cbConductor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbVehiculo);
            this.panel1.Controls.Add(this.datePickFin);
            this.panel1.Controls.Add(this.datePickInicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btBuscar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 104);
            this.panel1.TabIndex = 1;
            // 
            // tbNombreConductor
            // 
            this.tbNombreConductor.Location = new System.Drawing.Point(426, 71);
            this.tbNombreConductor.Name = "tbNombreConductor";
            this.tbNombreConductor.ReadOnly = true;
            this.tbNombreConductor.Size = new System.Drawing.Size(237, 23);
            this.tbNombreConductor.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nombre";
            // 
            // tbTipoVehiculo
            // 
            this.tbTipoVehiculo.Location = new System.Drawing.Point(87, 71);
            this.tbTipoVehiculo.Name = "tbTipoVehiculo";
            this.tbTipoVehiculo.ReadOnly = true;
            this.tbTipoVehiculo.Size = new System.Drawing.Size(155, 23);
            this.tbTipoVehiculo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo Vehiculo";
            // 
            // checkMaterial
            // 
            this.checkMaterial.AutoSize = true;
            this.checkMaterial.Checked = true;
            this.checkMaterial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMaterial.Location = new System.Drawing.Point(606, 11);
            this.checkMaterial.Name = "checkMaterial";
            this.checkMaterial.Size = new System.Drawing.Size(57, 19);
            this.checkMaterial.TabIndex = 13;
            this.checkMaterial.Text = "Todos";
            this.checkMaterial.UseVisualStyleBackColor = true;
            // 
            // cbMaterial
            // 
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(426, 9);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(174, 23);
            this.cbMaterial.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Material";
            // 
            // checkConductor
            // 
            this.checkConductor.AutoSize = true;
            this.checkConductor.Checked = true;
            this.checkConductor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkConductor.Location = new System.Drawing.Point(606, 39);
            this.checkConductor.Name = "checkConductor";
            this.checkConductor.Size = new System.Drawing.Size(57, 19);
            this.checkConductor.TabIndex = 10;
            this.checkConductor.Text = "Todos";
            this.checkConductor.UseVisualStyleBackColor = true;
            // 
            // checkVehiculo
            // 
            this.checkVehiculo.AutoSize = true;
            this.checkVehiculo.Checked = true;
            this.checkVehiculo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkVehiculo.Location = new System.Drawing.Point(248, 40);
            this.checkVehiculo.Name = "checkVehiculo";
            this.checkVehiculo.Size = new System.Drawing.Size(57, 19);
            this.checkVehiculo.TabIndex = 9;
            this.checkVehiculo.Text = "Todos";
            this.checkVehiculo.UseVisualStyleBackColor = true;
            // 
            // cbConductor
            // 
            this.cbConductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConductor.FormattingEnabled = true;
            this.cbConductor.Location = new System.Drawing.Point(426, 37);
            this.cbConductor.Name = "cbConductor";
            this.cbConductor.Size = new System.Drawing.Size(174, 23);
            this.cbConductor.TabIndex = 8;
            this.cbConductor.SelectedIndexChanged += new System.EventHandler(this.cbConductor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Conductor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vehiculo";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(87, 38);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(155, 23);
            this.cbVehiculo.TabIndex = 5;
            this.cbVehiculo.SelectedIndexChanged += new System.EventHandler(this.cbVehiculo_SelectedIndexChanged);
            // 
            // datePickFin
            // 
            this.datePickFin.CustomFormat = "yyyy/MM/dd";
            this.datePickFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickFin.Location = new System.Drawing.Point(262, 6);
            this.datePickFin.Name = "datePickFin";
            this.datePickFin.Size = new System.Drawing.Size(92, 23);
            this.datePickFin.TabIndex = 4;
            // 
            // datePickInicio
            // 
            this.datePickInicio.CustomFormat = "yyyy/MM/dd";
            this.datePickInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickInicio.Location = new System.Drawing.Point(87, 6);
            this.datePickInicio.Name = "datePickInicio";
            this.datePickInicio.Size = new System.Drawing.Size(92, 23);
            this.datePickInicio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Inicio";
            // 
            // btBuscar
            // 
            this.btBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btBuscar.Location = new System.Drawing.Point(693, 0);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(207, 104);
            this.btBuscar.TabIndex = 0;
            this.btBuscar.Text = "BUSCAR";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // frInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frInformes";
            this.Text = "Informes";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DateTimePicker datePickInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkConductor;
        private System.Windows.Forms.CheckBox checkVehiculo;
        private System.Windows.Forms.ComboBox cbConductor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.DateTimePicker datePickFin;
        private System.Windows.Forms.ListView lvResultado;
        private System.Windows.Forms.CheckBox checkMaterial;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombreConductor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTipoVehiculo;
        private System.Windows.Forms.Label label6;
    }
}