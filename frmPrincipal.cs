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
    public partial class frmPrincipal : Form
    {
        string varUsuario;
        clsLog objLog = new clsLog();
        public frmPrincipal(string usuario, string varCat)
        {
            InitializeComponent();
            this.pnlPrincipal.Controls.Clear();
            UCBienvenida uCBienvenida = new UCBienvenida();
            this.pnlPrincipal.Controls.Add(uCBienvenida);
            uCBienvenida.Show();
            varUsuario = usuario;

            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
            if (varCat =="Administrador")
            {
                btnCargarProv.Visible = true;
                btnProveedores.Visible = true;
                btnSocios.Visible = true;
                btnUsuarios.Visible = true;
            }
            else
            {
                btnCargarProv.Visible = true;
                btnProveedores.Visible = true;
                btnSocios.Visible = true;
                btnUsuarios.Visible = false;
            }

        }

        private void CerrarFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Cierra la aplicación completa

                string varAccion = "Cerro el programa (ESC)";
                DateTime varFecha = DateTime.Now;

                objLog.CargarLog(varUsuario, varFecha, varAccion);

            }
        }
                
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            
            string varAccion = "Ingreso a Proveedores";
            DateTime varFecha = DateTime.Now;

            objLog.CargarLog(varUsuario, varFecha, varAccion);

            this.pnlPrincipal.Controls.Clear();
            UCProveedores uCProveedores = new UCProveedores();
            this.pnlPrincipal.Controls.Add(uCProveedores);
            uCProveedores.Show();
            pctBordeProv.Visible = true;
            pctBordeCargarProv.Visible = false;
            btnProveedores.Checked = true;
            btnCargarProv.Checked = false;
            pctBordeBtnSocios.Visible = false;
            btnSocios.Checked = false;
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCargarProv_Click(object sender, EventArgs e)
        {

            string varAccion = "Ingreso a Cargar Proveedores";
            DateTime varFecha = DateTime.Now;

            objLog.CargarLog(varUsuario, varFecha, varAccion);

            this.pnlPrincipal.Controls.Clear();
            UCcargarProveedores1 uCcargarProveedores = new UCcargarProveedores1();
            this.pnlPrincipal.Controls.Add(uCcargarProveedores);
            uCcargarProveedores.Show();
            pctBordeProv.Visible = false;

            pctBordeCargarProv.Visible =true;
            btnProveedores.Checked = false;
            btnCargarProv.Checked = true;
            pctBordeBtnSocios.Visible = false;
            btnSocios.Checked = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            string varAccion = "Cerro sesion";
            DateTime varFecha = DateTime.Now;

            objLog.CargarLog(varUsuario, varFecha, varAccion);
            this.Hide();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }

        private void pctLogo_Click(object sender, EventArgs e)
        {

            this.pnlPrincipal.Controls.Clear();
            UCBienvenida uCBienvenida = new UCBienvenida();
            this.pnlPrincipal.Controls.Add(uCBienvenida);
            uCBienvenida.Show();
            
            pctBordeProv.Visible = false;

            pctBordeCargarProv.Visible = false;
            btnProveedores.Checked = false;
            btnCargarProv.Checked = false;
            pctBordeBtnSocios.Visible = false;
            btnSocios.Checked = false;

        }

        private void btnSocios_Click_1(object sender, EventArgs e)
        {
            string varAccion = "Ingreso a Socios";
            DateTime varFecha = DateTime.Now;

            objLog.CargarLog(varUsuario, varFecha, varAccion);

            this.pnlPrincipal.Controls.Clear();
            UCSocios uCSocios = new UCSocios();
            this.pnlPrincipal.Controls.Add(uCSocios);
            uCSocios.Show();
            pctBordeBtnSocios.Visible = true;
            btnSocios.Checked = true;
            
            pctBordeProv.Visible = false;

            pctBordeCargarProv.Visible = false;
            btnProveedores.Checked = false;
            btnCargarProv.Checked = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            string varAccion = "Ingreso a Usuarios";
            DateTime varFecha = DateTime.Now;

            objLog.CargarLog(varUsuario, varFecha, varAccion);

            this.pnlPrincipal.Controls.Clear();
            UCUsuarios uCUsuarios = new UCUsuarios();
            this.pnlPrincipal.Controls.Add(uCUsuarios);
            uCUsuarios.Show();
            btnSocios.Checked = true;
            
            
            pctBordeBtnSocios.Visible = false;
            btnSocios.Checked = false;

            pctBordeProv.Visible = false;

            pctBordeCargarProv.Visible = false;
            btnProveedores.Checked = false;
            btnCargarProv.Checked = false;
        }
    }
}
