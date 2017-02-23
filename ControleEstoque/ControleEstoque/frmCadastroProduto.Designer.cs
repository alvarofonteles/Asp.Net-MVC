namespace ControleEstoque
{
    partial class frmCadastroProduto
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
            this.btUnd = new System.Windows.Forms.Button();
            this.txtSub = new System.Windows.Forms.Button();
            this.txtCat = new System.Windows.Forms.Button();
            this.btRemoverImg = new System.Windows.Forms.Button();
            this.btCarregaImg = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUnidMedida = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnImagem = new System.Windows.Forms.Panel();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.pnBotoes.SuspendLayout();
            this.pnDados.SuspendLayout();
            this.pnImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.pnImagem);
            this.pnDados.Controls.Add(this.btUnd);
            this.pnDados.Controls.Add(this.txtSub);
            this.pnDados.Controls.Add(this.txtCat);
            this.pnDados.Controls.Add(this.btRemoverImg);
            this.pnDados.Controls.Add(this.btCarregaImg);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.cbUnidMedida);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.cbSubCategoria);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.cbCategoria);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtValorVenda);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtValorPago);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtQtd);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtDescricao);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtProduto);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label1);
            // 
            // btUnd
            // 
            this.btUnd.Location = new System.Drawing.Point(198, 397);
            this.btUnd.Name = "btUnd";
            this.btUnd.Size = new System.Drawing.Size(23, 21);
            this.btUnd.TabIndex = 46;
            this.btUnd.Text = "+";
            this.btUnd.UseVisualStyleBackColor = true;
            this.btUnd.Click += new System.EventHandler(this.btUnd_Click);
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(355, 348);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(23, 21);
            this.txtSub.TabIndex = 45;
            this.txtSub.Text = "+";
            this.txtSub.UseVisualStyleBackColor = true;
            this.txtSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(169, 348);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(23, 21);
            this.txtCat.TabIndex = 44;
            this.txtCat.Text = "+";
            this.txtCat.UseVisualStyleBackColor = true;
            this.txtCat.Click += new System.EventHandler(this.btCat_Click);
            // 
            // btRemoverImg
            // 
            this.btRemoverImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverImg.Image = global::ControleEstoque.Properties.Resources.Excluir2_;
            this.btRemoverImg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRemoverImg.Location = new System.Drawing.Point(586, 310);
            this.btRemoverImg.Name = "btRemoverImg";
            this.btRemoverImg.Size = new System.Drawing.Size(160, 94);
            this.btRemoverImg.TabIndex = 43;
            this.btRemoverImg.Text = "Remover Imagem";
            this.btRemoverImg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRemoverImg.UseVisualStyleBackColor = true;
            this.btRemoverImg.Click += new System.EventHandler(this.btRemoverImg_Click);
            // 
            // btCarregaImg
            // 
            this.btCarregaImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarregaImg.Image = global::ControleEstoque.Properties.Resources.Carregar_;
            this.btCarregaImg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCarregaImg.Location = new System.Drawing.Point(406, 310);
            this.btCarregaImg.Name = "btCarregaImg";
            this.btCarregaImg.Size = new System.Drawing.Size(160, 94);
            this.btCarregaImg.TabIndex = 42;
            this.btCarregaImg.Text = "Carregar Imagem";
            this.btCarregaImg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCarregaImg.UseVisualStyleBackColor = true;
            this.btCarregaImg.Click += new System.EventHandler(this.btLoFoto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Imagem";
            // 
            // cbUnidMedida
            // 
            this.cbUnidMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidMedida.FormattingEnabled = true;
            this.cbUnidMedida.Location = new System.Drawing.Point(14, 397);
            this.cbUnidMedida.Name = "cbUnidMedida";
            this.cbUnidMedida.Size = new System.Drawing.Size(178, 21);
            this.cbUnidMedida.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Unidade de Medida";
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(200, 348);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(149, 21);
            this.cbSubCategoria.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "SubCategoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(14, 348);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(149, 21);
            this.cbCategoria.TabIndex = 36;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Categoria";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(275, 303);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(103, 20);
            this.txtValorVenda.TabIndex = 34;
            this.txtValorVenda.Text = "0.00";
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Valor Venda";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(143, 303);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(100, 20);
            this.txtValorPago.TabIndex = 32;
            this.txtValorPago.Text = "0.00";
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Valor Pago";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(14, 303);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 30;
            this.txtQtd.Text = "0.00";
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            this.txtQtd.Leave += new System.EventHandler(this.txtQtd_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(14, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Quantidade";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(14, 120);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(364, 156);
            this.txtDescricao.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Descrição";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(14, 73);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(364, 20);
            this.txtProduto.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Produto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(14, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Código";
            // 
            // pnImagem
            // 
            this.pnImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnImagem.Controls.Add(this.pbImagem);
            this.pnImagem.Location = new System.Drawing.Point(406, 29);
            this.pnImagem.Name = "pnImagem";
            this.pnImagem.Size = new System.Drawing.Size(339, 246);
            this.pnImagem.TabIndex = 47;
            // 
            // pbImagem
            // 
            this.pbImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagem.Location = new System.Drawing.Point(0, 0);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(337, 244);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 0;
            this.pbImagem.TabStop = false;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroProduto";
            this.Text = ".:: Cadastro de Produto ::.";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.pnBotoes.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUnd;
        private System.Windows.Forms.Button txtSub;
        private System.Windows.Forms.Button txtCat;
        private System.Windows.Forms.Button btRemoverImg;
        private System.Windows.Forms.Button btCarregaImg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbUnidMedida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnImagem;
        private System.Windows.Forms.PictureBox pbImagem;
    }
}
