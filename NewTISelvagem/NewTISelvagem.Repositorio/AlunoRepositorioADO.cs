using NewTISelvagem.Dominio;
using NewTISelvagem.Dominio.Contrato;
using NewTISelvagem.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTISelvagem.RepositorioADO
{
    public class AlunoRepositorioADO : IRepositorio<Aluno>
    {
        private Contexto contexto;

        private void Inserir(Aluno aluno)
        {
            string strQuery = "insert into Aluno (Nome, Mae, DataNascimento) ";
            //strQuery += string.Format("values ('{0}', '{1}', CONVERT(datetime, '{2}', 103))",
            //    aluno.Nome, aluno.Mae, aluno.DataNascimento);//converte para dd/MM/yyy
            strQuery += string.Format("values ('{0}', '{1}', '{2}')",
                aluno.Nome, aluno.Mae, aluno.DataNascimento);

            using (contexto = new Contexto())
            {
                contexto.ExecuteQuery(strQuery);
            }
        }

        private void Alterar(Aluno aluno)
        {
            string strQuery = "update Aluno set ";
            strQuery += string.Format("Nome = '{0}',", aluno.Nome);
            strQuery += string.Format("Mae = '{0}',", aluno.Mae);
            //strQuery += string.Format("DataNascimento = CONVERT(datetime, '{0}', 103)",
            //    aluno.DataNascimento);//converte para dd/MM/yyy
            strQuery += string.Format("DataNascimento = '{0}'", aluno.DataNascimento);
            strQuery += string.Format("Where AlunoId = {0}", aluno.AlunoId);

            using (contexto = new Contexto())
            {
                contexto.ExecuteQuery(strQuery);
            }
        }

        public void Salvar(Aluno aluno)
        {
            if (aluno.AlunoId > 0)
                Alterar(aluno);
            else
                Inserir(aluno);
        }

        public void Deletar(Aluno aluno)
        {
            string strQuery = "delete from Aluno ";
            strQuery += string.Format("where AlunoId = {0}", aluno.AlunoId);

            using (contexto = new Contexto())
            {
                contexto.ExecuteQuery(strQuery);
            }
        }

        public IEnumerable<Aluno> ListaTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = "select * from Aluno";
                var retornoDados = contexto.ExecuteQueryRetorno(strQuery);
                return TransformaDataReaderEmLista(retornoDados);
            }
        }

        public Aluno ListaPorId(string id)
        {
            using (contexto = new Contexto())
            {
                string strSelects = string.Format("select * from Aluno where AlunoId = {0}", id);
                var retornaDataReader = contexto.ExecuteQueryRetorno(strSelects);
                return TransformaDataReaderEmLista(retornaDataReader).FirstOrDefault();
            }
        }

        private List<Aluno> TransformaDataReaderEmLista(SqlDataReader reader)
        {
            var alunos = new List<Aluno>();

            while (reader.Read())
            {
                var objAluno = new Aluno
                {
                    AlunoId = int.Parse(reader["AlunoId"].ToString()),
                    Nome = reader["Nome"].ToString(),
                    Mae = reader["Mae"].ToString(),
                    DataNascimento = DateTime.Parse(reader["DataNascimento"].ToString())
                };
                alunos.Add(objAluno);
            }
            reader.Close();
            return alunos;
        }
    }
}
