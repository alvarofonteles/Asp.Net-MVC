﻿using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTipoPagamento
    {
        private DALConexao conexao;

        public BLLTipoPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Inserir(ModeloTipoPagamento modelo)
        {
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O nome do tipo de pagamento é obrigatório.");
            }

            DALTipoPagamento tpag = new DALTipoPagamento(conexao);
            tpag.Inserir(modelo);
        }

        public void Alterar(ModeloTipoPagamento modelo)
        {
            if (modelo.TpaCod <= 0)
            {
                throw new Exception("O código do tipo de pagamento é obrigatório.");
            }
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O nome do tipo de pagamento  é obrigatório.");
            }

            DALTipoPagamento tpag = new DALTipoPagamento(conexao);
            tpag.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALTipoPagamento tpag = new DALTipoPagamento(conexao);
            tpag.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALTipoPagamento tpag = new DALTipoPagamento(conexao);
            return tpag.Localizar(valor);
        }

        public ModeloTipoPagamento CarregaModeloTipoPagamento(int codigo)
        {
            DALTipoPagamento tpag = new DALTipoPagamento(conexao);
            return tpag.CarregaModeloTipoPagamento(codigo);
        }

    }
}
