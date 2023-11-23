using AdestramentoMagali.App.Cadastros;
using AdestramentoMagali.App.Infra;
using AdestramentoMagali.App.Outros;
using AdestramentoMagali.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
using ReaLTaiizor.Forms;
using System.Security.Policy;

namespace AdestramentoMagali.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public static Funcionario Funcionario { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            CarregaLogin();
        }

        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblFuncionario.Text = $"Funcionário: {Funcionario.Nome}";
                }
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroFuncionario>();
        }

        private void equipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroEquipamento>();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCidade>();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCliente>();
        }

        private void cachorrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCachorro>();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}