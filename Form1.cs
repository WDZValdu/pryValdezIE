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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Crea una instancia del UserControl que deseas mostrar en el Panel
            UCProveedores UCProveedores = new UCProveedores();

            // Agrega el UserControl al Panel
            pnlPrincipal.Controls.Add(UCProveedores);

            // Calcula la posición para centrar el UserControl
            int x = (pnlPrincipal.Width - UCProveedores.Width) / 2;
            int y = (pnlPrincipal.Height - UCProveedores.Height) / 25;

            // Establece la posición del UserControl en el centro del Panel
            UCProveedores.Location = new Point(x, y);
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
        }
    }
}
