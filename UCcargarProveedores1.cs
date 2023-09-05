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

    using System.IO;
    public partial class UCcargarProveedores1 : UserControl
    {
        public UCcargarProveedores1()
        {
            InitializeComponent();
        }
        String Ruta;
        private void btnElegirCarpeta_Click(object sender, EventArgs e)
        {
            BuscarCarpeta.ShowDialog();
            Ruta = BuscarCarpeta.SelectedPath;
            lblRuta.Text = Ruta;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Ruta += "/" + txtNombreArchivo.Text;

            StreamWriter manejoArchivo = new StreamWriter(Ruta);
            //MessageBox.Show("Archivo creado con el nombre de  " + txtNombreArchivo.Text);
            //Idea: hacer que aparezca un dibujo en la parte derecha que diga que se guardo correctamente el archivo
            pctOkey.Visible=true;
            lblResultado.Visible=true;
            lblResultado.Text = "El archivo se genero correctamente con el nombre de: " + txtNombreArchivo.Text
                + " y se guardo en la siguiente ruta: " + Ruta;
            pnlOkey.Visible=true;
            
            btnGuardarArchivo.Enabled=false;
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
        }
    }
}
