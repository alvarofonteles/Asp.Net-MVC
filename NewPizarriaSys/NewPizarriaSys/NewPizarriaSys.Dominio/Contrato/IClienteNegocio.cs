using NewPizarriaSys.AcessoDados.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPizarriaSys.Dominio.Contrato
{
    public interface IClienteNegocio : IRepositorio<Cliente>
    {
        Cliente ListarClienteTelefone(string fone);

        Cliente ListarPorId(string id);

        IEnumerable<Cliente> ListarTelefones(string fone);
    }
}
