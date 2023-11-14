
namespace Reciclaje
{
    partial class Mapa
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkVuelta = new System.Windows.Forms.CheckBox();
            this.tbNombreR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTiempo = new System.Windows.Forms.TextBox();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.tbNombreRuta = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCrearRuta = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
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
            this.splitContainer1.Panel1.Controls.Add(this.checkVuelta);
            this.splitContainer1.Panel1.Controls.Add(this.tbNombreR);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tbTiempo);
            this.splitContainer1.Panel1.Controls.Add(this.tbDistancia);
            this.splitContainer1.Panel1.Controls.Add(this.btLimpiar);
            this.splitContainer1.Panel1.Controls.Add(this.tbNombreRuta);
            this.splitContainer1.Panel1.Controls.Add(this.btGuardar);
            this.splitContainer1.Panel1.Controls.Add(this.btCrearRuta);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gMapControl1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 0;
            // 
            // checkVuelta
            // 
            this.checkVuelta.AutoSize = true;
            this.checkVuelta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkVuelta.Location = new System.Drawing.Point(105, 175);
            this.checkVuelta.Name = "checkVuelta";
            this.checkVuelta.Size = new System.Drawing.Size(129, 19);
            this.checkVuelta.TabIndex = 24;
            this.checkVuelta.Text = "Finalizar en el inicio";
            this.checkVuelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkVuelta.UseVisualStyleBackColor = true;
            // 
            // tbNombreR
            // 
            this.tbNombreR.Location = new System.Drawing.Point(10, 40);
            this.tbNombreR.Name = "tbNombreR";
            this.tbNombreR.Size = new System.Drawing.Size(224, 23);
            this.tbNombreR.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tiempo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Distancia";
            // 
            // tbTiempo
            // 
            this.tbTiempo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTiempo.Location = new System.Drawing.Point(10, 361);
            this.tbTiempo.Name = "tbTiempo";
            this.tbTiempo.ReadOnly = true;
            this.tbTiempo.Size = new System.Drawing.Size(224, 27);
            this.tbTiempo.TabIndex = 20;
            // 
            // tbDistancia
            // 
            this.tbDistancia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDistancia.Location = new System.Drawing.Point(10, 306);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.ReadOnly = true;
            this.tbDistancia.Size = new System.Drawing.Size(224, 27);
            this.tbDistancia.TabIndex = 19;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLimpiar.Location = new System.Drawing.Point(10, 394);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(224, 44);
            this.btLimpiar.TabIndex = 8;
            this.btLimpiar.Text = "Limpiar Mapa";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // tbNombreRuta
            // 
            this.tbNombreRuta.AutoSize = true;
            this.tbNombreRuta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbNombreRuta.Location = new System.Drawing.Point(50, 9);
            this.tbNombreRuta.Name = "tbNombreRuta";
            this.tbNombreRuta.Size = new System.Drawing.Size(144, 21);
            this.tbNombreRuta.TabIndex = 2;
            this.tbNombreRuta.Text = "Identificador ruta";
            // 
            // btGuardar
            // 
            this.btGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btGuardar.Location = new System.Drawing.Point(10, 125);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(224, 44);
            this.btGuardar.TabIndex = 1;
            this.btGuardar.Text = "Guardar Ruta";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btCrearRuta
            // 
            this.btCrearRuta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCrearRuta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCrearRuta.Location = new System.Drawing.Point(10, 69);
            this.btCrearRuta.Name = "btCrearRuta";
            this.btCrearRuta.Size = new System.Drawing.Size(224, 44);
            this.btCrearRuta.TabIndex = 0;
            this.btCrearRuta.Text = "Vista Previa Ruta";
            this.btCrearRuta.UseVisualStyleBackColor = true;
            this.btCrearRuta.Click += new System.EventHandler(this.btCrearRuta_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.AutoSize = true;
            this.gMapControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(552, 450);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.OnMarkerClick);
            this.gMapControl1.OnRouteEnter += new GMap.NET.WindowsForms.RouteEnter(this.OnRouteEnter);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gMapControl1_KeyDown);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_DoubleClick);
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Mapa";
            this.Text = " ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btCrearRuta;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label tbNombreRuta;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTiempo;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.TextBox tbNombreR;
        private System.Windows.Forms.CheckBox checkVuelta;
    }
}