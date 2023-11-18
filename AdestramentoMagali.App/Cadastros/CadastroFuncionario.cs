using AdestramentoMagali.App.Base;
using AdestramentoMagali.App.Models;
using AdestramentoMagali.Domain.Base;
using AdestramentoMagali.Domain.Entities;
using AdestramentoMagali.Service.Validators;

namespace AdestramentoMagali.App.Cadastros
{
    public partial class CadastroFuncionario : CadastroBase
    {
        private readonly IBaseService<Funcionario> _funcionarioService;

        private List<FuncionarioModel>? funcionarios;

        public CadastroFuncionario(IBaseService<Funcionario> funcionarioService)
        {
            _funcionarioService = funcionarioService;
            InitializeComponent();
        }

        private void PreencheObjeto(Funcionario funcionario)
        {
            funcionario.Nome = txtNome.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            if (long.TryParse(txtTelefone.Text, out var telefone))
            {
                funcionario.Telefone = telefone;
            }
            funcionario.Especialidade = txtEspecialidade.Text;
            funcionario.Ativo = chkAtivo.Checked;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var funcionario = _funcionarioService.GetById<Funcionario>(id);
                        PreencheObjeto(funcionario);
                        funcionario = _funcionarioService.Update<Funcionario, Funcionario, FuncionarioValidator>(funcionario);
                    }
                }
                else
                {
                    var funcionario = new Funcionario();
                    PreencheObjeto(funcionario);
                    _funcionarioService.Add<Funcionario, Funcionario, FuncionarioValidator>(funcionario);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Adestramento Magali", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _funcionarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Adestramento Magali", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            funcionarios = _funcionarioService.Get<FuncionarioModel>().ToList();
            dataGridViewConsulta.DataSource = funcionarios;
            dataGridViewConsulta.Columns["Senha"]!.Visible = false;
            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtEspecialidade.Text = linha?.Cells["Especialidade"].Value.ToString();
            txtSenha.Text = linha?.Cells["Senha"].Value.ToString();
            chkAtivo.Checked = (bool)(linha?.Cells["Ativo"].Value ?? false);

            txtDataCadastro.Text = DateTime.TryParse(linha?.Cells["DataCadastro"].Value.ToString(), out var dataC)
                ? dataC.ToString("g")
                : "";
        }

    }
}
