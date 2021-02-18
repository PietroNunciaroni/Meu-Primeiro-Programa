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
  
    public partial class CadastrarPacotes : Form
    {
        //Cria uma variavel tipo DATA
        DataTable dtTabelas2;


        //setando tooltip
        ToolTip toolTip1 = new ToolTip();
        //criando variaveis
        int Converter, alterar2 = 0;
        DateTime converterdata, converterdata2;        
        //Conexão com o banco de dados
        MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;");
        //inicializa os componentes
        public CadastrarPacotes()
        {
            InitializeComponent();
        }
        //Botão fechar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //carregando o GRid
        private void selecionarCategoria()
        {
            conectar.Open();
            //conexão e fazendo o campo derivado
             MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(" SELECT ID_Pacote, pacote." +
                                                                      " Nome,peca,Preco_data , Quantidade,Data_entrada,Data_saida, Total " +
                                                                      " FROM Pacote", conectar);
            //MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("INSERT INTO Pacote (Lucro) SELECT CONCAT('R$ ', ROUND(pacote.Quantidade * produto.Preco, 2)) AS Lucro FROM pacote INNER JOIN produto ON pacote.FK_ID_Produto = produto.ID_Produto;", conectar);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            conectar.Close();
        }


       

        //form

        private void CadastrarPacotes_Load(object sender, EventArgs e)
        {
           
        
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
            toolTip1.SetToolTip(this.txtQuantidade, "Campo Obrigatório");


            //puxando os metodos
            Selecionarproduto();            
            selecionarCategoria();
            SetMyCustomFormat2();
            SetMyCustomFormat();

            dataGridView1.Columns["ID_Pacote"].HeaderText = "ID";
            dataGridView1.Columns["Preco_Data"].HeaderText = "Preço da data";
            dataGridView1.Columns["Data_entrada"].HeaderText = "Data de Entrada";
            dataGridView1.Columns["Data_saida"].HeaderText = "Data de Saida";
            dataGridView1.Columns["peca"].HeaderText = "Peça";
        }
        //Botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
            //criando metodo de conexão
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;");
            conectar.Open();
            var transaction = conectar.BeginTransaction();
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                System.Windows.Forms.MessageBox.Show("O nome do pacote está vazio, por favor digite algo");
                return; // sai do método
            }
            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                System.Windows.Forms.MessageBox.Show("A Quantidade do Pacote está vazia, por favor digite algo");
                return; // sai do método
            }
            

            //se 'alterar2 <= 0' ele vai somente cadastrar o produto
            else if (alterar2 <= 0)
            {
                //se 'DTPSaida.Checked == false' ele nao envia com a data 
                if (DTPSaida.Checked == false)

                {

                    Converter = Convert.ToInt32(txtQuantidade.Text);
                    double ValorData = Convert.ToDouble(dtTabelas2.Rows[(int)cbxPeca.SelectedValue - 1][2].ToString());
                    double Total = Converter * ValorData;
                    //Convertendo a quantidade



                    //criando a string de conexão

                    MySqlCommand Inserir = new MySqlCommand();
                    Inserir.Connection = conectar;
                    Inserir.CommandText = "INSERT INTO Pacote (Pacote.Nome, peca, FK_ID_Produto, Quantidade, Data_entrada, Preco_data, Total) VALUES (@Nome, @peca, @FK_ID_Produto, @Quantidade, @Data_entrada, @PrecoData, @Total)";
                    //inserindo com parametros
                    Inserir.Parameters.AddWithValue("@Nome", txtNome.Text);
                    Inserir.Parameters.AddWithValue("@peca", cbxPeca.Text);
                    Inserir.Parameters.AddWithValue("@Quantidade", txtQuantidade.Text);
                    Inserir.Parameters.AddWithValue("@Data_entrada", DTPEntrada.Value);                    
                    Inserir.Parameters.AddWithValue("@FK_ID_Produto", cbxPeca.SelectedValue);
                    Inserir.Parameters.AddWithValue("@PrecoData", ValorData);
                    Inserir.Parameters.AddWithValue("@Total", Total);
                  


                    Inserir.ExecuteNonQuery();
                    transaction.Commit();
                    conectar.Close();
                    MessageBox.Show("Produto cadastrado", "Concluido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    //voltando para configurações iniciais
                    alterar2 = 0;
                    txtNome.Text = "";
                    txtQuantidade.Text = "";
                    //chamando metodos
                    selecionarCategoria();
                    SetMyCustomFormat2();
                    SetMyCustomFormat();
                    DTPSaida.Checked = false;
                }
                //se estiver checado ele vai fazer a mesma função porém enviando com a data de saida
                else
                {
                    //Convertendo

                    Converter = Convert.ToInt32(txtQuantidade.Text);
                    double ValorData = Convert.ToDouble(dtTabelas2.Rows[(int)cbxPeca.SelectedValue - 1][2].ToString());
                    double Total = Converter * ValorData;
                    //converterdata = Convert.ToDateTime(DTPEntrada.Text);
                    //converterdata2 = Convert.ToDateTime(DTPSaida.Text);
                    //criando a STRING
                    MySqlCommand Inserir = new MySqlCommand();
                    Inserir.Connection = conectar;
                    Inserir.CommandText = "INSERT INTO Pacote (Pacote.Nome, peca, FK_ID_Produto, Quantidade, Data_entrada, Data_saida, Preco_Data, Total) VALUES (@Nome, @peca, @FK_ID_Produto, @Quantidade, @Data_entrada, @Data_saida, @Preco_Data, @Total)";
                    //inserindo com parametros
                    Inserir.Parameters.AddWithValue("@Nome", txtNome.Text);
                    Inserir.Parameters.AddWithValue("@peca", cbxPeca.Text);
                    Inserir.Parameters.AddWithValue("@Quantidade", txtQuantidade.Text);
                    Inserir.Parameters.AddWithValue("@Data_entrada", DTPEntrada.Value);
                    Inserir.Parameters.AddWithValue("@Data_saida", DTPSaida.Value);
                    Inserir.Parameters.AddWithValue("@FK_ID_Produto", cbxPeca.SelectedValue);
                    Inserir.Parameters.AddWithValue("@Preco_Data", dtTabelas2.Rows[(int)cbxPeca.SelectedValue - 1][2].ToString());
                    Inserir.Parameters.AddWithValue("@Total", Total);
                    Inserir.ExecuteNonQuery();

                    transaction.Commit();
                    conectar.Close();
                    MessageBox.Show("Produto cadastrado", "Concluido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    //voltando para configurações iniciais
                    alterar2 = 0;
                    txtNome.Text = "";
                    txtQuantidade.Text = "";
                    //chamando metodos
                    selecionarCategoria();
                    SetMyCustomFormat2();
                    SetMyCustomFormat();
                    DTPSaida.Checked = false;
                }
            }
            else
            {
                if (DTPSaida.Checked == false)
                {
                    conectar.Close();
                    conectar.Open();
                    //Convertendo quantidade
                    Converter = Convert.ToInt32(txtQuantidade.Text);
                    double ValorData = Convert.ToDouble(dtTabelas2.Rows[(int)cbxPeca.SelectedValue - 1][2].ToString());
                    double Total = Converter * ValorData;
                    //convertendo datas para serem aceita nos parametros de checagem
                    converterdata = Convert.ToDateTime(DTPEntrada.Text);
                    //converterdata2 = Convert.ToDateTime(DTPSaida.Text);


                    MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;");
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();

                    cmd.CommandText = @"UPDATE  Pacote SET Pacote.Nome = @Nome, Quantidade = @Quantidade, 
                   peca = @Peca ,Data_entrada = @Data, FK_ID_Produto=@FK_ID_Produto,Preco_Data =@PrecoDt, Total=@Total WHERE ID_Pacote = @ID";
                    //enviando por parametros e checando 
                    cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = txtNome.Text;
                    cmd.Parameters.Add("@Quantidade", MySqlDbType.Int32).Value = Converter;
                    cmd.Parameters.Add("@peca", MySqlDbType.VarChar).Value = cbxPeca.Text;
                    cmd.Parameters.Add("@Data", MySqlDbType.Date).Value = DTPEntrada.Value;
                    cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = alterar2;
                    cmd.Parameters.Add("@FK_ID_Produto", MySqlDbType.Int32).Value = cbxPeca.SelectedValue;
                    cmd.Parameters.Add("@PrecoDt", MySqlDbType.Double).Value = dtTabelas2.Rows[(int)cbxPeca.SelectedValue - 1][2].ToString();
                    cmd.Parameters.Add("@Total", MySqlDbType.Double).Value = Total;

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();





                    MessageBox.Show("Pacote alterado", "Concluido",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    conn.Close();

                    //voltando para configurações iniciais
                    alterar2 = 0;
                    txtNome.Text = "";
                    txtQuantidade.Text = "";
                    //chamando metodos
                    selecionarCategoria();
                    SetMyCustomFormat2();
                    SetMyCustomFormat();
                    DTPSaida.Checked = false;
                }
                else
                {


                    conectar.Close();
                    conectar.Open();
                    //Convertendo quantidade
                    Converter = Convert.ToInt32(txtQuantidade.Text);
                    double ValorData = Convert.ToDouble(dtTabelas2.Rows[(int)cbxPeca.SelectedValue - 1][2].ToString());
                    double Total = Converter * ValorData;
                    //convertendo datas para serem aceita nos parametros de checagem
                    converterdata = Convert.ToDateTime(DTPEntrada.Text);
                    //converterdata2 = Convert.ToDateTime(DTPSaida.Text);


                    MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;");
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();

                    cmd.CommandText = @"UPDATE  Pacote SET Pacote.Nome = @Nome, Quantidade = @Quantidade, 
                   peca = @Peca ,Data_entrada = @Data, Data_saida = @Data2, FK_ID_Produto=@FK_ID_Produto,Preco_Data =@PrecoDt, Total=@Total WHERE ID_Pacote = @ID";
                    //enviando por parametros e checando 
                    cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = txtNome.Text;
                    cmd.Parameters.Add("@Quantidade", MySqlDbType.Int32).Value = Converter;
                    cmd.Parameters.Add("@peca", MySqlDbType.VarChar).Value = cbxPeca.Text;
                    cmd.Parameters.Add("@Data", MySqlDbType.Date).Value = DTPEntrada.Value;
                    cmd.Parameters.Add("@Data2", MySqlDbType.Date).Value = DTPSaida.Value;
                    cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = alterar2;
                    cmd.Parameters.Add("@FK_ID_Produto", MySqlDbType.Int32).Value = cbxPeca.SelectedValue;
                    cmd.Parameters.Add("@PrecoDt", MySqlDbType.Double).Value = dtTabelas2.Rows[(int)cbxPeca.SelectedValue - 1][2].ToString();
                    cmd.Parameters.Add("@Total", MySqlDbType.Double).Value = Total;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();





                    MessageBox.Show("Pacote alterado", "Concluido",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    conn.Close();

                    //voltando para configurações iniciais
                    alterar2 = 0;
                    txtNome.Text = "";
                    txtQuantidade.Text = "";
                    //chamando metodos
                    selecionarCategoria();
                    SetMyCustomFormat2();
                    SetMyCustomFormat();
                    DTPSaida.Checked = false;
                }
            }

        }

        //FORM do cadastrar pacotes
        private void CadastrarProdutos_Load(object sender, EventArgs e)
        {
            //chamando metodos
            selecionarCategoria();
            
        }
        //criando metodo Selecionar produti bi cinbi box   
        private void Selecionarproduto()
        {
             
            //criando tabela no combo
            DataTable dtTabelas = new DataTable();
            //criando conexão
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=ProdPacote; Uid=root; pwd=1234;");
            //fazendo a conexão da tabela do COMBOBOX com a tabela do BD
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select ID_Produto, nome, Preco from Produto", conectar);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            cbxPeca.DataSource = DS.Tables[0];
            conectar.Open();
            mySqlDataAdapter.Fill(dtTabelas);

            dtTabelas2 = dtTabelas;

            //carrega as informacoes no combo
            this.cbxPeca.DataSource = dtTabelas;
             this.cbxPeca.DisplayMember = "nome";
             this.cbxPeca.ValueMember = "ID_Produto";
            //this.label4.Text = dtTabelas.Rows;

        }

        
         //Limpando os campos
        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtQuantidade.Clear();
            txtNome.Clear();
            txtBusca.Clear();
            SetMyCustomFormat();
            SetMyCustomFormat2();


        }

       //fazendo a caixa de pesquisa de dados
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            //tring de conexão com o caminho para 
            string strSelect = "SELECT * FROM Pacote WHERE Nome LIKE (@Nome)";

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

       
        //não permitindo a entrada de letras no campo quantidade
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
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



        //puxando os dados para e edição no banco 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            alterar2 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbxPeca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtQuantidade.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            DTPEntrada.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            DTPSaida.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            DTPSaida.Format = DateTimePickerFormat.Custom;
            DTPSaida.CustomFormat = " dd/MM/yyyy";

        }
        //fazendo a data ficar visivel assim que fecha o calendario
        private void DTPSaida_CloseUp(object sender, EventArgs e)
        {

          
            DTPSaida.Format = DateTimePickerFormat.Custom;
            DTPSaida.CustomFormat = " dd/MM/yyyy";
        }
        //botao de cancela
        private void btnCancel_Click(object sender, EventArgs e)
        {
            alterar2 = 0;
            txtBusca.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
            SetMyCustomFormat();
            SetMyCustomFormat2();
        }       
        //como mostra a data assim que abre a tela
        private void DTPSaida_ValueChanged(object sender, EventArgs e)
        {

            //this.DTPSaida.Value = DateTime.Now;
            DTPSaida.Format = DateTimePickerFormat.Custom;
            DTPSaida.CustomFormat = " --/--/----";
        }

        
        //criando metodo personalizado para a data de entrada od pacote
        public void SetMyCustomFormat()
        {
            this.DTPEntrada.Value = DateTime.Now;
            // Set da data em formato customizado
            DTPEntrada.Format = DateTimePickerFormat.Custom;
            DTPEntrada.CustomFormat = " dd/MM/yyyy";
        }
        //criando metodo personalizado para a data de saida do pacote
        public void SetMyCustomFormat2()
        {
            
            DTPSaida.Format = DateTimePickerFormat.Custom;
            DTPSaida.CustomFormat = " --/--/----";
        }
    }
}



