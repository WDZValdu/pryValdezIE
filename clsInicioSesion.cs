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
        clsLog objLog;
        
 
        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = EL_CLUB.accdb");
                conexionBD.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int varContador = 0;
        int varEncontro = 0;
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
                        objLog = new clsLog();
                        string varAccion = "Inicio Sesion";
                        DateTime varFecha = DateTime.Now;

                        objLog.CargarLog(varNombre, varFecha, varAccion);
   
                        frmInicio.Hide();
                        frmCargar frmCargar = new frmCargar(varNombre);
                        frmCargar.Show();
                        varEncontro++;
                        break;
                    }

                }
                if (varEncontro == 0)
                {
                    MessageBox.Show("Datos de inicio de sesion incorrectos");
                    varContador += 1;

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
