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
    internal class clsUsuarios
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
            //instancia un objeto en la memoria
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "Usuarios";

            lectorBD = comandoBD.ExecuteReader();

            grilla.Columns.Add("ID", "ID");
            grilla.Columns.Add("Usuario", "Usuario");
            grilla.Columns.Add("Estado", "Estado");
            grilla.Columns.Add("Categoria", "Categoria");
            

            //leo como si fuera un archivo
            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    datosTabla += "-" + lectorBD[0];
                    grilla.Rows.Add(lectorBD[0],lectorBD[1], lectorBD[2]);
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
            comandoBD.CommandText = "Usuarios"; 
            //abre la tabla y muestra por renglon
            lectorBD = comandoBD.ExecuteReader(); 


            //SI TIENE FILAS
            if (lectorBD.HasRows) 
            {
                
                while (lectorBD.Read()) //mientras pueda leer, mostrar (leer)
                {
                    if (int.Parse(lectorBD[0].ToString()) == codigo)
                    {

                        //datosTabla += "-" + lectorBD[0]; //dato d la comlumna 0
                        //MessageBox.Show("El Cliente " + lectorBD[0] + " Existente", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        grilla.Rows.Clear();
                        grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2]);
                        encontro = 1;
                        break;
                    }

                }
                if (encontro == 0)
                {

                    MessageBox.Show("ID "+ codigo + " no existe");
                    
                }
            }
            
        }
    }
}
