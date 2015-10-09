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
        //Variavel conexão
        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //Variaveis constantes
        /*public const string strDelete = "DELETE FROM usuario WHERE id = @id";
        public const string strInsert = "INSERT INTO usuario VALUES (@id, @de_nome)";
        public const string strSelect = "SELECT id, de_nome FROM usuario";
        public const string strUpdate = "UPDATE usuario  SET de_nome = @de_nome";*/

        /*public class usuario
        {
            public int id {get; set;}
            public string de_nome {get; set;}
        }*/

        /*public void Atualizar(int id, string de_nome)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strUpdate, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@id", id);
                    objCommand.Parameters.AddWithValue("@de_nome", de_nome);

                    objConexao.Open();
                    objCommand.ExecuteNonQuery();

                    objConexao.Close();
                }

            }
        }*/

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

        /*public void Excluir(int id )
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strDelete, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@id", id);
                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();
                }

            }
        }


        public void Gravar(int id, string de_nome)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strInsert, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@id", id);
                    objCommand.Parameters.AddWithValue("@de_nome", de_nome);

                    objConexao.Open();
                    objCommand.ExecuteNonQuery();

                    objConexao.Close();
                }

            }
        }*/
    }
}
