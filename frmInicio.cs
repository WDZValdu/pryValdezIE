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
            objBD = new clsInicioSesion();
            objBD.ConectarBD();
            objLog = new clsLog();


        }
        Int32 contador = 0;

        
        private void btnProveedores_Click(object sender, EventArgs e)
        {
           string varUsuario = txtUsuario.Text; // Asigna el valor de varUsuario         
           string varAccion = "Inicio Sesion";
           DateTime varFecha = DateTime.Now;

            //this.Hide();
            objBD.IngresarUsuario(txtUsuario.Text, txtContraseña.Text, this);
            objLog.CargarLog(varUsuario, varFecha, varAccion);


            /*if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
            {
                this.Hide();
                objBD.IngresarUsuario(txtUsuario.Text, txtContraseña.Text);
                

            }
            else
            {
                MessageBox.Show("Datos de inicio de sesion incorrectos");
                contador += 1;

            }
            
            if (contador >= 3) 
            {
                MessageBox.Show("Demaciados intentos de inicio de sesion, el sistema se cerrara");          
                Application.Exit();
            }*/
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
    }
}
