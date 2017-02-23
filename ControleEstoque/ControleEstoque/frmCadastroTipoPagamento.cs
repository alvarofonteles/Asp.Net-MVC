using BLL;
using DAL;
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
    public partial class frmCadastroTipoPagamento : ControleEstoque.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroTipoPagamento()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtPagamento.Clear();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPagamento frmConsTipPag = new frmConsultaTipoPagamento();
            frmConsTipPag.ShowDialog();
            if (frmConsTipPag.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(conexao);
                ModeloTipoPagamento modelo = bll.CarregaModeloTipoPagamento(frmConsTipPag.codigo);
                txtCodigo.Text = modelo.TpaCod.ToString();
                txtPagamento.Text = modelo.TpaNome;

                this.alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            frmConsTipPag.Dispose();
        }

        private void frmCadastroTipoPagamento_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir esse tipo de pagamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTipoPagamento bll = new BLLTipoPagamento(conexao);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));

                    MessageBox.Show("Excluido com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossível excluir o registro.\nO registro esta sendo utilizado em outro local", "Atenção"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.alteraBotoes(3);
            }

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(conexao);
                ModeloTipoPagamento modelo = new ModeloTipoPagamento();
                modelo.TpaNome = txtPagamento.Text;
                if (this.operacao == "inserir")
                {
                    if (MessageBox.Show("Deseja Inserir esse tipo de pagamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        bll.Inserir(modelo);
                        MessageBox.Show("Cadastro efetuado com sucesso: Código - " + modelo.TpaCod.ToString() + ".", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (MessageBox.Show("Deseja Alterar esse tipo de pagamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        modelo.TpaCod = Convert.ToInt32(txtCodigo.Text);
                        bll.Alterar(modelo);
                        MessageBox.Show("Cadastro Aterado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.alteraBotoes(1);
                this.LimpaTela();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
