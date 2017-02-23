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
    public class DALFornecedor
    {
        private DALConexao conexao;

        public DALFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO fornecedor (for_nome, for_rsocial, for_ie, for_cnpj, for_cep,"
                    + "for_endereco, for_bairro, for_fone, for_cel, for_email, for_endnumero, for_cidade, for_estado)"
                    + "VALUES (@fornome, @forrsocial, @forie, @forcnpj, @forcep, @forendereco,"
                    + "@forbairro, @forfone, @forcel, @foremail, @forendnumero, @forcidade, @forestado); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@fornome", modelo.ForNome);
                cmd.Parameters.AddWithValue("@forrsocial", modelo.ForRsocial);
                cmd.Parameters.AddWithValue("@forie", modelo.ForIe);
                cmd.Parameters.AddWithValue("@forcnpj", modelo.ForCnpj);
                cmd.Parameters.AddWithValue("@forcep", modelo.ForCep);
                cmd.Parameters.AddWithValue("@forendereco", modelo.ForEndereco);
                cmd.Parameters.AddWithValue("@forbairro", modelo.ForBairro);
                cmd.Parameters.AddWithValue("@forfone", modelo.ForFone);
                cmd.Parameters.AddWithValue("@forcel", modelo.ForCel);
                cmd.Parameters.AddWithValue("@foremail", modelo.ForEmail);
                cmd.Parameters.AddWithValue("@forendnumero", modelo.ForEndnumero);
                cmd.Parameters.AddWithValue("@forcidade", modelo.ForCidade);
                cmd.Parameters.AddWithValue("@forestado", modelo.ForEstado);
                conexao.Conectar();
                modelo.ForCod = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Alterar(ModeloFornecedor modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE fornecedor SET for_nome = @fornome, for_rsocial = @forrsocial,  for_ie = @forie,"
                    + "for_cnpj = @forcnpj, for_cep = @forcep, for_endereco = @forendereco,"
                    + "for_bairro = @forbairro,  for_fone = @forfone, for_cel = @forcel, for_email = @foremail,"
                    + "for_endnumero = @forendnumero, for_cidade = @forcidade, for_estado = @forestado WHERE for_cod = @forcod";
                cmd.Parameters.AddWithValue("@fornome", modelo.ForNome);
                cmd.Parameters.AddWithValue("@forrsocial", modelo.ForRsocial);
                cmd.Parameters.AddWithValue("@forie", modelo.ForIe);
                cmd.Parameters.AddWithValue("@forcnpj", modelo.ForCnpj);
                cmd.Parameters.AddWithValue("@forcep", modelo.ForCep);
                cmd.Parameters.AddWithValue("@forendereco", modelo.ForEndereco);
                cmd.Parameters.AddWithValue("@forbairro", modelo.ForBairro);
                cmd.Parameters.AddWithValue("@forfone", modelo.ForFone);
                cmd.Parameters.AddWithValue("@forcel", modelo.ForCel);
                cmd.Parameters.AddWithValue("@foremail", modelo.ForEmail);
                cmd.Parameters.AddWithValue("@forendnumero", modelo.ForEndnumero);
                cmd.Parameters.AddWithValue("@forcidade", modelo.ForCidade);
                cmd.Parameters.AddWithValue("@forestado", modelo.ForEstado);
                cmd.Parameters.AddWithValue("@forcod", modelo.ForCod);
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
                cmd.CommandText = "DELETE FROM fornecedor WHERE for_cod = @forcod";
                cmd.Parameters.AddWithValue("@forcod", codigo);
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

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from fornecedor where for_nome like '%"
                + valor + "%' or for_cnpj like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);

            return tabela;
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)//passa o codigo
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from fornecedor where for_cod = @forcod";
            cmd.Parameters.AddWithValue("@forcod", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.ForNome = Convert.ToString(registro["for_nome"]);
                modelo.ForRsocial = Convert.ToString(registro["for_rsocial"]);
                modelo.ForIe = Convert.ToString(registro["for_ie"]);
                modelo.ForCnpj = Convert.ToString(registro["for_cnpj"]);
                modelo.ForCep = Convert.ToString(registro["for_cep"]);
                modelo.ForEndereco = Convert.ToString(registro["for_endereco"]);
                modelo.ForBairro = Convert.ToString(registro["for_bairro"]);
                modelo.ForFone = Convert.ToString(registro["for_fone"]);
                modelo.ForCel = Convert.ToString(registro["for_cel"]);
                modelo.ForEmail = Convert.ToString(registro["for_email"]);
                modelo.ForEndnumero = Convert.ToString(registro["for_endnumero"]);
                modelo.ForCidade = Convert.ToString(registro["for_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["for_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
