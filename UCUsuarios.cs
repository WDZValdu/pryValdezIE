using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Web.UI.WebControls.WebParts;

namespace pryValdezIE
{
    public partial class UCUsuarios : UserControl
    {
        clsUsuarios objBD;
        public UCUsuarios()
        {
            InitializeComponent();
            objBD = new clsUsuarios();
            this.Show();
            objBD.ConectarBD();
            objBD.TraerDatos(grilla);
            
        }
        

        private void btnFiltrar_Click(object sender, EventArgs e)
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

        private void btnCargarUsuario_Click(object sender, EventArgs e)
        {
            frmPrincipal.CargarUsuarios();    
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter) && e.KeyChar == 13)
            {
                btnBuscar_Click(sender, e);
                e.Handled = true;
                
            }
        }
    }
}
