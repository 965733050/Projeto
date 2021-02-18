using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

//Classe responsável pela ação dos campos e botões do cadastro de clientes
namespace ProvaPratica_20210616
{
    public partial class Clientes : Form
    {
        DadosTableAdapters.dadosClientesTableAdapter TaCli = new DadosTableAdapters.dadosClientesTableAdapter();

        Principal pri;

        public Clientes()
        {
            InitializeComponent();
        }

        public Clientes(Principal Formpri)
        {
            InitializeComponent();
            pri = Formpri;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            if(MaskCPF.Text != "")
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void btnLocalizar_click(object sender, EventArgs e)
        {
            PesquisaCliente formPesquisaCliente = new PesquisaCliente(this);
            formPesquisaCliente.ShowDialog(this);
        }

        private void btnIncluir_click(object sender, EventArgs e)
        {
            MaskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (MaskCPF.Text == "")
                MessageBox.Show("Informe um CPF válido!", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (Validacoes.validarCPF(MaskCPF.Text))
                {
                    MaskCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    try
                    {
                        TaCli.cadastrarEAlterarClientes(MaskCPF.Text, txtNome.Text, MaskCredito.Text, MaskTelefone.Text, txtStatus.Text, 1);
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir cliente, verifique os dados\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Informe um CPF válido!", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_click(object sender, EventArgs e)
        {
            try
            {
                TaCli.cadastrarEAlterarClientes(MaskCPF.Text, txtNome.Text, MaskCredito.Text, MaskTelefone.Text, txtStatus.Text, 2);
                MessageBox.Show("Dados atualizados com sucesso!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar cliente\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este cliente?", "Excluir cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    TaCli.excluirClientes(MaskCPF.Text);
                    MaskCPF.Text = "";
                    txtNome.Text = "";
                    MaskCredito.Text = "";
                    MaskTelefone.Text = "";
                    txtStatus.Text = "";
                    MessageBox.Show("Cliente excluído", "Confirmação de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao excluir cliente!\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
