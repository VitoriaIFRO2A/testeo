namespace teste
{
    partial class Profes
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
            bd_limpar2 = new Button();
            aniversario = new Label();
            dt_nascimento2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            tx_profissao2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tx_nome2 = new TextBox();
            bd_Salvar2 = new Button();
            tx_materia = new TextBox();
            materia = new Label();
            tb_voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bd_limpar2
            // 
            bd_limpar2.Location = new Point(399, 183);
            bd_limpar2.Name = "bd_limpar2";
            bd_limpar2.Size = new Size(75, 23);
            bd_limpar2.TabIndex = 18;
            bd_limpar2.Text = "limpar";
            bd_limpar2.UseVisualStyleBackColor = true;
            bd_limpar2.Click += bd_limpar_Click;
            // 
            // aniversario
            // 
            aniversario.AutoSize = true;
            aniversario.Location = new Point(25, 210);
            aniversario.Name = "aniversario";
            aniversario.Size = new Size(64, 15);
            aniversario.TabIndex = 17;
            aniversario.Text = "aniversario";
            // 
            // dt_nascimento2
            // 
            dt_nascimento2.Location = new Point(95, 204);
            dt_nascimento2.Name = "dt_nascimento2";
            dt_nascimento2.Size = new Size(231, 23);
            dt_nascimento2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(362, 150);
            dataGridView1.TabIndex = 15;
            // 
            // tx_profissao2
            // 
            tx_profissao2.Location = new Point(86, 104);
            tx_profissao2.Name = "tx_profissao2";
            tx_profissao2.Size = new Size(146, 23);
            tx_profissao2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 107);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 13;
            label2.Text = "profissao";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 60);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "nome";
            // 
            // tx_nome2
            // 
            tx_nome2.Location = new Point(69, 57);
            tx_nome2.Name = "tx_nome2";
            tx_nome2.Size = new Size(146, 23);
            tx_nome2.TabIndex = 11;
            // 
            // bd_Salvar2
            // 
            bd_Salvar2.Location = new Point(399, 292);
            bd_Salvar2.Name = "bd_Salvar2";
            bd_Salvar2.Size = new Size(75, 23);
            bd_Salvar2.TabIndex = 10;
            bd_Salvar2.Text = "salvar";
            bd_Salvar2.UseVisualStyleBackColor = true;
            bd_Salvar2.Click += bd_Salvar2_Click;
            // 
            // tx_materia
            // 
            tx_materia.Location = new Point(86, 157);
            tx_materia.Name = "tx_materia";
            tx_materia.Size = new Size(146, 23);
            tx_materia.TabIndex = 19;
            // 
            // materia
            // 
            materia.AutoSize = true;
            materia.Location = new Point(25, 160);
            materia.Name = "materia";
            materia.Size = new Size(47, 15);
            materia.TabIndex = 20;
            materia.Text = "materia";
            // 
            // tb_voltar
            // 
            tb_voltar.Location = new Point(399, 232);
            tb_voltar.Name = "tb_voltar";
            tb_voltar.Size = new Size(75, 23);
            tb_voltar.TabIndex = 21;
            tb_voltar.Text = "voltar";
            tb_voltar.UseVisualStyleBackColor = true;
            tb_voltar.Click += tb_voltar_Click;
            // 
            // Profes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 424);
            Controls.Add(tb_voltar);
            Controls.Add(materia);
            Controls.Add(tx_materia);
            Controls.Add(bd_limpar2);
            Controls.Add(aniversario);
            Controls.Add(dt_nascimento2);
            Controls.Add(dataGridView1);
            Controls.Add(tx_profissao2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tx_nome2);
            Controls.Add(bd_Salvar2);
            Name = "Profes";
            Text = "Profes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bd_limpar2;
        private Label aniversario;
        private DateTimePicker dt_nascimento2;
        private DataGridView dataGridView1;
        private TextBox tx_profissao2;
        private Label label2;
        private Label label1;
        private TextBox tx_nome2;
        private Button bd_Salvar2;
        private TextBox tx_materia;
        private Label materia;
        private Button tb_voltar;
    }
}