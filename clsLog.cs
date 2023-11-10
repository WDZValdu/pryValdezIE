using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValdezIE
{
    internal class clsLog
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataAdapter objDataAdap;
        OleDbDataAdapter DataAdapSocios;
        DataSet objDataSet = new DataSet();
        

        public clsLog()
        {
            // Constructor para inicializar la conexión y el comando.
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
            
        }

        public string datosTabla;

        public void ConectarBD()
        {
            try
            {
                string conexion = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = EL_CLUB.accdb";
                conexionBD.ConnectionString = conexion;
                conexionBD.Open();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
       
        
        
        
        
        public void CargarLog(string varUsuario, DateTime varFecha, string varAccion)
        {
            ConectarBD();
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;


            // Establece el tipo de comando y la tabla
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            //Que tabla traigo
            comandoBD.CommandText = "Logs";

            

            // crear el objeto DataAdapter pasando como parámetro el objeto comando que queremos vincular
            objDataAdap = new OleDbDataAdapter(comandoBD);
            // ejecutar la lectura de la tabla y almacenar su contenido en el dataAdapter
            objDataAdap.Fill(objDataSet, "Logs");
            // obtenemos una referencia a la tabla


            DataTable dt = objDataSet.Tables["Logs"];

            // creamos el nuevo DataRow con la estructura de campos de la tabla
            DataRow dr = dt.NewRow();
            // asignamos los valores a todos los campos del DataRow
            dr["Usuario"] = varUsuario;
            dr["Fecha"] = varFecha;
            dr["Accion"] = varAccion;

            // agregamos el DataRow a la tabla

            dt.Rows.Add(dr);

            // creamos el objeto OledBCommandBuilder pasando como parámetro el DataAdapter
            OleDbCommandBuilder cb = new OleDbCommandBuilder(objDataAdap);

            // actualizamos la base con los cambios realizados
            objDataAdap.Update(objDataSet, "Logs");
            conexionBD.Close();
        }

        //qwwqdqdwqwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwdwd

        public void CambiarEstado(int codigo)
        {
            ConectarBD();

            try
            {
                // Crea el objeto OleDbDataAdapter pasando como parámetro el objeto comando que quiero conectar
                objDataAdap = new OleDbDataAdapter("SELECT * FROM SOCIOS", conexionBD);

                // Crea y llena el DataSet
                objDataAdap.Fill(objDataSet, "SOCIOS");

                // le digo q tabla traer
                DataTable dt = objDataSet.Tables["SOCIOS"];

                // Busca la fila que hay q modificar
                DataRow[] foundRows = dt.Select("Codigo_Socio = " + codigo);

                if (foundRows.Length > 0)
                {
                    // Cambia el valor en la columna "Estado" de la fila encontrada
                    bool estadoActual = (bool)foundRows[0]["Estado"];
                    foundRows[0]["Estado"] = !estadoActual; // Cambiar de Activo a Inactivo o viceversa

                    // Crea el objeto OleDbCommandBuilder pasando como parámetro el DataAdapter
                    OleDbCommandBuilder cb = new OleDbCommandBuilder(objDataAdap);

                    // Actualiza la base de datos con los cambios realizados
                    objDataAdap.Update(objDataSet, "SOCIOS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }           
                conexionBD.Close();
            

        }
    }
}
