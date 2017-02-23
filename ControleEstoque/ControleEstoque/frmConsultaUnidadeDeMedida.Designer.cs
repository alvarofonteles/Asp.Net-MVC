namespace ControleEstoque
{
    partial class frmConsultaUnidadeDeMedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaUnidadeDeMedida));
            this.btLocalizar = new System.Windows.Forms.Button();
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUndMed = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUndMed)).BeginInit();
            this.SuspendLayout();
            // 
            // btLocalizar
            // 
            this.btLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.Image = global::ControleEstoque.Properties.Resources.Lupa_32;
            this.btLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLocalizar.Location = new System.Drawing.Point(675, 26);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(99, 37);
            this.btLocalizar.TabIndex = 7;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Location = new System.Drawing.Point(14, 35);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(655, 20);
            this.txtLocalizar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unidade de Medida";
            // 
            // dgvUndMed
            // 
            this.dgvUndMed.AllowUserToAddRows = false;
            this.dgvUndMed.AllowUserToDeleteRows = false;
            this.dgvUndMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUndMed.Location = new System.Drawing.Point(14, 84);
            this.dgvUndMed.Name = "dgvUndMed";
            this.dgvUndMed.ReadOnly = true;
            this.dgvUndMed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUndMed.Size = new System.Drawing.Size(760, 457);
            this.dgvUndMed.TabIndex = 4;
            this.dgvUndMed.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUndMed_CellDoubleClick);
            // 
            // frmConsultaUnidadeDeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.txtLocalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUndMed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaUnidadeDeMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Consulta de Unidade de Medida ::";
            this.Load += new System.EventHandler(this.frmConsultaUnidadeDeMedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUndMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUndMed;
    }
}