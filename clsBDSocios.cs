using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Management;

namespace pryValdezIE
{
    internal class clsBDSocios
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        public string EstadoConexion = "";
        public string datosTabla;

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = EL_CLUB.accdb");
                conexionBD.Open();
                EstadoConexion = "Conectado";
            }
            catch (Exception ex)
            {
                EstadoConexion = "Error" + ex.Message;               
            }
        }

        public void TraerDatos(DataGridView grilla)
        {
            ConectarBD();
            //instancia un objeto en la memoria
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();

            grilla.Columns.Add("ID", "ID");
            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Apellido", "Apellido");
            grilla.Columns.Add("Pais", "Pais");
            grilla.Columns.Add("Edad", "Edad");
            grilla.Columns.Add("Ingreso", "Ingreso");
            grilla.Columns.Add("Puntaje", "Puntaje");
            grilla.Columns.Add("Estado", "Estado");
            //leo como si fuera un archivo
            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    // Comprueba si lectorBD[8] es true
                    string estado = lectorBD.GetBoolean(8) ? "Activo" : "Inactivo";

                    grilla.Rows.Add(lectorBD[0],lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[6], lectorBD[7], estado);
                    
                }
                
            }
        }

        int encontro = 0;
        public void BuscarPorID(int codigo, DataGridView grilla)
        {

            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            //q tipo de operacion quierp hacer y que me traiga TOD la tabla con el tabledirect
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            //Que tabla traigo
            comandoBD.CommandText = "SOCIOS"; 
            //abre la tabla y muestra por renglon
            lectorBD = comandoBD.ExecuteReader(); 


            //SI TIENE FILAS
            if (lectorBD.HasRows) 
            {
                encontro = 0;
                while (lectorBD.Read()) //mientras pueda leer, mostrar (leer)
                {  
                    if (int.Parse(lectorBD[0].ToString()) == codigo)
                    {

                        //datosTabla += "-" + lectorBD[0]; //dato d la comlumna 0
                        //MessageBox.Show("El Cliente " + lectorBD[0] + " Existente", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        grilla.Rows.Clear();
                        // Comprueba si lectorBD[8] es true
                        string estado = lectorBD.GetBoolean(8) ? "Activo" : "Inactivo";

                        grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[6], lectorBD[7], estado);
                        encontro = 1;

                        
                    }

                }
                conexionBD.Close();

                if (encontro == 0)
                {

                    MessageBox.Show("ID "+ codigo + " no existe");
                    
                }
            }
        }

        
    }
}
