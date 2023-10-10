using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Windows.Forms;



namespace pryValdezIE
{
    internal class ClsIngresoUsuario
    {
        OleDbConnection ConexionBD;

        public void AbrirBD()
        {
            try
            {
                ConexionBD = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = E:\\Escritorio\\Bases de datos\\Ingreso_Usuarios.accdb");
                ConexionBD.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
        }
        
    }
}
