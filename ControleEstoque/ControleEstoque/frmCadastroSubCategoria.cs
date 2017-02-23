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
    public partial class frmCadastroSubCategoria : ControleEstoque.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            this.txtNome.Focus();
        }

        private void carregaCombo()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cboCategoria.DataSource = bll.Localizar("");
            cboCategoria.DisplayMember = "cat_nome";
            cboCategoria.ValueMember = "cat_cod";
        }

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.carregaCombo();
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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.CatCod = Convert.ToInt32(cboCategoria.SelectedValue);
                modelo.ScatNome = txtNome.Text;
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(conexao);
                if (operacao == "inserir")
                {
                    if (MessageBox.Show("Deseja Salvar o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                    {
                        bll.Incluir(modelo);
                        MessageBox.Show("Cadastro efetuado com sucesso. Código - "
                            + modelo.ScatCod.ToString() + ".", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (MessageBox.Show("Deseja Alterar o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                    {
                        modelo.ScatCod = Convert.ToInt32(txtCodigo.Text);
                        bll.Alterar(modelo);
                        MessageBox.Show("Cadastro alterado com sucesso.", "Atenção"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro");
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir a subcategoria?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(conexao);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    MessageBox.Show("Subcategoria excluida com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro.\nO registro esta sendo utilizado em outro local", "Atenção"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.alteraBotoes(3);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria frmConsSubCat = new frmConsultaSubCategoria();
            frmConsSubCat.ShowDialog();
            if (frmConsSubCat.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(conexao);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(frmConsSubCat.codigo);
                this.txtCodigo.Text = modelo.ScatCod.ToString();
                this.txtNome.Text = modelo.ScatNome;
                this.cboCategoria.SelectedValue = modelo.CatCod;
                this.alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            frmConsSubCat.Dispose();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria frmCadCat = new frmCadastroCategoria();
            frmCadCat.ShowDialog();
            frmCadCat.Dispose();
            this.carregaCombo();

        }
    }
}
