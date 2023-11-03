using AdestramentoMagali.App.Cadastros;
using AdestramentoMagali.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace AdestramentoMagali.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroAdestrador>();
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