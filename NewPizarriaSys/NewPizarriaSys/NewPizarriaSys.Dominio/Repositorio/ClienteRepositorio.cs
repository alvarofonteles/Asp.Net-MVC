using NewPizarriaSys.AcessoDados.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewPizarriaSys.AcessoDados;
using System.Data;

namespace NewPizarriaSys.Dominio.Repositorio
{
    public class ClienteRepositorio : Contexto, IRepositorio<Cliente>
    {
        public void Salvar(Cliente entidade)
        {
            if (entidade.Id > 0)
                Alterar(entidade);
            else
                Incluir(entidade);
        }

        private void Incluir(Cliente entidade)
        {
            try
            {
                LimpaParametro();
                AdicionaParametro("@Nome", entidade.Nome);
                AdicionaParametro("@Telefone", entidade.Telefone);
                AdicionaParametro("@Email", entidade.Email);
                entidade.Id = Convert.ToInt32(ExecutaComando(CommandType.StoredProcedure, "spInserirCliente"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Alterar(Cliente entidade)
        {
            try
            {
                LimpaParametro();
                AdicionaParametro("@Id", entidade.Id);
                AdicionaParametro("@Nome", entidade.Nome);
                AdicionaParametro("@Telefone", entidade.Telefone);
                AdicionaParametro("@Email", entidade.Email);
                ExecutaComando(CommandType.StoredProcedure, "spAlterarCliente");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(Cliente entidade)
        {
            try
            {
                LimpaParametro();
                AdicionaParametro("@Id", entidade.Id);
                ExecutaComando(CommandType.StoredProcedure, "spExcluirCliente");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Cliente> ListarTodos()
        {
            try
            {
                LimpaParametro();
                DataTable dataTable = new DataTable();
                IList<Cliente> listCliente = new List<Cliente>();
                dataTable = ExecutaConsulta(CommandType.StoredProcedure, "spListarTodos");
                foreach (DataRow linhas in dataTable.Rows)
                {
                    Cliente cliente = new Cliente
                    {
                        Id = Convert.ToInt32(linhas["Id"].ToString()),
                        Nome = linhas["Nome"].ToString(),
                        Telefone = linhas["Telefone"].ToString(),
                        Email = linhas["Email"].ToString()
                    };
                    listCliente.Add(cliente);
                }
                return listCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }  

        public IEnumerable<Cliente> ListarPorTelefone(string fone)
        {
            try
            {
                LimpaParametro();
                AdicionaParametro("@Telefone", fone);
                DataTable dataTable = new DataTable();
                dataTable = ExecutaConsulta(CommandType.StoredProcedure, "spListarPorTelefone");
                IList<Cliente> listCliente = new List<Cliente>();
                foreach (DataRow linhas in dataTable.Rows)
                {
                    Cliente cliente = new Cliente
                    {
                        Id = Convert.ToInt32(linhas["Id"].ToString()),
                        Nome = linhas["Nome"].ToString(),
                        Telefone = linhas["Telefone"].ToString(),
                        Email = linhas["Email"].ToString()
                    };
                    listCliente.Add(cliente);
                }
                return listCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Cliente BuscarPorId(int id)
        {
            try
            {
                LimpaParametro();
                AdicionaParametro("@Id", id);
                Cliente cliente = new Cliente();
                DataTable dataTable = new DataTable();
                dataTable = ExecutaConsulta(CommandType.StoredProcedure, "spBuscarPorId");
                foreach (DataRow linha in dataTable.Rows)
                {
                    cliente.Id = Convert.ToInt32(linha["Id"].ToString());
                    cliente.Nome = linha["Nome"].ToString();
                    cliente.Telefone = linha["Telefone"].ToString();
                    cliente.Email = linha["Email"].ToString();
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
