using AdestramentoMagali.App.Models;
using AdestramentoMagali.Domain.Base;
using AdestramentoMagali.Domain.Entities;
using AdestramentoMagali.Service.Validators;
using ReaLTaiizor.Forms;

namespace AdestramentoMagali.App.Outros
{
    public partial class Login : MaterialForm
    {
        private readonly IBaseService<Funcionario> _funcionarioService;

        public Login(IBaseService<Funcionario> funcionarioService)
        {
            _funcionarioService = funcionarioService;
            InitializeComponent();
#if DEBUG
            txtEmail.Text = @"admin@mail.com";
            txtSenha.Text = @"admin";
#endif
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var funcionario = ObterFuncionario(txtEmail.Text, txtSenha.Text);

            if (funcionario == null)
            {
                MessageBox.Show("E-mail e/ou senha inválido(s)!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
            else if (!funcionario.Ativo)
            {
                MessageBox.Show("Usuário inativo!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
            else
            {
                funcionario = _funcionarioService.Update<Funcionario, Funcionario, FuncionarioValidator>(funcionario);
                FormPrincipal.Funcionario = funcionario;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private Funcionario? ObterFuncionario(string email, string senha)
        {
            ChecaExistenciaDeFuncionariosCadastrados();

            var funcionario = _funcionarioService.Get<Funcionario>().Where(x => x.Email == email).FirstOrDefault();
            if (funcionario == null)
            {
                return null;
            }
            return funcionario.Senha != senha ? null : funcionario;
        }

        private void ChecaExistenciaDeFuncionariosCadastrados()
        {
            var funcionarios = _funcionarioService.Get<FuncionarioModel>().ToList();
            if (!funcionarios.Any())
            {
                var funcionario = new Funcionario
                {
                    DataCadastro = DateTime.Now,
                    Ativo = true,
                    Nome = "Administrador",
                    Email = "admin@mail.com",
                    Senha = "admin",
                    Especialidade = "",
                    Telefone = 0
                };
                _funcionarioService.Add<Funcionario, Funcionario, FuncionarioValidator>(funcionario);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
