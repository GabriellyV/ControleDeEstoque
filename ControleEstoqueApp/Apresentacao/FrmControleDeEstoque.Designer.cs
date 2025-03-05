namespace ControleEstoqueApp
{
    partial class FrmControleDeEstoque
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            txtNome = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            lblQuantidade = new Label();
            lblPreco = new Label();
            btmSalvar = new Button();
            btmExcluir = new Button();
            dtgEstoque = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(12, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(55, 23);
            txtId.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(285, 40);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(179, 40);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(73, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 22);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 4;
            lblId.Text = "id";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(73, 22);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(179, 22);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(285, 22);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preco";
            // 
            // btmSalvar
            // 
            btmSalvar.Location = new Point(414, 74);
            btmSalvar.Name = "btmSalvar";
            btmSalvar.Size = new Size(75, 23);
            btmSalvar.TabIndex = 8;
            btmSalvar.Text = "Salvar";
            btmSalvar.UseVisualStyleBackColor = true;
            btmSalvar.Click += btmSalvar_Click;
            // 
            // btmExcluir
            // 
            btmExcluir.Location = new Point(333, 74);
            btmExcluir.Name = "btmExcluir";
            btmExcluir.Size = new Size(75, 23);
            btmExcluir.TabIndex = 9;
            btmExcluir.Text = "Excluir";
            btmExcluir.UseVisualStyleBackColor = true;
            btmExcluir.Click += btmExcluir_Click;
            // 
            // dtgEstoque
            // 
            dtgEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstoque.Location = new Point(12, 116);
            dtgEstoque.Name = "dtgEstoque";
            dtgEstoque.Size = new Size(477, 150);
            dtgEstoque.TabIndex = 10;
            dtgEstoque.CellDoubleClick += dtgEstoque_CellDoubleClick;
            // 
            // FrmControleDeEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(dtgEstoque);
            Controls.Add(btmExcluir);
            Controls.Add(btmSalvar);
            Controls.Add(lblPreco);
            Controls.Add(lblQuantidade);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtNome);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtId);
            Name = "FrmControleDeEstoque";
            Text = "Controle de estoque";
            Load += FrmControleDeEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private TextBox txtNome;
        private Label lblId;
        private Label lblNome;
        private Label lblQuantidade;
        private Label lblPreco;
        private Button btmSalvar;
        private Button btmExcluir;
        private DataGridView dtgEstoque;
    }
}
