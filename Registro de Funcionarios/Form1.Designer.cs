namespace Registro_de_Funcionarios
{
    partial class Form1
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
            this.btnId = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbldesenvoledora = new System.Windows.Forms.Label();
            this.txtDesenvolvedor = new System.Windows.Forms.TextBox();
            this.txtEmpresaPublicadora = new System.Windows.Forms.TextBox();
            this.lblPublicadora = new System.Windows.Forms.Label();
            this.lblDataLancamento = new System.Windows.Forms.Label();
            this.dtpDataLancamento = new System.Windows.Forms.DateTimePicker();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPlataforma = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtPlataforma = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblClassificacaoEtaria = new System.Windows.Forms.Label();
            this.txtClassicacaoEtaria = new System.Windows.Forms.TextBox();
            this.txtModoJogo = new System.Windows.Forms.TextBox();
            this.lblModoJogo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lboJogos = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnId
            // 
            this.btnId.Enabled = false;
            this.btnId.Location = new System.Drawing.Point(64, 17);
            this.btnId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(148, 26);
            this.btnId.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AcceptsReturn = true;
            this.txtTitulo.Location = new System.Drawing.Point(374, 20);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(229, 26);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(242, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(103, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo do jogo";
            // 
            // lbldesenvoledora
            // 
            this.lbldesenvoledora.AutoSize = true;
            this.lbldesenvoledora.Location = new System.Drawing.Point(629, 26);
            this.lbldesenvoledora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldesenvoledora.Name = "lbldesenvoledora";
            this.lbldesenvoledora.Size = new System.Drawing.Size(188, 20);
            this.lbldesenvoledora.TabIndex = 3;
            this.lbldesenvoledora.Text = "Empresa desenvolvedora";
            // 
            // txtDesenvolvedor
            // 
            this.txtDesenvolvedor.AcceptsReturn = true;
            this.txtDesenvolvedor.Location = new System.Drawing.Point(825, 23);
            this.txtDesenvolvedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesenvolvedor.Name = "txtDesenvolvedor";
            this.txtDesenvolvedor.Size = new System.Drawing.Size(209, 26);
            this.txtDesenvolvedor.TabIndex = 4;
            // 
            // txtEmpresaPublicadora
            // 
            this.txtEmpresaPublicadora.AcceptsReturn = true;
            this.txtEmpresaPublicadora.Location = new System.Drawing.Point(201, 86);
            this.txtEmpresaPublicadora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpresaPublicadora.Name = "txtEmpresaPublicadora";
            this.txtEmpresaPublicadora.Size = new System.Drawing.Size(229, 26);
            this.txtEmpresaPublicadora.TabIndex = 6;
            // 
            // lblPublicadora
            // 
            this.lblPublicadora.AutoSize = true;
            this.lblPublicadora.Location = new System.Drawing.Point(13, 89);
            this.lblPublicadora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublicadora.Name = "lblPublicadora";
            this.lblPublicadora.Size = new System.Drawing.Size(167, 20);
            this.lblPublicadora.TabIndex = 5;
            this.lblPublicadora.Text = "Empresa que publicou";
            // 
            // lblDataLancamento
            // 
            this.lblDataLancamento.AutoSize = true;
            this.lblDataLancamento.Location = new System.Drawing.Point(466, 92);
            this.lblDataLancamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataLancamento.Name = "lblDataLancamento";
            this.lblDataLancamento.Size = new System.Drawing.Size(106, 20);
            this.lblDataLancamento.TabIndex = 7;
            this.lblDataLancamento.Text = "Lançamentos";
            // 
            // dtpDataLancamento
            // 
            this.dtpDataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLancamento.Location = new System.Drawing.Point(605, 87);
            this.dtpDataLancamento.Name = "dtpDataLancamento";
            this.dtpDataLancamento.Size = new System.Drawing.Size(126, 26);
            this.dtpDataLancamento.TabIndex = 8;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(755, 93);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(119, 20);
            this.lblGenero.TabIndex = 9;
            this.lblGenero.Text = "Gênero do jogo";
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.AutoSize = true;
            this.lblPlataforma.Location = new System.Drawing.Point(14, 157);
            this.lblPlataforma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlataforma.Name = "lblPlataforma";
            this.lblPlataforma.Size = new System.Drawing.Size(142, 20);
            this.lblPlataforma.TabIndex = 11;
            this.lblPlataforma.Text = "Plataforma do jogo";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(370, 163);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 20);
            this.lblPreco.TabIndex = 13;
            this.lblPreco.Text = "Preço";
            // 
            // txtGenero
            // 
            this.txtGenero.AcceptsReturn = true;
            this.txtGenero.Location = new System.Drawing.Point(898, 93);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(136, 26);
            this.txtGenero.TabIndex = 14;
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.AcceptsReturn = true;
            this.txtPlataforma.Location = new System.Drawing.Point(182, 157);
            this.txtPlataforma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.Size = new System.Drawing.Size(138, 26);
            this.txtPlataforma.TabIndex = 15;
            // 
            // txtPreco
            // 
            this.txtPreco.AcceptsReturn = true;
            this.txtPreco.Location = new System.Drawing.Point(449, 160);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(138, 26);
            this.txtPreco.TabIndex = 16;
            // 
            // lblClassificacaoEtaria
            // 
            this.lblClassificacaoEtaria.AutoSize = true;
            this.lblClassificacaoEtaria.Location = new System.Drawing.Point(629, 166);
            this.lblClassificacaoEtaria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassificacaoEtaria.Name = "lblClassificacaoEtaria";
            this.lblClassificacaoEtaria.Size = new System.Drawing.Size(150, 20);
            this.lblClassificacaoEtaria.TabIndex = 17;
            this.lblClassificacaoEtaria.Text = "Classificação etaria ";
            // 
            // txtClassicacaoEtaria
            // 
            this.txtClassicacaoEtaria.AcceptsReturn = true;
            this.txtClassicacaoEtaria.Location = new System.Drawing.Point(806, 160);
            this.txtClassicacaoEtaria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClassicacaoEtaria.Name = "txtClassicacaoEtaria";
            this.txtClassicacaoEtaria.Size = new System.Drawing.Size(138, 26);
            this.txtClassicacaoEtaria.TabIndex = 18;
            // 
            // txtModoJogo
            // 
            this.txtModoJogo.AcceptsReturn = true;
            this.txtModoJogo.Location = new System.Drawing.Point(140, 222);
            this.txtModoJogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModoJogo.Name = "txtModoJogo";
            this.txtModoJogo.Size = new System.Drawing.Size(138, 26);
            this.txtModoJogo.TabIndex = 20;
            // 
            // lblModoJogo
            // 
            this.lblModoJogo.AutoSize = true;
            this.lblModoJogo.Location = new System.Drawing.Point(14, 225);
            this.lblModoJogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModoJogo.Name = "lblModoJogo";
            this.lblModoJogo.Size = new System.Drawing.Size(88, 20);
            this.lblModoJogo.TabIndex = 19;
            this.lblModoJogo.Text = "Modo Jogo";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 20);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 20);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "ID";
            // 
            // lboJogos
            // 
            this.lboJogos.FormattingEnabled = true;
            this.lboJogos.ItemHeight = 20;
            this.lboJogos.Location = new System.Drawing.Point(27, 408);
            this.lboJogos.Name = "lboJogos";
            this.lboJogos.Size = new System.Drawing.Size(953, 284);
            this.lboJogos.TabIndex = 22;
            this.lboJogos.SelectedValueChanged += new System.EventHandler(this.lboJogos_SelectedValueChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(47, 357);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(109, 35);
            this.btnAdicionar.TabIndex = 23;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(520, 357);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 35);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(825, 357);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(109, 35);
            this.btnAtualizar.TabIndex = 26;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(268, 357);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 35);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 704);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lboJogos);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtModoJogo);
            this.Controls.Add(this.lblModoJogo);
            this.Controls.Add(this.txtClassicacaoEtaria);
            this.Controls.Add(this.lblClassificacaoEtaria);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtPlataforma);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblPlataforma);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.dtpDataLancamento);
            this.Controls.Add(this.lblDataLancamento);
            this.Controls.Add(this.txtEmpresaPublicadora);
            this.Controls.Add(this.lblPublicadora);
            this.Controls.Add(this.txtDesenvolvedor);
            this.Controls.Add(this.lbldesenvoledora);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de funcionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox btnId;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbldesenvoledora;
        private System.Windows.Forms.TextBox txtDesenvolvedor;
        private System.Windows.Forms.TextBox txtEmpresaPublicadora;
        private System.Windows.Forms.Label lblPublicadora;
        private System.Windows.Forms.Label lblDataLancamento;
        private System.Windows.Forms.DateTimePicker dtpDataLancamento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPlataforma;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtPlataforma;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblClassificacaoEtaria;
        private System.Windows.Forms.TextBox txtClassicacaoEtaria;
        private System.Windows.Forms.TextBox txtModoJogo;
        private System.Windows.Forms.Label lblModoJogo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ListBox lboJogos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

