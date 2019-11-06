namespace GestaoEstoque
{ 
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.lblFundo = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.padokaBDDataSet = new GestaoEstoque.padokaBDDataSet();
            this.consumoProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumo_ProdTableAdapter = new GestaoEstoque.padokaBDDataSetTableAdapters.Consumo_ProdTableAdapter();
            this.iDConsumoProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condProdQuantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condProdPrecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condProdDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padokaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumoProdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFundo
            // 
            this.lblFundo.Location = new System.Drawing.Point(24, 17);
            this.lblFundo.Name = "lblFundo";
            this.lblFundo.Size = new System.Drawing.Size(670, 340);
            this.lblFundo.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(64, 307);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "&Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dgvVendas
            // 
            this.dgvVendas.AutoGenerateColumns = false;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDConsumoProdDataGridViewTextBoxColumn,
            this.iDCPFDataGridViewTextBoxColumn,
            this.iDProdutoDataGridViewTextBoxColumn,
            this.condProdQuantDataGridViewTextBoxColumn,
            this.condProdPrecoDataGridViewTextBoxColumn,
            this.condProdDataDataGridViewTextBoxColumn});
            this.dgvVendas.DataSource = this.consumoProdBindingSource;
            this.dgvVendas.Location = new System.Drawing.Point(52, 103);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(617, 182);
            this.dgvVendas.TabIndex = 6;
            // 
            // padokaBDDataSet
            // 
            this.padokaBDDataSet.DataSetName = "padokaBDDataSet";
            this.padokaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consumoProdBindingSource
            // 
            this.consumoProdBindingSource.DataMember = "Consumo_Prod";
            this.consumoProdBindingSource.DataSource = this.padokaBDDataSet;
            // 
            // consumo_ProdTableAdapter
            // 
            this.consumo_ProdTableAdapter.ClearBeforeFill = true;
            // 
            // iDConsumoProdDataGridViewTextBoxColumn
            // 
            this.iDConsumoProdDataGridViewTextBoxColumn.DataPropertyName = "ID_ConsumoProd";
            this.iDConsumoProdDataGridViewTextBoxColumn.HeaderText = "ID_ConsumoProd";
            this.iDConsumoProdDataGridViewTextBoxColumn.Name = "iDConsumoProdDataGridViewTextBoxColumn";
            // 
            // iDCPFDataGridViewTextBoxColumn
            // 
            this.iDCPFDataGridViewTextBoxColumn.DataPropertyName = "ID_CPF";
            this.iDCPFDataGridViewTextBoxColumn.HeaderText = "ID_CPF";
            this.iDCPFDataGridViewTextBoxColumn.Name = "iDCPFDataGridViewTextBoxColumn";
            // 
            // iDProdutoDataGridViewTextBoxColumn
            // 
            this.iDProdutoDataGridViewTextBoxColumn.DataPropertyName = "ID_Produto";
            this.iDProdutoDataGridViewTextBoxColumn.HeaderText = "ID_Produto";
            this.iDProdutoDataGridViewTextBoxColumn.Name = "iDProdutoDataGridViewTextBoxColumn";
            // 
            // condProdQuantDataGridViewTextBoxColumn
            // 
            this.condProdQuantDataGridViewTextBoxColumn.DataPropertyName = "CondProd_Quant";
            this.condProdQuantDataGridViewTextBoxColumn.HeaderText = "CondProd_Quant";
            this.condProdQuantDataGridViewTextBoxColumn.Name = "condProdQuantDataGridViewTextBoxColumn";
            // 
            // condProdPrecoDataGridViewTextBoxColumn
            // 
            this.condProdPrecoDataGridViewTextBoxColumn.DataPropertyName = "CondProd_Preco";
            this.condProdPrecoDataGridViewTextBoxColumn.HeaderText = "CondProd_Preco";
            this.condProdPrecoDataGridViewTextBoxColumn.Name = "condProdPrecoDataGridViewTextBoxColumn";
            // 
            // condProdDataDataGridViewTextBoxColumn
            // 
            this.condProdDataDataGridViewTextBoxColumn.DataPropertyName = "CondProd_Data";
            this.condProdDataDataGridViewTextBoxColumn.HeaderText = "CondProd_Data";
            this.condProdDataDataGridViewTextBoxColumn.Name = "condProdDataDataGridViewTextBoxColumn";
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 366);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVendas_FormClosing);
            this.Load += new System.EventHandler(this.frmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padokaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumoProdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFundo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dgvVendas;
        private padokaBDDataSet padokaBDDataSet;
        private System.Windows.Forms.BindingSource consumoProdBindingSource;
        private padokaBDDataSetTableAdapters.Consumo_ProdTableAdapter consumo_ProdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDConsumoProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condProdQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condProdPrecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condProdDataDataGridViewTextBoxColumn;
    }
}