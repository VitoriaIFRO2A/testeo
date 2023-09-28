namespace teste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bd_Salvar = new Button();
            tx_nome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tx_profissao = new TextBox();
            dataGridView1 = new DataGridView();
            dt_nascimento = new DateTimePicker();
            aniversario = new Label();
            bd_limpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bd_Salvar
            // 
            bd_Salvar.Location = new Point(679, 332);
            bd_Salvar.Name = "bd_Salvar";
            bd_Salvar.Size = new Size(75, 23);
            bd_Salvar.TabIndex = 0;
            bd_Salvar.Text = "salvar";
            bd_Salvar.UseVisualStyleBackColor = true;
            bd_Salvar.Click += bd_Salvar_Click;
            // 
            // tx_nome
            // 
            tx_nome.Location = new Point(105, 61);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(146, 23);
            tx_nome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 64);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 129);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "profissao";
            // 
            // tx_profissao
            // 
            tx_profissao.Location = new Point(113, 126);
            tx_profissao.Name = "tx_profissao";
            tx_profissao.Size = new Size(146, 23);
            tx_profissao.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(392, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(362, 150);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dt_nascimento
            // 
            dt_nascimento.Location = new Point(113, 212);
            dt_nascimento.Name = "dt_nascimento";
            dt_nascimento.Size = new Size(231, 23);
            dt_nascimento.TabIndex = 6;
            // 
            // aniversario
            // 
            aniversario.AutoSize = true;
            aniversario.Location = new Point(43, 218);
            aniversario.Name = "aniversario";
            aniversario.Size = new Size(64, 15);
            aniversario.TabIndex = 7;
            aniversario.Text = "aniversario";
            // 
            // bd_limpar
            // 
            bd_limpar.Location = new Point(392, 332);
            bd_limpar.Name = "bd_limpar";
            bd_limpar.Size = new Size(75, 23);
            bd_limpar.TabIndex = 8;
            bd_limpar.Text = "limpar";
            bd_limpar.UseVisualStyleBackColor = true;
            bd_limpar.Click += bd_limpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bd_limpar);
            Controls.Add(aniversario);
            Controls.Add(dt_nascimento);
            Controls.Add(dataGridView1);
            Controls.Add(tx_profissao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tx_nome);
            Controls.Add(bd_Salvar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bd_Salvar;
        private TextBox tx_nome;
        private Label label1;
        private Label label2;
        private TextBox tx_profissao;
        private DataGridView dataGridView1;
        private DateTimePicker dt_nascimento;
        private Label aniversario;
        private Button bd_limpar;
    }
}