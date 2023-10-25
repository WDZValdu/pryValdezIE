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
    internal class clsInicioSesion
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
                conexionBD = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = C:\\Users\\agusv\\source\\repos\\pryValdezIE\\bin\\Debug\\EL_CLUB.accdb");
                conexionBD.Open();
                EstadoConexion = "Conectado";
            }
            catch (Exception ex)
            {
                EstadoConexion = "Error" + ex.Message;
            }
        }
        int varContador = 0;
        public void IngresarUsuario(string varNombre, string varContraseña, frmInicio frmInicio)
        {

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
                    if (lectorBD[1].ToString() == varNombre && lectorBD[2].ToString() == varContraseña)
                    {           

                        frmInicio.Hide();
                        frmCargar frmCargar = new frmCargar();
                        frmCargar.Show();

                        break;
                    }
                    else
                    {
                        MessageBox.Show("Datos de inicio de sesion incorrectos");
                        varContador += 1;
                        break;
                    }
                    
                                      

                }
                if (varContador >= 3)
                {
                    MessageBox.Show("Demaciados intentos de inicio de sesion, el sistema se cerrara");
                    Application.Exit();
                    
                }
            }
            
            
        }


    }
}
