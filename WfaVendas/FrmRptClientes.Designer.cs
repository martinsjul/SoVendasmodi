namespace WfaVendas
{
    partial class FrmRptClientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pc_clientesTableAdapter1 = new WfaVendas.LP2DataSet1TableAdapters.pc_clientesTableAdapter();
            this.lP2DataSet1 = new WfaVendas.LP2DataSet1();
            this.pcitemvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_itemvendaTableAdapter = new WfaVendas.LP2DataSet1TableAdapters.pc_itemvendaTableAdapter();
            this.pcclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcitemvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcclientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pcclientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WfaVendas.RptClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 449);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // pc_clientesTableAdapter1
            // 
            this.pc_clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // lP2DataSet1
            // 
            this.lP2DataSet1.DataSetName = "LP2DataSet1";
            this.lP2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pcitemvendaBindingSource
            // 
            this.pcitemvendaBindingSource.DataMember = "pc_itemvenda";
            this.pcitemvendaBindingSource.DataSource = this.lP2DataSet1;
            // 
            // pc_itemvendaTableAdapter
            // 
            this.pc_itemvendaTableAdapter.ClearBeforeFill = true;
            // 
            // pcclientesBindingSource
            // 
            this.pcclientesBindingSource.DataMember = "pc_clientes";
            this.pcclientesBindingSource.DataSource = this.lP2DataSet1;
            // 
            // FrmRptClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptClientes";
            this.Text = "Relatório de Clientes";
            this.Load += new System.EventHandler(this.FrmRptClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcitemvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcclientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LP2DataSet1TableAdapters.pc_clientesTableAdapter pc_clientesTableAdapter1;
        private LP2DataSet1 lP2DataSet1;
        private System.Windows.Forms.BindingSource pcitemvendaBindingSource;
        private LP2DataSet1TableAdapters.pc_itemvendaTableAdapter pc_itemvendaTableAdapter;
        private System.Windows.Forms.BindingSource pcclientesBindingSource;
    }
}