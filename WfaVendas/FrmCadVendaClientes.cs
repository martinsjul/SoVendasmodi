using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfaVendas.LP2DataSet1TableAdapters;

namespace WfaVendas
{
    public partial class FrmCadVendaClientes : Form
    {
        bool incluir = false;
        bool editar = false;
        bool editarItem = false;
        bool incluirItem = false;
        double precoTemp = 0;

        public FrmCadVendaClientes()
        {
            InitializeComponent();
        }
        //esse n tem na foto
        

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendasDataSet.pc_itemvenda' table. You can move, or remove it, as needed.
            pc_itemvendaTableAdapter.Fill(lP2DataSet1.pc_itemvenda);
            // TODO: This line of code loads data into the 'vendasDataSet.pc_venda' table. You can move, or remove it, as needed.
            pc_vendaTableAdapter.Fill(lP2DataSet1.pc_venda);
            // TODO: This line of code loads data into the 'vendasDataSet.pc_produto' table. You can move, or remove it, as needed.
            pc_produtoTableAdapter.Fill(lP2DataSet1.pc_produto);

            if (dgvVendas.Rows.Count > 0)
            {
                dgvVendas.Rows[0].Selected = true;
            }
        }

        // Programa PRIMEIRO os métodos: habilitaCampos, habilitaCamposItem, habilitaBotoes, habilitaBotoesItem
        // e limpaCampos; Pois são pré-requisitos dos botões
        private void habilitaCampos(bool hab)
        {
            cmbCliente.Enabled = hab;
            dtpDataVenda.Enabled = hab;
            dtpDataEntrega.Enabled = hab;
            txtObs.Enabled = hab;
            txtNome.Enabled = hab;  
        }
        private void habilitaCamposItem(bool hab)
        {
            cmbProduto.Enabled = hab;
            nudQuantidade.Enabled = hab;
        }

        private void habilitaBotoes(bool hab)
        {
            btnIncluir.Enabled = hab;
            btnExcluir.Enabled = hab;
            btnAlterar.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;
        }

        private void habilitaBotoesItem(bool hab)
        {
            btnIncluirItem.Enabled = hab;
            btnExcluirItem.Enabled = hab;
            btnAlterarItem.Enabled = hab;
            btnPesquisarItem.Enabled = hab;
            btnGravarItem.Enabled = !hab;
            btnCancelarItem.Enabled = !hab;
        }

        private void limpaCampos(Control local) //(Form form) //TODO mostrar
        {
            foreach (Control item in local.Controls) //form.Controls)
            {
                if (item is TextBox) //(item is TextBox || item is MaskedTextBox)
                {
                    ((TextBox)item).Clear();
                    if (((TextBox)item).Name == "txtPrecoUnit"
                        || ((TextBox)item).Name == "txtSubTotal"
                        || ((TextBox)item).Name == "txtTotal")
                    {
                        ((TextBox)item).Text = "R$ 0,00";
                    }
                }

                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 1;
                }

                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }

