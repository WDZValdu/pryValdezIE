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
using System.IO;

namespace pryValdezIE
{
    public partial class ucCargarUsuarios : UserControl
    {
        clsLog log;
        clsCargarUsuario objCU;
        public ucCargarUsuarios()
        {
            InitializeComponent();
            clsLog log = new clsLog();
            log.CargarLst(lstPerfil);
            lstPerfil.SelectedIndex= 1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal.Volver();
            //this.Hide();
                        
        }
        string varCat;
        private void btnCargarUsuario_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Los campos Usuario y Contraseña no pueden estar vacios");

            }
            else
            {
                clsCargarUsuario objCU = new clsCargarUsuario();
                string lst;
                lst=lstPerfil.SelectedValue.ToString();

                objCU.CompararUsuario(txtUsuario.Text, txtContraseña.Text, Convert.ToInt32(lst));
                txtUsuario.Text ="";
                txtContraseña.Text= "";

            }
           
            
        }
    }
}
