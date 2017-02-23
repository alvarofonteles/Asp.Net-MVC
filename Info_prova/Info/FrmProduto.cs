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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormProduto = null;
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }

        private bool Valida()
        {
            if (descricaoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo descrrição obrigatório!");
                descricaoTextBox.Focus();
                return false;
            }
            return true;
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                if (MessageBox.Show("Deseja Gravar realmente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.produtoBindingSource.EndEdit();
                    DataContextFactory.DataContext.SubmitChanges();
                    produtoDataGridView.Refresh();
                    MessageBox.Show("Gravado com sucesso!");
                }
                else this.produtoBindingSource.CancelEdit();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
            MessageBox.Show("Categoria cancelada com sucesso.", "Confirmação.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir realmente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.produtoBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Excluido com sucesso!");
            }
        }

        private void produtoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Categoria)e.Value).Descricao;//exibe a descricao da tabela categoria
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
