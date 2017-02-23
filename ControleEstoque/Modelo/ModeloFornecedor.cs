using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFornecedor
    {
        private int for_cod;
        private string for_nome;
        private string for_rsocial;
        private string for_ie;
        private string for_cnpj;
        private string for_cep;
        private string for_endereco;
        private string for_bairro;
        private string for_fone;
        private string for_cel;
        private string for_email;
        private string for_endnumero;
        private string for_cidade;
        private string for_estado;

        public int ForCod { get { return this.for_cod; } set { this.for_cod = value; } }

        public string ForNome { get { return this.for_nome; } set { this.for_nome = value; } }

        public string ForRsocial { get { return this.for_rsocial; } set { this.for_rsocial = value; } }

        public string ForIe { get { return this.for_ie; } set { this.for_ie = value; } }

        public string ForCnpj { get { return this.for_cnpj; } set { this.for_cnpj = value; } }

        public string ForCep { get { return this.for_cep; } set { this.for_cep = value; } }

        public string ForEndereco { get { return this.for_endereco; } set { this.for_endereco = value; } }

        public string ForBairro { get { return this.for_bairro; } set { this.for_bairro = value; } }

        public string ForFone { get { return this.for_fone; } set { this.for_fone = value; } }

        public string ForCel { get { return this.for_cel; } set { this.for_cel = value; } }

        public string ForEmail { get { return this.for_email; } set { this.for_email = value; } }

        public string ForEndnumero { get { return this.for_endnumero; } set { this.for_endnumero = value; } }

        public string ForCidade { get { return this.for_cidade; } set { this.for_cidade = value; } }

        public string ForEstado { get { return this.for_estado; } set { this.for_estado = value; } }

        //construtor sem parametros
        public ModeloFornecedor()
        {
            this.ForCod = 0;
            this.ForNome = "";
            this.ForRsocial = "";
            this.ForIe = "";
            this.ForCnpj = "";
            this.ForCep = "";
            this.ForEndereco = "";
            this.ForBairro = "";
            this.ForFone = "";
            this.ForCel = "";
            this.ForEmail = "";
            this.ForEndnumero = "";
            this.ForCidade = "";
            this.ForEstado = "";
        }

        //construtor com parametros
        public ModeloFornecedor(
            int forcod,
            string fornome,
            string forrsocial,
            string forie,
            string forcnpj,
            string forcep,
            string forendereco,
            string forbairro,
            string forfone,
            string forcel,
            string foremail,
            string forendnumero,
            string forcidade,
            string forestado
            )
        {
            this.ForCod = forcod;
            this.ForNome = fornome;
            this.ForRsocial = forrsocial;
            this.ForIe = forie;
            this.ForCnpj = forcnpj;
            this.ForCep = forcep;
            this.ForEndereco = forendereco;
            this.ForBairro = forbairro;
            this.ForFone = forfone;
            this.ForCel = forcel;
            this.ForEmail = foremail;
            this.ForEndnumero = forendnumero;
            this.ForCidade = forcidade;
            this.ForEstado = forestado;
        }
    }
}
