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
    public partial class frmConsultaUnidadeDeMedida : Form
    {
        public int codigo = 0;//referente ao codigo da unidade de medida;

        public frmConsultaUnidadeDeMedida()
        {
            InitializeComponent();
        }

        private void frmConsultaUnidadeDeMedida_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvUndMed.Columns[0].HeaderText = "Código";
            dgvUndMed.Columns[0].Width = 70;
            dgvUndMed.Columns[1].HeaderText = "Unidade Medida";
            dgvUndMed.Columns[1].Width = 500;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(conexao);
            dgvUndMed.DataSource = bll.Localizar(txtLocalizar.Text);
        }

        private void dgvUndMed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvUndMed.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
