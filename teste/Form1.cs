namespace teste
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bd_limpar_Click(object sender, EventArgs e)
        {
            tx_nome.Text = "";
            tx_profissao.Text = "";
            dt_nascimento.Text = "";
        }

        private void bd_Salvar_Click(object sender, EventArgs e)
        {
            DateTime datanascimento = Convert.ToDateTime(dt_nascimento.Text);
            Pessoa pessoa = new Pessoa(tx_nome.Text, tx_profissao.Text, datanascimento);
          
            pessoas.Add(pessoa);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = 
        }
    }
}