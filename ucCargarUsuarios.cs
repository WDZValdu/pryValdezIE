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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryValdezIE
{
    public partial class ucCargarUsuarios : UserControl
    {
        clsLog log;
        public ucCargarUsuarios()
        {
            InitializeComponent();
            clsLog log = new clsLog();          
            log.CargarLst(lstPerfil);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            UCUsuarios uCUsuarios = new UCUsuarios();
            this.Hide();
            uCUsuarios.Show();
        }

        private void btnCargarUsuario_Click(object sender, EventArgs e)
        {
            lstPerfil.SelectedIndex = 0;
            log.NuevoUsuario(txtUsuario.Text, txtContraseña.Text, lstPerfil.Text);
        }
    }
}
