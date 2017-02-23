using NewTISelvagem.Dominio;
using NewTISelvagem.Dominio.Contrato;
using NewTISelvagem.RepositorioADO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTISelvagem.Aplicacao
{
    public class AlunoAplicacao
    {
        private readonly IRepositorio<Aluno> repositorio;

        public AlunoAplicacao(IRepositorio<Aluno> repo)
        {
            repositorio = repo;
        }

        public void Salvar(Aluno aluno)
        {
            repositorio.Salvar(aluno);
        }

        public void Deletar(Aluno aluno)
        {
            repositorio.Deletar(aluno);
        }

        public IEnumerable<Aluno> ListaTodos()
        {
            return repositorio.ListaTodos();
        }

        public Aluno ListaPorId(string id)
        {
            return repositorio.ListaPorId(id);
        }
    }
}
