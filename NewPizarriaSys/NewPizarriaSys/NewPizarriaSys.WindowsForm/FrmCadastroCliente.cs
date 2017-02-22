using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewPizarriaSys.Dominio;
using NewPizarriaSys.Dominio.Negocios;

namespace NewPizarriaSys.WindowsForm
{
    public partial class FrmCadastroCliente : Form
    {
        private AcaoTela _acaoTela;//enum
        public FrmCadastroCliente(AcaoTela acaoTela, Cliente cliente)
        {
            InitializeComponent();
            _acaoTela = acaoTela;

            if (_acaoTela == AcaoTela.Consultar)
            {
                txtCodigo.Text = cliente.Id.ToString();
                txtNome.Text = cliente.Nome;
                txtTelefone.Text = cliente.Telefone;
                txtEmail.Text = cliente.Email;
            }
        }

        private void LimparTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtNome.Focus();
            txtTelefone.Clear();
            txtEmail.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text
            };

            if (txtCodigo.Text.Trim().Length > 0)
            {
                cliente.Id = Convert.ToInt32(txtCodigo.Text);
                MessageBox.Show("Alterado com sucesso.", "Aviso");
            }
            else
                MessageBox.Show("Salvo com sucesso.", "Aviso");
            new ClienteNegocio().Salvar(cliente);
        }
    }
}
