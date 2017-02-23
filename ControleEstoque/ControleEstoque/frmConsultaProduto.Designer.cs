namespace ControleEstoque
{
    partial class frmConsultaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProduto));
            this.btLocalizar = new System.Windows.Forms.Button();
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.pro_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_valorpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_valorvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umed_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scat_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btLocalizar
            // 
            this.btLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.Image = global::ControleEstoque.Properties.Resources.Lupa_32;
            this.btLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLocalizar.Location = new System.Drawing.Point(678, 16);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(99, 37);
            this.btLocalizar.TabIndex = 6;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Location = new System.Drawing.Point(12, 25);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(660, 20);
            this.txtLocalizar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produto";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pro_cod,
            this.pro_nome,
            this.pro_descricao,
            this.pro_foto,
            this.pro_valorpago,
            this.pro_valorvenda,
            this.umed_cod,
            this.cat_cod,
            this.scat_cod});
            this.dgvProduto.Location = new System.Drawing.Point(15, 63);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(757, 486);
            this.dgvProduto.TabIndex = 7;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellDoubleClick);
            // 
            // pro_cod
            // 
            this.pro_cod.DataPropertyName = "pro_cod";
            this.pro_cod.HeaderText = "Código";
            this.pro_cod.Name = "pro_cod";
            this.pro_cod.ReadOnly = true;
            // 
            // pro_nome
            // 
            this.pro_nome.DataPropertyName = "pro_nome";
            this.pro_nome.HeaderText = "Produto";
            this.pro_nome.Name = "pro_nome";
            this.pro_nome.ReadOnly = true;
            // 
            // pro_descricao
            // 
            this.pro_descricao.DataPropertyName = "pro_descricao";
            this.pro_descricao.HeaderText = "Descrição";
            this.pro_descricao.Name = "pro_descricao";
            this.pro_descricao.ReadOnly = true;
            // 
            // pro_foto
            // 
            this.pro_foto.DataPropertyName = "pro_foto";
            this.pro_foto.HeaderText = "Foto";
            this.pro_foto.Name = "pro_foto";
            this.pro_foto.ReadOnly = true;
            this.pro_foto.Visible = false;
            // 
            // pro_valorpago
            // 
            this.pro_valorpago.DataPropertyName = "pro_valorpago";
            this.pro_valorpago.HeaderText = "Pago";
            this.pro_valorpago.Name = "pro_valorpago";
            this.pro_valorpago.ReadOnly = true;
            // 
            // pro_valorvenda
            // 
            this.pro_valorvenda.DataPropertyName = "pro_valorvenda";
            this.pro_valorvenda.HeaderText = "Venda";
            this.pro_valorvenda.Name = "pro_valorvenda";
            this.pro_valorvenda.ReadOnly = true;
            // 
            // umed_cod
            // 
            this.umed_cod.DataPropertyName = "umed_cod";
            this.umed_cod.HeaderText = "Und";
            this.umed_cod.Name = "umed_cod";
            this.umed_cod.ReadOnly = true;
            // 
            // cat_cod
            // 
            this.cat_cod.DataPropertyName = "cat_cod";
            this.cat_cod.HeaderText = "Categoria";
            this.cat_cod.Name = "cat_cod";
            this.cat_cod.ReadOnly = true;
            // 
            // scat_cod
            // 
            this.scat_cod.DataPropertyName = "scat_cod";
            this.scat_cod.HeaderText = "SubCategoria";
            this.scat_cod.Name = "scat_cod";
            this.scat_cod.ReadOnly = true;
            // 
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.txtLocalizar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Consulta Produto ::";
            this.Load += new System.EventHandler(this.frmConsultaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_valorpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_valorvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn umed_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn scat_cod;
    }
}