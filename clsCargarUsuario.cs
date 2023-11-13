using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace pryValdezIE
{
    internal class clsCargarUsuario
    {

        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataAdapter objDataAdap;     
        DataSet objDataSet = new DataSet();
        OleDbDataReader lectorBD;

        public clsCargarUsuario()
        {
            // Constructor para inicializar la conexión y el comando.
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();

        }



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
        public void CargarUsuario(string varUsuario, string varContraseña, int varCat)
        {
            //ConectarBD();
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;


            // Establece el tipo de comando y la tabla
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            //Que tabla traigo
            comandoBD.CommandText = "Usuarios";



            // crear el objeto DataAdapter pasando como parámetro el objeto comando que queremos vincular
            objDataAdap = new OleDbDataAdapter(comandoBD);
            // ejecutar la lectura de la tabla y almacenar su contenido en el dataAdapter
            objDataAdap.Fill(objDataSet, "Usuarios");
            // obtenemos una referencia a la tabla


            DataTable dt = objDataSet.Tables["Usuarios"];

            // creamos el nuevo DataRow con la estructura de campos de la tabla
            DataRow dr = dt.NewRow();
            // asignamos los valores a todos los campos del DataRow
            dr["Usuario"] = varUsuario;
            dr["Contraseña"] = varContraseña;
            dr["Categoria"] = varCat;

            // agregamos el DataRow a la tabla

            dt.Rows.Add(dr);

            // creamos el objeto OledBCommandBuilder pasando como parámetro el DataAdapter
            OleDbCommandBuilder cb = new OleDbCommandBuilder(objDataAdap);

            // actualizamos la base con los cambios realizados
            objDataAdap.Update(objDataSet, "Usuarios");
            conexionBD.Close();

            MessageBox.Show("El usuario se cargo correctamente");
        }
        int contador;
        public void CompararUsuario(string varUsuario, string varContraseña, int varCat)
        {
            contador = 0;
            ConectarBD();
            comandoBD = new OleDbCommand();
            
            comandoBD.Connection = conexionBD;


            // Establece el tipo de comando y la tabla
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
                    if (lectorBD[1].ToString() == varUsuario)
                    {
                        MessageBox.Show("El nombre de usuario ingresado ya esta en uso");
                        contador = 1;
                        break;
                    }

                }
                
            }
            if (contador == 0)
            {
                CargarUsuario(varUsuario, varContraseña,varCat);
            }
        }
    }
}
