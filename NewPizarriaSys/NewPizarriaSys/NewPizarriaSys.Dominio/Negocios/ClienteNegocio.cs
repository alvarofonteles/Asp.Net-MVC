using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewPizarriaSys.Dominio.Contrato;
using NewPizarriaSys.Dominio.Repositorio;

namespace NewPizarriaSys.Dominio.Negocios
{
    public class ClienteNegocio : ClienteRepositorio, IClienteNegocio
    {
        public Cliente ListarClienteTelefone(string fone)
        {
            return ListarPorTelefone(fone).FirstOrDefault();
        }

        public Cliente ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return ListarTodos().FirstOrDefault(x => x.Id == idInt);
        }

        public IEnumerable<Cliente> ListarTelefones(string fone)
        {
            return ListarPorTelefone(fone);
        }
    }
}
