using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace NewPizarriaSys.AcessoDados
{
    public class Contexto : IDisposable
    {
        private readonly SqlConnection conexao;
        public Contexto()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString);
            conexao.Open();
        }

        public void Dispose()
        {
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
        }

        private SqlParameterCollection sqlParameterConllection = new SqlCommand().Parameters;

        public void AdicionaParametro(string nomeParametro, object valorParametro)
        {
            sqlParameterConllection.AddWithValue(nomeParametro, valorParametro);
        }

        private SqlCommand CriaComando(CommandType cmdType, string nomeProcedure)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao,
                CommandType = cmdType,//StoredProcedure
                CommandText = nomeProcedure,//nome da Procedure
                CommandTimeout = 7200
            };

            foreach (SqlParameter sqlParameter in sqlParameterConllection)//passa da colecao para o parametro
            {
                cmd.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
            }
            return cmd;
        }

        protected void LimpaParametro()
        {
            sqlParameterConllection.Clear();
        }

        protected object ExecutaComando(CommandType cmdType, string nomeProcedure)//vai ser herdada(protected)
        {
            try
            {
                SqlCommand cmd = CriaComando(cmdType, nomeProcedure);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected DataTable ExecutaConsulta(CommandType cmdType, string nomeProcedure)
        {
            try
            {
            SqlCommand cmd = CriaComando(cmdType, nomeProcedure);
            DataTable dataTable = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
