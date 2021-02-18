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
    public partial class FrmVisualizador : Form
    {
        MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;");

        public FrmVisualizador()
        {

            conectar.Open();
            
            InitializeComponent();

            conectar.Close();
        }

        private void FrmVisualizador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodpacoteDataSet1.pacote' table. You can move, or remove it, as needed.
            this.pacoteTableAdapter.Fill(this.prodpacoteDataSet1.pacote);

            conectar.Open();
            conectar.Close();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            conectar.Open();
            conectar.Close();
        }
    }
}
