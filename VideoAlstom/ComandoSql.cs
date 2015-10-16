using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VideoAlstom
{
    public class ComandoSql
    {

        public static DataTable Consulta(string sql)
        {

            string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            SqlConnection objConexao = new SqlConnection(strConexao);
            SqlCommand objCommand = new SqlCommand(sql, objConexao);
            SqlDataAdapter DA = new SqlDataAdapter(objCommand);

            DataTable dados = new DataTable();

            DA.Fill(dados);
            try
            {
                objConexao.Open();
                objCommand.ExecuteNonQuery();
                objConexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
            return dados;

        }

        public static void Query(string sql)
        {
            string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection objConexao = new SqlConnection(strConexao);
            objConexao.Open();
            SqlCommand objCommand = new SqlCommand(sql, objConexao);

            objCommand.CommandText = sql;
            SqlDataReader reader = objCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    object dataValue = reader.GetValue(0);
                    string sValue = dataValue.ToString();

                }

                reader.Close();
                reader = null;
                objCommand.Dispose();
                objCommand = null;
                objConexao.Close();
                objConexao = null;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

    }
}
