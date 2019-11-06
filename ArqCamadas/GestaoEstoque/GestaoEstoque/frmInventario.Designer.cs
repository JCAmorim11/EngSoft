namespace GestaoEstoque
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padokaBDDataSetInventario = new GestaoEstoque.padokaBDDataSetInventario();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.produtoTableAdapter = new GestaoEstoque.padokaBDDataSetInventarioTableAdapters.ProdutoTableAdapter();
            this.padokaBDDataSetInventario1 = new GestaoEstoque.padokaBDDataSetInventario();
            this.iDProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodValorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFundo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padokaBDDataSetInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padokaBDDataSetInventario1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProdutoDataGridViewTextBoxColumn,
            this.prodNomeDataGridViewTextBoxColumn,
            this.prodValorDataGridViewTextBoxColumn,
            this.iDLoteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.padokaBDDataSetInventario;
            // 
            // padokaBDDataSetInventario
            // 
            this.padokaBDDataSetInventario.DataSetName = "padokaBDDataSetInventario";
            this.padokaBDDataSetInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventário";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(607, 42);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "&Voltar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // padokaBDDataSetInventario1
            // 
            this.padokaBDDataSetInventario1.DataSetName = "padokaBDDataSetInventario";
            this.padokaBDDataSetInventario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDProdutoDataGridViewTextBoxColumn
            // 
            this.iDProdutoDataGridViewTextBoxColumn.DataPropertyName = "ID_Produto";
            this.iDProdutoDataGridViewTextBoxColumn.HeaderText = "ID_Produto";
            this.iDProdutoDataGridViewTextBoxColumn.Name = "iDProdutoDataGridViewTextBoxColumn";
            // 
            // prodNomeDataGridViewTextBoxColumn
            // 
            this.prodNomeDataGridViewTextBoxColumn.DataPropertyName = "Prod_Nome";
            this.prodNomeDataGridViewTextBoxColumn.HeaderText = "Prod_Nome";
            this.prodNomeDataGridViewTextBoxColumn.Name = "prodNomeDataGridViewTextBoxColumn";
            // 
            // prodValorDataGridViewTextBoxColumn
            // 
            this.prodValorDataGridViewTextBoxColumn.DataPropertyName = "Prod_Valor";
            this.prodValorDataGridViewTextBoxColumn.HeaderText = "Prod_Valor";
            this.prodValorDataGridViewTextBoxColumn.Name = "prodValorDataGridViewTextBoxColumn";
            // 
            // iDLoteDataGridViewTextBoxColumn
            // 
            this.iDLoteDataGridViewTextBoxColumn.DataPropertyName = "ID_Lote";
            this.iDLoteDataGridViewTextBoxColumn.HeaderText = "ID_Lote";
            this.iDLoteDataGridViewTextBoxColumn.Name = "iDLoteDataGridViewTextBoxColumn";
            // 
            // lblFundo
            // 
            this.lblFundo.Location = new System.Drawing.Point(25, 32);
            this.lblFundo.Name = "lblFundo";
            this.lblFundo.Size = new System.Drawing.Size(671, 426);
            this.lblFundo.TabIndex = 6;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 465);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFundo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventário";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padokaBDDataSetInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padokaBDDataSetInventario1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicio;
        private padokaBDDataSetInventario padokaBDDataSetInventario;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private padokaBDDataSetInventarioTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private padokaBDDataSetInventario padokaBDDataSetInventario1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblFundo;
    }
}