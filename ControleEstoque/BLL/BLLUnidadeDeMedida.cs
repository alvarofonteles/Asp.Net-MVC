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
    public class BLLUnidadeDeMedida
    {
        private DALConexao conexao;

        public BLLUnidadeDeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório");
            }

            modelo.UmedNome = modelo.UmedNome.ToUpper();

            DALUnidadeDeMedida unidade = new DALUnidadeDeMedida(conexao);
            unidade.Incluir(modelo);
        }

        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }

            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O Nome da unidade de medida é obrigatório");
            }

            modelo.UmedNome = modelo.UmedNome.ToUpper();

            DALUnidadeDeMedida unidade = new DALUnidadeDeMedida(conexao);
            unidade.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALUnidadeDeMedida unidade = new DALUnidadeDeMedida(conexao);
            unidade.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALUnidadeDeMedida unidade = new DALUnidadeDeMedida(conexao);
            return unidade.Localizar(valor);
        }

        public int VerificaUnidadeDeMedida(String valor)
        {
            DALUnidadeDeMedida unidade = new DALUnidadeDeMedida(conexao);
            return unidade.VerificaUnidadeDeMedida(valor);
        }

        public ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            DALUnidadeDeMedida unidade = new DALUnidadeDeMedida(conexao);
            return unidade.CarregaModeloUnidadeDeMedida(codigo);
        }
    }
}
