using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria frmCadCat = new frmCadastroCategoria();
            frmCadCat.ShowDialog();
            frmCadCat.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria frmConsCat = new frmConsultaCategoria();
            frmConsCat.ShowDialog();
            frmConsCat.Dispose();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria frmCadScat = new frmCadastroSubCategoria();
            frmCadScat.ShowDialog();
            frmCadScat.Dispose();
        }

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria frmConsSubCat = new frmConsultaSubCategoria();
            frmConsSubCat.ShowDialog();
            frmConsSubCat.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeDeMedida frmCadUniMed = new frmCadastroUnidadeDeMedida();
            frmCadUniMed.ShowDialog();
            frmCadUniMed.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida frmConsUniMed = new frmConsultaUnidadeDeMedida();
            frmConsUniMed.ShowDialog();
            frmConsUniMed.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmCadProd = new frmCadastroProduto();
            frmCadProd.ShowDialog();
            frmCadProd.Dispose();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto frmConsProd = new frmConsultaProduto();
            frmConsProd.ShowDialog();
            frmConsProd.Dispose();
        }

        private void configuraçãoDoBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracaoBanco frmConfBan = new frmConfiguracaoBanco();
            frmConfBan.ShowDialog();
            frmConfBan.Dispose();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void mSExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader lerArquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDaConexao.servidor = lerArquivo.ReadLine();
                DadosDaConexao.banco = lerArquivo.ReadLine();
                DadosDaConexao.usuario = lerArquivo.ReadLine();
                DadosDaConexao.senha = lerArquivo.ReadLine();
                lerArquivo.Close();
                //testar a nova conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados\n"
                    + "Acesse as configurações do banco de dados \n"
                    + "e informe os parametros de conexão\n\n", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
        }

        private void backupDoBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupBanco frmBackupBanc = new frmBackupBanco();
            frmBackupBanc.ShowDialog();
            frmBackupBanc.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTipoPagamento frmCadTipPag = new frmCadastroTipoPagamento();
            frmCadTipPag.ShowDialog();
            frmCadTipPag.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPagamento frmConsTipPag = new frmConsultaTipoPagamento();
            frmConsTipPag.ShowDialog();
            frmConsTipPag.Dispose();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente frmConsCli = new frmConsultaCliente();
            frmConsCli.ShowDialog();
            frmConsCli.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCadCli = new frmCadastroCliente();
            frmCadCli.ShowDialog();
            frmCadCli.Dispose();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor frmConsForn = new frmConsultaFornecedor();
            frmConsForn.ShowDialog();
            frmConsForn.Dispose();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor frmCadForn = new frmCadastroFornecedor();
            frmCadForn.ShowDialog();
            frmCadForn.Dispose();
        }
    }
}
