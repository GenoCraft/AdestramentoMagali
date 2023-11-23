using AdestramentoMagali.App.Base;
using AdestramentoMagali.App.Models;
using AdestramentoMagali.Domain.Base;
using AdestramentoMagali.Domain.Entities;
using AdestramentoMagali.Service.Validators;
using System.Globalization;

namespace AdestramentoMagali.App.Cadastros
{
    public partial class CadastroCachorro : CadastroBase
    {
        private List<EquipamentoModel> _equipamentos;
        private readonly IBaseService<Cachorro> _cachorroService;
        private readonly IBaseService<Funcionario> _funcionarioService;
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Equipamento> _equipamentoService;

        private List<CachorroModel>? cachorros;

        public CadastroCachorro(IBaseService<Cachorro> cachorroService, IBaseService<Funcionario> funcionarioService, IBaseService<Cliente> clienteService, IBaseService<Equipamento> equipamentoService)
        {
            _cachorroService = cachorroService;
            _funcionarioService = funcionarioService;
            _clienteService = clienteService;
            _equipamentoService = equipamentoService;
            _equipamentos = new List<EquipamentoModel>();
            InitializeComponent();
            CarregarCombo();
            CarregaGridEquipamentos();
        }

        private void CarregarCombo()
        {
            cboFuncionario.ValueMember = "Id";
            cboFuncionario.DisplayMember = "Nome";
            cboFuncionario.DataSource = _funcionarioService.Get<Funcionario>().ToList();

            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _clienteService.Get<Cliente>().ToList();

            cboEquipamento.ValueMember = "Id";
            cboEquipamento.DisplayMember = "Nome";
            cboEquipamento.DataSource = _equipamentoService.Get<Equipamento>().ToList();
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

            if (int.TryParse(cboFuncionario.SelectedValue.ToString(), out var idFuncionario))
            {
                var funcionario = _funcionarioService.GetById<Funcionario>(idFuncionario);
                cachorro.Funcionario = funcionario;
            }
            if (int.TryParse(cboCliente.SelectedValue.ToString(), out var idCliente))
            {
                var cliente = _clienteService.GetById<Cliente>(idCliente);
                cachorro.Cliente = cliente;
            }

            foreach (var equipamentos in _equipamentos)
            {
                var equipamento = new Equipamento
                {
                    Id = equipamentos.Id,
                    Nome = equipamentos.Nome,
                    Indicacao = equipamentos.Indicacao,
                    Descricao = equipamentos.Descricao,
                    Quantidade = equipamentos.Quantidade
                };

                cachorro.Equipamentos.Add(equipamento);
            }
        }

        protected override void Novo()
        {
            LimpaCampos();
            _equipamentos.Clear();
            CarregaGridEquipamentos();
            materialTabControl.SelectedIndex = 0;
            tabPageCadastro.Focus();
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
            cachorros = _cachorroService.Get<CachorroModel>(new[] { "Funcionario", "Cliente" }).ToList();
            dataGridViewConsulta.DataSource = cachorros;
            dataGridViewConsulta.Columns["IdFuncionario"]!.Visible = false;
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
            cboFuncionario.SelectedValue = linha?.Cells["IdFuncionario"].Value;
            cboCliente.SelectedValue = linha?.Cells["IdCliente"].Value;
        }

        private void CarregaGridEquipamentos()
        {
            var source = new BindingSource();
            if (_equipamentos == null)
            {
                _equipamentos = new List<EquipamentoModel>();
            }
            source.DataSource = _equipamentos.ToArray();
            dataGridViewEquip.DataSource = source;
            dataGridViewEquip.Columns["Id"].Visible = false;
            dataGridViewEquip.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidaEquip())
            {
                var equipamento = new EquipamentoModel();

                if (int.TryParse(cboEquipamento.SelectedValue.ToString(), out var idEquipamento))
                {
                    equipamento = _equipamentoService.GetById<EquipamentoModel>(idEquipamento);
                }

                _equipamentos.Add(equipamento);
                CarregaGridEquipamentos();
            }
        }

        private bool ValidaEquip()
        {
            return true;
        }
    }
}