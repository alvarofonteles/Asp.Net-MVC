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
    public class BLLCategoria
    {
        private DALConexao conexao;

        public BLLCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }

            modelo.CatNome = modelo.CatNome.ToUpper();

            DALCategoria cat = new DALCategoria(conexao);
            cat.Incluir(modelo);
        }

        public void Alterar(ModeloCategoria modelo)
        {
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }

            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }

            modelo.CatNome = modelo.CatNome.ToUpper();//todas as letras maiusculas

            DALCategoria cat = new DALCategoria(conexao);
            cat.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCategoria cat = new DALCategoria(conexao);
            cat.Excluir(codigo);
        }

        public DataTable Localizar(string valor)
        {
            DALCategoria cat = new DALCategoria(conexao);
            return cat.Localizar(valor);
        }

        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            DALCategoria cat = new DALCategoria(conexao);
            return cat.CarregaModeloCategoria(codigo);
        }

    }
}
