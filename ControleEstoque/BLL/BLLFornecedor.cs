using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFornecedor
    {
        private DALConexao conexao;

        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O Nome do fornecedor é obrigatorio.");
            }

            modelo.ForNome = modelo.ForNome.ToUpper();

            //verifica CNPJ
            try
            {
                //cnpj
                if (Validacao.IsCnpj(modelo.ForCnpj) == false)
                {
                    throw new Exception("O CNPJ Inválido.");
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do fornecedor é obrigatorio.");
            }

            //verifica CEP
            try
            {
                if (Validacao.verificaCEP(modelo.ForCep) == false)
                {
                    throw new Exception("CEP Inválido.");
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);//sem internet
            }

            if (modelo.ForEndereco.Trim().Length == 0)
            {
                throw new Exception("O Endereço do fornecedor é obrigatorio.");
            }

            modelo.ForEndereco = modelo.ForEndereco.ToUpper();
            modelo.ForEndnumero = modelo.ForEndnumero.ToUpper();

            if (modelo.ForBairro.Trim().Length == 0)
            {
                throw new Exception("O Bairro do fornecedor é obrigatorio.");
            }

            modelo.ForBairro = modelo.ForBairro.ToUpper();

            if (modelo.ForCel.Trim().Length == 0)
            {
                throw new Exception("O Celular do fornecedor é obrigatorio.");
            }

            //verifica E-mail
            if (Validacao.ValidaEmail(modelo.ForEmail) == true)
            {
                throw new Exception("E-mail Inválido.");
            }

            if (modelo.ForCidade.Trim().Length == 0)
            {
                throw new Exception("A Cidade do fornecedor é obrigatorio.");
            }

            modelo.ForCidade = modelo.ForCidade.ToUpper();

            if (modelo.ForEstado.Trim().Length == 0)
            {
                throw new Exception("O Estado do fornecedor é obrigatorio.");
            }

            modelo.ForEstado = modelo.ForEstado.ToUpper();
            modelo.ForRsocial = modelo.ForRsocial.ToUpper();

            DALFornecedor forn = new DALFornecedor(conexao);
            forn.Incluir(modelo);
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O Nome do fornecedor é obrigatorio.");
            }

            modelo.ForNome = modelo.ForNome.ToUpper();

            //verifica CNPJ
            try
            {
                //cnpj
                if (Validacao.IsCnpj(modelo.ForCnpj) == false)
                {
                    throw new Exception("O CNPJ Inválido.");
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do fornecedor é obrigatorio.");
            }

            //verifica CEP
            try
            {
                if (Validacao.verificaCEP(modelo.ForCep) == false)
                {
                    throw new Exception("CEP Inválido.");
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);//sem internet
            }

            if (modelo.ForEndereco.Trim().Length == 0)
            {
                throw new Exception("O Endereço do fornecedor é obrigatorio.");
            }

            modelo.ForEndereco = modelo.ForEndereco.ToUpper();
            modelo.ForEndnumero = modelo.ForEndnumero.ToUpper();

            if (modelo.ForBairro.Trim().Length == 0)
            {
                throw new Exception("O Bairro do fornecedor é obrigatorio.");
            }

            modelo.ForBairro = modelo.ForBairro.ToUpper();

            if (modelo.ForCel.Trim().Length == 0)
            {
                throw new Exception("O Celular do fornecedor é obrigatorio.");
            }

            //verifica E-mail
            if (Validacao.ValidaEmail(modelo.ForEmail) == true)
            {
                throw new Exception("E-mail Inválido.");
            }

            if (modelo.ForCidade.Trim().Length == 0)
            {
                throw new Exception("A Cidade do fornecedor é obrigatorio.");
            }

            modelo.ForCidade = modelo.ForCidade.ToUpper();

            if (modelo.ForEstado.Trim().Length == 0)
            {
                throw new Exception("O Estado do fornecedor é obrigatorio.");
            }

            modelo.ForEstado = modelo.ForEstado.ToUpper();
            modelo.ForRsocial = modelo.ForRsocial.ToUpper();

            if (modelo.ForCod <= 0)
            {
                throw new Exception("O Código do fornecedor é obrigatorio.");
            }

            DALFornecedor forn = new DALFornecedor(conexao);
            forn.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALFornecedor forn = new DALFornecedor(conexao);
            forn.Excluir(codigo);
        }

        public DataTable Localizar(string valor)
        {
            DALFornecedor forn = new DALFornecedor(conexao);
            return forn.Localizar(valor);
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)//passa o codigo
        {
            DALFornecedor forn = new DALFornecedor(conexao);
            return forn.CarregaModeloFornecedor(codigo);
        }
    }
}
