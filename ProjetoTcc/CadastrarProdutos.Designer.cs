namespace ProjetoTcc
{
    partial class CadastrarProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNonePeca = new System.Windows.Forms.Label();
            this.lblDrescricao = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCadastrarProdutos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ckbAtiv = new System.Windows.Forms.CheckBox();
            this.btnSalvar2 = new System.Windows.Forms.Button();
            this.txtFechar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNonePeca
            // 
            this.lblNonePeca.AutoSize = true;
            this.lblNonePeca.BackColor = System.Drawing.Color.Transparent;
            this.lblNonePeca.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonePeca.ForeColor = System.Drawing.Color.Maroon;
            this.lblNonePeca.Location = new System.Drawing.Point(42, 86);
            this.lblNonePeca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNonePeca.Name = "lblNonePeca";
            this.lblNonePeca.Size = new System.Drawing.Size(195, 31);
            this.lblNonePeca.TabIndex = 1;
            this.lblNonePeca.Text = "Nome da peça:";
            // 
            // lblDrescricao
            // 
            this.lblDrescricao.AutoSize = true;
            this.lblDrescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDrescricao.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrescricao.ForeColor = System.Drawing.Color.Maroon;
            this.lblDrescricao.Location = new System.Drawing.Point(42, 163);
            this.lblDrescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDrescricao.Name = "lblDrescricao";
            this.lblDrescricao.Size = new System.Drawing.Size(245, 31);
            this.lblDrescricao.TabIndex = 2;
            this.lblDrescricao.Text = "Descrição da peça:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.Maroon;
            this.lblPreco.Location = new System.Drawing.Point(42, 291);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(94, 31);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "Preço:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(48, 131);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(48, 202);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(226, 70);
            this.txtDescricao.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(48, 337);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(226, 20);
            this.txtPreco.TabIndex = 6;
            //this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged_1);
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Location = new System.Drawing.Point(507, 403);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 44);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Li&mpar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCadastrarProdutos
            // 
            this.lblCadastrarProdutos.AutoSize = true;
            this.lblCadastrarProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrarProdutos.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarProdutos.ForeColor = System.Drawing.Color.Maroon;
            this.lblCadastrarProdutos.Location = new System.Drawing.Point(204, 9);
            this.lblCadastrarProdutos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCadastrarProdutos.Name = "lblCadastrarProdutos";
            this.lblCadastrarProdutos.Size = new System.Drawing.Size(413, 50);
            this.lblCadastrarProdutos.TabIndex = 9;
            this.lblCadastrarProdutos.Text = "Cadastrar Produtos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(336, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 292);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
           // this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            //this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // ckbAtiv
            // 
            this.ckbAtiv.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbAtiv.AutoSize = true;
            this.ckbAtiv.BackColor = System.Drawing.Color.Transparent;
            this.ckbAtiv.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold);
            this.ckbAtiv.ForeColor = System.Drawing.Color.Green;
            this.ckbAtiv.Location = new System.Drawing.Point(44, 403);
            this.ckbAtiv.Name = "ckbAtiv";
            this.ckbAtiv.Size = new System.Drawing.Size(92, 41);
            this.ckbAtiv.TabIndex = 12;
            this.ckbAtiv.Text = "Ativo";
            this.ckbAtiv.UseVisualStyleBackColor = false;
            this.ckbAtiv.CheckedChanged += new System.EventHandler(this.ckbAtiv_CheckedChanged);
            // 
            // btnSalvar2
            // 
            this.btnSalvar2.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnSalvar2.ForeColor = System.Drawing.Color.Maroon;
            this.btnSalvar2.Location = new System.Drawing.Point(333, 403);
            this.btnSalvar2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalvar2.Name = "btnSalvar2";
            this.btnSalvar2.Size = new System.Drawing.Size(106, 44);
            this.btnSalvar2.TabIndex = 13;
            this.btnSalvar2.Text = "&Salvar";
            this.btnSalvar2.UseVisualStyleBackColor = false;
            this.btnSalvar2.Click += new System.EventHandler(this.btnSalvar2_Click);
            // 
            // txtFechar
            // 
            this.txtFechar.BackColor = System.Drawing.Color.Transparent;
            this.txtFechar.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtFechar.ForeColor = System.Drawing.Color.Maroon;
            this.txtFechar.ImageKey = "(none)";
            this.txtFechar.Location = new System.Drawing.Point(765, 403);
            this.txtFechar.Name = "txtFechar";
            this.txtFechar.Size = new System.Drawing.Size(116, 44);
            this.txtFechar.TabIndex = 11;
            this.txtFechar.Text = "F&echar";
            this.txtFechar.UseVisualStyleBackColor = false;
            this.txtFechar.Click += new System.EventHandler(this.txtFechar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(444, 60);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(251, 20);
            this.txtBusca.TabIndex = 14;
            //this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            this.txtBusca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(330, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar:";
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(700, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Status:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "todos",
            "Ativo",
            "Inativo"});
            this.comboBox1.Location = new System.Drawing.Point(794, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 22);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // CadastrarProdutos
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ProjetoTcc.Properties.Resources.tcc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 485);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnSalvar2);
            this.Controls.Add(this.ckbAtiv);
            this.Controls.Add(this.txtFechar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCadastrarProdutos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblDrescricao);
            this.Controls.Add(this.lblNonePeca);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastrarProdutos";
            this.Text = ".:Cadastrar Produtos:.";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.CadastrarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNonePeca;
        private System.Windows.Forms.Label lblDrescricao;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCadastrarProdutos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtFechar;
        private System.Windows.Forms.CheckBox ckbAtiv;
        private System.Windows.Forms.Button btnSalvar2;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}