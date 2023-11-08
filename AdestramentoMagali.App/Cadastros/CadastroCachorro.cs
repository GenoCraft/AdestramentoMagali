using AdestramentoMagali.App.Base;
using AdestramentoMagali.App.Models;
using AdestramentoMagali.Domain.Base;
using AdestramentoMagali.Domain.Entities;
using AdestramentoMagali.Service.Validators;

namespace AdestramentoMagali.App.Cadastros
{
    public partial class CadastroCachorro : CadastroBase
    {
        private readonly IBaseService<Cachorro> _cachorroService;
        private readonly IBaseService<Adestrador> _adestradorService;
        private readonly IBaseService<Cliente> _clienteService;

        private List<CachorroModel>? cachorros;

        public CadastroCachorro(IBaseService<Cachorro> cachorroService, IBaseService<Adestrador> adestradorService, IBaseService<Cliente> clienteService)
        {
            _cachorroService = cachorroService;
            _adestradorService = adestradorService;
            _clienteService = clienteService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboAdestrador.ValueMember = "Id";
            cboAdestrador.DisplayMember = "Nome";
            cboAdestrador.DataSource = _adestradorService.Get<Adestrador>().ToList();
            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _clienteService.Get<Cliente>().ToList();
        }

        private void PreencheObjeto(Cachorro cachorro)
        {
            cachorro.Nome = txtNome.Text;
            if (int.TryParse(txtIdade.Text, out var idade))
            {
                cachorro.Idade = idade;
            }
            cachorro.Sexo = cboSexo.Text;
            cachorro.Raca = txtRaca.Text;
            cachorro.Porte = txtPorte.Text;
            if (float.TryParse(txtPeso.Text, out var peso))
            {
                cachorro.Peso = peso;
            }
            cachorro.Temperamento = txtTemperamento.Text;
            cachorro.TipoAdestramento = txtTipoAdestramento.Text;
            cachorro.Plano = txtPlano.Text;

            if (int.TryParse(cboAdestrador.SelectedValue.ToString(), out var idAdestrador))
            {
                var adestrador = _adestradorService.GetById<Adestrador>(idAdestrador);
                cachorro.Adestrador = adestrador;
            }
            if (int.TryParse(cboCliente.SelectedValue.ToString(), out var idCliente))
            {
                var cliente = _clienteService.GetById<Cliente>(idCliente);
                cachorro.Cliente = cliente;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var cachorro = _cachorroService.GetById<Cachorro>(id);
                        PreencheObjeto(cachorro);
                        _cachorroService.Update<Cachorro, Cachorro, CachorroValidator>(cachorro);
                    }
                }
                else
                {
                    var cachorro = new Cachorro();
                    PreencheObjeto(cachorro);
                    _cachorroService.Add<Cachorro, Cachorro, CachorroValidator>(cachorro);

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
                _cachorroService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Adestramento Magali", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            cachorros = _cachorroService.Get<CachorroModel>(new[] { "Adestrador" , "Cliente" }).ToList();
            dataGridViewConsulta.DataSource = cachorros;
            dataGridViewConsulta.Columns["IdAdestrador"]!.Visible = false;
            dataGridViewConsulta.Columns["IdCliente"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtIdade.Text = linha?.Cells["Idade"].Value.ToString();
            cboSexo.Text = linha?.Cells["Sexo"].Value.ToString();
            txtRaca.Text = linha?.Cells["Raca"].Value.ToString();
            txtPorte.Text = linha?.Cells["Porte"].Value.ToString();
            txtPeso.Text = linha?.Cells["Peso"].Value.ToString();
            txtTemperamento.Text = linha?.Cells["Temperamento"].Value.ToString();
            txtTipoAdestramento.Text = linha?.Cells["TipoAdestramento"].Value.ToString();
            txtPlano.Text = linha?.Cells["Plano"].Value.ToString();
            cboAdestrador.SelectedValue = linha?.Cells["IdAdestrador"].Value;
            cboCliente.SelectedValue = linha?.Cells["IdCliente"].Value;
        }

    }
}