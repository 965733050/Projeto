using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Classe responsável pela ação dos botões e campos da tela de pesquisa de clientes, validando também a busca por cpf ou nome do cliente.
namespace ProvaPratica_20210616
{
    public partial class PesquisaCliente : Form
    {
        Dados.dadosClientesDataTable DTClientes = new Dados.dadosClientesDataTable();
        DadosTableAdapters.dadosClientesTableAdapter TaCli = new DadosTableAdapters.dadosClientesTableAdapter();

        Clientes formCli;
        public PesquisaCliente()
        {
            InitializeComponent();
        }

        public PesquisaCliente(Clientes formClientes)
        {
            InitializeComponent();
            formCli = formClientes;
        }

        private void txtPesquisa_TextChanged(Object sender, EventArgs e)
        {
            try
            {
                if (rdbCPF.Checked == true)
                {
                    TaCli.FillByBuscaCliCPF(DTClientes, txtPesquisa.Text);
                    dgvClientes.DataSource = DTClientes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente não encontrado\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha;
                linha = dgvClientes.CurrentRow;
                formCli.MaskCPF.Text = linha.Cells["CPF"].Value.ToString();
                formCli.txtNome.Text = linha.Cells["Nome"].Value.ToString();
                formCli.MaskTelefone.Text = linha.Cells["Telefone"].Value.ToString();
                formCli.MaskCredito.Text = linha.Cells["Crédito"].Value.ToString();
                formCli.txtStatus.Text = linha.Cells["Status"].Value.ToString();
                this.Close();
                formCli.btnAlterar.Enabled = true;
                formCli.btnExcluir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione um cliente\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void formPesquisaCliente_Load(Object sender, EventArgs e)
        {
            TaCli.FillByDados(DTClientes);
            dgvClientes.DataSource = DTClientes;   
        }
    }
}
