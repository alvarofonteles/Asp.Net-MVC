using NewPizarriaSys.Dominio;
using NewPizarriaSys.Dominio.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPizarriaSys.WindowsForm
{
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente = new ClienteNegocio().ListarClienteTelefone(txtConsultar.Text);

            if (cliente == null)
                return;

            FrmCadastroCliente frmCadCli = new FrmCadastroCliente(AcaoTela.Consultar, cliente);
            this.Dispose();
            frmCadCli.ShowDialog();
            frmCadCli.Dispose();
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = new ClienteNegocio().ListarTodos();
        }

        private void btnConsTodos_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new ClienteNegocio().ListarTelefones(txtConsultar.Text);

            dgvConsulta.DataSource = bs;
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //duplo clique carrega
            int cod = Convert.ToInt32(dgvConsulta.Rows[e.RowIndex].Cells[0].Value);
            var cliente = new ClienteNegocio().ListarTodos().FirstOrDefault(x => x.Id == cod);
            FrmCadastroCliente frmCadCli = new FrmCadastroCliente(AcaoTela.Consultar, cliente);
            this.Dispose();
            frmCadCli.ShowDialog();
            frmCadCli.Dispose();
        }
    }
}
