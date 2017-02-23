using BLL;
using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class frmCadastroCliente : ControleEstoque.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        //
        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
            CEP = 3,
        }
        //mascara dos campos cpf, cnpj e cep
        public void Formatar(Campo Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case Campo.CPF:
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    } break;
                case Campo.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    } break;
                case Campo.CEP:
                    txtTexto.MaxLength = 9;
                    if (txtTexto.Text.Length == 5)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    } break;
            }
        }
        //

        private void LimpaTela()
        {
            this.alteraBotoes(1);
            txtCodigo.Clear();
            txtNome.Clear();
            txtCelular.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtCEP.Clear();
            txtEmail.Clear();
            txtFone.Clear();
            txtCpf.Clear();
            txtRG.Clear();
            txtRazao.Clear();
            this.rbFisica.Checked = true;
            lbCPFNull.Visible = false;
            lbCEP.Visible = false;
            lbEmail.Visible = false;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCliente frmConsCli = new frmConsultaCliente();
            frmConsCli.ShowDialog();
            //codigo

            if (frmConsCli.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(conexao);
                ModeloCliente modelo = bll.CarregaModeloCliente(frmConsCli.codigo);
                txtCodigo.Text = modelo.CliCod.ToString();
                txtNome.Text = modelo.CliNome;
                txtCelular.Text = modelo.CliCel;
                txtEndereco.Text = modelo.CliEndereco;
                txtNumero.Text = modelo.CliEndNumero;
                txtBairro.Text = modelo.CliBairro;
                txtCidade.Text = modelo.CliCidade;
                txtEstado.Text = modelo.CliEstado;
                txtCEP.Text = modelo.CliCep;
                txtEmail.Text = modelo.CliEmail;
                txtFone.Text = modelo.CliFone;
                txtRG.Text = modelo.CliRgIe;
                txtRazao.Text = modelo.CliRsocial;
                if (modelo.CliTipo == 0)//0 fisica, 1 juridica
                {
                    rbFisica.Checked = true;
                    RadioFisicaJuridica();
                    txtCpf.Text = modelo.CliCpfCnpj;
                }
                else
                {
                    rbJuridica.Checked = true;
                    RadioFisicaJuridica();
                    txtCpf.Text = modelo.CliCpfCnpj;
                }
                this.alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            frmConsCli.Dispose();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            RadioFisicaJuridica();
        }

        private void RadioFisicaJuridica()
        {
            lbCPFNull.Visible = false;
            Campo valor = Campo.CPF;

            if (rbJuridica.Checked == true)//CNPJ
            {
                //cli_tipo = 1
                lbRazao.Visible = true;
                txtRazao.Visible = true;
                lbCPF.Text = "CNPJ";
                lbRG.Text = "IE";

                valor = Campo.CNPJ;
                Formatar(valor, txtCpf);//mascara
            }
            else
            {
                //cli_tipo = 0
                lbRazao.Visible = false;
                txtRazao.Visible = false;
                lbCPF.Text = "CPF";
                lbRG.Text = "RG";

                Formatar(valor, txtCpf);//mascara
            }
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            RadioFisicaJuridica();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            this.txtNome.Focus();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCliente modelo = new ModeloCliente();
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(conexao);
                modelo.CliNome = txtNome.Text;
                modelo.CliCep = txtCEP.Text;
                modelo.CliEndereco = txtEndereco.Text;
                modelo.CliBairro = txtBairro.Text;
                modelo.CliFone = txtFone.Text;
                modelo.CliCel = txtCelular.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliEndNumero = txtNumero.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliCpfCnpj = txtCpf.Text;
                modelo.CliRgIe = txtRG.Text;
                modelo.CliRsocial = txtRazao.Text;
                if (rbFisica.Checked == true)//cli_tipo = 0, fisica
                {
                    modelo.CliTipo = 0;
                }
                else//cli_tipo = 1, juridica
                {
                    modelo.CliTipo = 1;
                }

                if (this.operacao == "inserir")
                {
                    if (MessageBox.Show("Deseja Incluir o Cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        bll.Incluir(modelo);
                        MessageBox.Show("Incluido com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (MessageBox.Show("Deseja Alterar o Cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        modelo.CliCod = Convert.ToInt32(txtCodigo.Text);
                        bll.Alterar(modelo);
                        MessageBox.Show("Alterado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja Excluir o Cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(conexao);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    MessageBox.Show("Excluido com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.alteraBotoes(3);
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Validacao.ValidaCEP(txtCEP.Text) == false)
                {
                    MessageBox.Show("O CEP é inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCEP.Clear();
                    txtCEP.Focus();
                }
                else
                {
                    if (Validacao.verificaCEP(txtCEP.Text) == true)
                    {
                        txtEndereco.Text = Validacao.endereco;
                        txtBairro.Text = Validacao.bairro;
                        txtCidade.Text = Validacao.cidade;
                        txtEstado.Text = Validacao.estado;
                        txtCEP.Text = Validacao.cep;
                        txtEmail.Focus();
                        lbCEP.Visible = false;
                    }
                    else
                    {
                        lbCEP.Visible = true;
                        txtEndereco.Focus();
                    }
                }
            }
            catch (Exception erro)//sem internet
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)//masck
        {
            lbCPFNull.Visible = false;
            try
            {
                if (rbFisica.Checked == true)
                {
                    if (Validacao.IsCpf(txtCpf.Text) == false)
                    {
                        lbCPFNull.Visible = true;
                    }
                }
                else
                {
                    if (Validacao.IsCnpj(txtCpf.Text) == false)
                    {
                        lbCPFNull.Visible = true;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)//backspace
                RadioFisicaJuridica();
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)//backspace
            {
                Campo valor = Campo.CEP;
                Formatar(valor, txtCEP);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Validacao.ValidaEmail(txtEmail.Text) == true)
            {
                lbEmail.Visible = true;
            }
        }
    }
}
