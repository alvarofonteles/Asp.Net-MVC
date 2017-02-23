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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCategoria = null;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private bool Valida()
        {
            if (TxtCategoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo categoria obrigatório");
                TxtCategoria.Focus();
                return false;
            }
            return true;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtCategoria.Focus();

            if (Valida())
            {
                this.categoriaBindingSource.AddNew();
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                if (MessageBox.Show("Deseja Gravar?", "Atenção!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.categoriaBindingSource.EndEdit();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria armazenada com sucesso.", "Confirmação.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.categoriaBindingSource.CancelEdit();
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
            MessageBox.Show("Categoria cancelada com sucesso.", "Confirmação.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.CategoriaPossuiProduto(this.CategoriaCorrente))//testa se existe produto 
                        MessageBox.Show("Impossível excluir categoria que tenha produto!");
                    else
                    {
                        this.categoriaBindingSource.RemoveCurrent();
                        DataContextFactory.DataContext.SubmitChanges();
                        MessageBox.Show("Categoria excluida com sucesso", "Confirmação.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public Categoria CategoriaCorrente //pega categoria corrente
        {
            get
            {
                return (Categoria)this.categoriaBindingSource.Current;
            }
        }

        private bool CategoriaPossuiProduto(Categoria categoria)//pesquisa se tem o produto da categoria
        {
            var produtos = DataContextFactory.DataContext.Produtos.Where(x => x.Categoria.Codigo == categoria.Codigo);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
        }
    }
}
