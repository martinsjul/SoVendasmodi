using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaVendas
{
    public partial class FrmRptClientes : Form
    {
        public FrmRptClientes()
        {
            InitializeComponent();
        }

        private void FrmRptClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet1.pc_itemvenda'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_itemvendaTableAdapter.Fill(this.lP2DataSet1.pc_itemvenda);
            pc_clientesTableAdapter1.Fill(this.lP2DataSet1.pc_clientes);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
