﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Info.DAO;

namespace Info
{
    public partial class FrmPessoaFisica : Form
    {
        public FrmPessoaFisica()
        {
            InitializeComponent();
        }

        private void FrmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormPessoaFisica = null;
        }

        private void FrmPessoaFisica_Load(object sender, EventArgs e)
        {
            this.pessoaBindingSource.DataSource = DataContextFactory.DataContext.PessoaFisicas.Select(x => x.Pessoa);
        }

        public Pessoa PessoaCorrete
        {
            get
            {
                return (Pessoa)this.pessoaBindingSource.Current;
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.nomeTextBox.Focus();
            this.pessoaBindingSource.AddNew();
            this.PessoaCorrete.PessoaFisica = new PessoaFisica();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            this.pessoaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            this.pessoaDataGridView.Refresh();
            MessageBox.Show("Gravado com sucesso.");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.pessoaBindingSource.CancelEdit();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes) 
            {
                this.pessoaBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Excluido com sucesso.");
            }
        }

        private void pessoaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4)
                e.Value = ((PessoaFisica)e.Value).CPF;//cast

            if (e.Value != null && e.ColumnIndex == 5)
                e.Value = ((PessoaFisica)e.Value).RG;
        }
    }
}
