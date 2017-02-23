using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLSubCategoria
    {
        private DALConexao conexao;

        public BLLSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O codigo da categoria é obrigatório.");
            }

            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório.");
            }

            modelo.ScatNome = modelo.ScatNome.ToUpper();

            DALSubCategoria subc = new DALSubCategoria(conexao);
            subc.Incluir(modelo);
        }

        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.ScatCod <= 0)
            {
                throw new Exception("O codigo da subcategoria é obrigatório.");
            }

            if (modelo.CatCod <= 0)
            {
                throw new Exception("O codigo da categoria é obrigatório.");
            }

            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório");
            }

            modelo.ScatNome = modelo.ScatNome.ToUpper();

            DALSubCategoria subc = new DALSubCategoria(conexao);
            subc.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALSubCategoria subc = new DALSubCategoria(conexao);
            subc.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALSubCategoria subc = new DALSubCategoria(conexao);
            return subc.Localizar(valor);
        }

        public DataTable LocalizaPorCategoria(int codigo)
        {
            DALSubCategoria subc = new DALSubCategoria(conexao);
            return subc.LocalizaPorCategoria(codigo);
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            DALSubCategoria subc = new DALSubCategoria(conexao);
            return subc.CarregaModeloSubCategoria(codigo);
        }
    }
}
