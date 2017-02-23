namespace ControleEstoque
{
    partial class frmBackupBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupBanco));
            this.btRestaurar = new System.Windows.Forms.Button();
            this.btBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRestaurar
            // 
            this.btRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestaurar.Image = global::ControleEstoque.Properties.Resources.VoltarBackUp_256;
            this.btRestaurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRestaurar.Location = new System.Drawing.Point(393, 12);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(379, 239);
            this.btRestaurar.TabIndex = 5;
            this.btRestaurar.Text = "Restaurar o Banco";
            this.btRestaurar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRestaurar.UseVisualStyleBackColor = true;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // btBackup
            // 
            this.btBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackup.Image = global::ControleEstoque.Properties.Resources.CriarBackUp_256;
            this.btBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btBackup.Location = new System.Drawing.Point(12, 12);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(375, 239);
            this.btBackup.TabIndex = 4;
            this.btBackup.Text = "BackUp do Banco";
            this.btBackup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // frmBackupBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 263);
            this.Controls.Add(this.btRestaurar);
            this.Controls.Add(this.btBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackupBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Backup do Banco de Dados ::";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRestaurar;
        private System.Windows.Forms.Button btBackup;
    }
}