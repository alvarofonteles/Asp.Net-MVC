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
    public partial class frmConsultaFornecedor : Form
    {
        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }

        public int codigo;

        private void frmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            Localizar(txtFornecedor.Text);
        }

        public void Localizar(String localizar)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(conexao);
            dgvFornecedor.DataSource = bll.Localizar(localizar);
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            dgvFornecedor.Columns[0].HeaderText = "Código";
            dgvFornecedor.Columns[0].Width = 70;
            dgvFornecedor.Columns[1].HeaderText = "Fornecedor";
            dgvFornecedor.Columns[1].Width = 200;
            dgvFornecedor.Columns[2].HeaderText = "Razão Social";
            dgvFornecedor.Columns[2].Width = 180;
            dgvFornecedor.Columns[3].HeaderText = "Insc. Estadual";
            dgvFornecedor.Columns[3].Width = 110;
            dgvFornecedor.Columns[4].HeaderText = "CNPJ";
            dgvFornecedor.Columns[4].Width = 110;
            dgvFornecedor.Columns[5].HeaderText = "CEP";
            dgvFornecedor.Columns[5].Width = 110;
            dgvFornecedor.Columns[6].HeaderText = "Endereço";
            dgvFornecedor.Columns[6].Width = 230;
            dgvFornecedor.Columns[7].HeaderText = "Bairro";
            dgvFornecedor.Columns[7].Width = 150;
            dgvFornecedor.Columns[8].HeaderText = "Telefone";
            dgvFornecedor.Columns[8].Width = 110;
            dgvFornecedor.Columns[9].HeaderText = "Celular";
            dgvFornecedor.Columns[9].Width = 110;
            dgvFornecedor.Columns[10].HeaderText = "E-mail";
            dgvFornecedor.Columns[10].Width = 200;
            dgvFornecedor.Columns[11].HeaderText = "Numero";
            dgvFornecedor.Columns[11].Width = 150;
            dgvFornecedor.Columns[12].HeaderText = "Cidade";
            dgvFornecedor.Columns[12].Width = 90;
            dgvFornecedor.Columns[13].HeaderText = "Estado";
            dgvFornecedor.Columns[13].Width = 110;
        }

        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvFornecedor.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            Localizar(txtFornecedor.Text);
        }
    }
}
