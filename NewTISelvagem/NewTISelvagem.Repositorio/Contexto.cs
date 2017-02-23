using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace NewTISelvagem.Repositorio
{
    class Contexto : IDisposable
    {
        private readonly SqlConnection conexao;
        public Contexto()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["TISelvagemConfig"].ConnectionString);//pega os dados do Web.config/App.config
            conexao.Open();
        }

        public SqlDataReader ExecuteQueryRetorno(string strQuery)
        {
            SqlCommand cmd = new SqlCommand(strQuery, conexao);
            return cmd.ExecuteReader();
        }

        public void ExecuteQuery(string strQuery)
        {
            SqlCommand cmd = new SqlCommand(strQuery, conexao);
            cmd.ExecuteNonQuery();
        }

        public void Dispose()
        {
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
        }
    }
}
