namespace WfaVendas
{
    partial class FrmCadVendaClientes
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
            System.Windows.Forms.Label codproLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label txtSubtotal;
            System.Windows.Forms.Label lblTotal;
            System.Windows.Forms.Label datavendaLabel;
            System.Windows.Forms.Label dataentregaLabel;
            System.Windows.Forms.Label codcliLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label precounitLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadVendaClientes));
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.numvendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codproDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precounitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcitemvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lP2DataSet1 = new WfaVendas.LP2DataSet1();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.txtPrecoUnit = new System.Windows.Forms.TextBox();
            this.pcprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSub = new System.Windows.Forms.TextBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnGravarItem = new System.Windows.Forms.Button();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnPesquisarItem = new System.Windows.Forms.Button();
            this.btnAlterarItem = new System.Windows.Forms.Button();
            this.btnIncluirItem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumVenda = new System.Windows.Forms.TextBox();
            this.pcvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.pcclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.numvendaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc_itemvendaTableAdapter = new WfaVendas.LP2DataSet1TableAdapters.pc_itemvendaTableAdapter();
            this.lP2DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_vendaTableAdapter = new WfaVendas.LP2DataSet1TableAdapters.pc_vendaTableAdapter();
            this.pc_clientesTableAdapter = new WfaVendas.LP2DataSet1TableAdapters.pc_clientesTableAdapter();
            this.pc_produtoTableAdapter = new WfaVendas.LP2DataSet1TableAdapters.pc_produtoTableAdapter();
            codproLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            datavendaLabel = new System.Windows.Forms.Label();
            dataentregaLabel = new System.Windows.Forms.Label();
            codcliLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            precounitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcitemvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).BeginInit();
            this.grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcclientesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codproLabel
            // 
            codproLabel.AutoSize = true;
            codproLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            codproLabel.Location = new System.Drawing.Point(22, 36);
            codproLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codproLabel.Name = "codproLabel";
            codproLabel.Size = new System.Drawing.Size(53, 15);
            codproLabel.TabIndex = 19;
            codproLabel.Text = "Produto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            quantidadeLabel.Location = new System.Drawing.Point(251, 36);
            quantidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(70, 15);
            quantidadeLabel.TabIndex = 21;
            quantidadeLabel.Text = "quantidade:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.AutoSize = true;
            txtSubtotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            txtSubtotal.Location = new System.Drawing.Point(255, 100);
            txtSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new System.Drawing.Size(51, 15);
            txtSubtotal.TabIndex = 26;
            txtSubtotal.Text = "Subtotal";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblTotal.Location = new System.Drawing.Point(480, 102);
            lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(32, 15);
            lblTotal.TabIndex = 29;
            lblTotal.Text = "Total";
            // 
            // datavendaLabel
            // 
            datavendaLabel.AutoSize = true;
            datavendaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            datavendaLabel.Location = new System.Drawing.Point(12, 70);
            datavendaLabel.Name = "datavendaLabel";
            datavendaLabel.Size = new System.Drawing.Size(84, 15);
            datavendaLabel.TabIndex = 44;
            datavendaLabel.Text = "data da Venda:";
            // 
            // dataentregaLabel
            // 
            dataentregaLabel.AutoSize = true;
            dataentregaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataentregaLabel.Location = new System.Drawing.Point(162, 70);
            dataentregaLabel.Name = "dataentregaLabel";
            dataentregaLabel.Size = new System.Drawing.Size(92, 15);
            dataentregaLabel.TabIndex = 46;
            dataentregaLabel.Text = "data da Entrega:";
            // 
            // codcliLabel
            // 
            codcliLabel.AutoSize = true;
            codcliLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            codcliLabel.Location = new System.Drawing.Point(422, 13);
            codcliLabel.Name = "codcliLabel";
            codcliLabel.Size = new System.Drawing.Size(47, 15);
            codcliLabel.TabIndex = 48;
            codcliLabel.Text = "Cliente:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            obsLabel.Location = new System.Drawing.Point(12, 129);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(70, 15);
            obsLabel.TabIndex = 50;
            obsLabel.Text = "observação:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nomeLabel.Location = new System.Drawing.Point(162, 13);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(41, 15);
            nomeLabel.TabIndex = 52;
            nomeLabel.Text = "nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(11, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 15);
            label1.TabIndex = 55;
            label1.Text = "Número da Venda:";
            // 
            // precounitLabel
            // 
            precounitLabel.AutoSize = true;
            precounitLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            precounitLabel.Location = new System.Drawing.Point(20, 101);
            precounitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precounitLabel.Name = "precounitLabel";
            precounitLabel.Size = new System.Drawing.Size(61, 15);
            precounitLabel.TabIndex = 23;
            precounitLabel.Text = "precounit:";
            precounitLabel.Click += new System.EventHandler(this.precounitLabel_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numvendaDataGridViewTextBoxColumn,
            this.codproDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precounitDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn});
            this.dgvItens.DataSource = this.pcitemvendaBindingSource;
            this.dgvItens.Location = new System.Drawing.Point(160, 612);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.Size = new System.Drawing.Size(678, 172);
            this.dgvItens.TabIndex = 24;
            this.dgvItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pc_itemvendaDataGridView_CellContentClick);
            // 
            // numvendaDataGridViewTextBoxColumn
            // 
            this.numvendaDataGridViewTextBoxColumn.DataPropertyName = "numvenda";
            this.numvendaDataGridViewTextBoxColumn.HeaderText = "numvenda";
            this.numvendaDataGridViewTextBoxColumn.Name = "numvendaDataGridViewTextBoxColumn";
            this.numvendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codproDataGridViewTextBoxColumn
            // 
            this.codproDataGridViewTextBoxColumn.DataPropertyName = "codpro";
            this.codproDataGridViewTextBoxColumn.HeaderText = "codpro";
            this.codproDataGridViewTextBoxColumn.Name = "codproDataGridViewTextBoxColumn";
            this.codproDataGridViewTextBoxColumn.ReadOnly = true;
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
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pcitemvendaBindingSource
            // 
            this.pcitemvendaBindingSource.DataMember = "pc_itemvenda";
            this.pcitemvendaBindingSource.DataSource = this.lP2DataSet1;
            // 
            // lP2DataSet1
            // 
            this.lP2DataSet1.DataSetName = "LP2DataSet1";
            this.lP2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpItem
            // 
            this.grpItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.grpItem.Controls.Add(this.txtPrecoUnit);
            this.grpItem.Controls.Add(this.txtSub);
            this.grpItem.Controls.Add(this.nudQuantidade);
            this.grpItem.Controls.Add(this.txtTotal);
            this.grpItem.Controls.Add(lblTotal);
            this.grpItem.Controls.Add(this.cmbProduto);
            this.grpItem.Controls.Add(txtSubtotal);
            this.grpItem.Controls.Add(precounitLabel);
            this.grpItem.Controls.Add(quantidadeLabel);
            this.grpItem.Controls.Add(codproLabel);
            this.grpItem.Location = new System.Drawing.Point(160, 404);
            this.grpItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpItem.Name = "grpItem";
            this.grpItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpItem.Size = new System.Drawing.Size(678, 198);
            this.grpItem.TabIndex = 25;
            this.grpItem.TabStop = false;
            this.grpItem.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pcprodutoBindingSource, "precounit", true));
            this.txtPrecoUnit.Enabled = false;
            this.txtPrecoUnit.Location = new System.Drawing.Point(36, 120);
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.Size = new System.Drawing.Size(100, 23);
            this.txtPrecoUnit.TabIndex = 34;
            this.txtPrecoUnit.TextChanged += new System.EventHandler(this.txtPrecoUnit_TextChanged);
            // 
            // pcprodutoBindingSource
            // 
            this.pcprodutoBindingSource.DataMember = "pc_produto";
            this.pcprodutoBindingSource.DataSource = this.lP2DataSet1;
            // 
            // txtSub
            // 
            this.txtSub.Enabled = false;
            this.txtSub.Location = new System.Drawing.Point(268, 120);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(129, 23);
            this.txtSub.TabIndex = 33;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pcitemvendaBindingSource, "quantidade", true));
            this.nudQuantidade.Enabled = false;
            this.nudQuantidade.Location = new System.Drawing.Point(268, 56);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 23);
            this.nudQuantidade.TabIndex = 31;
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTotal.Location = new System.Drawing.Point(496, 120);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(139, 23);
            this.txtTotal.TabIndex = 30;
            // 
            // cmbProduto
            // 
            this.cmbProduto.DataSource = this.pcprodutoBindingSource;
            this.cmbProduto.DisplayMember = "descricao";
            this.cmbProduto.Enabled = false;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(36, 56);
            this.cmbProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(167, 23);
            this.cmbProduto.TabIndex = 28;
            this.cmbProduto.ValueMember = "codpro";
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirItem.Location = new System.Drawing.Point(27, 141);
            this.btnExcluirItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(76, 45);
            this.btnExcluirItem.TabIndex = 41;
            this.btnExcluirItem.Text = "Excluir";
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnGravarItem
            // 
            this.btnGravarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnGravarItem.Enabled = false;
            this.btnGravarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravarItem.Location = new System.Drawing.Point(27, 263);
            this.btnGravarItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGravarItem.Name = "btnGravarItem";
            this.btnGravarItem.Size = new System.Drawing.Size(76, 45);
            this.btnGravarItem.TabIndex = 39;
            this.btnGravarItem.Text = "Gravar";
            this.btnGravarItem.UseVisualStyleBackColor = false;
            this.btnGravarItem.Click += new System.EventHandler(this.btnGravarItem_Click);
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnCancelarItem.Enabled = false;
            this.btnCancelarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarItem.Location = new System.Drawing.Point(27, 324);
            this.btnCancelarItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(76, 45);
            this.btnCancelarItem.TabIndex = 40;
            this.btnCancelarItem.Text = "Cancelar";
            this.btnCancelarItem.UseVisualStyleBackColor = false;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // btnPesquisarItem
            // 
            this.btnPesquisarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnPesquisarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarItem.Location = new System.Drawing.Point(27, 202);
            this.btnPesquisarItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisarItem.Name = "btnPesquisarItem";
            this.btnPesquisarItem.Size = new System.Drawing.Size(76, 45);
            this.btnPesquisarItem.TabIndex = 38;
            this.btnPesquisarItem.Text = "Pesquisar";
            this.btnPesquisarItem.UseVisualStyleBackColor = false;
            this.btnPesquisarItem.Click += new System.EventHandler(this.btnPesquisarItem_Click);
            // 
            // btnAlterarItem
            // 
            this.btnAlterarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnAlterarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarItem.Location = new System.Drawing.Point(27, 80);
            this.btnAlterarItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterarItem.Name = "btnAlterarItem";
            this.btnAlterarItem.Size = new System.Drawing.Size(76, 45);
            this.btnAlterarItem.TabIndex = 36;
            this.btnAlterarItem.Text = "Editar";
            this.btnAlterarItem.UseVisualStyleBackColor = false;
            this.btnAlterarItem.Click += new System.EventHandler(this.btnAlterarItem_Click);
            // 
            // btnIncluirItem
            // 
            this.btnIncluirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnIncluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluirItem.Location = new System.Drawing.Point(27, 19);
            this.btnIncluirItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIncluirItem.Name = "btnIncluirItem";
            this.btnIncluirItem.Size = new System.Drawing.Size(76, 45);
            this.btnIncluirItem.TabIndex = 35;
            this.btnIncluirItem.Text = "Incluir";
            this.btnIncluirItem.UseVisualStyleBackColor = false;
            this.btnIncluirItem.Click += new System.EventHandler(this.btnIncluirItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.txtNumVenda);
            this.groupBox2.Controls.Add(this.cmbCliente);
            this.groupBox2.Controls.Add(datavendaLabel);
            this.groupBox2.Controls.Add(this.dtpDataVenda);
            this.groupBox2.Controls.Add(dataentregaLabel);
            this.groupBox2.Controls.Add(this.dtpDataEntrega);
            this.groupBox2.Controls.Add(codcliLabel);
            this.groupBox2.Controls.Add(obsLabel);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(nomeLabel);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(160, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(678, 231);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // txtNumVenda
            // 
            this.txtNumVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pcvendaBindingSource, "numvenda", true));
            this.txtNumVenda.Enabled = false;
            this.txtNumVenda.Location = new System.Drawing.Point(25, 37);
            this.txtNumVenda.Name = "txtNumVenda";
            this.txtNumVenda.Size = new System.Drawing.Size(96, 23);
            this.txtNumVenda.TabIndex = 56;
            // 
            // pcvendaBindingSource
            // 
            this.pcvendaBindingSource.DataMember = "pc_venda";
            this.pcvendaBindingSource.DataSource = this.lP2DataSet1;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.pcclientesBindingSource;
            this.cmbCliente.DisplayMember = "nome";
            this.cmbCliente.Enabled = false;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(442, 37);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(156, 23);
            this.cmbCliente.TabIndex = 54;
            this.cmbCliente.ValueMember = "codcli";
            // 
            // pcclientesBindingSource
            // 
            this.pcclientesBindingSource.DataMember = "pc_clientes";
            this.pcclientesBindingSource.DataSource = this.lP2DataSet1;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.CustomFormat = "dd/MM/yyyy";
            this.dtpDataVenda.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pcvendaBindingSource, "datavenda", true));
            this.dtpDataVenda.Enabled = false;
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataVenda.Location = new System.Drawing.Point(25, 94);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(96, 23);
            this.dtpDataVenda.TabIndex = 45;
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.CustomFormat = "dd/MM/yyyy";
            this.dtpDataEntrega.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pcvendaBindingSource, "dataentrega", true));
            this.dtpDataEntrega.Enabled = false;
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEntrega.Location = new System.Drawing.Point(176, 94);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(96, 23);
            this.dtpDataEntrega.TabIndex = 47;
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(25, 147);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(637, 66);
            this.txtObs.TabIndex = 51;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(176, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 23);
            this.txtNome.TabIndex = 53;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(557, 90);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 35);
            this.button8.TabIndex = 42;
            this.button8.Text = "Todos";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Location = new System.Drawing.Point(27, 192);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(76, 39);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(27, 310);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 39);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnGravar.Enabled = false;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravar.Location = new System.Drawing.Point(27, 251);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(76, 39);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Location = new System.Drawing.Point(27, 133);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(76, 39);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Location = new System.Drawing.Point(27, 74);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(76, 39);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Editar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluir.Location = new System.Drawing.Point(27, 15);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(76, 39);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(-1, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(142, 374);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            this.groupBox3.Controls.Add(this.btnExcluirItem);
            this.groupBox3.Controls.Add(this.btnGravarItem);
            this.groupBox3.Controls.Add(this.btnCancelarItem);
            this.groupBox3.Controls.Add(this.btnIncluirItem);
            this.groupBox3.Controls.Add(this.btnAlterarItem);
            this.groupBox3.Controls.Add(this.btnPesquisarItem);
            this.groupBox3.Location = new System.Drawing.Point(-1, 404);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(142, 380);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AutoGenerateColumns = false;
            this.dgvVendas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numvendaDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn,
            this.datavendaDataGridViewTextBoxColumn,
            this.dataentregaDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn});
            this.dgvVendas.DataSource = this.pcvendaBindingSource;
            this.dgvVendas.Location = new System.Drawing.Point(160, 255);
            this.dgvVendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersWidth = 51;
            this.dgvVendas.Size = new System.Drawing.Size(678, 133);
            this.dgvVendas.TabIndex = 35;
            this.dgvVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendas_CellContentClick);
            // 
            // numvendaDataGridViewTextBoxColumn1
            // 
            this.numvendaDataGridViewTextBoxColumn1.DataPropertyName = "numvenda";
            this.numvendaDataGridViewTextBoxColumn1.HeaderText = "numvenda";
            this.numvendaDataGridViewTextBoxColumn1.Name = "numvendaDataGridViewTextBoxColumn1";
            this.numvendaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datavendaDataGridViewTextBoxColumn
            // 
            this.datavendaDataGridViewTextBoxColumn.DataPropertyName = "datavenda";
            this.datavendaDataGridViewTextBoxColumn.HeaderText = "datavenda";
            this.datavendaDataGridViewTextBoxColumn.Name = "datavendaDataGridViewTextBoxColumn";
            this.datavendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataentregaDataGridViewTextBoxColumn
            // 
            this.dataentregaDataGridViewTextBoxColumn.DataPropertyName = "dataentrega";
            this.dataentregaDataGridViewTextBoxColumn.HeaderText = "dataentrega";
            this.dataentregaDataGridViewTextBoxColumn.Name = "dataentregaDataGridViewTextBoxColumn";
            this.dataentregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            this.obsDataGridViewTextBoxColumn.DataPropertyName = "obs";
            this.obsDataGridViewTextBoxColumn.HeaderText = "obs";
            this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            this.obsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pc_itemvendaTableAdapter
            // 
            this.pc_itemvendaTableAdapter.ClearBeforeFill = true;
            // 
            // lP2DataSet1BindingSource
            // 
            this.lP2DataSet1BindingSource.DataSource = this.lP2DataSet1;
            this.lP2DataSet1BindingSource.Position = 0;
            // 
            // pc_vendaTableAdapter
            // 
            this.pc_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // pc_clientesTableAdapter
            // 
            this.pc_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // pc_produtoTableAdapter
            // 
            this.pc_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCadVendaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(859, 809);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.dgvItens);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadVendaClientes";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmCadVendaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcitemvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).EndInit();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcclientesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGravarItem;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnPesquisarItem;
        private System.Windows.Forms.Button btnAlterarItem;
        private System.Windows.Forms.Button btnIncluirItem;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private LP2DataSet1 lP2DataSet1;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtNumVenda;
        private System.Windows.Forms.BindingSource pcitemvendaBindingSource;
        private LP2DataSet1TableAdapters.pc_itemvendaTableAdapter pc_itemvendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numvendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codproDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precounitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lP2DataSet1BindingSource;
        private System.Windows.Forms.BindingSource pcvendaBindingSource;
        private LP2DataSet1TableAdapters.pc_vendaTableAdapter pc_vendaTableAdapter;
        private System.Windows.Forms.BindingSource pcclientesBindingSource;
        private LP2DataSet1TableAdapters.pc_clientesTableAdapter pc_clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numvendaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pcprodutoBindingSource;
        private LP2DataSet1TableAdapters.pc_produtoTableAdapter pc_produtoTableAdapter;
        private System.Windows.Forms.TextBox txtPrecoUnit;
        private System.Windows.Forms.TextBox txtSub;
    }
}