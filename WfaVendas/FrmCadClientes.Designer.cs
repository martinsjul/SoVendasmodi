namespace WfaVendas
{
    partial class FrmCadClientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codcliLabel1;
            System.Windows.Forms.Label nomeLabel1;
            System.Windows.Forms.Label enderecoLabel1;
            System.Windows.Forms.Label cidadeLabel1;
            System.Windows.Forms.Label bairroLabel1;
            System.Windows.Forms.Label uFLabel1;
            System.Windows.Forms.Label cEPLabel1;
            System.Windows.Forms.Label telefoneLabel1;
            System.Windows.Forms.Label datanascLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadClientes));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pc_clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lP2DataSet1 = new WfaVendas.LP2DataSet1();
            this.pc_clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodcli = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mskUF = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtpDatanasc = new System.Windows.Forms.DateTimePicker();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pc_clientesTableAdapter = new WfaVendas.LP2DataSet1TableAdapters.pc_clientesTableAdapter();
            this.tableAdapterManager = new WfaVendas.LP2DataSet1TableAdapters.TableAdapterManager();
            this.codcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codcliLabel1 = new System.Windows.Forms.Label();
            nomeLabel1 = new System.Windows.Forms.Label();
            enderecoLabel1 = new System.Windows.Forms.Label();
            cidadeLabel1 = new System.Windows.Forms.Label();
            bairroLabel1 = new System.Windows.Forms.Label();
            uFLabel1 = new System.Windows.Forms.Label();
            cEPLabel1 = new System.Windows.Forms.Label();
            telefoneLabel1 = new System.Windows.Forms.Label();
            datanascLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // codcliLabel1
            // 
            codcliLabel1.AutoSize = true;
            codcliLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            codcliLabel1.Location = new System.Drawing.Point(7, 42);
            codcliLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codcliLabel1.Name = "codcliLabel1";
            codcliLabel1.Size = new System.Drawing.Size(49, 15);
            codcliLabel1.TabIndex = 20;
            codcliLabel1.Text = "Código:";
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nomeLabel1.Location = new System.Drawing.Point(228, 39);
            nomeLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(43, 15);
            nomeLabel1.TabIndex = 22;
            nomeLabel1.Text = "Nome:";
            // 
            // enderecoLabel1
            // 
            enderecoLabel1.AutoSize = true;
            enderecoLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            enderecoLabel1.Location = new System.Drawing.Point(7, 79);
            enderecoLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            enderecoLabel1.Name = "enderecoLabel1";
            enderecoLabel1.Size = new System.Drawing.Size(59, 15);
            enderecoLabel1.TabIndex = 24;
            enderecoLabel1.Text = "Endereço:";
            // 
            // cidadeLabel1
            // 
            cidadeLabel1.AutoSize = true;
            cidadeLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            cidadeLabel1.Location = new System.Drawing.Point(443, 75);
            cidadeLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cidadeLabel1.Name = "cidadeLabel1";
            cidadeLabel1.Size = new System.Drawing.Size(47, 15);
            cidadeLabel1.TabIndex = 26;
            cidadeLabel1.Text = "Cidade:";
            // 
            // bairroLabel1
            // 
            bairroLabel1.AutoSize = true;
            bairroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            bairroLabel1.Location = new System.Drawing.Point(7, 110);
            bairroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bairroLabel1.Name = "bairroLabel1";
            bairroLabel1.Size = new System.Drawing.Size(41, 15);
            bairroLabel1.TabIndex = 28;
            bairroLabel1.Text = "Bairro:";
            // 
            // uFLabel1
            // 
            uFLabel1.AutoSize = true;
            uFLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            uFLabel1.Location = new System.Drawing.Point(402, 113);
            uFLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uFLabel1.Name = "uFLabel1";
            uFLabel1.Size = new System.Drawing.Size(24, 15);
            uFLabel1.TabIndex = 30;
            uFLabel1.Text = "UF:";
            // 
            // cEPLabel1
            // 
            cEPLabel1.AutoSize = true;
            cEPLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            cEPLabel1.Location = new System.Drawing.Point(573, 111);
            cEPLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cEPLabel1.Name = "cEPLabel1";
            cEPLabel1.Size = new System.Drawing.Size(31, 15);
            cEPLabel1.TabIndex = 32;
            cEPLabel1.Text = "CEP:";
            // 
            // telefoneLabel1
            // 
            telefoneLabel1.AutoSize = true;
            telefoneLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            telefoneLabel1.Location = new System.Drawing.Point(7, 141);
            telefoneLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefoneLabel1.Name = "telefoneLabel1";
            telefoneLabel1.Size = new System.Drawing.Size(54, 15);
            telefoneLabel1.TabIndex = 34;
            telefoneLabel1.Text = "Telefone:";
            // 
            // datanascLabel1
            // 
            datanascLabel1.AutoSize = true;
            datanascLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            datanascLabel1.Location = new System.Drawing.Point(260, 140);
            datanascLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            datanascLabel1.Name = "datanascLabel1";
            datanascLabel1.Size = new System.Drawing.Size(114, 15);
            datanascLabel1.TabIndex = 36;
            datanascLabel1.Text = "Data de Nascimento";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcliDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.datanascDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.pc_clientesBindingSource1;
            this.dgvClientes.Location = new System.Drawing.Point(25, 332);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(822, 222);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClientes_CellFormatting);
            // 
            // pc_clientesBindingSource1
            // 
            this.pc_clientesBindingSource1.DataMember = "pc_clientes";
            this.pc_clientesBindingSource1.DataSource = this.lP2DataSet1;
            // 
            // lP2DataSet1
            // 
            this.lP2DataSet1.DataSetName = "LP2DataSet1";
            this.lP2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCodcli
            // 
            this.txtCodcli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_clientesBindingSource1, "codcli", true));
            this.txtCodcli.Enabled = false;
            this.txtCodcli.Location = new System.Drawing.Point(91, 36);
            this.txtCodcli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodcli.Name = "txtCodcli";
            this.txtCodcli.ReadOnly = true;
            this.txtCodcli.Size = new System.Drawing.Size(80, 23);
            this.txtCodcli.TabIndex = 21;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(311, 34);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(344, 23);
            this.txtNome.TabIndex = 23;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(90, 71);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(344, 23);
            this.txtEndereco.TabIndex = 25;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(498, 74);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(264, 23);
            this.txtCidade.TabIndex = 27;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(90, 104);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(264, 23);
            this.txtBairro.TabIndex = 29;
            // 
            // mskUF
            // 
            this.mskUF.Enabled = false;
            this.mskUF.Location = new System.Drawing.Point(485, 104);
            this.mskUF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskUF.Mask = ">LL";
            this.mskUF.Name = "mskUF";
            this.mskUF.Size = new System.Drawing.Size(40, 23);
            this.mskUF.TabIndex = 31;
            this.mskUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskCEP
            // 
            this.mskCEP.Enabled = false;
            this.mskCEP.Location = new System.Drawing.Point(632, 107);
            this.mskCEP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(80, 23);
            this.mskCEP.TabIndex = 33;
            this.mskCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Enabled = false;
            this.mskTelefone.Location = new System.Drawing.Point(90, 137);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskTelefone.Mask = "(00) 90000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(112, 23);
            this.mskTelefone.TabIndex = 35;
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefoneMaskedTextBox_MaskInputRejected);
            // 
            // dtpDatanasc
            // 
            this.dtpDatanasc.CustomFormat = "dd/MM/yyyy";
            this.dtpDatanasc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_clientesBindingSource1, "datanasc", true));
            this.dtpDatanasc.Enabled = false;
            this.dtpDatanasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatanasc.Location = new System.Drawing.Point(434, 137);
            this.dtpDatanasc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDatanasc.Name = "dtpDatanasc";
            this.dtpDatanasc.Size = new System.Drawing.Size(128, 23);
            this.dtpDatanasc.TabIndex = 37;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluir.Location = new System.Drawing.Point(33, 27);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(71, 45);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(283, 27);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(71, 45);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Location = new System.Drawing.Point(408, 27);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(71, 45);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Excluir";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Location = new System.Drawing.Point(658, 27);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(71, 45);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(783, 27);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 45);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnGravar.Enabled = false;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravar.Location = new System.Drawing.Point(533, 27);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(71, 45);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Location = new System.Drawing.Point(158, 27);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6, 6, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(71, 45);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button8_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(-8, -12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1091, 98);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.groupBox2.Controls.Add(codcliLabel1);
            this.groupBox2.Controls.Add(this.dtpDatanasc);
            this.groupBox2.Controls.Add(this.txtCodcli);
            this.groupBox2.Controls.Add(datanascLabel1);
            this.groupBox2.Controls.Add(nomeLabel1);
            this.groupBox2.Controls.Add(this.mskTelefone);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(telefoneLabel1);
            this.groupBox2.Controls.Add(enderecoLabel1);
            this.groupBox2.Controls.Add(this.mskCEP);
            this.groupBox2.Controls.Add(this.txtEndereco);
            this.groupBox2.Controls.Add(cEPLabel1);
            this.groupBox2.Controls.Add(cidadeLabel1);
            this.groupBox2.Controls.Add(this.mskUF);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(uFLabel1);
            this.groupBox2.Controls.Add(bairroLabel1);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(25, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 211);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preencha os campos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pc_clientesTableAdapter
            // 
            this.pc_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_clientesTableAdapter = this.pc_clientesTableAdapter;
            this.tableAdapterManager.pc_itemvendaTableAdapter = null;
            this.tableAdapterManager.pc_produtoTableAdapter = null;
            this.tableAdapterManager.pc_vendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WfaVendas.LP2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codcliDataGridViewTextBoxColumn
            // 
            this.codcliDataGridViewTextBoxColumn.DataPropertyName = "codcli";
            this.codcliDataGridViewTextBoxColumn.HeaderText = "código";
            this.codcliDataGridViewTextBoxColumn.Name = "codcliDataGridViewTextBoxColumn";
            this.codcliDataGridViewTextBoxColumn.ReadOnly = true;
            this.codcliDataGridViewTextBoxColumn.Width = 55;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereço";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datanascDataGridViewTextBoxColumn
            // 
            this.datanascDataGridViewTextBoxColumn.DataPropertyName = "datanasc";
            this.datanascDataGridViewTextBoxColumn.HeaderText = "data Nasc.";
            this.datanascDataGridViewTextBoxColumn.Name = "datanascDataGridViewTextBoxColumn";
            this.datanascDataGridViewTextBoxColumn.ReadOnly = true;
            this.datanascDataGridViewTextBoxColumn.Width = 90;
            // 
            // ufDataGridViewTextBoxColumn
            // 
            this.ufDataGridViewTextBoxColumn.DataPropertyName = "uf";
            this.ufDataGridViewTextBoxColumn.HeaderText = "Uf";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            this.ufDataGridViewTextBoxColumn.ReadOnly = true;
            this.ufDataGridViewTextBoxColumn.Width = 50;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(876, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvClientes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadClientes";
            this.Text = "Cadastro de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadClientes_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource pc_clientesBindingSource;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtCodcli;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox mskUF;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.DateTimePicker dtpDatanasc;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private LP2DataSet1 lP2DataSet1;
        private System.Windows.Forms.BindingSource pc_clientesBindingSource1;
        private LP2DataSet1TableAdapters.pc_clientesTableAdapter pc_clientesTableAdapter;
        private LP2DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
    }
}

