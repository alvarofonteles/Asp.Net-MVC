using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Modelo;
using ControleEstoque;
using DAL;
using System.IO;

namespace ControleEstoque
{
    public partial class frmCadastroProduto : ControleEstoque.frmModeloDeFormularioDeCadastro
    {
        public string foto = "";
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }
        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtProduto.Clear();
            txtDescricao.Clear();
            txtValorPago.Clear();
            txtValorVenda.Clear();
            txtQtd.Clear();
            this.foto = "";
            pbImagem.Image = null;
        }
        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            CarregaCategoria();
            CarregaSubCategoria();
            CarregaUndMedida();
        }

        public void CarregaCategoria()
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            //combo da categoria
            BLLCategoria bllCat = new BLLCategoria(conexao);
            cbCategoria.DataSource = bllCat.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";
        }

        public void CarregaSubCategoria()
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                //combo da subcategoria
                BLLSubCategoria bllSub = new BLLSubCategoria(conexao);
                cbSubCategoria.DataSource = bllSub.LocalizaPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch { }
        }

        public void CarregaUndMedida()
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            //como da unidade de medida
            BLLUnidadeDeMedida bllUnd = new BLLUnidadeDeMedida(conexao);
            cbUnidMedida.DataSource = bllUnd.Localizar("");
            cbUnidMedida.DisplayMember = "umed_nome";
            cbUnidMedida.ValueMember = "umed_cod";
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPago.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            if (txtValorPago.Text.Contains(",") == false)
            {
                txtValorPago.Text += ",00";
            }
            else
            {
                if (txtValorPago.Text.IndexOf(",") == txtValorPago.Text.Length - 1)
                {
                    txtValorPago.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorPago.Text);
            }
            catch
            {
                txtValorPago.Text = "0,00";
            }
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorVenda.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Contains(",") == false)
            {
                txtValorVenda.Text += ",00";
            }
            else
            {
                if (txtValorVenda.Text.IndexOf(",") == txtValorVenda.Text.Length - 1)
                {
                    txtValorVenda.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorVenda.Text);
            }
            catch
            {
                txtValorVenda.Text = "0,00";
            }
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtQtd.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {
            if (txtQtd.Text.Contains(",") == false)
            {
                txtQtd.Text += ",00";
            }
            else
            {
                if (txtQtd.Text.IndexOf(",") == txtQtd.Text.Length - 1)
                {
                    txtQtd.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtQtd.Text);
            }
            catch
            {
                txtQtd.Text = "0,00";
            }
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
                //leitura dos dados
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProNome = txtProduto.Text;
                modelo.ProDescricao = txtDescricao.Text;
                modelo.ProValorPago = Convert.ToDouble(txtValorPago.Text);
                modelo.ProValorVenda = Convert.ToDouble(txtValorVenda.Text);
                modelo.ProQtde = Convert.ToDouble(txtQtd.Text);
                modelo.UmedCod = Convert.ToInt32(cbUnidMedida.SelectedValue);
                modelo.CatCod = Convert.ToInt32(cbCategoria.SelectedValue);
                modelo.ScatCod = Convert.ToInt32(cbSubCategoria.SelectedValue);

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma Produto
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ProCod.ToString());
                }
                else
                {
                    modelo.ProCod = Convert.ToInt32(txtCodigo.Text);
                    //alterar um produto
                    if (this.foto == "Foto Original")
                    {
                        ModeloProduto mt = bll.CarregaModeloProduto(modelo.ProCod);
                        modelo.ProFoto = mt.ProFoto;
                    }
                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaSubCategoria();
        }

        private void btLoFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                this.pbImagem.Load(this.foto);
            }

        }

        private void btRemoverImg_Click(object sender, EventArgs e)
        {
            this.foto = "";
            this.pbImagem.Image = null;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigoProd != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigoProd);
                txtCodigo.Text = modelo.CatCod.ToString();
                //colocar os dados na tela
                txtCodigo.Text = modelo.ProCod.ToString();
                txtDescricao.Text = modelo.ProDescricao;
                txtProduto.Text = modelo.ProNome;
                txtQtd.Text = modelo.ProQtde.ToString();
                txtValorPago.Text = modelo.ProValorPago.ToString();
                txtValorVenda.Text = modelo.ProValorVenda.ToString();
                cbCategoria.SelectedValue = modelo.CatCod;
                cbSubCategoria.SelectedValue = modelo.ScatCod;
                cbUnidMedida.SelectedValue = modelo.UmedCod;
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    pbImagem.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch { }

                txtQtd_Leave(sender, e);
                txtValorPago_Leave(sender, e);
                txtValorVenda_Leave(sender, e);
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btCat_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria frmCadCat = new frmCadastroCategoria();
            frmCadCat.ShowDialog();
            frmCadCat.Dispose();
            CarregaCategoria();
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria frmCadSubCat = new frmCadastroSubCategoria();
            frmCadSubCat.ShowDialog();
            frmCadSubCat.Dispose();
            CarregaSubCategoria();
        }

        private void btUnd_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeDeMedida frmCadUnd = new frmCadastroUnidadeDeMedida();
            frmCadUnd.ShowDialog();
            frmCadUnd.Dispose();
            CarregaUndMedida();
        }
    }
}
