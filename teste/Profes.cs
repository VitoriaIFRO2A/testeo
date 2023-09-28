using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Profes : Form
    {
        List<Professor> pessoas2 = new List<Professor>();
        public Profes()
        {
            InitializeComponent();
        }

        private void bd_limpar_Click(object sender, EventArgs e)
        {
            tx_nome2.Text = "";
            tx_profissao2.Text = "";
            dt_nascimento2.Text = "";
            tx_materia.Text = "";
        }

        private void bd_Salvar2_Click(object sender, EventArgs e)
        {
            DateTime datanascimento2 = Convert.ToDateTime(dt_nascimento2.Text);
            Professor pesso = new Professor(tx_nome2.Text, tx_profissao2.Text, datanascimento2, tx_materia.Text);

            pessoas2.Add(pesso);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = pessoas2;

        }

        private void tb_voltar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
