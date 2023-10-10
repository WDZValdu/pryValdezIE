using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace pryValdezIE
{

    
    public partial class UCcargarProveedores1 : UserControl
    {
        public UCcargarProveedores1()
        {
            InitializeComponent();
            lblContenido.Text = "Cargar Proveedores: Le permite crear nuevos \narchivos y carpetas para sus proveedores";
            BuscarCarpeta.SelectedPath = Application.StartupPath;
        }
        string Ruta;
        private void btnElegirCarpeta_Click(object sender, EventArgs e)
        {
            BuscarCarpeta.ShowDialog();
            Ruta = BuscarCarpeta.SelectedPath;
            lblRuta.Text = Ruta;
            lblRuta.Visible = true;
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            Ruta += "/" + txtNombreArchivo.Text + ".txt";

            StreamWriter ManejoArchivo = new StreamWriter(Ruta, false);
            //MessageBox.Show("Archivo creado con el nombre de  " + txtNombreArchivo.Text);
            //Idea: hacer que aparezca un dibujo en la parte derecha que diga que se guardo correctamente el archivo
            
            ManejoArchivo.Write("N° ;Entidad ;Apertura ;N° Expte. ;Juzg. ;Jurisdiccion ;Liquidador Responsable");
            
            pctOkey.Visible=true;
            lblResultado.Visible=true;
            lblResultado.Text = "El archivo se genero correctamente con el nombre de: " + txtNombreArchivo.Text
                + "\n y se guardo en la siguiente ruta: \n" + Ruta;
            
            ManejoArchivo.Close();
            ManejoArchivo.Dispose();
            btnGuardarArchivo.Enabled=false;
            lblContenido.Visible=false;
            pctProveedor.Visible=false;
            lblResultado.Visible= true;
        }

        private void pctCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCargarProv_Click(object sender, EventArgs e)
        {
            txtNombreArchivo.Text = "";
            lblRuta.Text = "Ruta seleccionada:";
            btnGuardarArchivo.Enabled = true;
            pctProveedor.Visible = true;
            lblContenido.Visible = true;
            lblResultado.Visible = false;
        }
    }
}
