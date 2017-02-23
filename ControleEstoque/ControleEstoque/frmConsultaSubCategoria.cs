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
    public partial class frmConsultaSubCategoria : Form
    {
        public int codigo = 0;

        public frmConsultaSubCategoria()
        {
            InitializeComponent();
        }

        private void frmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            this.button1_Click(sender, e);
            dgvSubCategoria.Columns[0].HeaderText = "Cód SubCat";
            dgvSubCategoria.Columns[0].Width = 90;
            dgvSubCategoria.Columns[1].HeaderText = "SubCategoria";
            dgvSubCategoria.Columns[1].Width = 300;
            dgvSubCategoria.Columns[2].HeaderText = "Cód Cat";
            dgvSubCategoria.Columns[2].Width = 70;
            dgvSubCategoria.Columns[3].HeaderText = "Categoria";
            dgvSubCategoria.Columns[3].Width = 250;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSubCategoria bll = new BLLSubCategoria(conexao);
            dgvSubCategoria.DataSource = bll.Localizar(txtLocalizarSub.Text);
        }

        private void dgvSubCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvSubCategoria.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
