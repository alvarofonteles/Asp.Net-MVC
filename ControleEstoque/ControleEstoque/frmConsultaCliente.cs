using BLL;
using DAL;
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
    public partial class frmConsultaCliente : Form
    {
        public int codigo;
        private int localizar; //1-nome 2-cpfcnpj

        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
        }

        private void CarregaGrid()
        {
            dgvCliente.Columns[0].HeaderText = "Código";
            dgvCliente.Columns[0].Width = 70;
            dgvCliente.Columns[1].HeaderText = "Cliente";
            dgvCliente.Columns[1].Width = 200;
            if (this.localizar == 1)
            {
                dgvCliente.Columns[2].HeaderText = "CPF";
                dgvCliente.Columns[2].Width = 110;
                dgvCliente.Columns[3].HeaderText = "RG";
                dgvCliente.Columns[3].Width = 110;
                dgvCliente.Columns[4].Visible = false;//Razao
            }
            else
            {
                dgvCliente.Columns[2].HeaderText = "CNPJ";
                dgvCliente.Columns[2].Width = 110;
                dgvCliente.Columns[3].HeaderText = "Insc. Estadual";
                dgvCliente.Columns[3].Width = 110;
                dgvCliente.Columns[4].Visible = true;//Razao
                dgvCliente.Columns[4].HeaderText = "Razão Social";
                dgvCliente.Columns[4].Width = 180;
            }
            dgvCliente.Columns[5].Visible = false;//Tipo
            dgvCliente.Columns[6].HeaderText = "CEP";
            dgvCliente.Columns[6].Width = 110;
            dgvCliente.Columns[7].HeaderText = "Endereço";
            dgvCliente.Columns[7].Width = 230;
            dgvCliente.Columns[8].HeaderText = "Bairro";
            dgvCliente.Columns[8].Width = 150;
            dgvCliente.Columns[9].HeaderText = "Telefone";
            dgvCliente.Columns[9].Width = 110;
            dgvCliente.Columns[10].HeaderText = "Celular";
            dgvCliente.Columns[10].Width = 110;
            dgvCliente.Columns[11].HeaderText = "E-mail";
            dgvCliente.Columns[11].Width = 200;
            dgvCliente.Columns[12].HeaderText = "Complemento";
            dgvCliente.Columns[12].Width = 150;
            dgvCliente.Columns[13].HeaderText = "Cidade";
            dgvCliente.Columns[13].Width = 90;
            dgvCliente.Columns[14].HeaderText = "Estado";
            dgvCliente.Columns[14].Width = 110;
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(conexao);
            int tipo;
            if (rbFisica.Checked == true)
            {
                tipo = 0;
                try
                {
                    int cpf = Convert.ToInt32(txtCliente.Text);
                    dgvCliente.DataSource = bll.LocalizarCpfCnpj(txtCliente.Text, tipo);
                }
                catch
                {
                    dgvCliente.DataSource = bll.LocalizarNome(txtCliente.Text, tipo);
                }
                this.localizar = 1;
            }
            else
            {
                tipo = 1;
                try
                {
                    int cpfcnpj = Convert.ToInt32(txtCliente.Text);
                    dgvCliente.DataSource = bll.LocalizarCpfCnpj(txtCliente.Text, tipo);
                }
                catch
                {
                    dgvCliente.DataSource = bll.LocalizarNome(txtCliente.Text, tipo);
                }
                this.localizar = 2;
            }
            CarregaGrid();
        }
    }
}
