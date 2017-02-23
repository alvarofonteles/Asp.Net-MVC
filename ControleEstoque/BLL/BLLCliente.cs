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
    public class BLLCliente
    {
        private DALConexao conexao;

        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O Nome do cliente é obrigatorio.");
            }

            modelo.CliNome = modelo.CliNome.ToUpper();

            //verifica CPF/CNPJ
            try
            {
                if (modelo.CliTipo == 0)
                {
                    //cpf
                    if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                    {
                        throw new Exception("O CPF Inválido.");
                    }
                }
                else
                {
                    //cnpj
                    if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                    {
                        throw new Exception("O CNPJ Inválido.");
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE do cliente é obrigatorio.");
            }

            //verifica CEP
            try
            {
                if (Validacao.verificaCEP(modelo.CliCep) == false)
                {
                    throw new Exception("CEP Inválido.");
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);//sem internet
            }

            if (modelo.CliEndereco.Trim().Length == 0)
            {
                throw new Exception("O Endereço do cliente é obrigatorio.");
            }

            modelo.CliEndereco = modelo.CliEndereco.ToUpper();
            modelo.CliEndNumero = modelo.CliEndNumero.ToUpper();

            if (modelo.CliBairro.Trim().Length == 0)
            {
                throw new Exception("O Bairro do cliente é obrigatorio.");
            }

            modelo.CliBairro = modelo.CliBairro.ToUpper();

            if (modelo.CliCel.Trim().Length == 0)
            {
                throw new Exception("O Celular do cliente é obrigatorio.");
            }

            //verifica E-mail
            if (Validacao.ValidaEmail(modelo.CliEmail) == true)
            {
                throw new Exception("E-mail Inválido.");
            }

            if (modelo.CliCidade.Trim().Length == 0)
            {
                throw new Exception("A Cidade do cliente é obrigatorio.");
            }

            modelo.CliCidade = modelo.CliCidade.ToUpper();

            if (modelo.CliEstado.Trim().Length == 0)
            {
                throw new Exception("O Estado do cliente é obrigatorio.");
            }

            modelo.CliEstado = modelo.CliEstado.ToUpper();
            modelo.CliRsocial = modelo.CliRsocial.ToUpper();

            DALCliente cli = new DALCliente(conexao);
            cli.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O Nome do cliente é obrigatorio.");
            }

            modelo.CliNome = modelo.CliNome.ToUpper();

            //verifica CPF/CNPJ
            try
            {
                if (modelo.CliTipo == 0)
                {
                    //cpf
                    if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                    {
                        throw new Exception("O CPF Inválido.");
                    }
                }
                else
                {
                    //cnpj
                    if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                    {
                        throw new Exception("O CNPJ Inválido.");
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE do cliente é obrigatorio.");
            }

            //verifica CEP
            try
            {
                if (Validacao.verificaCEP(modelo.CliCep) == false)
                {
                    throw new Exception("CEP Inválido.");
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);//sem internet
            }

            if (modelo.CliEndereco.Trim().Length == 0)
            {
                throw new Exception("O Endereço do cliente é obrigatorio.");
            }

            modelo.CliEndereco = modelo.CliEndereco.ToUpper();
            modelo.CliEndNumero = modelo.CliEndNumero.ToUpper();

            if (modelo.CliBairro.Trim().Length == 0)
            {
                throw new Exception("O Bairro do cliente é obrigatorio.");
            }

            modelo.CliBairro = modelo.CliBairro.ToUpper();

            if (modelo.CliCel.Trim().Length == 0)
            {
                throw new Exception("O Celular do cliente é obrigatorio.");
            }

            //verifica E-mail
            if (Validacao.ValidaEmail(modelo.CliEmail) == true)
            {
                throw new Exception("E-mail Inválido.");
            }

            if (modelo.CliCidade.Trim().Length == 0)
            {
                throw new Exception("A Cidade do cliente é obrigatorio.");
            }

            modelo.CliCidade = modelo.CliCidade.ToUpper();

            if (modelo.CliEstado.Trim().Length == 0)
            {
                throw new Exception("O Estado do cliente é obrigatorio.");
            }

            modelo.CliEstado = modelo.CliEstado.ToUpper();
            modelo.CliRsocial = modelo.CliRsocial.ToUpper();

            if (modelo.CliCod <= 0)
            {
                throw new Exception("O Código do cliente é obrigatorio.");
            }

            DALCliente cli = new DALCliente(conexao);
            cli.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCliente cli = new DALCliente(conexao);
            cli.Excluir(codigo);
        }

        public DataTable LocalizarNome(string valor, int tipo)
        {
            DALCliente cli = new DALCliente(conexao);
            return cli.LocalizarNome(valor, tipo);
        }

        public DataTable LocalizarCpfCnpj(string valor, int tipo)
        {
            DALCliente cli = new DALCliente(conexao);
            return cli.LocalizarCpfCnpj(valor, tipo);
        }

        public ModeloCliente CarregaModeloCliente(int codigo)//passa o codigo
        {
            DALCliente cli = new DALCliente(conexao);
            return cli.CarregaModeloCliente(codigo);
        }

    }
}
