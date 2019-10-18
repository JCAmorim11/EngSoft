namespace wfaGestaoEstoque
{
    partial class frmIncio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECIONE SEU DESTINO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(185, 125);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(90, 49);
            this.btnCad.TabIndex = 1;
            this.btnCad.Text = "Cadastros";
            this.btnCad.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.Location = new System.Drawing.Point(185, 180);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(90, 57);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(338, 180);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(104, 57);
            this.btnVendas.TabIndex = 4;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(185, 243);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 51);
            this.button5.TabIndex = 5;
            this.button5.Text = "Inventario";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(338, 243);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 52);
            this.button6.TabIndex = 6;
            this.button6.Text = "Produtos";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SESSÃO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Locais";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmIncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.label1);
            this.Name = "frmIncio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

