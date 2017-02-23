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
    public class DALSubCategoria
    {
        private DALConexao conexao;

        public DALSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into subcategoria (scat_nome, cat_cod) values (@snome, @codigo); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@snome", modelo.ScatNome);
                cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
                conexao.Conectar();
                modelo.ScatCod = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Alterar(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update subcategoria set scat_nome = @snome, cat_cod = @codigo where scat_cod = @scodigo";
                cmd.Parameters.AddWithValue("@snome", modelo.ScatNome);
                cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
                cmd.Parameters.AddWithValue("@scodigo", modelo.ScatCod);
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
                cmd.CommandText = "delete from subcategoria where scat_cod = @scodigo";
                cmd.Parameters.AddWithValue("@scodigo", codigo);
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
            SqlDataAdapter da = new SqlDataAdapter("select sub.scat_cod, sub.scat_nome, sub.cat_cod, cat.cat_nome "
                + "from subcategoria sub inner join categoria cat on sub.cat_cod = cat.cat_cod where scat_nome like '%"
                + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizaPorCategoria(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select sub.scat_cod, sub.scat_nome, sub.cat_cod, cat.cat_nome "
                + "from subcategoria sub inner join categoria cat on sub.cat_cod = cat.cat_cod where sub.cat_cod = "
                + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            ModeloSubCategoria modelo = new ModeloSubCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from subcategoria where scat_cod = @scodigo;";
            cmd.Parameters.AddWithValue("@scodigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();//excuta e ler os dados

            if (registro.HasRows)
            {
                registro.Read();
                modelo.ScatCod = Convert.ToInt32(registro["scat_cod"]);
                modelo.ScatNome = Convert.ToString(registro["scat_nome"]);
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
