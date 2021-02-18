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
using System.Text.RegularExpressions;

namespace ProjetoTcc
{

    public partial class CadastrarProdutos : Form
    {
        //variaveis
        decimal Converter;
        int alterar = 0;
        string ativIndat = "Ativo";

        //conexão com o banco
        MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;");
        public CadastrarProdutos()
        {
            InitializeComponent();
        }
        //limpando
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            alterar = 0;
            txtNome.Text = "";
            txtPreco.Text = "";
            txtDescricao.Text = "";
            txtBusca.Text = "";
            comboBox1.Text = "";
            ckbAtiv.Checked = false;
            selecionarCategoria();
        }
        //metodo para prencher o dataGrid
        private void selecionarCategoria()
        {
            conectar.Open();




            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from Produto", conectar);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            conectar.Close();

        }

        //FORM do cadastrar produtos
        private void CadastrarProdutos_Load(object sender, EventArgs e)
        {
            //primeiro espaço fazio no combobox
            
            //
            selecionarCategoria();
            //toolTip
            ToolTip toolTip1 = new ToolTip();

            // Configurar os atrasos para o toolTip
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Força o texto da dica de ferramenta a ser exibido, quer o formulário esteja ou não ativo.
            toolTip1.ShowAlways = true;

            // setando o toolTip nos campos
            toolTip1.SetToolTip(this.txtNome, "Campo Obrigatório");
            toolTip1.SetToolTip(this.txtDescricao, "Campo Obrigatório");
            toolTip1.SetToolTip(this.txtPreco, "Campo Obrigatório");
           

            dataGridView1.Columns["ID_Produto"].HeaderText = "ID";
            dataGridView1.Columns["Descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["Preco"].HeaderText = "Preço";


        }

       
        //fecha
        private void txtFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        //deixando somemte numeros no txt
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas numeros", "Concluido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
            }


        }

        
        //CheckBox
        private void ckbAtiv_CheckedChanged(object sender, EventArgs e)
        {
            Converter = Convert.ToInt16(ckbAtiv.Checked);
            if (ckbAtiv.Checked)
            {
                ativIndat = "Inativo";
                ckbAtiv.ForeColor = Color.Red;
                ckbAtiv.Text = "Inativo";
            }
            else
            {
                ativIndat = "Ativo";
                ckbAtiv.ForeColor = Color.Green;
                ckbAtiv.Text = "Ativo";
            }


        }
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
             
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            alterar = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPreco.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();



            //Converter = Convert.ToDecimal(txtPreco.Text);

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBox1.Text == "Ativo")
            {
                string strSelect = "SELECT * FROM Produto WHERE status='Ativo' AND nome  LIKE (@Nome)";

                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;"))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(strSelect, conn);
                    //Passagem por parâmetros.
                    da.SelectCommand.Parameters.AddWithValue("@Nome", txtBusca.Text + "%");
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Nome");
                    dataGridView1.DataSource = ds.Tables["Nome"];
                }
            }
            else if (comboBox1.Text == "Inativo")
            {
                string strSelect = "SELECT * FROM Produto WHERE status='Inativo' AND nome  LIKE (@Nome)";
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;"))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(strSelect, conn);
                    //Passagem por parâmetros.
                    da.SelectCommand.Parameters.AddWithValue("@Nome", txtBusca.Text + "%");
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Nome");
                    dataGridView1.DataSource = ds.Tables["Nome"];
                }
            }
            else
            {
                string strSelect = "SELECT * FROM Produto WHERE Nome LIKE (@Nome)";

                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;"))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(strSelect, conn);
                    //Passagem por parâmetros.
                    da.SelectCommand.Parameters.AddWithValue("@Nome", txtBusca.Text + "%");
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Nome");
                    dataGridView1.DataSource = ds.Tables["Nome"];
                }
            }
        }

       
        private void btnSalvar2_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;");
            conectar.Open();
            var transaction = conectar.BeginTransaction();
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                System.Windows.Forms.MessageBox.Show("O nome do produto está vazio, por favor digite algo");
                return; // sai do método
            }
            else if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                System.Windows.Forms.MessageBox.Show("A Descrição do produto está vazia, por favor digite algo");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                System.Windows.Forms.MessageBox.Show("O Preço do produto está vazio, por favor digite algo");
            }
            else if (alterar <= 0)
            {
                MySqlCommand Inserir = new MySqlCommand();
                Inserir.Connection = conectar;
                Inserir.CommandText = @"INSERT INTO Produto SET Nome = @Nome, Descricao = @Descricao, 
                   Preco = @Preco ,status = @status ";

                Inserir.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = txtNome.Text;
                Inserir.Parameters.Add("@Descricao", MySqlDbType.VarChar).Value = txtDescricao.Text;
                Inserir.Parameters.Add("@Preco", MySqlDbType.Double).Value = txtPreco.Text;
                Inserir.Parameters.Add("@status", MySqlDbType.VarChar).Value = ativIndat;

                Inserir.ExecuteNonQuery();

                transaction.Commit();
                conectar.Close();
                MessageBox.Show("Produto cadastrado", "Concluido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                selecionarCategoria();
                alterar = 0;
                txtNome.Text = "";
                txtPreco.Text = "";
                txtDescricao.Text = "";
            }
            else
            {
                conectar.Close();
                conectar.Open();
                //Convertendo

                Converter = Convert.ToDecimal(txtPreco.Text);



                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;");
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = @"UPDATE  Produto SET Nome = @Nome, Descricao = @Descricao, 
                   Preco = @Preco ,status = @status WHERE ID_Produto = @ID";

                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = txtNome.Text;
                cmd.Parameters.Add("@Descricao", MySqlDbType.VarChar).Value = txtDescricao.Text;
                cmd.Parameters.Add("@Preco", MySqlDbType.Double).Value = txtPreco.Text;
                cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = ativIndat;
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = alterar;
                cmd.ExecuteNonQuery();
                conn.Close();
                conectar.Close();
                alterar = 0;
                txtNome.Text = "";
                txtPreco.Text = "";
                txtDescricao.Text = "";
                MessageBox.Show("Produto alterado", "Concluido",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                selecionarCategoria();


            }
        }
        
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string strSelect = "SELECT * FROM Produto WHERE status LIKE (@status)";
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=prodPacote; Uid=root; pwd=1234;"))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(strSelect, conn);
                if (comboBox1.Text == "todos")
                {
                    da.SelectCommand.Parameters.AddWithValue("@status", "" + "%");
                    DataSet ds = new DataSet();
                    da.Fill(ds, "status");
                    dataGridView1.DataSource = ds.Tables["status"];
                }
                else
                {
                    //Passagem por parâmetros.
                    da.SelectCommand.Parameters.AddWithValue("@status", comboBox1.Text + "%");
                    DataSet ds = new DataSet();
                    da.Fill(ds, "status");
                    dataGridView1.DataSource = ds.Tables["status"];

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }    
}


