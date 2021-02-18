namespace ProjetoTcc
{
    partial class CadastrarPacotes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarPacotes));
            this.lblCadastrarPacotes = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPeca = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxPeca = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.prodpacoteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DTPEntrada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPSaida = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodpacoteDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastrarPacotes
            // 
            this.lblCadastrarPacotes.AutoSize = true;
            this.lblCadastrarPacotes.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrarPacotes.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarPacotes.ForeColor = System.Drawing.Color.Maroon;
            this.lblCadastrarPacotes.Location = new System.Drawing.Point(460, 9);
            this.lblCadastrarPacotes.Name = "lblCadastrarPacotes";
            this.lblCadastrarPacotes.Size = new System.Drawing.Size(382, 50);
            this.lblCadastrarPacotes.TabIndex = 0;
            this.lblCadastrarPacotes.Text = "Cadastrar Pacotes";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Maroon;
            this.lblNome.Location = new System.Drawing.Point(44, 113);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(223, 31);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Pacote:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.Maroon;
            this.lblQuantidade.Location = new System.Drawing.Point(15, 220);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(278, 31);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade de peças:";
            // 
            // lblPeca
            // 
            this.lblPeca.AutoSize = true;
            this.lblPeca.BackColor = System.Drawing.Color.Transparent;
            this.lblPeca.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeca.ForeColor = System.Drawing.Color.Maroon;
            this.lblPeca.Location = new System.Drawing.Point(185, 162);
            this.lblPeca.Name = "lblPeca";
            this.lblPeca.Size = new System.Drawing.Size(82, 31);
            this.lblPeca.TabIndex = 3;
            this.lblPeca.Text = "Peça:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrada.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.ForeColor = System.Drawing.Color.Maroon;
            this.lblEntrada.Location = new System.Drawing.Point(42, 287);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(231, 31);
            this.lblEntrada.TabIndex = 5;
            this.lblEntrada.Text = "Data de Entrada:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(299, 124);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(299, 231);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(164, 20);
            this.txtQuantidade.TabIndex = 8;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(474, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(641, 266);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.Maroon;
            this.btnSalvar.Location = new System.Drawing.Point(12, 384);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 40);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Location = new System.Drawing.Point(582, 455);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 40);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Fec&har";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxPeca
            // 
            this.cbxPeca.FormattingEnabled = true;
            this.cbxPeca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxPeca.Location = new System.Drawing.Point(299, 173);
            this.cbxPeca.Name = "cbxPeca";
            this.cbxPeca.Size = new System.Drawing.Size(164, 22);
            this.cbxPeca.TabIndex = 15;
            this.cbxPeca.Text = "Selecione";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Maroon;
            this.btnLimpar.Location = new System.Drawing.Point(155, 385);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 39);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "L&impar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(503, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pacotes Cadastrados:";
            // 
            // DTPEntrada
            // 
            this.DTPEntrada.CalendarForeColor = System.Drawing.Color.Maroon;
            this.DTPEntrada.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.DTPEntrada.CalendarTitleBackColor = System.Drawing.Color.Maroon;
            this.DTPEntrada.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.DTPEntrada.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.DTPEntrada.CustomFormat = "yyyy-MM-dd";
            this.DTPEntrada.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPEntrada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTPEntrada.Location = new System.Drawing.Point(279, 287);
            this.DTPEntrada.Name = "DTPEntrada";
            this.DTPEntrada.Size = new System.Drawing.Size(164, 39);
            this.DTPEntrada.TabIndex = 23;
            this.DTPEntrada.TabStop = false;
            this.DTPEntrada.Value = new System.DateTime(2019, 5, 9, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(468, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Buscar:";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(582, 131);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(237, 20);
            this.txtBusca.TabIndex = 20;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(44, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data de Saida:";
            // 
            // DTPSaida
            // 
            this.DTPSaida.CalendarForeColor = System.Drawing.Color.Maroon;
            this.DTPSaida.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.DTPSaida.CalendarTitleBackColor = System.Drawing.Color.Maroon;
            this.DTPSaida.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.DTPSaida.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.DTPSaida.Checked = false;
            this.DTPSaida.CustomFormat = "----/--/--";
            this.DTPSaida.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPSaida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTPSaida.Location = new System.Drawing.Point(279, 332);
            this.DTPSaida.Name = "DTPSaida";
            this.DTPSaida.Size = new System.Drawing.Size(164, 39);
            this.DTPSaida.TabIndex = 23;
            this.DTPSaida.TabStop = false;
            this.DTPSaida.Value = new System.DateTime(2019, 5, 8, 0, 0, 0, 0);
            this.DTPSaida.CloseUp += new System.EventHandler(this.DTPSaida_CloseUp);
            this.DTPSaida.ValueChanged += new System.EventHandler(this.DTPSaida_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancel.Location = new System.Drawing.Point(299, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 39);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Ca&ncelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CadastrarPacotes
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 529);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.DTPSaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.DTPEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cbxPeca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblPeca);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCadastrarPacotes);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastrarPacotes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarPacotes";
            this.Load += new System.EventHandler(this.CadastrarPacotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodpacoteDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastrarPacotes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPeca;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxPeca;
        private System.Windows.Forms.Button btnLimpar;
       // private prodpacoteDataSet prodpacoteDataSet;
        private System.Windows.Forms.BindingSource prodpacoteDataSetBindingSource;
        private System.Windows.Forms.Label label1;
       // private prodpacoteDataSetTableAdapters.produtoTableAdapter produtoTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker DTPEntrada;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker DTPSaida;
    }
}