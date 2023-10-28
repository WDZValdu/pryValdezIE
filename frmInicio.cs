using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValdezIE
{
    public partial class frmInicio : Form
    {
        clsInicioSesion objBD;
        clsLog objLog;
        public frmInicio()
        {
            InitializeComponent();
            txtUsuario.Focus();
            objBD = new clsInicioSesion();
            objBD.ConectarBD();
            objLog = new clsLog();
            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
            

        }
        Int32 contador = 0;
        private void CerrarFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Cierra la aplicación completa
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {                     
            objBD.IngresarUsuario(txtUsuario.Text, txtContraseña.Text, this);
        }

        private void linklblOlvidadoCont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contraseña: admin");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Usuario: admin");
        }

        private void pctX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && e.KeyChar == 13)
            {
                txtContraseña.Focus();
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && e.KeyChar == 13)
            {
                btnIniciarSesion_Click(sender, e);
                e.Handled = true;
            }
        }

        
    }
}
