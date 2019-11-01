namespace wfaGestaoEstoque.View
{
    partial class frmCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastros));
            this.btnConsumidores = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsumidores
            // 
            this.btnConsumidores.Location = new System.Drawing.Point(8, 12);
            this.btnConsumidores.Name = "btnConsumidores";
            this.btnConsumidores.Size = new System.Drawing.Size(233, 51);
            this.btnConsumidores.TabIndex = 0;
            this.btnConsumidores.Text = "Consumidores";
            this.btnConsumidores.UseVisualStyleBackColor = true;
            this.btnConsumidores.Click += new System.EventHandler(this.btnConsumidores_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Location = new System.Drawing.Point(8, 69);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(233, 51);
            this.btnFornecedores.TabIndex = 1;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(8, 126);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(233, 51);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // frmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 182);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.btnConsumidores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsumidores;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnProdutos;
    }
}