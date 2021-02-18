using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Data.SqlClient;

using MySql.Data;
using MySql.Data.MySqlClient;
namespace ProjetoTcc
{
    public partial class Relatorio : Form
    {
        MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;");

        public Relatorio()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblPeriodo_Click(object sender, EventArgs e)
        {

        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVisualizador oForm = new FrmVisualizador();
            oForm.Show();
        }
    }
}
