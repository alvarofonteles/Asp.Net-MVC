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
    public partial class frmConsultaProduto : Form
    {
        public int codigoProd = 0;

        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            Localizar();
        }

        public void Localizar()
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(conexao);
            dgvProduto.DataSource = bll.Localizar(txtLocalizar.Text);
        }
        private void btLocalizar_Click(object sender, EventArgs e)
        {
            Localizar();
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigoProd = Convert.ToInt32(dgvProduto.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
