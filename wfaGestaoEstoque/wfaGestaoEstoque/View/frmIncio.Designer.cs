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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncio));
            this.lblSelecione = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnLocais = new System.Windows.Forms.Button();
            this.lblFundoMenu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSelecione.Font = new System.Drawing.Font("Letter Gothic Std", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(45, 10);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(461, 44);
            this.lblSelecione.TabIndex = 0;
            this.lblSelecione.Text = "SELECIONE SEU DESTINO";
            this.lblSelecione.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(406, 291);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(90, 49);
            this.btnCad.TabIndex = 1;
            this.btnCad.Text = "Cadastros";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.BtnCad_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(635, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 41);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Location = new System.Drawing.Point(148, 297);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(102, 36);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(138, 102);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(112, 43);
            this.btnVendas.TabIndex = 4;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(406, 107);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(100, 43);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(406, 192);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(104, 52);
            this.btnProdutos.TabIndex = 6;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnLocais
            // 
            this.btnLocais.Location = new System.Drawing.Point(138, 201);
            this.btnLocais.Name = "btnLocais";
            this.btnLocais.Size = new System.Drawing.Size(112, 43);
            this.btnLocais.TabIndex = 8;
            this.btnLocais.Text = "Locais";
            this.btnLocais.UseVisualStyleBackColor = true;
            // 
            // lblFundoMenu
            // 
            this.lblFundoMenu.BackColor = System.Drawing.Color.Green;
            this.lblFundoMenu.Location = new System.Drawing.Point(0, 0);
            this.lblFundoMenu.Name = "lblFundoMenu";
            this.lblFundoMenu.Size = new System.Drawing.Size(794, 93);
            this.lblFundoMenu.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(736, 305);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(38, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 73);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(38, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 73);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(38, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 73);
            this.label6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(295, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 73);
            this.label7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(295, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 73);
            this.label8.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(295, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 73);
            this.label9.TabIndex = 16;
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.White;
            this.lblData.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(562, 273);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(158, 67);
            this.lblData.TabIndex = 17;
            this.lblData.Text = "Data";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbInicio
            // 
            this.pbInicio.BackColor = System.Drawing.Color.White;
            this.pbInicio.Image = global::wfaGestaoEstoque.Properties.Resources.logo;
            this.pbInicio.Location = new System.Drawing.Point(554, 102);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(176, 142);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInicio.TabIndex = 18;
            this.pbInicio.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::wfaGestaoEstoque.Properties.Resources.sales_performance;
            this.pictureBox1.Location = new System.Drawing.Point(50, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::wfaGestaoEstoque.Properties.Resources._57451;
            this.pictureBox2.Location = new System.Drawing.Point(50, 283);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(525, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 41);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmIncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wfaGestaoEstoque.Properties.Resources._818643_amazing_bakery_wallpapers_1920x1200_picture;
            this.ClientSize = new System.Drawing.Size(780, 380);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbInicio);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnLocais);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFundoMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIncio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmIncio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnLocais;
        private System.Windows.Forms.Label lblFundoMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogout;
    }
}

