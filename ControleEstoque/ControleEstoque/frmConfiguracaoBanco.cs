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
    public partial class frmConfiguracaoBanco : Form
    {
        public frmConfiguracaoBanco()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter EscreveArquivo = new StreamWriter("ConfiguracaoBanco.txt", false);
                EscreveArquivo.WriteLine(txtServidor.Text);
                EscreveArquivo.WriteLine(txtBanco.Text);
                EscreveArquivo.WriteLine(txtUsuario.Text);
                EscreveArquivo.WriteLine(txtSenha.Text);
                EscreveArquivo.Close();
                MessageBox.Show("Arquivo Atualizado com sucesso!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void frmConfiguracaoBanco_Load(object sender, EventArgs e)
        {
            StreamReader LerArquivo = new StreamReader("ConfiguracaoBanco.txt");
            txtServidor.Text = LerArquivo.ReadLine();
            txtBanco.Text = LerArquivo.ReadLine();
            txtUsuario.Text = LerArquivo.ReadLine();
            txtSenha.Text = LerArquivo.ReadLine();
            LerArquivo.Close();
        }

        private void btTestar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao.servidor = txtServidor.Text;
                DadosDaConexao.banco = txtBanco.Text;
                DadosDaConexao.usuario = txtUsuario.Text;
                DadosDaConexao.senha = txtSenha.Text;
                //testar a nova conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Conectado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Verifique os dados informados.\n\n", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
