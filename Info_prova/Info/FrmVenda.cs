using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Info.DAO;

namespace Info
{
    public partial class FrmVenda : Form
    {
        public FrmVenda()
        {
            InitializeComponent();
        }

        private void FrmVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool _found = false;

            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FrmPrincipal)
                {
                    _openForm.WindowState = FormWindowState.Normal;
                    _openForm.Focus();

                    _found = true;
                }
            }
            if (!_found)
            {
                FrmPrincipal _FrmPrincipal = new FrmPrincipal();
                _FrmPrincipal.Show();
            }
            MeusFormularios.FormVenda = null;
        }

        public Venda VendaCorrent
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }

        public ItensVenda ItemCorrente
        {
            get
            {
                return (ItensVenda)this.itensVendaBindingSource.Current;
            }
        }

        public ContasAReceber ContaCorrente
        {
            get
            {
                return (ContasAReceber)this.contasAReceberBindingSource.Current;
            }
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            this.pessoaBindingSource.DataSource =
                DataContextFactory.DataContext.Pessoas;

            this.vendaBindingSource.DataSource =
                DataContextFactory.DataContext.Vendas;

            this.produtoBindingSource.DataSource =
                DataContextFactory.DataContext.Produtos;

            this.vendaBindingSource.AddNew();

            this.contasAReceberBindingSource.DataSource =
                DataContextFactory.DataContext.ContasARecebers;

            this.statusPagamentoBindingSource.DataSource =
                DataContextFactory.DataContext.StatusPagamentos;
        }

        private void BtnNovaVenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            CboCodigoPessoa.Enabled = false;
            GbxNovaVenda.Visible = true;
            BtnNovaVenda.Enabled = false;
            this.itensVendaBindingSource.Clear();
            this.itensVendaBindingSource.DataSource =
                DataContextFactory.DataContext.ItensVendas.Where(x => x.CodigoProduto
                    == this.VendaCorrent.CodigoVenda);//x.codigoproduto
            NovoItem();
        }

        private void NovoItem()
        {
            this.itensVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrent.CodigoVenda;
            this.ItemCorrente.Quantidade = 1;
        }

        private void BtnNovoItem_Click(object sender, EventArgs e)
        {
            this.itensVendaBindingSource.EndEdit();
            DgvItensVenda.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();
        }

        private void DgvItensVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Produto)e.Value).Descricao;
        }

        private void CboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboProduto.SelectedItem != null)
            {
                var pro = (Produto)CboProduto.SelectedItem;
                this.ItemCorrente.CodigoProduto = (int)pro.Codigo;
                this.ItemCorrente.Valor = (decimal)pro.Valor;
            }
        }

        private void MostraSomaValores()
        {
            decimal total = 0;
            foreach (DataGridViewRow dg in DgvItensVenda.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subtotal = v1 * v2;
                dg.Cells[4].Value = subtotal;
                total = total + subtotal;
            }
            this.VendaCorrent.Valor = total;
        }

        private void BtnFDP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar pedito?\nNão será possível adicionar um novo item",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itensVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrent.Desconto = 0;
                BtnNovoItem.Enabled = false;
                CboProduto.Enabled = false;
                TxtValor.Enabled = false;
                TxtQuantidade.Enabled = false;
                TxtCodigoVenda.Enabled = false;
                TxtDesconto.ReadOnly = false;
                TxtDesconto.Focus();
                BtnFDP.Enabled = false;
                BtnFV.Enabled = true;
            }
        }

        private void BtnFV_Click(object sender, EventArgs e)
        {
            this.VendaCorrent.Desconto = Convert.ToDecimal(TxtDesconto.Text);
            this.VendaCorrent.ValorPago = (decimal)(this.VendaCorrent.Valor - this.VendaCorrent.Desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            TxtDesconto.Enabled = false;
            BtnFV.Enabled = false;
            //contas a receber
            this.contasAReceberBindingSource.AddNew();
            CboStatus.Enabled = true;
            this.ContaCorrente.CodigoVenda = this.VendaCorrent.CodigoVenda;
            this.ContaCorrente.DataCompra = DateTime.Now;
            this.ContaCorrente.DataVencimento = DateTime.Now;
        }

        private void CboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CboStatus.SelectedItem != null)
            {
                var status = (StatusPagamento)CboStatus.SelectedItem;
                if (status.CodigoStatus == 1)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.CodigoStatus;
                    this.ContaCorrente.DataPagamento = DateTime.Now;
                    BtnFinalizar.Enabled = true;
                    TxtDataVencimento.Enabled = false;
                }
                else if (status.CodigoStatus == 2)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.CodigoStatus;
                    this.ContaCorrente.DataVencimento = DateTime.Now;
                    this.ContaCorrente.DataPagamento = null;
                    TxtDataVencimento.Enabled = true;
                    BtnFinalizar.Enabled = true;
                }
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            this.contasAReceberBindingSource.EndEdit();
            TxtDataVencimento.Enabled = false;
            CboStatus.Enabled = false;
            DataContextFactory.DataContext.SubmitChanges();
            BtnImprimir.Enabled = true;
            BtnFinalizar.Enabled = false;
            MessageBox.Show("Venda finalizada com sucesso.\nImprima o cupom da venda", "Venda Finalizada");
        }
    }
}
