using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace pryValdezIE
{
    using System.IO;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            this.pnlPrincipal.Controls.Clear();
            UCProveedores uCProveedores = new UCProveedores();
            this.pnlPrincipal.Controls.Add(uCProveedores);
            uCProveedores.Show();
            pctBordeProv.Visible = true;
            pctBordeCargarProv.Visible = false;
            btnProveedores.Checked = true;
            btnCargarProv.Checked = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCargarProv_Click(object sender, EventArgs e)
        {
            this.pnlPrincipal.Controls.Clear();
            UCcargarProveedores1 uCcargarProveedores = new UCcargarProveedores1();
            this.pnlPrincipal.Controls.Add(uCcargarProveedores);
            uCcargarProveedores.Show();
            pctBordeProv.Visible = false;

            pctBordeCargarProv.Visible =true;
            btnProveedores.Checked = false;
            btnCargarProv.Checked = true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }
    }
}
