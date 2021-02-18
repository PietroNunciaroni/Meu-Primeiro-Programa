namespace ProjetoTcc
{
    partial class FrmVisualizador
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pacoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodpacoteDataSet = new ProjetoTcc.prodpacoteDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.data1ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.data1ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.data2ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.data2ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.data1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.data1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.data2ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.data2ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.prodpacoteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacoteTableAdapter = new ProjetoTcc.prodpacoteDataSetTableAdapters.pacoteTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pacoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodpacoteDataSet)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodpacoteDataSetBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pacoteBindingSource
            // 
            this.pacoteBindingSource.DataMember = "pacote";
            this.pacoteBindingSource.DataSource = this.prodpacoteDataSet;
            // 
            // prodpacoteDataSet
            // 
            this.prodpacoteDataSet.DataSetName = "prodpacoteDataSet";
            this.prodpacoteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatório";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Snow;
            this.reportViewer1.BackgroundImage = global::ProjetoTcc.Properties.Resources.tcc;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource1.Name = "DtPacote";
            reportDataSource1.Value = this.pacoteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoTcc.Relatorio_Produtos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(109, 167);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(795, 356);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(375, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 36);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2019, 4, 24, 0, 0, 0, 0);
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(639, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(161, 36);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Value = new System.DateTime(2019, 4, 24, 0, 0, 0, 0);
            this.dateTimePicker2.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.data1ToolStripLabel1,
            this.data1ToolStripTextBox1,
            this.data2ToolStripLabel1,
            this.data2ToolStripTextBox1,
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(982, 25);
            this.fillBy2ToolStrip.TabIndex = 5;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Visible = false;
            // 
            // data1ToolStripLabel1
            // 
            this.data1ToolStripLabel1.Name = "data1ToolStripLabel1";
            this.data1ToolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.data1ToolStripLabel1.Text = "data1:";
            // 
            // data1ToolStripTextBox1
            // 
            this.data1ToolStripTextBox1.Name = "data1ToolStripTextBox1";
            this.data1ToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // data2ToolStripLabel1
            // 
            this.data2ToolStripLabel1.Name = "data2ToolStripLabel1";
            this.data2ToolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.data2ToolStripLabel1.Text = "data2:";
            // 
            // data2ToolStripTextBox1
            // 
            this.data2ToolStripTextBox1.Name = "data2ToolStripTextBox1";
            this.data2ToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy2ToolStripButton.Text = "FillBy2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(820, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(546, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Entre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Busca por datas de entrada:";
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.data1ToolStripLabel,
            this.data1ToolStripTextBox,
            this.data2ToolStripLabel,
            this.data2ToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(982, 25);
            this.fillByToolStrip.TabIndex = 9;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // data1ToolStripLabel
            // 
            this.data1ToolStripLabel.Name = "data1ToolStripLabel";
            this.data1ToolStripLabel.Size = new System.Drawing.Size(39, 22);
            this.data1ToolStripLabel.Text = "data1:";
            // 
            // data1ToolStripTextBox
            // 
            this.data1ToolStripTextBox.Name = "data1ToolStripTextBox";
            this.data1ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // data2ToolStripLabel
            // 
            this.data2ToolStripLabel.Name = "data2ToolStripLabel";
            this.data2ToolStripLabel.Size = new System.Drawing.Size(39, 22);
            this.data2ToolStripLabel.Text = "data2:";
            // 
            // data2ToolStripTextBox
            // 
            this.data2ToolStripTextBox.Name = "data2ToolStripTextBox";
            this.data2ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // prodpacoteDataSetBindingSource
            // 
            this.prodpacoteDataSetBindingSource.DataMember = "pacote";
            this.prodpacoteDataSetBindingSource.DataSource = this.prodpacoteDataSet;
            // 
            // pacoteTableAdapter
            // 
            this.pacoteTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(332, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpar Filtros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(982, 25);
            this.fillToolStrip.TabIndex = 11;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.Visible = false;
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Maroon;
            this.btnFechar.Location = new System.Drawing.Point(389, 534);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(175, 38);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmVisualizador
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ProjetoTcc.Properties.Resources.tcc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 584);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVisualizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVisualizador";
            this.Load += new System.EventHandler(this.FrmVisualizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodpacoteDataSet)).EndInit();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodpacoteDataSetBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        //private prodpacoteDataSet1 prodpacoteDataSet1;
       // private prodpacoteDataSet1TableAdapters.pacoteTableAdapter pacoteTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripLabel data1ToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox data1ToolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel data2ToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox data2ToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource prodpacoteDataSetBindingSource;
        private prodpacoteDataSet prodpacoteDataSet;
        private prodpacoteDataSetTableAdapters.pacoteTableAdapter pacoteTableAdapter;
        private System.Windows.Forms.BindingSource pacoteBindingSource;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel data1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox data1ToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel data2ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox data2ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.Button btnFechar;
        //private prodpacoteDataSet4 prodpacoteDataSet4;
    }
}