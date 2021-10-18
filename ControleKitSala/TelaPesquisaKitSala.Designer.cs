
namespace ControleKitSala
{
    partial class TelaPesquisaKitSala
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxPreto = new System.Windows.Forms.CheckBox();
            this.checkBoxAzul = new System.Windows.Forms.CheckBox();
            this.checkBoxChave = new System.Windows.Forms.CheckBox();
            this.checkBoxApagador = new System.Windows.Forms.CheckBox();
            this.checkBoxConData = new System.Windows.Forms.CheckBox();
            this.checkBoxConAr = new System.Windows.Forms.CheckBox();
            this.tbkitSala = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodigoKitSala = new System.Windows.Forms.TextBox();
            this.btnBuscaKitSala = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(36, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisa Tudo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbCodigoKitSala);
            this.tabPage2.Controls.Add(this.btnBuscaKitSala);
            this.tabPage2.Controls.Add(this.checkBoxPreto);
            this.tabPage2.Controls.Add(this.checkBoxAzul);
            this.tabPage2.Controls.Add(this.checkBoxChave);
            this.tabPage2.Controls.Add(this.checkBoxApagador);
            this.tabPage2.Controls.Add(this.checkBoxConData);
            this.tabPage2.Controls.Add(this.checkBoxConAr);
            this.tabPage2.Controls.Add(this.tbkitSala);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa por Código";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxPreto
            // 
            this.checkBoxPreto.AutoSize = true;
            this.checkBoxPreto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPreto.Location = new System.Drawing.Point(451, 366);
            this.checkBoxPreto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPreto.Name = "checkBoxPreto";
            this.checkBoxPreto.Size = new System.Drawing.Size(316, 44);
            this.checkBoxPreto.TabIndex = 18;
            this.checkBoxPreto.Text = "Canetão Digital Preto";
            this.checkBoxPreto.UseVisualStyleBackColor = true;
            // 
            // checkBoxAzul
            // 
            this.checkBoxAzul.AutoSize = true;
            this.checkBoxAzul.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAzul.Location = new System.Drawing.Point(451, 302);
            this.checkBoxAzul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxAzul.Name = "checkBoxAzul";
            this.checkBoxAzul.Size = new System.Drawing.Size(303, 44);
            this.checkBoxAzul.TabIndex = 17;
            this.checkBoxAzul.Text = "Canetão Digital Azul";
            this.checkBoxAzul.UseVisualStyleBackColor = true;
            // 
            // checkBoxChave
            // 
            this.checkBoxChave.AutoSize = true;
            this.checkBoxChave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxChave.Location = new System.Drawing.Point(451, 244);
            this.checkBoxChave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxChave.Name = "checkBoxChave";
            this.checkBoxChave.Size = new System.Drawing.Size(221, 44);
            this.checkBoxChave.TabIndex = 16;
            this.checkBoxChave.Text = "Chave da Sala";
            this.checkBoxChave.UseVisualStyleBackColor = true;
            // 
            // checkBoxApagador
            // 
            this.checkBoxApagador.AutoSize = true;
            this.checkBoxApagador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxApagador.Location = new System.Drawing.Point(21, 366);
            this.checkBoxApagador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxApagador.Name = "checkBoxApagador";
            this.checkBoxApagador.Size = new System.Drawing.Size(373, 44);
            this.checkBoxApagador.TabIndex = 15;
            this.checkBoxApagador.Text = "Apagador da lousa digital";
            this.checkBoxApagador.UseVisualStyleBackColor = true;
            // 
            // checkBoxConData
            // 
            this.checkBoxConData.AutoSize = true;
            this.checkBoxConData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxConData.Location = new System.Drawing.Point(21, 302);
            this.checkBoxConData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxConData.Name = "checkBoxConData";
            this.checkBoxConData.Size = new System.Drawing.Size(332, 44);
            this.checkBoxConData.TabIndex = 14;
            this.checkBoxConData.Text = "Controle do DataShow";
            this.checkBoxConData.UseVisualStyleBackColor = true;
            // 
            // checkBoxConAr
            // 
            this.checkBoxConAr.AutoSize = true;
            this.checkBoxConAr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxConAr.Location = new System.Drawing.Point(21, 244);
            this.checkBoxConAr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxConAr.Name = "checkBoxConAr";
            this.checkBoxConAr.Size = new System.Drawing.Size(417, 44);
            this.checkBoxConAr.TabIndex = 13;
            this.checkBoxConAr.Text = "Controle do Ar Condicionado";
            this.checkBoxConAr.UseVisualStyleBackColor = true;
            // 
            // tbkitSala
            // 
            this.tbkitSala.Location = new System.Drawing.Point(273, 154);
            this.tbkitSala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbkitSala.Name = "tbkitSala";
            this.tbkitSala.Size = new System.Drawing.Size(141, 31);
            this.tbkitSala.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Itens:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(163, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kit Sala:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(48, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Digite o Kit Sala";
            // 
            // tbCodigoKitSala
            // 
            this.tbCodigoKitSala.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbCodigoKitSala.Location = new System.Drawing.Point(271, 78);
            this.tbCodigoKitSala.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodigoKitSala.Name = "tbCodigoKitSala";
            this.tbCodigoKitSala.Size = new System.Drawing.Size(148, 36);
            this.tbCodigoKitSala.TabIndex = 20;
            this.tbCodigoKitSala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscaKitSala
            // 
            this.btnBuscaKitSala.Location = new System.Drawing.Point(445, 78);
            this.btnBuscaKitSala.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaKitSala.Name = "btnBuscaKitSala";
            this.btnBuscaKitSala.Size = new System.Drawing.Size(118, 36);
            this.btnBuscaKitSala.TabIndex = 21;
            this.btnBuscaKitSala.Text = "Pesquisar";
            this.btnBuscaKitSala.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(718, 225);
            this.dataGridView1.TabIndex = 1;
            // 
            // TelaPesquisaKitSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 619);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaPesquisaKitSala";
            this.Text = "TelaPesquisaKitSala";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxPreto;
        private System.Windows.Forms.CheckBox checkBoxAzul;
        private System.Windows.Forms.CheckBox checkBoxChave;
        private System.Windows.Forms.CheckBox checkBoxApagador;
        private System.Windows.Forms.CheckBox checkBoxConData;
        private System.Windows.Forms.CheckBox checkBoxConAr;
        private System.Windows.Forms.TextBox tbkitSala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodigoKitSala;
        private System.Windows.Forms.Button btnBuscaKitSala;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}