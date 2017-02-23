using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTISelvagem.Dominio.Contrato
{
    public interface IRepositorio<T> where T : class
    {
        void Salvar(T entidade);

        void Deletar(T entidade);

        IEnumerable<T> ListaTodos();

        T ListaPorId(string id);
    }
}
