namespace ProjetoTcc
{
    partial class Relatorio
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
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblData1 = new System.Windows.Forms.Label();
            this.lblData2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnChamarRelat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblRelatorio.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorio.ForeColor = System.Drawing.Color.Maroon;
            this.lblRelatorio.Location = new System.Drawing.Point(144, 0);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(213, 50);
            this.lblRelatorio.TabIndex = 0;
            this.lblRelatorio.Text = "Relatório";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodo.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.Maroon;
            this.lblPeriodo.Location = new System.Drawing.Point(38, 68);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(120, 31);
            this.lblPeriodo.TabIndex = 1;
            this.lblPeriodo.Text = "Periodo:";
            this.lblPeriodo.Click += new System.EventHandler(this.lblPeriodo_Click);
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.BackColor = System.Drawing.Color.Transparent;
            this.lblData1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData1.ForeColor = System.Drawing.Color.Maroon;
            this.lblData1.Location = new System.Drawing.Point(38, 108);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(57, 31);
            this.lblData1.TabIndex = 2;
            this.lblData1.Text = "De:";
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.BackColor = System.Drawing.Color.Transparent;
            this.lblData2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData2.ForeColor = System.Drawing.Color.Maroon;
            this.lblData2.Location = new System.Drawing.Point(281, 108);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(66, 31);
            this.lblData2.TabIndex = 3;
            this.lblData2.Text = "Até:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(353, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Maroon;
            this.btnSair.Location = new System.Drawing.Point(115, 353);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(256, 39);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair do Relatorio";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnChamarRelat
            // 
            this.btnChamarRelat.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnChamarRelat.ForeColor = System.Drawing.Color.Maroon;
            this.btnChamarRelat.Location = new System.Drawing.Point(179, 232);
            this.btnChamarRelat.Name = "btnChamarRelat";
            this.btnChamarRelat.Size = new System.Drawing.Size(153, 39);
            this.btnChamarRelat.TabIndex = 8;
            this.btnChamarRelat.Text = "Relatório";
            this.btnChamarRelat.UseVisualStyleBackColor = true;
            this.btnChamarRelat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoTcc.Properties.Resources.tcc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(497, 404);
            this.Controls.Add(this.btnChamarRelat);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblData2);
            this.Controls.Add(this.lblData1);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblRelatorio);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnChamarRelat;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}