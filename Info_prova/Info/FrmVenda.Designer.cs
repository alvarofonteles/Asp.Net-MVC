namespace Info
{
    partial class FrmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoPessoaLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label valorLabel2;
            System.Windows.Forms.Label valorPagoLabel;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label codigoVendaLabel;
            System.Windows.Forms.Label codigoStatusLabel;
            System.Windows.Forms.Label dataVencimentoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CboCodigoPessoa = new System.Windows.Forms.ComboBox();
            this.BtnNovaVenda = new System.Windows.Forms.Button();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GbxNovaVenda = new System.Windows.Forms.GroupBox();
            this.TxtDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.contasAReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.statusPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CboProduto = new System.Windows.Forms.ComboBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnFV = new System.Windows.Forms.Button();
            this.BtnFDP = new System.Windows.Forms.Button();
            this.TxtValorPago = new System.Windows.Forms.TextBox();
            this.TxtDesconto = new System.Windows.Forms.TextBox();
            this.TxtValorItens = new System.Windows.Forms.TextBox();
            this.BtnNovoItem = new System.Windows.Forms.Button();
            this.DgvItensVenda = new System.Windows.Forms.DataGridView();
            this.codigoItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCodigoVenda = new System.Windows.Forms.TextBox();
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            valorLabel2 = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            codigoStatusLabel = new System.Windows.Forms.Label();
            dataVencimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.GbxNovaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasAReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItensVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Location = new System.Drawing.Point(14, 15);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(42, 13);
            codigoPessoaLabel.TabIndex = 6;
            codigoPessoaLabel.Text = "Cliente:";
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Location = new System.Drawing.Point(18, 56);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(83, 13);
            codigoProdutoLabel.TabIndex = 21;
            codigoProdutoLabel.Text = "Codigo Produto:";
            // 
            // valorLabel2
            // 
            valorLabel2.AutoSize = true;
            valorLabel2.Location = new System.Drawing.Point(73, 109);
            valorLabel2.Name = "valorLabel2";
            valorLabel2.Size = new System.Drawing.Size(34, 13);
            valorLabel2.TabIndex = 18;
            valorLabel2.Text = "Valor:";
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Location = new System.Drawing.Point(99, 380);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(62, 13);
            valorPagoLabel.TabIndex = 14;
            valorPagoLabel.Text = "Valor Pago:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(105, 351);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(56, 13);
            descontoLabel.TabIndex = 13;
            descontoLabel.Text = "Desconto:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(127, 322);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(34, 13);
            valorLabel1.TabIndex = 12;
            valorLabel1.Text = "Valor:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(42, 83);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // codigoVendaLabel
            // 
            codigoVendaLabel.AutoSize = true;
            codigoVendaLabel.Location = new System.Drawing.Point(24, 30);
            codigoVendaLabel.Name = "codigoVendaLabel";
            codigoVendaLabel.Size = new System.Drawing.Size(77, 13);
            codigoVendaLabel.TabIndex = 0;
            codigoVendaLabel.Text = "Codigo Venda:";
            // 
            // codigoStatusLabel
            // 
            codigoStatusLabel.AutoSize = true;
            codigoStatusLabel.Location = new System.Drawing.Point(321, 322);
            codigoStatusLabel.Name = "codigoStatusLabel";
            codigoStatusLabel.Size = new System.Drawing.Size(111, 13);
            codigoStatusLabel.TabIndex = 22;
            codigoStatusLabel.Text = "Forma de Pagamento:";
            // 
            // dataVencimentoLabel
            // 
            dataVencimentoLabel.AutoSize = true;
            dataVencimentoLabel.Location = new System.Drawing.Point(340, 352);
            dataVencimentoLabel.Name = "dataVencimentoLabel";
            dataVencimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataVencimentoLabel.TabIndex = 23;
            dataVencimentoLabel.Text = "Data Vencimento:";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(Info.DAO.Venda);
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(Info.DAO.Pessoa);
            // 
            // CboCodigoPessoa
            // 
            this.CboCodigoPessoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.CboCodigoPessoa.DataSource = this.pessoaBindingSource;
            this.CboCodigoPessoa.DisplayMember = "Nome";
            this.CboCodigoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCodigoPessoa.FormattingEnabled = true;
            this.CboCodigoPessoa.Location = new System.Drawing.Point(62, 12);
            this.CboCodigoPessoa.Name = "CboCodigoPessoa";
            this.CboCodigoPessoa.Size = new System.Drawing.Size(424, 21);
            this.CboCodigoPessoa.TabIndex = 5;
            this.CboCodigoPessoa.ValueMember = "Codigo";
            // 
            // BtnNovaVenda
            // 
            this.BtnNovaVenda.Location = new System.Drawing.Point(492, 10);
            this.BtnNovaVenda.Name = "BtnNovaVenda";
            this.BtnNovaVenda.Size = new System.Drawing.Size(75, 23);
            this.BtnNovaVenda.TabIndex = 7;
            this.BtnNovaVenda.Text = "Nova Venda";
            this.BtnNovaVenda.UseVisualStyleBackColor = true;
            this.BtnNovaVenda.Click += new System.EventHandler(this.BtnNovaVenda_Click);
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(Info.DAO.ItensVenda);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Info.DAO.Produto);
            // 
            // GbxNovaVenda
            // 
            this.GbxNovaVenda.Controls.Add(this.TxtDataVencimento);
            this.GbxNovaVenda.Controls.Add(this.BtnFinalizar);
            this.GbxNovaVenda.Controls.Add(dataVencimentoLabel);
            this.GbxNovaVenda.Controls.Add(codigoStatusLabel);
            this.GbxNovaVenda.Controls.Add(this.CboStatus);
            this.GbxNovaVenda.Controls.Add(codigoProdutoLabel);
            this.GbxNovaVenda.Controls.Add(this.CboProduto);
            this.GbxNovaVenda.Controls.Add(this.TxtQuantidade);
            this.GbxNovaVenda.Controls.Add(this.TxtValor);
            this.GbxNovaVenda.Controls.Add(valorLabel2);
            this.GbxNovaVenda.Controls.Add(this.BtnImprimir);
            this.GbxNovaVenda.Controls.Add(this.BtnFV);
            this.GbxNovaVenda.Controls.Add(this.BtnFDP);
            this.GbxNovaVenda.Controls.Add(valorPagoLabel);
            this.GbxNovaVenda.Controls.Add(this.TxtValorPago);
            this.GbxNovaVenda.Controls.Add(descontoLabel);
            this.GbxNovaVenda.Controls.Add(this.TxtDesconto);
            this.GbxNovaVenda.Controls.Add(valorLabel1);
            this.GbxNovaVenda.Controls.Add(this.TxtValorItens);
            this.GbxNovaVenda.Controls.Add(this.BtnNovoItem);
            this.GbxNovaVenda.Controls.Add(this.DgvItensVenda);
            this.GbxNovaVenda.Controls.Add(quantidadeLabel);
            this.GbxNovaVenda.Controls.Add(codigoVendaLabel);
            this.GbxNovaVenda.Controls.Add(this.TxtCodigoVenda);
            this.GbxNovaVenda.Location = new System.Drawing.Point(8, 39);
            this.GbxNovaVenda.Name = "GbxNovaVenda";
            this.GbxNovaVenda.Size = new System.Drawing.Size(569, 418);
            this.GbxNovaVenda.TabIndex = 11;
            this.GbxNovaVenda.TabStop = false;
            this.GbxNovaVenda.Text = "Nova Venda";
            this.GbxNovaVenda.Visible = false;
            // 
            // TxtDataVencimento
            // 
            this.TxtDataVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasAReceberBindingSource, "DataVencimento", true));
            this.TxtDataVencimento.Enabled = false;
            this.TxtDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtDataVencimento.Location = new System.Drawing.Point(449, 346);
            this.TxtDataVencimento.Name = "TxtDataVencimento";
            this.TxtDataVencimento.Size = new System.Drawing.Size(110, 20);
            this.TxtDataVencimento.TabIndex = 26;
            // 
            // contasAReceberBindingSource
            // 
            this.contasAReceberBindingSource.DataSource = typeof(Info.DAO.ContasAReceber);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Enabled = false;
            this.BtnFinalizar.Location = new System.Drawing.Point(484, 372);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.BtnFinalizar.TabIndex = 25;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // CboStatus
            // 
            this.CboStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contasAReceberBindingSource, "CodigoStatus", true));
            this.CboStatus.DataSource = this.statusPagamentoBindingSource;
            this.CboStatus.DisplayMember = "Status";
            this.CboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStatus.Enabled = false;
            this.CboStatus.FormattingEnabled = true;
            this.CboStatus.Location = new System.Drawing.Point(438, 319);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(121, 21);
            this.CboStatus.TabIndex = 23;
            this.CboStatus.ValueMember = "CodigoStatus";
            this.CboStatus.SelectedIndexChanged += new System.EventHandler(this.CboStatus_SelectedIndexChanged);
            // 
            // statusPagamentoBindingSource
            // 
            this.statusPagamentoBindingSource.DataSource = typeof(Info.DAO.StatusPagamento);
            // 
            // CboProduto
            // 
            this.CboProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "CodigoProduto", true));
            this.CboProduto.DataSource = this.produtoBindingSource;
            this.CboProduto.DisplayMember = "Descricao";
            this.CboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProduto.FormattingEnabled = true;
            this.CboProduto.Location = new System.Drawing.Point(107, 53);
            this.CboProduto.Name = "CboProduto";
            this.CboProduto.Size = new System.Drawing.Size(121, 21);
            this.CboProduto.TabIndex = 22;
            this.CboProduto.ValueMember = "Codigo";
            this.CboProduto.SelectedIndexChanged += new System.EventHandler(this.CboProduto_SelectedIndexChanged);
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "Quantidade", true));
            this.TxtQuantidade.Location = new System.Drawing.Point(108, 80);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.TxtQuantidade.TabIndex = 21;
            // 
            // TxtValor
            // 
            this.TxtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "Valor", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.TxtValor.Location = new System.Drawing.Point(108, 106);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.ReadOnly = true;
            this.TxtValor.Size = new System.Drawing.Size(100, 20);
            this.TxtValor.TabIndex = 20;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Enabled = false;
            this.BtnImprimir.Location = new System.Drawing.Point(6, 375);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(75, 23);
            this.BtnImprimir.TabIndex = 18;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // BtnFV
            // 
            this.BtnFV.Enabled = false;
            this.BtnFV.Location = new System.Drawing.Point(6, 346);
            this.BtnFV.Name = "BtnFV";
            this.BtnFV.Size = new System.Drawing.Size(95, 23);
            this.BtnFV.TabIndex = 15;
            this.BtnFV.Text = "Finalizar Venda";
            this.BtnFV.UseVisualStyleBackColor = true;
            this.BtnFV.Click += new System.EventHandler(this.BtnFV_Click);
            // 
            // BtnFDP
            // 
            this.BtnFDP.Location = new System.Drawing.Point(6, 317);
            this.BtnFDP.Name = "BtnFDP";
            this.BtnFDP.Size = new System.Drawing.Size(95, 23);
            this.BtnFDP.TabIndex = 16;
            this.BtnFDP.Text = "Finalizar Pedido";
            this.BtnFDP.UseVisualStyleBackColor = true;
            this.BtnFDP.Click += new System.EventHandler(this.BtnFDP_Click);
            // 
            // TxtValorPago
            // 
            this.TxtValorPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.TxtValorPago.Location = new System.Drawing.Point(167, 377);
            this.TxtValorPago.Name = "TxtValorPago";
            this.TxtValorPago.ReadOnly = true;
            this.TxtValorPago.Size = new System.Drawing.Size(100, 20);
            this.TxtValorPago.TabIndex = 15;
            // 
            // TxtDesconto
            // 
            this.TxtDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.TxtDesconto.Location = new System.Drawing.Point(167, 348);
            this.TxtDesconto.Name = "TxtDesconto";
            this.TxtDesconto.ReadOnly = true;
            this.TxtDesconto.Size = new System.Drawing.Size(100, 20);
            this.TxtDesconto.TabIndex = 14;
            // 
            // TxtValorItens
            // 
            this.TxtValorItens.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.TxtValorItens.Location = new System.Drawing.Point(167, 319);
            this.TxtValorItens.Name = "TxtValorItens";
            this.TxtValorItens.ReadOnly = true;
            this.TxtValorItens.Size = new System.Drawing.Size(100, 20);
            this.TxtValorItens.TabIndex = 13;
            // 
            // BtnNovoItem
            // 
            this.BtnNovoItem.Location = new System.Drawing.Point(276, 104);
            this.BtnNovoItem.Name = "BtnNovoItem";
            this.BtnNovoItem.Size = new System.Drawing.Size(75, 23);
            this.BtnNovoItem.TabIndex = 12;
            this.BtnNovoItem.Text = "Novo Item";
            this.BtnNovoItem.UseVisualStyleBackColor = true;
            this.BtnNovoItem.Click += new System.EventHandler(this.BtnNovoItem_Click);
            // 
            // DgvItensVenda
            // 
            this.DgvItensVenda.AllowUserToAddRows = false;
            this.DgvItensVenda.AllowUserToDeleteRows = false;
            this.DgvItensVenda.AutoGenerateColumns = false;
            this.DgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoItemDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.ValorTotal});
            this.DgvItensVenda.DataSource = this.itensVendaBindingSource;
            this.DgvItensVenda.Location = new System.Drawing.Point(6, 138);
            this.DgvItensVenda.Name = "DgvItensVenda";
            this.DgvItensVenda.ReadOnly = true;
            this.DgvItensVenda.Size = new System.Drawing.Size(553, 170);
            this.DgvItensVenda.TabIndex = 8;
            this.DgvItensVenda.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvItensVenda_CellFormatting);
            // 
            // codigoItemDataGridViewTextBoxColumn
            // 
            this.codigoItemDataGridViewTextBoxColumn.DataPropertyName = "CodigoItem";
            this.codigoItemDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoItemDataGridViewTextBoxColumn.Name = "codigoItemDataGridViewTextBoxColumn";
            this.codigoItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ValorTotal
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.ValorTotal.HeaderText = "ValorTotal";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // TxtCodigoVenda
            // 
            this.TxtCodigoVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CodigoVenda", true));
            this.TxtCodigoVenda.Location = new System.Drawing.Point(107, 27);
            this.TxtCodigoVenda.Name = "TxtCodigoVenda";
            this.TxtCodigoVenda.ReadOnly = true;
            this.TxtCodigoVenda.Size = new System.Drawing.Size(51, 20);
            this.TxtCodigoVenda.TabIndex = 1;
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 465);
            this.Controls.Add(this.GbxNovaVenda);
            this.Controls.Add(this.BtnNovaVenda);
            this.Controls.Add(this.CboCodigoPessoa);
            this.Controls.Add(codigoPessoaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVenda";
            this.Text = ":: Venda ::";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVenda_FormClosed);
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.GbxNovaVenda.ResumeLayout(false);
            this.GbxNovaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasAReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItensVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.Button BtnNovaVenda;
        private System.Windows.Forms.ComboBox CboCodigoPessoa;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.GroupBox GbxNovaVenda;
        private System.Windows.Forms.ComboBox CboProduto;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnFV;
        private System.Windows.Forms.Button BtnFDP;
        private System.Windows.Forms.TextBox TxtValorPago;
        private System.Windows.Forms.TextBox TxtDesconto;
        private System.Windows.Forms.TextBox TxtValorItens;
        private System.Windows.Forms.Button BtnNovoItem;
        private System.Windows.Forms.DataGridView DgvItensVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.TextBox TxtCodigoVenda;
        private System.Windows.Forms.ComboBox CboStatus;
        private System.Windows.Forms.BindingSource contasAReceberBindingSource;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.BindingSource statusPagamentoBindingSource;
        private System.Windows.Forms.DateTimePicker TxtDataVencimento;
    }
}