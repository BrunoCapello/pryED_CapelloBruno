using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace pryED_CapelloBruno
{
    internal class clsBaseDeDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador;

        string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..//..//Libreria.mdb";

        public void Listar(DataGridView dgv, string tabla)
        {
            try
            {
                conexion.ConnectionString = cadena;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet ds = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(ds, tabla);
                dgv.DataSource = ds.Tables[tabla];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public DataSet Listar(string consulta)
        {
            DataSet ds = new DataSet();
            try
            {
                conexion.ConnectionString = cadena;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return ds;
        }
    }
}
