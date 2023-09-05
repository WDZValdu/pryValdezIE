namespace pryValdezIE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.btnCargarProv = new Guna.UI2.WinForms.Guna2Button();
            this.pctBordeCargarProv = new System.Windows.Forms.PictureBox();
            this.btnProveedores = new Guna.UI2.WinForms.Guna2Button();
            this.pctBordeProv = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBordeCargarProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBordeProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnCargarProv);
            this.pnlMenu.Controls.Add(this.pctBordeCargarProv);
            this.pnlMenu.Controls.Add(this.btnProveedores);
            this.pnlMenu.Controls.Add(this.pctBordeProv);
            this.pnlMenu.Controls.Add(this.pctLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(209, 598);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pictureBox2);
            this.pnlPrincipal.Controls.Add(this.pictureBox1);
            this.pnlPrincipal.Location = new System.Drawing.Point(206, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(807, 598);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 22;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pryValdezIE.Properties.Resources.x;
            this.pictureBox2.Location = new System.Drawing.Point(774, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryValdezIE.Properties.Resources.menos;
            this.pictureBox1.Location = new System.Drawing.Point(734, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BorderRadius = 22;
            this.btnCerrarSesion.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCerrarSesion.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCerrarSesion.CheckedState.Image = global::pryValdezIE.Properties.Resources.contrato__1_;
            this.btnCerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::pryValdezIE.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCerrarSesion.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnCerrarSesion.Location = new System.Drawing.Point(10, 533);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(188, 43);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.TextOffset = new System.Drawing.Point(10, 0);
            this.btnCerrarSesion.UseTransparentBackground = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
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
            this.btnCargarProv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarProv.ForeColor = System.Drawing.Color.White;
            this.btnCargarProv.Image = global::pryValdezIE.Properties.Resources.contrato;
            this.btnCargarProv.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCargarProv.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCargarProv.Location = new System.Drawing.Point(10, 214);
            this.btnCargarProv.Name = "btnCargarProv";
            this.btnCargarProv.Size = new System.Drawing.Size(188, 43);
            this.btnCargarProv.TabIndex = 0;
            this.btnCargarProv.Text = "Cargar Proveedores";
            this.btnCargarProv.TextOffset = new System.Drawing.Point(17, 0);
            this.btnCargarProv.UseTransparentBackground = true;
            this.btnCargarProv.Click += new System.EventHandler(this.btnCargarProv_Click);
            // 
            // pctBordeCargarProv
            // 
            this.pctBordeCargarProv.Image = global::pryValdezIE.Properties.Resources.Union;
            this.pctBordeCargarProv.Location = new System.Drawing.Point(169, 181);
            this.pctBordeCargarProv.Name = "pctBordeCargarProv";
            this.pctBordeCargarProv.Size = new System.Drawing.Size(38, 106);
            this.pctBordeCargarProv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBordeCargarProv.TabIndex = 2;
            this.pctBordeCargarProv.TabStop = false;
            this.pctBordeCargarProv.Visible = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.BorderRadius = 22;
            this.btnProveedores.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnProveedores.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnProveedores.CheckedState.Image = global::pryValdezIE.Properties.Resources.dos_personas__1_;
            this.btnProveedores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProveedores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProveedores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProveedores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProveedores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = global::pryValdezIE.Properties.Resources.dos_personas;
            this.btnProveedores.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProveedores.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnProveedores.Location = new System.Drawing.Point(10, 138);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(188, 43);
            this.btnProveedores.TabIndex = 0;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseTransparentBackground = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // pctBordeProv
            // 
            this.pctBordeProv.Image = global::pryValdezIE.Properties.Resources.Union;
            this.pctBordeProv.Location = new System.Drawing.Point(168, 105);
            this.pctBordeProv.Name = "pctBordeProv";
            this.pctBordeProv.Size = new System.Drawing.Size(38, 106);
            this.pctBordeProv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBordeProv.TabIndex = 1;
            this.pctBordeProv.TabStop = false;
            this.pctBordeProv.Visible = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::pryValdezIE.Properties.Resources.sancoseg;
            this.pctLogo.Location = new System.Drawing.Point(0, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(179, 50);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1013, 598);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlMenu.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBordeCargarProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBordeProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Panel pnlPrincipal;
        private Guna.UI2.WinForms.Guna2Button btnProveedores;
        private System.Windows.Forms.PictureBox pctBordeProv;
        private Guna.UI2.WinForms.Guna2Button btnCargarProv;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pctBordeCargarProv;
        private Guna.UI2.WinForms.Guna2Button btnCerrarSesion;
    }
}

