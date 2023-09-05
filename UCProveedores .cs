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
            //btnArcProvUno.Text = "Nombre Archivo";
        }
        private void LlenarTreeView()
        {
            TreeNode nodoMadre;

            DirectoryInfo info = new DirectoryInfo(@"C:\Users\YO\Desktop\Proveedores");
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
    }
}
