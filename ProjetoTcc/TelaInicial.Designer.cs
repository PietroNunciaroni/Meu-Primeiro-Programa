namespace ProjetoTcc
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.btnCadastrarProdutos = new System.Windows.Forms.Button();
            this.btnCadastrarPacotes = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarProdutos
            // 
            this.btnCadastrarProdutos.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCadastrarProdutos, "btnCadastrarProdutos");
            this.btnCadastrarProdutos.ForeColor = System.Drawing.Color.Maroon;
            this.btnCadastrarProdutos.Name = "btnCadastrarProdutos";
            this.btnCadastrarProdutos.UseVisualStyleBackColor = false;
            this.btnCadastrarProdutos.Click += new System.EventHandler(this.btnCadastrarProdutos_Click);
            // 
            // btnCadastrarPacotes
            // 
            this.btnCadastrarPacotes.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCadastrarPacotes, "btnCadastrarPacotes");
            this.btnCadastrarPacotes.ForeColor = System.Drawing.Color.Maroon;
            this.btnCadastrarPacotes.Name = "btnCadastrarPacotes";
            this.btnCadastrarPacotes.UseVisualStyleBackColor = false;
            this.btnCadastrarPacotes.Click += new System.EventHandler(this.btnCadastrarPacotes_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnRelatorios, "btnRelatorios");
            this.btnRelatorios.ForeColor = System.Drawing.Color.Maroon;
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // lbl1
            // 
            resources.ApplyResources(this.lbl1, "lbl1");
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.ForeColor = System.Drawing.Color.Maroon;
            this.lbl1.Name = "lbl1";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseCompatibleTextRendering = true;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TelaInicial
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ProjetoTcc.Properties.Resources.tcc;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnCadastrarPacotes);
            this.Controls.Add(this.btnCadastrarProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaInicial_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarProdutos;
        private System.Windows.Forms.Button btnCadastrarPacotes;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClose;
    }
}

