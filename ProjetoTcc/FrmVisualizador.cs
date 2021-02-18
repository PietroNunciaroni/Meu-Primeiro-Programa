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
            // TODO: esta linha de código carrega dados na tabela 'prodpacoteDataSet.pacote'. Você pode movê-la ou removê-la conforme necessário.
            this.pacoteTableAdapter.Fill(this.prodpacoteDataSet.pacote);
            // TODO: esta linha de código carrega dados na tabela 'novoConjutntoDedados.produto'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtoTableAdapter.Fill(this.novoConjutntoDedados.produto);
            SetMyCustomFormat();
            SetMyCustomFormat2();
            // TODO: This line of code loads data into the 'prodpacoteDataSet1.pacote' table. You can move, or remove it, as needed.
            //this.pacoteTableAdapter.Fill(this.prodpacoteDataSet1.pacote);

            conectar.Open();
            conectar.Close();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            conectar.Open();
            conectar.Close();
        }

       
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacoteTableAdapter.FillBy(this.prodpacoteDataSet.pacote, ((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value.ToString(), typeof(System.DateTime)))), ((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value.ToString(), typeof(System.DateTime)))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void SetMyCustomFormat()
        {
            this.dateTimePicker1.Value = DateTime.Now;
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " --/--/----";
        }
        public void SetMyCustomFormat2()
        {
            this.dateTimePicker2.Value = DateTime.Now;
            // Set the Format type and the CustomFormat string.
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = " --/--/----";
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " dd/MM/yyyy";
        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = " dd/MM/yyyy";
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacoteTableAdapter.Fill(this.prodpacoteDataSet.pacote);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
