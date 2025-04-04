using Registro_de_Funcionarios.dbJogosDataSetTableAdapters;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Registro_de_Funcionarios
{
    public partial class Form1 : Form
    {

        private void atualizarlista() 
        {
            tbJogoTableAdapter tabela = new tbJogoTableAdapter();
            var dados = from linha in tabela.GetData() select linha;

            foreach (var dado in dados)
            {
                lboJogos.Items.Add(dado);

            }
        }

        public Form1()
        {
            InitializeComponent();
            atualizarlista();
        }

        private void lboJogos_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (lboJogos.SelectedItem == null) return;

          
        }
    }
}
