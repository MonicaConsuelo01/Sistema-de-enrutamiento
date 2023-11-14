
namespace Reciclaje
{
    partial class fmCrearRuta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCrearRuta));
            this.cbRutas = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRuta = new System.Windows.Forms.Button();
            this.tbCapacidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNombreConductor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.lbMaterial = new System.Windows.Forms.Label();
            this.btSimular = new System.Windows.Forms.Button();
            this.lbFecha = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btConductor = new System.Windows.Forms.Button();
            this.tbParadas = new System.Windows.Forms.TextBox();
            this.btVehiculo = new System.Windows.Forms.Button();
            this.cbConductor = new System.Windows.Forms.ComboBox();
            this.lbConductor = new System.Windows.Forms.Label();
            this.cbVehiculos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRuta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDistanciaRuta = new System.Windows.Forms.TextBox();
            this.tbTiempoAproxSin = new System.Windows.Forms.TextBox();
            this.tbTipoVehiculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRecolectado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHuellaCarbon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.tbEmisionTotal = new System.Windows.Forms.TextBox();
            this.tbDistanciaRecorrida = new System.Windows.Forms.TextBox();
            this.tbTiempoAproxCon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRutas
            // 
            this.cbRutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRutas.FormattingEnabled = true;
            this.cbRutas.Location = new System.Drawing.Point(99, 58);
            this.cbRutas.Name = "cbRutas";
            this.cbRutas.Size = new System.Drawing.Size(193, 23);
            this.cbRutas.TabIndex = 1;
            this.cbRutas.SelectedIndexChanged += new System.EventHandler(this.cbRutas_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRuta);
            this.groupBox1.Controls.Add(this.tbCapacidad);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbNombreConductor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btLimpiar);
            this.groupBox1.Controls.Add(this.cbMaterial);
            this.groupBox1.Controls.Add(this.lbMaterial);
            this.groupBox1.Controls.Add(this.btSimular);
            this.groupBox1.Controls.Add(this.lbFecha);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.btConductor);
            this.groupBox1.Controls.Add(this.tbParadas);
            this.groupBox1.Controls.Add(this.btVehiculo);
            this.groupBox1.Controls.Add(this.cbConductor);
            this.groupBox1.Controls.Add(this.lbConductor);
            this.groupBox1.Controls.Add(this.cbVehiculos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbRuta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbRutas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 401);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorrido";
            // 
            // btRuta
            // 
            this.btRuta.Location = new System.Drawing.Point(298, 58);
            this.btRuta.Name = "btRuta";
            this.btRuta.Size = new System.Drawing.Size(28, 23);
            this.btRuta.TabIndex = 17;
            this.btRuta.Text = "...";
            this.btRuta.UseVisualStyleBackColor = true;
            this.btRuta.Click += new System.EventHandler(this.btRuta_Click);
            // 
            // tbCapacidad
            // 
            this.tbCapacidad.Location = new System.Drawing.Point(99, 214);
            this.tbCapacidad.Name = "tbCapacidad";
            this.tbCapacidad.ReadOnly = true;
            this.tbCapacidad.Size = new System.Drawing.Size(227, 23);
            this.tbCapacidad.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Capacidad(KG)";
            // 
            // tbNombreConductor
            // 
            this.tbNombreConductor.Location = new System.Drawing.Point(99, 292);
            this.tbNombreConductor.Name = "tbNombreConductor";
            this.tbNombreConductor.ReadOnly = true;
            this.tbNombreConductor.Size = new System.Drawing.Size(227, 23);
            this.tbNombreConductor.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nombre";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(0, 334);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(126, 53);
            this.btLimpiar.TabIndex = 12;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            // 
            // cbMaterial
            // 
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(101, 136);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(227, 23);
            this.cbMaterial.TabIndex = 2;
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(7, 139);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(50, 15);
            this.lbMaterial.TabIndex = 11;
            this.lbMaterial.Text = "Material";
            // 
            // btSimular
            // 
            this.btSimular.Location = new System.Drawing.Point(200, 334);
            this.btSimular.Name = "btSimular";
            this.btSimular.Size = new System.Drawing.Size(126, 53);
            this.btSimular.TabIndex = 10;
            this.btSimular.Text = "Simular Ruta";
            this.btSimular.UseVisualStyleBackColor = true;
            this.btSimular.Click += new System.EventHandler(this.btSimular_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(8, 25);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(38, 15);
            this.lbFecha.TabIndex = 9;
            this.lbFecha.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "yyyy/MM/dd";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(99, 19);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(227, 23);
            this.dtFecha.TabIndex = 0;
            // 
            // btConductor
            // 
            this.btConductor.Location = new System.Drawing.Point(298, 252);
            this.btConductor.Name = "btConductor";
            this.btConductor.Size = new System.Drawing.Size(28, 23);
            this.btConductor.TabIndex = 7;
            this.btConductor.Text = "...";
            this.btConductor.UseVisualStyleBackColor = true;
            this.btConductor.Click += new System.EventHandler(this.btConductor_Click);
            // 
            // tbParadas
            // 
            this.tbParadas.Location = new System.Drawing.Point(99, 97);
            this.tbParadas.Name = "tbParadas";
            this.tbParadas.ReadOnly = true;
            this.tbParadas.Size = new System.Drawing.Size(227, 23);
            this.tbParadas.TabIndex = 8;
            this.tbParadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btVehiculo
            // 
            this.btVehiculo.Location = new System.Drawing.Point(298, 175);
            this.btVehiculo.Name = "btVehiculo";
            this.btVehiculo.Size = new System.Drawing.Size(28, 23);
            this.btVehiculo.TabIndex = 6;
            this.btVehiculo.Text = "...";
            this.btVehiculo.UseVisualStyleBackColor = true;
            this.btVehiculo.Click += new System.EventHandler(this.btVehiculo_Click);
            // 
            // cbConductor
            // 
            this.cbConductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConductor.FormattingEnabled = true;
            this.cbConductor.Location = new System.Drawing.Point(99, 253);
            this.cbConductor.Name = "cbConductor";
            this.cbConductor.Size = new System.Drawing.Size(193, 23);
            this.cbConductor.TabIndex = 4;
            this.cbConductor.SelectedIndexChanged += new System.EventHandler(this.cbConductor_SelectedIndexChanged);
            // 
            // lbConductor
            // 
            this.lbConductor.AutoSize = true;
            this.lbConductor.Location = new System.Drawing.Point(6, 256);
            this.lbConductor.Name = "lbConductor";
            this.lbConductor.Size = new System.Drawing.Size(85, 15);
            this.lbConductor.TabIndex = 4;
            this.lbConductor.Text = "Rut Conductor";
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculos.FormattingEnabled = true;
            this.cbVehiculos.Location = new System.Drawing.Point(99, 175);
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Size = new System.Drawing.Size(193, 23);
            this.cbVehiculos.TabIndex = 3;
            this.cbVehiculos.SelectedIndexChanged += new System.EventHandler(this.cbVehiculos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehiculo";
            // 
            // lbRuta
            // 
            this.lbRuta.AutoSize = true;
            this.lbRuta.Location = new System.Drawing.Point(8, 61);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(87, 15);
            this.lbRuta.TabIndex = 1;
            this.lbRuta.Text = "Seleccione ruta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Paradas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDistanciaRuta);
            this.groupBox2.Controls.Add(this.tbTiempoAproxSin);
            this.groupBox2.Controls.Add(this.tbTipoVehiculo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(361, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Ruta";
            // 
            // tbDistanciaRuta
            // 
            this.tbDistanciaRuta.Location = new System.Drawing.Point(94, 88);
            this.tbDistanciaRuta.Name = "tbDistanciaRuta";
            this.tbDistanciaRuta.ReadOnly = true;
            this.tbDistanciaRuta.Size = new System.Drawing.Size(282, 23);
            this.tbDistanciaRuta.TabIndex = 12;
            // 
            // tbTiempoAproxSin
            // 
            this.tbTiempoAproxSin.Location = new System.Drawing.Point(131, 55);
            this.tbTiempoAproxSin.Name = "tbTiempoAproxSin";
            this.tbTiempoAproxSin.ReadOnly = true;
            this.tbTiempoAproxSin.Size = new System.Drawing.Size(245, 23);
            this.tbTiempoAproxSin.TabIndex = 10;
            // 
            // tbTipoVehiculo
            // 
            this.tbTipoVehiculo.Location = new System.Drawing.Point(90, 22);
            this.tbTipoVehiculo.Name = "tbTipoVehiculo";
            this.tbTipoVehiculo.ReadOnly = true;
            this.tbTipoVehiculo.Size = new System.Drawing.Size(286, 23);
            this.tbTipoVehiculo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Distancia Ruta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tiempo Aproximado ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo Vehiculo";
            // 
            // tbRecolectado
            // 
            this.tbRecolectado.Location = new System.Drawing.Point(156, 95);
            this.tbRecolectado.Name = "tbRecolectado";
            this.tbRecolectado.ReadOnly = true;
            this.tbRecolectado.Size = new System.Drawing.Size(220, 23);
            this.tbRecolectado.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cantidad Recolectada";
            // 
            // tbHuellaCarbon
            // 
            this.tbHuellaCarbon.Location = new System.Drawing.Point(113, 163);
            this.tbHuellaCarbon.Name = "tbHuellaCarbon";
            this.tbHuellaCarbon.ReadOnly = true;
            this.tbHuellaCarbon.Size = new System.Drawing.Size(263, 23);
            this.tbHuellaCarbon.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Emision CO₂ Total";
            // 
            // btGuardar
            // 
            this.btGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btGuardar.Image")));
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardar.Location = new System.Drawing.Point(617, 346);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(126, 53);
            this.btGuardar.TabIndex = 16;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbEmisionTotal
            // 
            this.tbEmisionTotal.Location = new System.Drawing.Point(156, 129);
            this.tbEmisionTotal.Name = "tbEmisionTotal";
            this.tbEmisionTotal.ReadOnly = true;
            this.tbEmisionTotal.Size = new System.Drawing.Size(220, 23);
            this.tbEmisionTotal.TabIndex = 15;
            // 
            // tbDistanciaRecorrida
            // 
            this.tbDistanciaRecorrida.Location = new System.Drawing.Point(120, 61);
            this.tbDistanciaRecorrida.Name = "tbDistanciaRecorrida";
            this.tbDistanciaRecorrida.ReadOnly = true;
            this.tbDistanciaRecorrida.Size = new System.Drawing.Size(256, 23);
            this.tbDistanciaRecorrida.TabIndex = 13;
            // 
            // tbTiempoAproxCon
            // 
            this.tbTiempoAproxCon.Location = new System.Drawing.Point(156, 27);
            this.tbTiempoAproxCon.Name = "tbTiempoAproxCon";
            this.tbTiempoAproxCon.ReadOnly = true;
            this.tbTiempoAproxCon.Size = new System.Drawing.Size(220, 23);
            this.tbTiempoAproxCon.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Consumo Energetico Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Distancia Recorrida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tiempo Aproximado Total";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbTiempoAproxCon);
            this.groupBox3.Controls.Add(this.tbRecolectado);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbHuellaCarbon);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbDistanciaRecorrida);
            this.groupBox3.Controls.Add(this.tbEmisionTotal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(361, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 199);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Recorrido";
            // 
            // fmCrearRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 419);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fmCrearRuta";
            this.Text = "Crear Ruta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRutas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.Button btSimular;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Button btConductor;
        private System.Windows.Forms.Button btVehiculo;
        private System.Windows.Forms.ComboBox cbConductor;
        private System.Windows.Forms.Label lbConductor;
        private System.Windows.Forms.ComboBox cbVehiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRuta;
        private System.Windows.Forms.TextBox tbNombreConductor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox tbEmisionTotal;
        private System.Windows.Forms.TextBox tbDistanciaRecorrida;
        private System.Windows.Forms.TextBox tbDistanciaRuta;
        private System.Windows.Forms.TextBox tbTiempoAproxCon;
        private System.Windows.Forms.TextBox tbTiempoAproxSin;
        private System.Windows.Forms.TextBox tbTipoVehiculo;
        private System.Windows.Forms.TextBox tbParadas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHuellaCarbon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCapacidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btRuta;
        private System.Windows.Forms.TextBox tbRecolectado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}