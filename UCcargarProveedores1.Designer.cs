namespace pryValdezIE
{
    partial class UCcargarProveedores1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BuscarCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.lblRuta = new System.Windows.Forms.Label();
            this.elipseUCCargarProveedores = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pctOkey = new System.Windows.Forms.PictureBox();
            this.pctCerrar = new System.Windows.Forms.PictureBox();
            this.txtNombreArchivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGuardarArchivo = new Guna.UI2.WinForms.Guna2Button();
            this.btnElegirCarpeta = new Guna.UI2.WinForms.Guna2Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pnlOkey = new System.Windows.Forms.Panel();
            this.elipsePanel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnCargarProv = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctOkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).BeginInit();
            this.pnlOkey.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.lblRuta.Location = new System.Drawing.Point(20, 98);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(133, 16);
            this.lblRuta.TabIndex = 3;
            this.lblRuta.Text = "Ruta seleccionada:";
            // 
            // elipseUCCargarProveedores
            // 
            this.elipseUCCargarProveedores.BorderRadius = 22;
            this.elipseUCCargarProveedores.TargetControl = this;
            // 
            // pctOkey
            // 
            this.pctOkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.pctOkey.Image = global::pryValdezIE.Properties.Resources.comprobado;
            this.pctOkey.Location = new System.Drawing.Point(126, 25);
            this.pctOkey.Name = "pctOkey";
            this.pctOkey.Size = new System.Drawing.Size(317, 279);
            this.pctOkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctOkey.TabIndex = 6;
            this.pctOkey.TabStop = false;
            this.pctOkey.Visible = false;
            // 
            // pctCerrar
            // 
            this.pctCerrar.Image = global::pryValdezIE.Properties.Resources.xCeleste;
            this.pctCerrar.Location = new System.Drawing.Point(773, 6);
            this.pctCerrar.Name = "pctCerrar";
            this.pctCerrar.Size = new System.Drawing.Size(17, 27);
            this.pctCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCerrar.TabIndex = 5;
            this.pctCerrar.TabStop = false;
            this.pctCerrar.Click += new System.EventHandler(this.pctCerrar_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.AutoRoundedCorners = true;
            this.txtNombreArchivo.BorderRadius = 15;
            this.txtNombreArchivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreArchivo.DefaultText = "";
            this.txtNombreArchivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreArchivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreArchivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreArchivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreArchivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreArchivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreArchivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreArchivo.IconLeft = global::pryValdezIE.Properties.Resources.lapiz__2_;
            this.txtNombreArchivo.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtNombreArchivo.Location = new System.Drawing.Point(16, 133);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.PasswordChar = '\0';
            this.txtNombreArchivo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNombreArchivo.PlaceholderText = "Nombre del Archivo";
            this.txtNombreArchivo.SelectedText = "";
            this.txtNombreArchivo.Size = new System.Drawing.Size(205, 33);
            this.txtNombreArchivo.TabIndex = 4;
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarArchivo.BorderColor = System.Drawing.Color.Transparent;
            this.btnGuardarArchivo.BorderRadius = 22;
            this.btnGuardarArchivo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarArchivo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarArchivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarArchivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarArchivo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnGuardarArchivo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarArchivo.Image = global::pryValdezIE.Properties.Resources.documento;
            this.btnGuardarArchivo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGuardarArchivo.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnGuardarArchivo.Location = new System.Drawing.Point(16, 179);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(205, 43);
            this.btnGuardarArchivo.TabIndex = 2;
            this.btnGuardarArchivo.Text = "Guardar Archivo";
            this.btnGuardarArchivo.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnElegirCarpeta
            // 
            this.btnElegirCarpeta.BorderRadius = 22;
            this.btnElegirCarpeta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnElegirCarpeta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnElegirCarpeta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnElegirCarpeta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnElegirCarpeta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnElegirCarpeta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirCarpeta.ForeColor = System.Drawing.Color.White;
            this.btnElegirCarpeta.Image = global::pryValdezIE.Properties.Resources.files_and_folder;
            this.btnElegirCarpeta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnElegirCarpeta.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnElegirCarpeta.Location = new System.Drawing.Point(16, 45);
            this.btnElegirCarpeta.Name = "btnElegirCarpeta";
            this.btnElegirCarpeta.Size = new System.Drawing.Size(205, 43);
            this.btnElegirCarpeta.TabIndex = 1;
            this.btnElegirCarpeta.Text = "Seleccione una carpeta";
            this.btnElegirCarpeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnElegirCarpeta.Click += new System.EventHandler(this.btnElegirCarpeta_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(126, 321);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(317, 144);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Visible = false;
            // 
            // pnlOkey
            // 
            this.pnlOkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.pnlOkey.Controls.Add(this.lblResultado);
            this.pnlOkey.Controls.Add(this.pctOkey);
            this.pnlOkey.Location = new System.Drawing.Point(237, 92);
            this.pnlOkey.Name = "pnlOkey";
            this.pnlOkey.Size = new System.Drawing.Size(559, 490);
            this.pnlOkey.TabIndex = 8;
            this.pnlOkey.Visible = false;
            // 
            // elipsePanel
            // 
            this.elipsePanel.BorderRadius = 22;
            this.elipsePanel.TargetControl = this.pnlOkey;
            // 
            // btnCargarProv
            // 
            this.btnCargarProv.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarProv.BorderRadius = 22;
            this.btnCargarProv.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCargarProv.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCargarProv.CheckedState.Image = global::pryValdezIE.Properties.Resources.contrato__1_;
            this.btnCargarProv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargarProv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargarProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargarProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargarProv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCargarProv.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCargarProv.ForeColor = System.Drawing.Color.White;
            this.btnCargarProv.Image = global::pryValdezIE.Properties.Resources.contrato;
            this.btnCargarProv.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCargarProv.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCargarProv.Location = new System.Drawing.Point(16, 536);
            this.btnCargarProv.Name = "btnCargarProv";
            this.btnCargarProv.Size = new System.Drawing.Size(205, 43);
            this.btnCargarProv.TabIndex = 10;
            this.btnCargarProv.Text = "Volver a cargar";
            this.btnCargarProv.TextOffset = new System.Drawing.Point(5, 0);
            this.btnCargarProv.UseTransparentBackground = true;
            this.btnCargarProv.Click += new System.EventHandler(this.btnCargarProv_Click);
            // 
            // UCcargarProveedores1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCargarProv);
            this.Controls.Add(this.pnlOkey);
            this.Controls.Add(this.pctCerrar);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnElegirCarpeta);
            this.Controls.Add(this.btnGuardarArchivo);
            this.Location = new System.Drawing.Point(0, 5);
            this.Name = "UCcargarProveedores1";
            this.Size = new System.Drawing.Size(802, 588);
            ((System.ComponentModel.ISupportInitialize)(this.pctOkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).EndInit();
            this.pnlOkey.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnElegirCarpeta;
        private Guna.UI2.WinForms.Guna2Button btnGuardarArchivo;
        private System.Windows.Forms.FolderBrowserDialog BuscarCarpeta;
        private System.Windows.Forms.Label lblRuta;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreArchivo;
        private Guna.UI2.WinForms.Guna2Elipse elipseUCCargarProveedores;
        private System.Windows.Forms.PictureBox pctCerrar;
        private System.Windows.Forms.PictureBox pctOkey;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel pnlOkey;
        private Guna.UI2.WinForms.Guna2Elipse elipsePanel;
        private Guna.UI2.WinForms.Guna2Button btnCargarProv;
    }
}
