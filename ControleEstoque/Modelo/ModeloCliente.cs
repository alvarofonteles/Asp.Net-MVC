using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        private int cli_cod;
        private string cli_nome;
        private string cli_cpfcnpj;
        private string cli_rgie;
        private string cli_rsocial;
        private int cli_tipo;
        private string cli_cep;
        private string cli_endereco;
        private string cli_bairro;
        private string cli_fone;
        private string cli_cel;
        private string cli_email;
        private string cli_endnumero;
        private string cli_cidade;
        private string cli_estado;

        public int CliCod { get { return this.cli_cod; } set { this.cli_cod = value; } }

        public string CliNome { get { return this.cli_nome; } set { this.cli_nome = value; } }

        public string CliCpfCnpj { get { return this.cli_cpfcnpj; } set { this.cli_cpfcnpj = value; } }

        public string CliRgIe { get { return this.cli_rgie; } set { this.cli_rgie = value; } }

        public string CliRsocial { get { return this.cli_rsocial; } set { this.cli_rsocial = value; } }

        public int CliTipo { get { return this.cli_tipo; } set { this.cli_tipo = value; } }

        public string CliCep { get { return this.cli_cep; } set { this.cli_cep = value; } }

        public string CliEndereco { get { return this.cli_endereco; } set { this.cli_endereco = value; } }

        public string CliBairro { get { return this.cli_bairro; } set { this.cli_bairro = value; } }

        public string CliFone { get { return this.cli_fone; } set { this.cli_fone = value; } }

        public string CliCel { get { return this.cli_cel; } set { this.cli_cel = value; } }

        public string CliEmail { get { return this.cli_email; } set { this.cli_email = value; } }

        public string CliEndNumero { get { return this.cli_endnumero; } set { this.cli_endnumero = value; } }

        public string CliCidade { get { return this.cli_cidade; } set { this.cli_cidade = value; } }

        public string CliEstado { get { return this.cli_estado; } set { this.cli_estado = value; } }

        //construtor sem parametros
        public ModeloCliente()
        {
            this.CliCod = 0;
            this.CliNome = "";
            this.CliCpfCnpj = "";
            this.CliRgIe = "";
            this.CliRsocial = "";
            this.CliTipo = 0;
            this.CliCep = "";
            this.CliEndereco = "";
            this.CliBairro = "";
            this.CliFone = "";
            this.CliCel = "";
            this.CliEmail = "";
            this.CliEndNumero = "";
            this.CliCidade = "";
            this.CliEstado = "";
        }

        //construtor com parametros
        public ModeloCliente(
            int clicod,
            string clinome,
            string clicpfcnpj,
            string clirgie,
            string clirsocial,
            int clitipo,
            string clicep,
            string cliendereco,
            string clibairro,
            string clifone,
            string clicel,
            string cliemail,
            string cliendnumero,
            string clicidade,
            string cliestado
            )
        {
            this.CliCod = clicod;
            this.CliNome = clinome;
            this.CliCpfCnpj = clicpfcnpj;
            this.CliRgIe = clirgie;
            this.CliRsocial = clirsocial;
            this.CliTipo = clitipo;
            this.CliCep = clicep;
            this.CliEndereco = cliendereco;
            this.CliBairro = clibairro;
            this.CliFone = clifone;
            this.CliCel = clicel;
            this.CliEmail = cliemail;
            this.CliEndNumero = cliendnumero;
            this.CliCidade = clicidade;
            this.CliEstado = cliestado;
        }
    }
}
