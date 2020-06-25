using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC.DAL
{
    class DALMVC
    {
        private MySqlConnection conexao;
        private string string_conexao = "Persist security info= false;" + 
                                        "Server = localhost;" + 
                                        "Database = ProjetoMVCA11;" + 
                                        "user = root; pwd=;";

        //classe para conectar ao banco de dados
        private void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch(MySqlException e)
            {
                throw new Exception("Problemas na conexão com o banco de dados. Erro: " + e.Message);
            }
        }

        //metodo para executar consulta no banco
        public void ExecutarComando(string sql)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch(MySqlException e)
            {
                throw new Exception("Não foi possível executar a instrução do banco. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                dados.Fill(dt);
                return dt;
            }
            catch(MySqlException e)
            {
                throw new Exception("Não foi possível executar a consulta no Banco. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
