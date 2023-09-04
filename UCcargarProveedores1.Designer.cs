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
            this.btnElegirCarpeta = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardarArchivo = new Guna.UI2.WinForms.Guna2Button();
            this.BuscarCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
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
            this.btnElegirCarpeta.Location = new System.Drawing.Point(16, 34);
            this.btnElegirCarpeta.Name = "btnElegirCarpeta";
            this.btnElegirCarpeta.Size = new System.Drawing.Size(205, 43);
            this.btnElegirCarpeta.TabIndex = 1;
            this.btnElegirCarpeta.Text = "Seleccione una carpeta";
            this.btnElegirCarpeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnElegirCarpeta.Click += new System.EventHandler(this.btnElegirCarpeta_Click);
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.BorderRadius = 22;
            this.btnGuardarArchivo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarArchivo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarArchivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarArchivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarArchivo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnGuardarArchivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarArchivo.Image = global::pryValdezIE.Properties.Resources.files_and_folder;
            this.btnGuardarArchivo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGuardarArchivo.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnGuardarArchivo.Location = new System.Drawing.Point(16, 188);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(205, 43);
            this.btnGuardarArchivo.TabIndex = 2;
            this.btnGuardarArchivo.Text = "Guardar Archivo";
            this.btnGuardarArchivo.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(27, 100);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(96, 13);
            this.lblRuta.TabIndex = 3;
            this.lblRuta.Text = "Ruta seleccionada";
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
            this.txtNombreArchivo.IconLeft = global::pryValdezIE.Properties.Resources.Lupa;
            this.txtNombreArchivo.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtNombreArchivo.Location = new System.Drawing.Point(16, 149);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.PasswordChar = '\0';
            this.txtNombreArchivo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNombreArchivo.PlaceholderText = "Nombre del Archivo";
            this.txtNombreArchivo.SelectedText = "";
            this.txtNombreArchivo.Size = new System.Drawing.Size(205, 33);
            this.txtNombreArchivo.TabIndex = 4;
            // 
            // UCcargarProveedores1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnGuardarArchivo);
            this.Controls.Add(this.btnElegirCarpeta);
            this.Name = "UCcargarProveedores1";
            this.Size = new System.Drawing.Size(807, 598);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnElegirCarpeta;
        private Guna.UI2.WinForms.Guna2Button btnGuardarArchivo;
        private System.Windows.Forms.FolderBrowserDialog BuscarCarpeta;
        private System.Windows.Forms.Label lblRuta;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreArchivo;
    }
}
