using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValdezIE
{
    using System.IO;
    public partial class UCProveedores : UserControl
    {
        
        public UCProveedores()
        {
            InitializeComponent();
            LlenarTreeView();
            //lblContenido.Text = "Esta funcion Le permite administrar los proveedores que ya ha creado, modificar sus datos, eliminarlos o consultar su historial.";
            lblTitulo.Visible = false;
            pnlArchivos.Visible = false;
            //btnArcProvUno.Text = "Nombre Archivo";
        }
        private void LlenarTreeView()
        {
            TreeNode nodoMadre;

            DirectoryInfo info = new DirectoryInfo(Application.StartupPath +"\\Proveedores");
            if (info.Exists == true) //POR DEFECTO el IF pregunta true
            {
                nodoMadre = new TreeNode(info.Name);
                nodoMadre.Tag = info;
                ObtenerCarpetas(info.GetDirectories(), nodoMadre);
                treeView1.Nodes.Add(nodoMadre);
            }
        }

        //desde info.GetDirectories() nos da todos los nombrs
        //de carpetas
        private void ObtenerCarpetas(DirectoryInfo[] subDirs,
    TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;


            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";

                // Obtener archivos en lugar de solo carpetas
                FileInfo[] files = subDir.GetFiles();
                foreach (FileInfo file in files)
                {
                    TreeNode fileNode = new TreeNode(file.Name, 1, 1); // Usar una imagen para archivos
                    fileNode.Tag = file;
                    aNode.Nodes.Add(fileNode);
                }

                //recursiva - se llama a si mismo para
                //buscar màs carpetas
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    ObtenerCarpetas(subSubDirs, aNode);
                }

                nodeToAddTo.Nodes.Add(aNode);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void btnArcProvUno_Click(object sender, EventArgs e)
        {
            //pctBordeCeleste.Visible = true;
            pnlArchivos.Visible = true;
        }
        string leerLinea;
        string[] separarDatos;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            grilla.Rows.Clear();
            grilla.Columns.Clear();

            try
            {
                string Archivo = Convert.ToString(treeView1.SelectedNode.FullPath);
                string NombreArchivo = treeView1.SelectedNode.Text;

                StreamReader sr = new StreamReader(Archivo);

                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');

                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    grilla.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }

                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    grilla.Rows.Add(separarDatos);
                }

                sr.Close();
                btnGuardar.Visible = true;                          
                grilla.Visible = true;
                lblTitulo.Visible = true;
                pnlArchivos.Visible = true;
                lblTitulo.Text = NombreArchivo;

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un archivo");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Archivo = Convert.ToString(treeView1.SelectedNode.FullPath);

            // Asegúrate de que hay un archivo seleccionado
            if (string.IsNullOrEmpty(Archivo))
            {
                MessageBox.Show("Selecciona un archivo para guardar los cambios.");
                return;
            }

            // Lee la primera línea del archivo
            string primeraLinea = string.Empty;
            if (File.Exists(Archivo))
            {
                using (StreamReader sr = new StreamReader(Archivo))
                {
                    primeraLinea = sr.ReadLine();
                }
            }

            // Construye la cadena de texto con los datos del DataGridView
            StringBuilder sb = new StringBuilder();

            // Agrega la primera línea al resultado
            sb.AppendLine(primeraLinea);

            // Recorre todas las filas, excepto la primera (fila de encabezado)
            foreach (DataGridViewRow fila in grilla.Rows)
            {
                if (!fila.IsNewRow)
                {
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        if (celda.Value != null)
                        {
                            sb.Append(celda.Value.ToString());
                        }
                        sb.Append(";");
                    }
                    sb.AppendLine(); // Agrega un salto de línea después de cada fila
                }
            }

            // Escribe la cadena de texto en el archivo
            File.WriteAllText(Archivo, sb.ToString());

            MessageBox.Show("Los cambios se han guardado correctamente.");
        }
       
    }
}
