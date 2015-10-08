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
    public class Dados
    {
        //Variavel conexão
        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //Variaveis constantes
        public const string strDelete = "DELETE FROM usuario WHERE id = @id";
        public const string strInsert = "INSERT INTO usuario VALUES (@id, @de_nome)";
        public const string strSelect = "SELECT id, de_nome FROM usuario";
        public const string strUpdate = "UPDATE usuario  SET de_nome = @de_nome";

        /*public class usuario
        {
            public int id {get; set;}
            public string de_nome {get; set;}
        }*/

        public void Atualizar(int id, string de_nome)
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
        }

       /* public static void Consultando(string sql)
        {
            //string conexao = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //FbConnection dbcon = new FbConnection(strConexao);
            SqlConnection objConexao = new SqlConnection(strConexao);
            //FbCommand cmdCad = new FbCommand(codigo, dbcon);
            SqlCommand objCommand = new SqlCommand(sql, objConexao);
            //FbDataAdapter DA = new FbDataAdapter(cmdCad);
            objConexao.Open();


            SqlDataReader objDataReader = objCommand.ExecuteReader();

            if (objDataReader.HasRows)
            //if (objDataReader.RecordsAffected > -1 )
            {
                while (objDataReader.Read())
                {
                    object dataValue = objDataReader.GetValue(0);
                    string sValue = dataValue.ToString();

                }
                objDataReader.Close();
            }
            objConexao.Close();



        }*/

        public static DataTable Consultando(string sql)
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


        /*public List<usuario> Consultar()
        {
            //Estancio a lista
            List<usuario> lstUsuario = new List<usuario>();

            //Abre o obj   de conexão
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                //Estancio o obj command
                using (SqlCommand objCommand = new SqlCommand(strSelect, objConexao))
                {
                    objConexao.Open();
                    //Crio um obj data reader que exxecuta o datareader
                    SqlDataReader objDataReader = objCommand.ExecuteReader();

                    if (objDataReader.HasRows )
                    //if (objDataReader.RecordsAffected > -1 )
                    {
                        while (objDataReader.Read())
                        {
                            usuario objUsuario = new usuario();
                            objUsuario.id = Convert.ToInt32(objDataReader["id"].ToString());
                            objUsuario.de_nome = objDataReader["de_nome"].ToString();

                            //Joga na lista o objeto preeenchido
                            lstUsuario.Add(objUsuario);
                        }
                        objDataReader.Close();
                    }
                    objConexao.Close();
                }

            }
            return lstUsuario;
        }*/

        public void Excluir(int id )
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
        }
    }
}
