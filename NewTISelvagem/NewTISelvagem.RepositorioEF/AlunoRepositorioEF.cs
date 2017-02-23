using NewTISelvagem.Dominio;
using NewTISelvagem.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTISelvagem.RepositorioEF
{
    public class AlunoRepositorioEF : IRepositorio<Aluno>
    {
        private readonly Contexto contexto;

        public AlunoRepositorioEF()
        {
            contexto = new Contexto();
        }

        public void Salvar(Aluno entidade)
        {
            if (entidade.AlunoId > 0)
            {
                var alunoSalvar = contexto.Alunos.First(x => x.AlunoId == entidade.AlunoId);
                alunoSalvar.Nome = entidade.Nome;
                alunoSalvar.Mae = entidade.Mae;
                alunoSalvar.DataNascimento = entidade.DataNascimento;
            }
            else
            {
                contexto.Alunos.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Deletar(Aluno entidade)
        {
            var alunoDeletar = contexto.Alunos.First(x => x.AlunoId == entidade.AlunoId);
            contexto.Set<Aluno>().Remove(alunoDeletar);
            contexto.SaveChanges();
        }

        public IEnumerable<Aluno> ListaTodos()
        {
            return contexto.Alunos;
        }

        public Aluno ListaPorId(string id)//converter para inteiro (int)
        {
            int idInt;
            int.TryParse(id, out idInt);
            return contexto.Alunos.First(x => x.AlunoId == idInt);
        }
    }
}
