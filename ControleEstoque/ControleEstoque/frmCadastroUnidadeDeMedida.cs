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
    public partial class frmCadastroUnidadeDeMedida : ControleEstoque.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroUnidadeDeMedida()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida frmConsUndMed = new frmConsultaUnidadeDeMedida();
            frmConsUndMed.ShowDialog();
            if (frmConsUndMed.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(conexao);
                ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeDeMedida(frmConsUndMed.codigo);
                this.txtCodigo.Text = modelo.UmedCod.ToString();
                this.txtNome.Text = modelo.UmedNome;
                this.alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            frmConsUndMed.Dispose();
        }

        private void frmCadastroUnidadeDeMedida_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            this.txtNome.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
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

                if (MessageBox.Show("Deseja Excluir a unidade de medida?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(conexao);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    MessageBox.Show("Unidade Excluida com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro", erro.Message);
                this.alteraBotoes(3);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
                modelo.UmedNome = txtNome.Text;
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(conexao);
                if (this.operacao == "inserir")
                {
                    if (MessageBox.Show("Deseja Salvar a unidade de medida?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bll.Incluir(modelo);
                        MessageBox.Show("Unidade Salva com sucesso. Código " + modelo.UmedCod.ToString() + "", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (MessageBox.Show("Deseja Alterar a unidade de medida?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        modelo.UmedCod = Convert.ToInt32(txtCodigo.Text);
                        bll.Alterar(modelo);
                        MessageBox.Show("Unidade Alterada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro", erro.Message);
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (operacao == "inserir")
            {
                int valor = 0;//nao retorna
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(conexao);
                valor = bll.VerificaUnidadeDeMedida(txtNome.Text);
                if (valor > 0)
                {
                    if (MessageBox.Show("Já Existe essa unidade de medida.\nDeseja Alterar a unidade de medida?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.operacao = "alterar";
                        ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeDeMedida(valor);
                        txtCodigo.Text = modelo.UmedCod.ToString();
                        txtNome.Text = modelo.UmedNome;
                    }
                }
            }
        }
    }
}
