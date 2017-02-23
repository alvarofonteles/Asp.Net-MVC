using DAL;
using Ferramentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class frmBackupBanco : Form
    {
        public frmBackupBanco()
        {
            InitializeComponent();
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Backup Files |*.bak";
                save.ShowDialog();
                if (!string.IsNullOrEmpty(save.FileName))
                {
                    String nomeBanco = DadosDaConexao.banco;
                    String localBackup = save.FileName;
                    String conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User="
                        + DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    Validacao.BackupDataBase(conexao, nomeBanco, localBackup);

                    MessageBox.Show("Backup realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao realizar o Backup, informe ao seu Administrador.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Restore Files |*.bak";
                open.ShowDialog();
                if (!string.IsNullOrEmpty(open.FileName))
                {
                    String nomeBanco = DadosDaConexao.banco;
                    String localRestore = open.FileName;
                    String conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User="
                        + DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    Validacao.RestauraDatabase(conexao, nomeBanco, localRestore);

                    MessageBox.Show("Restauração realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao realizar a Restauração, informe ao seu Administrador.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
