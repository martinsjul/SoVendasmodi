namespace WfaVendas
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.relatoriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeSeuTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.relatorioClientesToolStripMenuItem = new System.Windows.Forms.ToolStripSplitButton();
            this.relatorioDeClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.sstStatus = new System.Windows.Forms.StatusStrip();
            this.sslTexto = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.relátorioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relátorioDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relátorioDeJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.sstStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatoriosToolStripMenuItem,
            this.relatoriosToolStripMenuItem1,
            this.janelasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.mnuMenu.Size = new System.Drawing.Size(1200, 24);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.cadastroDeVendasToolStripMenuItem,
            this.toolStripSeparator1});
            this.relatoriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.relatoriosToolStripMenuItem.Text = "&Arquivo";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de &Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // cadastroDeVendasToolStripMenuItem
            // 
            this.cadastroDeVendasToolStripMenuItem.Name = "cadastroDeVendasToolStripMenuItem";
            this.cadastroDeVendasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cadastroDeVendasToolStripMenuItem.Text = "Cadastro de &Vendas";
            this.cadastroDeVendasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeVendasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // relatoriosToolStripMenuItem1
            // 
            this.relatoriosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioDeClientesToolStripMenuItem,
            this.relatorioDeVendasToolStripMenuItem,
            this.relatorioDeProdutosToolStripMenuItem,
            this.relatorioDeSeuTemaToolStripMenuItem,
            this.toolStripSeparator2});
            this.relatoriosToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.relatoriosToolStripMenuItem1.Name = "relatoriosToolStripMenuItem1";
            this.relatoriosToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.relatoriosToolStripMenuItem1.Text = "&Relatorios";
            // 
            // relatorioDeClientesToolStripMenuItem
            // 
            this.relatorioDeClientesToolStripMenuItem.Name = "relatorioDeClientesToolStripMenuItem";
            this.relatorioDeClientesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.relatorioDeClientesToolStripMenuItem.Text = "Relatório de &Clientes";
            // 
            // relatorioDeVendasToolStripMenuItem
            // 
            this.relatorioDeVendasToolStripMenuItem.Name = "relatorioDeVendasToolStripMenuItem";
            this.relatorioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.relatorioDeVendasToolStripMenuItem.Text = "Relatório de &Vendas";
            // 
            // relatorioDeProdutosToolStripMenuItem
            // 
            this.relatorioDeProdutosToolStripMenuItem.Name = "relatorioDeProdutosToolStripMenuItem";
            this.relatorioDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.relatorioDeProdutosToolStripMenuItem.Text = "Relatório de &Produtos";
            // 
            // relatorioDeSeuTemaToolStripMenuItem
            // 
            this.relatorioDeSeuTemaToolStripMenuItem.Name = "relatorioDeSeuTemaToolStripMenuItem";
            this.relatorioDeSeuTemaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.relatorioDeSeuTemaToolStripMenuItem.Text = "Relatório de &Seu Tema";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizarNaHorizontalToolStripMenuItem,
            this.organizarNaVerticalToolStripMenuItem,
            this.organizarNaCascataToolStripMenuItem});
            this.janelasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.janelasToolStripMenuItem.Text = "&Janelas";
            // 
            // organizarNaHorizontalToolStripMenuItem
            // 
            this.organizarNaHorizontalToolStripMenuItem.Name = "organizarNaHorizontalToolStripMenuItem";
            this.organizarNaHorizontalToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.organizarNaHorizontalToolStripMenuItem.Text = "Organizar na &Horizontal";
            // 
            // organizarNaVerticalToolStripMenuItem
            // 
            this.organizarNaVerticalToolStripMenuItem.Name = "organizarNaVerticalToolStripMenuItem";
            this.organizarNaVerticalToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.organizarNaVerticalToolStripMenuItem.Text = "Organizar na &Vertical";
            // 
            // organizarNaCascataToolStripMenuItem
            // 
            this.organizarNaCascataToolStripMenuItem.Name = "organizarNaCascataToolStripMenuItem";
            this.organizarNaCascataToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.organizarNaCascataToolStripMenuItem.Text = "Organizar na &Cascata";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ajudaToolStripMenuItem.Text = "Aj&uda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton5,
            this.toolStripButton3,
            this.relatorioClientesToolStripMenuItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // relatorioClientesToolStripMenuItem
            // 
            this.relatorioClientesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.relatorioClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioDeClientesToolStripMenuItem1,
            this.relátorioDeVendasToolStripMenuItem,
            this.relátorioDeProdutoToolStripMenuItem,
            this.relátorioDeJogosToolStripMenuItem});
            this.relatorioClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatorioClientesToolStripMenuItem.Image")));
            this.relatorioClientesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.relatorioClientesToolStripMenuItem.Name = "relatorioClientesToolStripMenuItem";
            this.relatorioClientesToolStripMenuItem.Size = new System.Drawing.Size(36, 24);
            this.relatorioClientesToolStripMenuItem.Text = "Relátorio de Clientes";
            // 
            // relatorioDeClientesToolStripMenuItem1
            // 
            this.relatorioDeClientesToolStripMenuItem1.Name = "relatorioDeClientesToolStripMenuItem1";
            this.relatorioDeClientesToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.relatorioDeClientesToolStripMenuItem1.Text = "Relátorio de Clientes";
            this.relatorioDeClientesToolStripMenuItem1.Click += new System.EventHandler(this.relatorioDeClientesToolStripMenuItem1_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // sstStatus
            // 
            this.sstStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslTexto,
            this.sslHora});
            this.sstStatus.Location = new System.Drawing.Point(0, 664);
            this.sstStatus.Name = "sstStatus";
            this.sstStatus.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.sstStatus.Size = new System.Drawing.Size(1200, 28);
            this.sstStatus.TabIndex = 3;
            // 
            // sslTexto
            // 
            this.sslTexto.AutoSize = false;
            this.sslTexto.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslTexto.Name = "sslTexto";
            this.sslTexto.Size = new System.Drawing.Size(998, 23);
            this.sslTexto.Spring = true;
            this.sslTexto.Text = "toolStripStatusLabel1";
            // 
            // sslHora
            // 
            this.sslHora.AutoSize = false;
            this.sslHora.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslHora.Name = "sslHora";
            this.sslHora.Size = new System.Drawing.Size(180, 23);
            this.sslHora.Text = "toolStripStatusLabel2";
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // relátorioDeVendasToolStripMenuItem
            // 
            this.relátorioDeVendasToolStripMenuItem.Name = "relátorioDeVendasToolStripMenuItem";
            this.relátorioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.relátorioDeVendasToolStripMenuItem.Text = "Relátorio de Vendas";
            // 
            // relátorioDeProdutoToolStripMenuItem
            // 
            this.relátorioDeProdutoToolStripMenuItem.Name = "relátorioDeProdutoToolStripMenuItem";
            this.relátorioDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.relátorioDeProdutoToolStripMenuItem.Text = "Relátorio de Produto";
            // 
            // relátorioDeJogosToolStripMenuItem
            // 
            this.relátorioDeJogosToolStripMenuItem.Name = "relátorioDeJogosToolStripMenuItem";
            this.relátorioDeJogosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.relátorioDeJogosToolStripMenuItem.Text = "Relátorio de Jogos";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.sstStatus);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuMenu);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenu";
            this.Text = "Controle de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.sstStatus.ResumeLayout(false);
            this.sstStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip sstStatus;
        private System.Windows.Forms.ToolStripStatusLabel sslTexto;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.ToolStripStatusLabel sslHora;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeSeuTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem organizarNaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSplitButton relatorioClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relátorioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relátorioDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relátorioDeJogosToolStripMenuItem;
    }
}