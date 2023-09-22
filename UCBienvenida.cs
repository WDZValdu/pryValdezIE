using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValdezIE
{
    public partial class UCBienvenida : UserControl
    {
        public UCBienvenida()
        {
            InitializeComponent();
            lblContenido.Text = "Aquí podrá gestionar sus proveedores y usuarios de forma fácil y rápida. \nEsperamos que disfrute de nuestro servicio. ";

        }

        private void pctCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
