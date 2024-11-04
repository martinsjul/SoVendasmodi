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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            sslHora.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if (form is FrmCadClientes)
                {
                    form.Focus();
                    return;
                }
            }

            FrmCadClientes frmCadClientes = new FrmCadClientes();
            frmCadClientes.MdiParent = this;
            frmCadClientes.Show();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo Fechar?", "Atenção: ",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cadastroDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if (form is FrmCadVendaClientes)
                {
                    form.Focus();
                    return;
                }
            }

            FrmCadVendaClientes frmCadVendasClientes = new FrmCadVendaClientes();
            frmCadVendasClientes.MdiParent = this;
            frmCadVendasClientes.Show();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if (form is FrmCadClientes)
                {
                    form.Focus();
                    return;
                }
            }

            FrmRptVendas frmRptVendas = new FrmRptVendas();
            frmRptVendas.MdiParent = this;
            frmRptVendas.Show();
        }

        private void relatorioDeClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}