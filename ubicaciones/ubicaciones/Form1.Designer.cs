namespace ubicaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.mapa = new GMap.NET.WindowsForms.GMapControl();
            this.grupo1 = new System.Windows.Forms.Button();
            this.grupo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(623, 603);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // mapa
            // 
            this.mapa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mapa.Bearing = 0F;
            this.mapa.CanDragMap = true;
            this.mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapa.GrayScaleMode = false;
            this.mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapa.LevelsKeepInMemmory = 5;
            this.mapa.Location = new System.Drawing.Point(21, 25);
            this.mapa.MarkersEnabled = true;
            this.mapa.MaxZoom = 2;
            this.mapa.MinZoom = 2;
            this.mapa.MouseWheelZoomEnabled = true;
            this.mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapa.Name = "mapa";
            this.mapa.NegativeMode = false;
            this.mapa.PolygonsEnabled = true;
            this.mapa.RetryLoadTile = 0;
            this.mapa.RoutesEnabled = true;
            this.mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapa.ShowTileGridLines = false;
            this.mapa.Size = new System.Drawing.Size(569, 566);
            this.mapa.TabIndex = 1;
            this.mapa.Zoom = 0D;
            // 
            // grupo1
            // 
            this.grupo1.Location = new System.Drawing.Point(926, 12);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(130, 23);
            this.grupo1.TabIndex = 2;
            this.grupo1.Text = "cargar grupo 1";
            this.grupo1.UseVisualStyleBackColor = true;
            this.grupo1.Click += new System.EventHandler(this.act_Click);
            // 
            // grupo2
            // 
            this.grupo2.Location = new System.Drawing.Point(926, 66);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(130, 23);
            this.grupo2.TabIndex = 3;
            this.grupo2.Text = "cargar grupo 2";
            this.grupo2.UseVisualStyleBackColor = true;
            this.grupo2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 603);
            this.Controls.Add(this.grupo2);
            this.Controls.Add(this.grupo1);
            this.Controls.Add(this.mapa);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl mapa;
        private System.Windows.Forms.Button grupo1;
        private System.Windows.Forms.Button grupo2;
    }
}

