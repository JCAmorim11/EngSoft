namespace wfaGestaoEstoque.View
{
    partial class frmCadConsum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblValida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(121, 82);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(131, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(55, 167);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(197, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cadastro de Consumidor";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(121, 128);
            this.mskCPF.Mask = "999,999,999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(85, 20);
            this.mskCPF.TabIndex = 3;
            this.mskCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskCPF_KeyPress);
            // 
            // lblValida
            // 
            this.lblValida.AutoSize = true;
            this.lblValida.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValida.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblValida.Location = new System.Drawing.Point(272, 171);
            this.lblValida.Name = "lblValida";
            this.lblValida.Size = new System.Drawing.Size(132, 14);
            this.lblValida.TabIndex = 7;
            this.lblValida.Text = "Cadastro realizado!";
            this.lblValida.Visible = false;
            // 
            // frmCadConsum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 207);
            this.Controls.Add(this.lblValida);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadConsum";
            this.Text = "frmCadConsum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblValida;
    }
}