                if (item is ComboBox)
                {
                    if (((ComboBox)item).Items.Count > 0)
                    {
                        ((ComboBox)item).SelectedIndex = 0;
                    }
                }

                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            incluir = true;
            habilitaCampos(true);
            habilitaBotoes(false);
        }
        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendas.RowCount > 0) //TODO mostrar
                {
                    this.pc_itemvendaTableAdapter.FillByNumVenda(this.lP2DataSet1.pc_itemvenda,
                        Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));

                    if (dgvItens.RowCount > 0)
                    {
                        double total = (Double)pc_itemvendaTableAdapter.TotalVenda(
                            Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        txtTotal.Text = total.ToString("R$ #,###,##0.00");
                    }
                    else
                    {
                        txtTotal.Text = "R$ 0,00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message,
                    "Erro ao acessar os Itens da VENDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Trocar nome do DataGridView para 'dgvVendas'
                if (dgvVendas.SelectedRows.Count > 0)
                {
                    
                    {
                        pc_vendaTableAdapter.Delete(Convert.ToInt32(
                            (dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString())));
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmVendas_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione uma venda primeiro!",
                        "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        try
            {
                if (incluir)
                {
                    // Insere um novo registro na tabela "pc_venda" do banco de dados
                    pc_vendaTableAdapter.Insert((int)
                                                cmbCliente.SelectedValue, dtpDataVenda.Value,
                                                dtpDataEntrega.Value, txtObs.Text);
                    MessageBox.Show("Incluído com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (editar)
                {
                    // Atualiza um registro existente na tabela "pc_venda" do banco de dados
                    pc_vendaTableAdapter.Update((Int32)cmbCliente.SelectedValue, dtpDataVenda.Value,
                                                dtpDataEntrega.Value, txtObs.Text, Convert.ToInt32(txtNumVenda.Text));
                    MessageBox.Show("Alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnCancelar_Click(null, null);
                FrmVendas_Load(null, null);
            }
            catch (Exception ex)

            {
                // Exibe uma mensagem de erro caso ocorra alguma exceção
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos(this); //TODO mostrar
            limpaCampos(grpItem);
            habilitaCampos(false);
            habilitaBotoes(true);
            editar = false;
            incluir = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvVendas.SelectedRows.Count > 0)
            {
                editar = true;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtNumVenda.Text = dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbCliente.SelectedValue = Convert.ToInt32(dgvVendas[4, dgvVendas.CurrentRow.Index].Value.ToString());
                dtpDataVenda.Value = Convert.ToDateTime(dgvVendas[2, dgvVendas.CurrentRow.Index].Value.ToString());
                dtpDataEntrega.Value = Convert.ToDateTime(dgvVendas[3, dgvVendas.CurrentRow.Index].Value.ToString());
                txtObs.Text = dgvVendas[5, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbCliente.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione uma VENDA primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (cmbCliente.Enabled == false)
            {
                cmbCliente.Enabled = true;
                cmbCliente.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;

                MessageBox.Show(null, "Digite o nome do cliente desejado ou" +
                                "\nparte dele.", "Pesquisa", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                pc_vendaTableAdapter.FillByNome(this.lP2DataSet1.pc_venda,
                                                "%" + cmbCliente.Text + "%");
                btnCancelar_Click(null, null);
            }


        }

        private void btnIncluirItem_Click(object sender, EventArgs e)
        {
            incluirItem = true;
            habilitaCamposItem(true);
            habilitaBotoesItem(false);
            cmbProduto_SelectedIndexChanged(null, null);
            cmbProduto.Focus();
        }
        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable produto = pc_produtoTableAdapter.GetDataByDescricao(cmbProduto.Text);
            precoTemp = 0; //Zerar precoTemp para garantir o cálculo
            foreach (DataRow row in produto.Rows) // Loop "nas linhas"
            {
                precoTemp = Convert.ToDouble(row["precounit"].ToString());
            }
            nudQuantidade.Value = 1;
           
            txtSub.Text = precoTemp.ToString("R$ #,###,##0.00");
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            double subTotal = (Int32)nudQuantidade.Value * precoTemp;
            txtSub.Text = subTotal.ToString("R$ #,###,##0.00");
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Trocar nome do DataGridView para 'dgvVendas'
                if (dgvItens.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o ITEM selecionado?", //trocar a mensagem
                        "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_itemvendaTableAdapter.Delete(
                            Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()),
                            Convert.ToInt32(dgvItens[0, dgvItens.CurrentRow.Index].Value.ToString())
                        );
                        dgvVendas_SelectionChanged(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um item primeiro!",
                        "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            if (dgvItens.SelectedRows.Count > 0)
            {
                editarItem = true;
                habilitaBotoesItem(false);
                habilitaCamposItem(true);
                cmbProduto.Text =
                    dgvItens[1, dgvItens.CurrentRow.Index].Value.ToString();
                // evitar erro de valor igual no cmbProduto
                cmbProduto_SelectedIndexChanged(null, null);
                nudQuantidade.Value = Convert.ToInt32(
                    dgvItens[2, dgvItens.CurrentRow.Index].Value.ToString());
                cmbProduto.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione uma ITEM primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItens.RowCount > 0)
                {
                    // alterar 'cmbCliente' ou 'cmbCodCli' p/ cmbProduto ou cmbCodPro
                    if (cmbProduto.Enabled == false)
                    {
                        cmbProduto.Enabled = true;
                        cmbProduto.Focus();
                        habilitaBotoesItem(false);
                        btnPesquisarItem.Enabled = true;
                        btnGravarItem.Enabled = false;
                        btnCancelarItem.Enabled = false;
                        MessageBox.Show(null, "Digite o nome do ITEM desejado ou" +
                            "inparte dele.", "Pesquisa", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show(null, "Cadastre um item primeiro!",
                        "Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
          limpaCampos(grpItem);
            habilitaCamposItem(false);
            habilitaBotoesItem(true);
            editarItem = false;
            incluirItem = false;
        }
        private void btnGravarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluirItem)
                {
                    pc_itemvendaTableAdapter.Insert(Convert.ToInt32(
                        dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()),
                        (Int32)cmbProduto.SelectedValue, (Int32)nudQuantidade.Value,
                        precoTemp);
                    MessageBox.Show(null, "Incluído com sucesso!", "Inclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (editarItem)
                {
                    pc_itemvendaTableAdapter.Update(
                        (Int32)cmbProduto.SelectedValue, // CodPro
                        (Int32)nudQuantidade.Value, // Quantidade
                        precoTemp, // PrecoUnit
                        Convert.ToInt32( // numvenda
                            dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()),
                        Convert.ToInt32( // CodPro selecionado em dgvItens
                            dgvItens[0, dgvItens.CurrentRow.Index].Value.ToString()));
                    MessageBox.Show(null, "Alterado com sucesso!", "Alteração",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvVendas_SelectionChanged(null, null);
                btnCancelarItem_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: " + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            FrmVendas_Load(null, null);
        }

        //apagar depois
        private void txtSubtotal_Click(object sender, EventArgs e)
        {
            // Seu código aqui
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Código que será executado quando o label1 for clicado
        }
        private void codcliLabel_Click(object sender, EventArgs e)
        {
            // Código para executar quando o codcliLabel for clicado
        }
        private void pc_itemvendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Código para tratar o evento de clique no conteúdo da célula
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Código para tratar o evento de entrada no GroupBox
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // Código para tratar o evento de entrada no GroupBox
        }
        private void FrmCadVendaClientes_Load(object sender, EventArgs e)
        {




            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet1.pc_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_clientesTableAdapter.Fill(this.lP2DataSet1.pc_clientes);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet1.pc_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_produtoTableAdapter.Fill(this.lP2DataSet1.pc_produto);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet1.pc_itemvenda'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_itemvendaTableAdapter.Fill(this.lP2DataSet1.pc_itemvenda);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet1.pc_venda'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_vendaTableAdapter.Fill(this.lP2DataSet1.pc_venda);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_clientes'. Você pode movê-la ou removê-la conforme necessário
   
            // Código para tratar o evento Load do formulário

        }

        private void txtNumVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void nudQuantidade_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void numvendaLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecoUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void precounitLabel_Click(object sender, EventArgs e)
        {

        }

        private void precounitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pc_produtoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}