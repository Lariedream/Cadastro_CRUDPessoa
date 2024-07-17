using Teste_desenvolvimento.Repositorios;

namespace Teste_desenvolvimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, insira um nome válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                MessageBox.Show("Por favor, insira um CPF válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefone.Text) || !int.TryParse(txtTelefone.Text, out int telefone))
            {
                MessageBox.Show("Por favor, insira um telefone válido! Utilizar somente números.");
                return;
            }
            var pessoa = new Pessoa(0, txtNome.Text, txtCpf.Text, Convert.ToInt32(txtTelefone.Text));
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Inserir(pessoa);
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }
        private void LimparCampos()
        {
            txtCpf.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtID.Text = string.Empty;
        }
        private void BuscarTodasAsPessoas(PessoaRepositorio pessoaRepositorio)
        {
            var pessoas = pessoaRepositorio.BuscarTodasPessoas();
            dgPessoa.DataSource = pessoas.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepositorio();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }

        private void dgPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            txtID.Text = dgv.CurrentRow.Cells["Id"]?.Value?.ToString();
            txtNome.Text = dgv.CurrentRow.Cells["Nome"]?.Value?.ToString();
            txtCpf.Text = dgv.CurrentRow.Cells["Cpf"]?.Value?.ToString();
            txtTelefone.Text = dgv.CurrentRow.Cells["Telefone"]?.Value?.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, insira um nome válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                MessageBox.Show("Por favor, insira um CPF válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefone.Text) || !int.TryParse(txtTelefone.Text, out int telefone))
            {
                MessageBox.Show("Por favor, insira um telefone válido! Utilizar somente números.");
                return;
            }
            var pessoa = new Pessoa(Convert.ToInt32(txtID.Text), txtNome.Text, txtCpf.Text, Convert.ToInt32(txtTelefone.Text));
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Atualizar(pessoa);
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Deletar(Convert.ToInt32(txtID.Text));
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);

        }
    }
}
