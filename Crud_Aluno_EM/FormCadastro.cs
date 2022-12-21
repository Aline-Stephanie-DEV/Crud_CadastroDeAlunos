using System.ComponentModel;
using EM.Domain;
using EM.Repository;

namespace Crud_Aluno_EM
{
    public partial class FormCadastro : Form
    {
        private readonly RepositorioAluno repositorioAluno = new();
        private readonly IList<Aluno> alunos = new BindingList<Aluno>();
        private readonly BindingSource alunosSource = new();
        public FormCadastro()
        {
            InitializeComponent();
            AtualizaDgv();
            alunosSource.DataSource = alunos;
            dgvDadosAlunos.DataSource = alunosSource;
            cbxSexo.DataSource = Enum.GetValues(typeof(EnumeradorSexo));
        }
      
        private void AtualizaDgv()
        {
            alunos.Clear();
            IEnumerable<Aluno> alunosNoRepositorio = repositorioAluno.GetAll();
            dgvDadosAlunos.DataSource = alunos;
            foreach (Aluno aluno in alunosNoRepositorio)
            {
                alunos.Add(aluno);
            }
        }        
        private void AdicioneAlunos()
        {
            string matriculaRecebida = txtMatricula.Text;
            if (matriculaRecebida.Length == 0)
            {
                MessageBox.Show("Campo precisa ser preenchido! \n" + "A matricula deve ser infomada.", "Campo obrigatório"); return;
            }
            int matricula = Convert.ToInt32(matriculaRecebida);
            foreach (Aluno aluno in alunos)
            {
                if (matricula == aluno.Matricula)
                {
                    MessageBox.Show("Matricula já existente! \n", "Campo obrigatório"); return;
                }
            }

            string nomeRecebido = txtNome.Text;
            if (nomeRecebido.Length <= 0)
            {
                MessageBox.Show("Nome não informado! \n", "Campo obrigatório"); return;
            }

            DateTime nascimento;
            try { nascimento = Convert.ToDateTime(mtbNascimento.Text); }
            catch (FormatException) { MessageBox.Show("Data inválida!\n" + "Formato válido: dd/mm/aaaa", "Campo obrigatório"); return; }
            if (nascimento > DateTime.Today) { MessageBox.Show("Data inválida!\n" + "Formato válido: dd/mm/aaaa", "Campo obrigatório"); return; }

            EnumeradorSexo sexo = (EnumeradorSexo)cbxSexo.SelectedItem;

            string valorCpf = txtCPF.Text ?? string.Empty;
            Cpf cpf = (Cpf)valorCpf;
            

            Aluno aluno1 = new(matricula, nomeRecebido, sexo, nascimento, cpf);

            repositorioAluno.Add(aluno1);
            AtualizaDgv();

            if (cpf.Valor == string.Empty)
            {
                MessageBox.Show("Cadastro realizado sem o uso do CPF!\n Pois não foi informado um cpf válido.");
            }
            else { MessageBox.Show("Cadastro realizado com Sucesso!"); }
        }
        private void ModifiqueAluno()
        {
            string nomeRecebido = txtNome.Text ?? string.Empty;
            if (nomeRecebido.Length == 0)
            {
                MessageBox.Show("Nome não informado! \n", "Campo obrigatório"); return;
            }

            DateTime nascimento;
            try
            {
                nascimento = Convert.ToDateTime(mtbNascimento.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Data inválida!\n" + "Formato válido: dd/mm/aaaa", "Campo obrigatório"); return;
            }
            if (nascimento > DateTime.Today) { MessageBox.Show("Data inválida!\n" + "Formato válido: dd/mm/aaaa", "Campo obrigatório"); return; }

            EnumeradorSexo sexo = (EnumeradorSexo)cbxSexo.SelectedItem;

            string valorCpf = txtCPF.Text ?? string.Empty;
            Cpf cpf = (Cpf)valorCpf;

            int matricula = Convert.ToInt32(txtMatricula.Text);

            Aluno aluno1 = new(matricula, nomeRecebido, sexo, nascimento, cpf);

            repositorioAluno.Update(aluno1);
            AtualizaDgv();

            if (cpf.Valor == string.Empty)
            {
                MessageBox.Show("Alteração realizada sem o uso do CPF!\n Pois não foi informado um cpf válido.");
            }
            else { MessageBox.Show("Alteração realizada com Sucesso!"); }

            btnAdicionar.Text = "Adicionar";
            btnLimpar.Text = "Limpar";
            LimpeCampos();
        }
        private void LimpeCampos()
        {
            txtMatricula.Enabled = true;
            txtMatricula.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtNome.Text = string.Empty;
            mtbNascimento.Text = string.Empty;
            txtPesquisa.Text = string.Empty;
        }
        private void CanceleEdicao()
        {
            btnAdicionar.Text = "Adicionar";
            btnLimpar.Text = "Limpar";
            LimpeCampos();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            switch (btnAdicionar.Text) { case "Modificar": ModifiqueAluno(); break; case "Adicionar": AdicioneAlunos(); break; default: return; }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            switch (btnLimpar.Text) { case "Cancelar": CanceleEdicao(); break; case "Limpar": LimpeCampos(); break; default: return; }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Text = "Modificar";
            gbxNovoAluno.Text = "Editando aluno";
            btnLimpar.Text = "Cancelar";
            txtMatricula.Enabled = false;

            txtMatricula.Text = dgvDadosAlunos.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvDadosAlunos.CurrentRow.Cells[1].Value.ToString();
            cbxSexo.Text = dgvDadosAlunos.CurrentRow.Cells[2].Value.ToString();
            mtbNascimento.Text = dgvDadosAlunos.CurrentRow.Cells[3].Value.ToString();
            txtCPF.Text = dgvDadosAlunos.CurrentRow.Cells[4].Value.ToString()?.Replace(".","").Replace("-","");
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            bool ehValorNumerico = int.TryParse(pesquisa, out _);
            if (ehValorNumerico == false)
            {
                var alunosEncontrados = repositorioAluno.GetByContendoNoNome(pesquisa);
                alunos.Clear();
                dgvDadosAlunos.DataSource = alunos;
                foreach (Aluno aluno in alunosEncontrados)
                {
                    alunos.Add(aluno);
                }
            }
            else
            {
                int pesquisanumero = Convert.ToInt32(pesquisa);
                try
                {
                    Aluno alunoSelecionado = repositorioAluno.GetByMatricula(pesquisanumero);
                    alunos.Clear();
                    dgvDadosAlunos.DataSource = alunos;
                    alunos.Add(alunoSelecionado);
                }
                catch (InvalidOperationException) { alunos.Clear(); }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            txtMatricula.Enabled = false;
            txtMatricula.Text = dgvDadosAlunos.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvDadosAlunos.CurrentRow.Cells[1].Value.ToString();
            cbxSexo.Text = dgvDadosAlunos.CurrentRow.Cells[2].Value.ToString();
            mtbNascimento.Text = dgvDadosAlunos.CurrentRow.Cells[3].Value.ToString();
            txtCPF.Text = dgvDadosAlunos.CurrentRow.Cells[4].Value.ToString();

            int matricula = Convert.ToInt32(txtMatricula.Text);
            foreach (Aluno aluno in alunos)
            {
                if (matricula == aluno.Matricula)
                {
                    string confirmar = "Deseja confirmar a exclusão do aluno " + aluno.Nome.ToString() + " ?";
                    string alerta = "Exclusão de aluno";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(confirmar, alerta, buttons);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("O Aluno " + aluno.Nome.ToString() + " foi excluído com sucesso!");
                        repositorioAluno.Remove(aluno);
                        AtualizaDgv();
                        return;
                    }
                }
            }
        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            };
        }
        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}