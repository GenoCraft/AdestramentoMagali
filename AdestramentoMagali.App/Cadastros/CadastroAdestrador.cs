using AdestramentoMagali.App.Base;
using AdestramentoMagali.App.Models;
using AdestramentoMagali.Domain.Base;
using AdestramentoMagali.Domain.Entities;
using AdestramentoMagali.Service.Validators;

namespace AdestramentoMagali.App.Cadastros
{
    public partial class CadastroAdestrador : CadastroBase
    {
        private readonly IBaseService<Adestrador> _adestradorService;

        private List<AdestradorModel>? adestradores;

        public CadastroAdestrador(IBaseService<Adestrador> adestradorService)
        {
            _adestradorService = adestradorService;
            InitializeComponent();
        }

        private void PreencheObjeto(Adestrador adestrador)
        {
            adestrador.Nome = txtNome.Text;
            adestrador.Email = txtEmail.Text;
            adestrador.Senha = txtSenha.Text;
            if (long.TryParse(txtTelefone.Text, out var telefone))
            {
                adestrador.Telefone = telefone;
            }
            adestrador.Especialidade = txtEspecialidade.Text;
            adestrador.Ativo = chkAtivo.Checked;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var adestrador = _adestradorService.GetById<Adestrador>(id);
                        PreencheObjeto(adestrador);
                        adestrador = _adestradorService.Update<Adestrador, Adestrador, AdestradorValidator>(adestrador);
                    }
                }
                else
                {
                    var adestrador = new Adestrador();
                    PreencheObjeto(adestrador);
                    _adestradorService.Add<Adestrador, Adestrador, AdestradorValidator>(adestrador);

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
                _adestradorService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Adestramento Magali", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            adestradores = _adestradorService.Get<AdestradorModel>().ToList();
            dataGridViewConsulta.DataSource = adestradores;
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
