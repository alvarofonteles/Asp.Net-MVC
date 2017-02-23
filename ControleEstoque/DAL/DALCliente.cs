using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCliente
    {
        private DALConexao conexao;

        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO cliente (cli_nome, cli_cpfcnpj, cli_rgie, cli_rsocial, cli_tipo, cli_cep,"
                    + "cli_endereco, cli_bairro, cli_fone, cli_cel, cli_email, cli_endnumero, cli_cidade, cli_estado)"
                    + "VALUES (@clinome, @clicpfcnpj, @clirgie, @clirsocial, @clitipo, @clicep, @cliendereco,"
                    + "@clibairro, @clifone, @clicel, @cliemail, @cliendnumero, @clicidade, @cliestado); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@clinome", modelo.CliNome);
                cmd.Parameters.AddWithValue("@clicpfcnpj", modelo.CliCpfCnpj);
                cmd.Parameters.AddWithValue("@clirgie", modelo.CliRgIe);
                cmd.Parameters.AddWithValue("@clirsocial", modelo.CliRsocial);
                cmd.Parameters.AddWithValue("@clitipo", modelo.CliTipo);
                cmd.Parameters.AddWithValue("@clicep", modelo.CliCep);
                cmd.Parameters.AddWithValue("@cliendereco", modelo.CliEndereco);
                cmd.Parameters.AddWithValue("@clibairro", modelo.CliBairro);
                cmd.Parameters.AddWithValue("@clifone", modelo.CliFone);
                cmd.Parameters.AddWithValue("@clicel", modelo.CliCel);
                cmd.Parameters.AddWithValue("@cliemail", modelo.CliEmail);
                cmd.Parameters.AddWithValue("@cliendnumero", modelo.CliEndNumero);//substituido do numero do endereço.
                cmd.Parameters.AddWithValue("@clicidade", modelo.CliCidade);
                cmd.Parameters.AddWithValue("@cliestado", modelo.CliEstado);
                conexao.Conectar();
                modelo.CliCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Alterar(ModeloCliente modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE cliente SET cli_nome = @clinome, cli_cpfcnpj = @clicpfcnpj,  cli_rgie = @clirgie,"
                    + "cli_rsocial = @clirsocial, cli_tipo = @clitipo, cli_cep = @clicep, cli_endereco = @cliendereco,"
                    + "cli_bairro = @clibairro,  cli_fone = @clifone, cli_cel = @clicel, cli_email = @cliemail,"
                    + "cli_endnumero = @cliendnumero, cli_cidade = @clicidade, cli_estado = @cliestado WHERE cli_cod = @clicod";
                cmd.Parameters.AddWithValue("@clinome", modelo.CliNome);
                cmd.Parameters.AddWithValue("@clicpfcnpj", modelo.CliCpfCnpj);
                cmd.Parameters.AddWithValue("@clirgie", modelo.CliRgIe);
                cmd.Parameters.AddWithValue("@clirsocial", modelo.CliRsocial);
                cmd.Parameters.AddWithValue("@clitipo", modelo.CliTipo);
                cmd.Parameters.AddWithValue("@clicep", modelo.CliCep);
                cmd.Parameters.AddWithValue("@cliendereco", modelo.CliEndereco);
                cmd.Parameters.AddWithValue("@clibairro", modelo.CliBairro);
                cmd.Parameters.AddWithValue("@clifone", modelo.CliFone);
                cmd.Parameters.AddWithValue("@clicel", modelo.CliCel);
                cmd.Parameters.AddWithValue("@cliemail", modelo.CliEmail);
                cmd.Parameters.AddWithValue("@cliendnumero", modelo.CliEndNumero);//substituido do numero do endereço.
                cmd.Parameters.AddWithValue("@clicidade", modelo.CliCidade);
                cmd.Parameters.AddWithValue("@cliestado", modelo.CliEstado);
                cmd.Parameters.AddWithValue("@clicod", modelo.CliCod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM cliente WHERE cli_cod = @clicod";
                cmd.Parameters.AddWithValue("@clicod", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable LocalizarNome(string valor, int tipo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from cliente where cli_nome like '%"
                + valor + "%' and cli_tipo = " + tipo, conexao.StringConexao);
            da.Fill(tabela);

            return tabela;
        }

        public DataTable LocalizarCpfCnpj(string valor, int tipo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from cliente where cli_cpfcnpj like '%"
                + valor + "%' and cli_tipo = " + tipo, conexao.StringConexao);
            da.Fill(tabela);

            return tabela;
        }

        public ModeloCliente CarregaModeloCliente(int codigo)//passa o codigo
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cli_cod = @clicod";
            cmd.Parameters.AddWithValue("@clicod", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.CliNome = Convert.ToString(registro["cli_nome"]);
                modelo.CliCpfCnpj = Convert.ToString(registro["cli_cpfcnpj"]);
                modelo.CliRgIe = Convert.ToString(registro["cli_rgie"]);
                modelo.CliRsocial = Convert.ToString(registro["cli_rsocial"]);
                modelo.CliTipo = Convert.ToInt32(registro["cli_tipo"]);
                modelo.CliCep = Convert.ToString(registro["cli_cep"]);
                modelo.CliEndereco = Convert.ToString(registro["cli_endereco"]);
                modelo.CliBairro = Convert.ToString(registro["cli_bairro"]);
                modelo.CliFone = Convert.ToString(registro["cli_fone"]);
                modelo.CliCel = Convert.ToString(registro["cli_cel"]);
                modelo.CliEmail = Convert.ToString(registro["cli_email"]);
                modelo.CliEndNumero = Convert.ToString(registro["cli_endnumero"]);
                modelo.CliCidade = Convert.ToString(registro["cli_cidade"]);
                modelo.CliEstado = Convert.ToString(registro["cli_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
