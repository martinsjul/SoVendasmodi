namespace WfaVendas
{
    partial class FrmCadProdutos
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
            System.Windows.Forms.Label codcliLabel1;
            System.Windows.Forms.Label telefoneLabel1;
            System.Windows.Forms.Label enderecoLabel1;
            System.Windows.Forms.Label bairroLabel1;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodcli = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lP2DataSet1 = new WfaVendas.LP2DataSet1();
            this.pcprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_produtoTableAdapter = new WfaVendas.LP2DataSet1TableAdapters.pc_produtoTableAdapter();
            this.codproDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precounitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.nudprecounit = new System.Windows.Forms.NumericUpDown();
            codcliLabel1 = new System.Windows.Forms.Label();
            telefoneLabel1 = new System.Windows.Forms.Label();
            enderecoLabel1 = new System.Windows.Forms.Label();
            bairroLabel1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudprecounit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.groupBox2.Controls.Add(this.nudprecounit);
            this.groupBox2.Controls.Add(this.nudQuantidade);
            this.groupBox2.Controls.Add(codcliLabel1);
            this.groupBox2.Controls.Add(this.txtCodcli);
            this.groupBox2.Controls.Add(telefoneLabel1);
            this.groupBox2.Controls.Add(enderecoLabel1);
            this.groupBox2.Controls.Add(this.txtEndereco);
            this.groupBox2.Controls.Add(bairroLabel1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(13, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 211);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preencha os campos";
            // 
            // codcliLabel1
            // 
            codcliLabel1.AutoSize = true;
            codcliLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            codcliLabel1.Location = new System.Drawing.Point(20, 43);
            codcliLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codcliLabel1.Name = "codcliLabel1";
            codcliLabel1.Size = new System.Drawing.Size(43, 13);
            codcliLabel1.TabIndex = 20;
            codcliLabel1.Text = "Código:";
            // 
            // txtCodcli
            // 
            this.txtCodcli.Enabled = false;
            this.txtCodcli.Location = new System.Drawing.Point(75, 40);
            this.txtCodcli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodcli.Name = "txtCodcli";
            this.txtCodcli.ReadOnly = true;
            this.txtCodcli.Size = new System.Drawing.Size(80, 20);
            this.txtCodcli.TabIndex = 21;
            // 
            // telefoneLabel1
            // 
            telefoneLabel1.AutoSize = true;
            telefoneLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            telefoneLabel1.Location = new System.Drawing.Point(239, 81);
            telefoneLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefoneLabel1.Name = "telefoneLabel1";
            telefoneLabel1.Size = new System.Drawing.Size(77, 13);
            telefoneLabel1.TabIndex = 34;
            telefoneLabel1.Text = "Preço Unitário:";
            // 
            // enderecoLabel1
            // 
            enderecoLabel1.AutoSize = true;
            enderecoLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            enderecoLabel1.Location = new System.Drawing.Point(240, 43);
            enderecoLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            enderecoLabel1.Name = "enderecoLabel1";
            enderecoLabel1.Size = new System.Drawing.Size(38, 13);
            enderecoLabel1.TabIndex = 24;
            enderecoLabel1.Text = "Nome:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(296, 40);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(275, 20);
            this.txtEndereco.TabIndex = 25;
            // 
            // bairroLabel1
            // 
            bairroLabel1.AutoSize = true;
            bairroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            bairroLabel1.Location = new System.Drawing.Point(20, 81);
            bairroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bairroLabel1.Name = "bairroLabel1";
            bairroLabel1.Size = new System.Drawing.Size(65, 13);
            bairroLabel1.TabIndex = 28;
            bairroLabel1.Text = "Quantidade:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnApagar);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Location = new System.Drawing.Point(-20, -12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1091, 98);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluir.Location = new System.Drawing.Point(33, 27);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(71, 43);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Location = new System.Drawing.Point(133, 27);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(71, 43);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(233, 27);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(71, 43);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Location = new System.Drawing.Point(333, 27);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(71, 43);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Excluir";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnGravar.Enabled = false;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravar.Location = new System.Drawing.Point(433, 27);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(71, 43);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Location = new System.Drawing.Point(533, 27);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(71, 43);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(633, 27);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 43);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codproDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precounitDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.pcprodutoBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(13, 332);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(672, 222);
            this.dgvClientes.TabIndex = 40;
            // 
            // lP2DataSet1
            // 
            this.lP2DataSet1.DataSetName = "LP2DataSet1";
            this.lP2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pcprodutoBindingSource
            // 
            this.pcprodutoBindingSource.DataMember = "pc_produto";
            this.pcprodutoBindingSource.DataSource = this.lP2DataSet1;
            // 
            // pc_produtoTableAdapter
            // 
            this.pc_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // codproDataGridViewTextBoxColumn
            // 
            this.codproDataGridViewTextBoxColumn.DataPropertyName = "codpro";
            this.codproDataGridViewTextBoxColumn.HeaderText = "codpro";
            this.codproDataGridViewTextBoxColumn.Name = "codproDataGridViewTextBoxColumn";
            this.codproDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precounitDataGridViewTextBoxColumn
            // 
            this.precounitDataGridViewTextBoxColumn.DataPropertyName = "precounit";
            this.precounitDataGridViewTextBoxColumn.HeaderText = "precounit";
            this.precounitDataGridViewTextBoxColumn.Name = "precounitDataGridViewTextBoxColumn";
            this.precounitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(92, 79);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 20);
            this.nudQuantidade.TabIndex = 35;
            // 
            // nudprecounit
            // 
            this.nudprecounit.Location = new System.Drawing.Point(326, 79);
            this.nudprecounit.Name = "nudprecounit";
            this.nudprecounit.Size = new System.Drawing.Size(120, 20);
            this.nudprecounit.TabIndex = 36;
            // 
            // FrmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FrmCadProdutos";
            this.Text = "FrmCadProdutos";
            this.Load += new System.EventHandler(this.FrmCadProdutos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudprecounit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodcli;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private LP2DataSet1 lP2DataSet1;
        private System.Windows.Forms.BindingSource pcprodutoBindingSource;
        private LP2DataSet1TableAdapters.pc_produtoTableAdapter pc_produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codproDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precounitDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown nudprecounit;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
    }
}