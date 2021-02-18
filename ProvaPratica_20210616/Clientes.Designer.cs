namespace ProvaPratica_20210616
{
    partial class Clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.MaskCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaskCredito = new System.Windows.Forms.MaskedTextBox();
            this.txtStatus = new System.Windows.Forms.ListBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // MaskCPF
            // 
            this.MaskCPF.Location = new System.Drawing.Point(108, 53);
            this.MaskCPF.Mask = "___.___.___-__";
            this.MaskCPF.Name = "MaskCPF";
            this.MaskCPF.Size = new System.Drawing.Size(145, 22);
            this.MaskCPF.TabIndex = 1;
            this.MaskCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskCPF_MaskInputRejected);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(277, 51);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(96, 23);
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Text = "Pesquisar...";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "TELEFONE: ";
            // 
            // MaskTelefone
            // 
            this.MaskTelefone.Location = new System.Drawing.Point(108, 107);
            this.MaskTelefone.Mask = "(__) _.____-____";
            this.MaskTelefone.Name = "MaskTelefone";
            this.MaskTelefone.Size = new System.Drawing.Size(145, 22);
            this.MaskTelefone.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(108, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(145, 22);
            this.txtNome.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "CRÉDITO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "STATUS";
            // 
            // MaskCredito
            // 
            this.MaskCredito.Location = new System.Drawing.Point(108, 139);
            this.MaskCredito.Mask = "____,__";
            this.MaskCredito.Name = "MaskCredito";
            this.MaskCredito.Size = new System.Drawing.Size(100, 22);
            this.MaskCredito.TabIndex = 9;
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.ItemHeight = 16;
            this.txtStatus.Items.AddRange(new object[] {
            "Nome Livre",
            "Não Deseja Ser Contatado",
            "Cliente Aceitou Oferta",
            "Caiu a Ligação",
            "Viajou",
            "Falecido"});
            this.txtStatus.Location = new System.Drawing.Point(108, 174);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(120, 84);
            this.txtStatus.TabIndex = 10;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(15, 340);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 11;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(108, 340);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(205, 340);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(563, 340);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.MaskCredito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.MaskTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.MaskCPF);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.MaskedTextBox MaskTelefone;
        public System.Windows.Forms.Button btnIncluir;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.MaskedTextBox MaskCPF;
        public System.Windows.Forms.MaskedTextBox MaskCredito;
        public System.Windows.Forms.ListBox txtStatus;
    }
}