
namespace ControleKitSala
{
    partial class TelaFuncionarioPesquisaCodigo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigoFun = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tbChapaFun = new System.Windows.Forms.TextBox();
            this.tbEmailFun = new System.Windows.Forms.TextBox();
            this.tbNomeFun = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Código do Funcionário";
            // 
            // tbCodigoFun
            // 
            this.tbCodigoFun.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbCodigoFun.Location = new System.Drawing.Point(115, 68);
            this.tbCodigoFun.Name = "tbCodigoFun";
            this.tbCodigoFun.Size = new System.Drawing.Size(119, 31);
            this.tbCodigoFun.TabIndex = 1;
            this.tbCodigoFun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(254, 68);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(94, 29);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "Pesquisar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // tbChapaFun
            // 
            this.tbChapaFun.Location = new System.Drawing.Point(61, 309);
            this.tbChapaFun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbChapaFun.Name = "tbChapaFun";
            this.tbChapaFun.Size = new System.Drawing.Size(110, 27);
            this.tbChapaFun.TabIndex = 12;
            // 
            // tbEmailFun
            // 
            this.tbEmailFun.Location = new System.Drawing.Point(61, 229);
            this.tbEmailFun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmailFun.Name = "tbEmailFun";
            this.tbEmailFun.Size = new System.Drawing.Size(353, 27);
            this.tbEmailFun.TabIndex = 11;
            // 
            // tbNomeFun
            // 
            this.tbNomeFun.Location = new System.Drawing.Point(61, 150);
            this.tbNomeFun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNomeFun.Name = "tbNomeFun";
            this.tbNomeFun.Size = new System.Drawing.Size(353, 27);
            this.tbNomeFun.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chapa: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(65, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(51, 111);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 402);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(465, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisa Tudo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbChapaFun);
            this.tabPage2.Controls.Add(this.tbCodigoFun);
            this.tabPage2.Controls.Add(this.tbEmailFun);
            this.tabPage2.Controls.Add(this.btnBusca);
            this.tabPage2.Controls.Add(this.tbNomeFun);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(465, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa Código";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(339, 308);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 29);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(216, 309);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 29);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Soybeanut Free", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(177, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pesquisa Funcionário";
            // 
            // TelaFuncionarioPesquisaCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 557);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaFuncionarioPesquisaCodigo";
            this.Text = "Pesquisa por Código";
            this.Load += new System.EventHandler(this.TelaFuncionarioPesquisaCodigo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigoFun;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox tbChapaFun;
        private System.Windows.Forms.TextBox tbEmailFun;
        private System.Windows.Forms.TextBox tbNomeFun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
    }
}