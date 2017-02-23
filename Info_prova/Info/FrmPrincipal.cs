using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public bool aberto()
        {
            return true;
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCategoria == null)
                MeusFormularios.FormCategoria = new FrmCategoria();

            MeusFormularios.FormCategoria.Show();
            MeusFormularios.FormCategoria.Focus();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProduto == null)
                MeusFormularios.FormProduto = new FrmProduto();

            MeusFormularios.FormProduto.Show();
            MeusFormularios.FormProduto.Focus();
        }

        private void produtoPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormPorCategoria == null)
                MeusFormularios.FormPorCategoria = new FrmProdutoPorCategoria();

            MeusFormularios.FormPorCategoria.Show();
            MeusFormularios.FormPorCategoria.Focus();
        }

        private void pessoasFisicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormPessoaFisica == null)
                MeusFormularios.FormPessoaFisica = new FrmPessoaFisica();

            MeusFormularios.FormPessoaFisica.Show();
            MeusFormularios.FormPessoaFisica.Focus();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormVenda == null)
                MeusFormularios.FormVenda = new FrmVenda();

            MeusFormularios.FormVenda.Show();
            MeusFormularios.FormVenda.Focus();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
    