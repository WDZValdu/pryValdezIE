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
    public partial class UCSocios : UserControl
    {
        clsBDSocios objBD;
        public UCSocios()
        {
            InitializeComponent();
            objBD = new clsBDSocios();
            objBD.ConectarBD();

            lblConectado.Text = objBD.EstadoConexion;
            lblConectado.BackColor = Color.Green;

            objBD.TraerDatos(grilla);
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            txtNumero.Visible = true;
            btnBuscar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try 
            {
                objBD.BuscarPorID(int.Parse(txtNumero.Text), grilla);               

            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero");
            }
        }

    }
}
