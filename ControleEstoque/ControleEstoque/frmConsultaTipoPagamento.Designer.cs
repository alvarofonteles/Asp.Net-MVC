namespace ControleEstoque
{
    partial class frmConsultaTipoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaTipoPagamento));
            this.dgvTipoPag = new System.Windows.Forms.DataGridView();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPag)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoPag
            // 
            this.dgvTipoPag.AllowUserToAddRows = false;
            this.dgvTipoPag.AllowUserToDeleteRows = false;
            this.dgvTipoPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPag.Location = new System.Drawing.Point(12, 86);
            this.dgvTipoPag.Name = "dgvTipoPag";
            this.dgvTipoPag.ReadOnly = true;
            this.dgvTipoPag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoPag.Size = new System.Drawing.Size(760, 455);
            this.dgvTipoPag.TabIndex = 7;
            this.dgvTipoPag.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoPag_CellDoubleClick);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLocalizar.Location = new System.Drawing.Point(685, 33);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(87, 23);
            this.btLocalizar.TabIndex = 6;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(12, 35);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(655, 20);
            this.txtPagamento.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Pagamento";
            // 
            // frmConsultaTipoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvTipoPag);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaTipoPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: ConsultaTipoPagamento ::";
            this.Load += new System.EventHandler(this.frmConsultaTipoPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoPag;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.Label label1;
    }
}