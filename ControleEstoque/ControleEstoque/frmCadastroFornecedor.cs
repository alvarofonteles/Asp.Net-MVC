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
    public partial class frmCadastroFornecedor : ControleEstoque.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        //
        public enum Campo
        {
            CNPJ = 1,
            CEP = 2,
        }
        //mascara dos campos cpf, cnpj e cep
        public void Formatar(Campo Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
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
                    }
                    break;
                case Campo.CEP:
                    txtTexto.MaxLength = 9;
                    if (txtTexto.Text.Length == 5)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
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
            txtCnpj.Clear();
            txtIE.Clear();
            txtRazao.Clear();
            lbCNPJNull.Visible = false;
            lbCEP.Visible = false;
            lbEmail.Visible = false;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor frmConsForn = new frmConsultaFornecedor();
            frmConsForn.ShowDialog();
            //codigo

            if (frmConsForn.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(conexao);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(frmConsForn.codigo);
                txtCodigo.Text = modelo.ForCod.ToString();
                txtNome.Text = modelo.ForNome;
                txtCelular.Text = modelo.ForCel;
                txtEndereco.Text = modelo.ForEndereco;
                txtNumero.Text = modelo.ForEndnumero;
                txtBairro.Text = modelo.ForBairro;
                txtCidade.Text = modelo.ForCidade;
                txtEstado.Text = modelo.ForEstado;
                txtCEP.Text = modelo.ForCep;
                txtEmail.Text = modelo.ForEmail;
                txtFone.Text = modelo.ForFone;
                txtIE.Text = modelo.ForIe;
                txtRazao.Text = modelo.ForRsocial;
                txtCnpj.Text = modelo.ForCnpj;

                this.alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            frmConsForn.Dispose();
        }

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
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
                ModeloFornecedor modelo = new ModeloFornecedor();
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(conexao);
                modelo.ForNome = txtNome.Text;
                modelo.ForCep = txtCEP.Text;
                modelo.ForEndereco = txtEndereco.Text;
                modelo.ForBairro = txtBairro.Text;
                modelo.ForFone = txtFone.Text;
                modelo.ForCel = txtCelular.Text;
                modelo.ForEmail = txtEmail.Text;
                modelo.ForEndnumero = txtNumero.Text;
                modelo.ForCidade = txtCidade.Text;
                modelo.ForEstado = txtEstado.Text;
                modelo.ForCnpj = txtCnpj.Text;
                modelo.ForIe = txtIE.Text;
                modelo.ForRsocial = txtRazao.Text;

                if (this.operacao == "inserir")
                {
                    if (MessageBox.Show("Deseja Incluir o Fornecedor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        bll.Incluir(modelo);
                        MessageBox.Show("Incluido com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (MessageBox.Show("Deseja Alterar o Fornecedor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        modelo.ForCod = Convert.ToInt32(txtCodigo.Text);
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
                if (MessageBox.Show("Deseja Excluir o Fornecedor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLFornecedor bll = new BLLFornecedor(conexao);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    MessageBox.Show("Excluido com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtCnpj_Leave(object sender, EventArgs e)//masck
        {
            lbCNPJNull.Visible = false;
            try
            {
                if (Validacao.IsCnpj(txtCnpj.Text) == false)
                {
                    lbCNPJNull.Visible = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)//backspace
            {
                Campo valor = Campo.CNPJ;
                Formatar(valor, txtCnpj);//mascara
            }
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
            lbEmail.Visible = false;
            if (Validacao.ValidaEmail(txtEmail.Text) == true)
            {
                lbEmail.Visible = true;
            }
        }
    }
}
