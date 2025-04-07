using Registro_de_Funcionarios.dbJogosDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Registro_de_Funcionarios.dbJogosDataSet;


namespace Registro_de_Funcionarios
{
    public partial class Form1 : Form
    {

        private void atualizarlista() 
        {
            lboJogos.Items.Clear();
            tbJogoTableAdapter tabela = new tbJogoTableAdapter();
            var dados = from linha in tabela.GetData() select linha;

            foreach (var linha in dados)
            {
                lboJogos.Items.Add(linha);
            }
        }

        public Form1()
        {
            InitializeComponent();
            atualizarlista();
        }

        private void LimparTela() 
        {
            txtTitulo.Clear();
            txtPlataforma.Clear();
            txtGenero.Clear();
            txtDesenvolvedor.Clear();
            txtClassicacaoEtaria.Clear();
            txtPlataforma.Clear();
            txtPreco.Clear();
            txtID.Clear();
            txtEmpresaPublicadora.Clear();
            dtpDataLancamento.Value = DateTime.Now;  
        }


        private void lboJogos_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (lboJogos.SelectedItem == null) 
            { 
                return;
            }

            tbJogoRow jogos = lboJogos.SelectedItem as tbJogoRow;

            txtID.Text = jogos.Id_jogo.ToString();
            txtTitulo.Text = jogos.titulo;
            txtDesenvolvedor.Text = jogos.desenvolvedora;
            txtEmpresaPublicadora.Text = jogos.publicadora;
            txtGenero.Text = jogos.genero;
            txtPlataforma.Text = jogos.plataformas;
            txtPreco.Text = jogos.preco.ToString();
            txtClassicacaoEtaria.Text = jogos.classificacao;
            dtpDataLancamento.Value = jogos.data_lancamento;
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {
            if (txtTitulo.Text == "" || txtPreco.Text == "" || txtClassicacaoEtaria.Text == ""
                || txtDesenvolvedor.Text == "" || txtEmpresaPublicadora.Text == "" || txtGenero.Text == "" || txtPlataforma.Text == "" || dtpDataLancamento.Value == null) {
                MessageBox.Show("Preencha todos os campos para adicionar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            tbJogoTableAdapter novosDados = new tbJogoTableAdapter();

            string titulo = txtTitulo.Text;
            string empresaDesenvolvedora = txtEmpresaPublicadora.Text;
            string empresaPublicadora = txtEmpresaPublicadora.Text;
            DateTime lancamentos = dtpDataLancamento.Value;
            string genero = txtGenero.Text;
            string plataforma  = txtPlataforma.Text;
            decimal preco = decimal.Parse(txtPreco.Text);
            string classificacao = txtClassicacaoEtaria.Text;

            novosDados.Insert(titulo, empresaDesenvolvedora, empresaPublicadora, lancamentos, genero, plataforma, preco, classificacao);
            atualizarlista();
            LimparTela();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "" || txtPreco.Text == "" || txtClassicacaoEtaria.Text == ""
                || txtDesenvolvedor.Text == "" || txtEmpresaPublicadora.Text == "" || txtGenero.Text == "" || txtPlataforma.Text == "" || dtpDataLancamento.Value == null)
            {
                MessageBox.Show("Não há nenhum campo preenchido","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            atualizarlista();
            LimparTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lboJogos.SelectedItem == null) 
            {
                MessageBox.Show("Selecione qual campo sera excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tbJogoRow excluir = lboJogos.SelectedItem as tbJogoRow;
            tbJogoTableAdapter dados = new tbJogoTableAdapter();

            dados.Delete(excluir.Id_jogo, excluir.titulo, excluir.desenvolvedora,excluir.publicadora ,excluir.data_lancamento, excluir.genero,
                excluir.plataformas, excluir.preco, excluir
                .classificacao);


            atualizarlista();
            LimparTela();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (lboJogos.SelectedItem == null) return;
           
            tbJogoRow dadosAtualizar = lboJogos.SelectedItem as tbJogoRow;
            tbJogoTableAdapter atualizar = new tbJogoTableAdapter();

            string titulo = txtTitulo.Text;
            string empresaDesenvolvedora = txtEmpresaPublicadora.Text;
            string empresaPublicadora = txtEmpresaPublicadora.Text;
            DateTime lancamentos = dtpDataLancamento.Value;
            string genero = txtGenero.Text;
            string plataforma = txtPlataforma.Text;
            decimal preco = decimal.Parse(txtPreco.Text);
            string classificacao = txtClassicacaoEtaria.Text;

            // Atualizando os dados 
            dadosAtualizar.titulo = titulo;
            dadosAtualizar.desenvolvedora = empresaDesenvolvedora;
            dadosAtualizar.publicadora = empresaPublicadora;
            dadosAtualizar.data_lancamento = lancamentos;
            dadosAtualizar.genero = genero;
            dadosAtualizar.plataformas = plataforma;
            dadosAtualizar.preco = preco;
            dadosAtualizar.classificacao = classificacao;
            atualizar.Update(dadosAtualizar);

            atualizarlista();
            LimparTela();

        }
    }
}
