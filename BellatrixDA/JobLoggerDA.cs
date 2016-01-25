using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDA
{
    public class JobLoggerDA
    {

        public void InsertLog(string  mensaje, string  codigo)
        {
            string strMsgError = string.Empty, strMsj = string.Empty;
            SqlConnection cn = new SqlConnection(Conexion.strConexion);
            SqlCommand cmd = new SqlCommand("Insert into Log Values('" + mensaje + "'," + codigo + ")",cn);

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                strMsj = String.Format("Error en Insert: {0}", ex.Message.ToString());
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
                    cmd.Connection.Dispose();
                    cmd.Dispose();
            }
           
        }

    }
}
