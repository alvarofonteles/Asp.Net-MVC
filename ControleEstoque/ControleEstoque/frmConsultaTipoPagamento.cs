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
    public partial class frmConsultaTipoPagamento : Form
    {
        public int codigo;

        public frmConsultaTipoPagamento()
        {
            InitializeComponent();
        }

        private void frmConsultaTipoPagamento_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);

            dgvTipoPag.Columns[0].HeaderText = "Código";
            dgvTipoPag.Columns[0].Width = 80;
            dgvTipoPag.Columns[1].HeaderText = "Pagamento";
            dgvTipoPag.Columns[1].Width = 320;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(conexao);
            dgvTipoPag.DataSource = bll.Localizar(txtPagamento.Text);

        }

        private void dgvTipoPag_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvTipoPag.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

    }
}
