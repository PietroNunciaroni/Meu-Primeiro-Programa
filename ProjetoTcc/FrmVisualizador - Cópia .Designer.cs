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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prodpacoteDataSet1 = new ProjetoTcc.prodpacoteDataSet1();
            this.pacoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacoteTableAdapter = new ProjetoTcc.prodpacoteDataSet1TableAdapters.pacoteTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodpacoteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BackColor = System.Drawing.Color.Snow;
            this.reportViewer1.BackgroundImage = global::ProjetoTcc.Properties.Resources.tcc;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pacoteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoTcc.Relatorio_Produtos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(33, 103);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(683, 258);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // prodpacoteDataSet1
            // 
            this.prodpacoteDataSet1.DataSetName = "prodpacoteDataSet1";
            this.prodpacoteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacoteBindingSource
            // 
            this.pacoteBindingSource.DataMember = "pacote";
            this.pacoteBindingSource.DataSource = this.prodpacoteDataSet1;
            // 
            // pacoteTableAdapter
            // 
            this.pacoteTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(289, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatório";
            // 
            // FrmVisualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoTcc.Properties.Resources.tcc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmVisualizador";
            this.Text = "FrmVisualizador";
            this.Load += new System.EventHandler(this.FrmVisualizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodpacoteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacoteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pacoteBindingSource;
        private prodpacoteDataSet1 prodpacoteDataSet1;
        private prodpacoteDataSet1TableAdapters.pacoteTableAdapter pacoteTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}