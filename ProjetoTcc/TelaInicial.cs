using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTcc
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            CadastrarProdutos CadastroProduto = new CadastrarProdutos();
            CadastroProduto.ShowDialog();
        }

        private void btnCadastrarPacotes_Click(object sender, EventArgs e)
        {
            CadastrarPacotes CadastroPacote = new CadastrarPacotes();
            CadastroPacote.ShowDialog();

        }
       
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            FrmVisualizador oForm = new FrmVisualizador();
            oForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void TelaInicial_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
