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
            MessageBox.Show("Archivo Creado " + txtNombreArchivo.Text);
            
        }
    }
}
