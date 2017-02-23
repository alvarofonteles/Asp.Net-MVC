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
    public partial class FrmProdutoPorCategoria : Form
    {
        public FrmProdutoPorCategoria()
        {
            InitializeComponent();
        }

        private void FrmProdutoPorCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormPorCategoria = null;
        }

        private void FrmProdutoPorCategoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)CboCategoria.SelectedValue);//carrega o valor selecionado
        }

        public void Pesquisar(int codigoCategoria)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos.Where(x => x.CodigoCategoria == codigoCategoria);
        }
    }
}
