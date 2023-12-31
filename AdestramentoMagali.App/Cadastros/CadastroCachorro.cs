﻿using AdestramentoMagali.App.Base;
using AdestramentoMagali.App.Models;
using AdestramentoMagali.Domain.Base;
using AdestramentoMagali.Domain.Entities;
using AdestramentoMagali.Service.Validators;
using System.Globalization;

namespace AdestramentoMagali.App.Cadastros
{
    public partial class CadastroCachorro : CadastroBase
    {
        private List<CachorroEquipModel> _cachorroEquip;
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
            _cachorroEquip = new List<CachorroEquipModel>();
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

            foreach (var equipamentos in _cachorroEquip)
            {
                var cachorroEquip = new CachorroEquip
                {
                    Cachorro = cachorro,
                    Equipamento = _equipamentoService.GetById<Equipamento>(equipamentos.IdEquipamento)
                };

                cachorro.Equipamentos.Add(cachorroEquip);
            }
        }

        protected override void Novo()
        {
            base.Novo();
            _cachorroEquip.Clear();
            CarregaGridEquipamentos();
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

        protected override void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                materialTabControl.SelectedIndex = 0;
                tabPageCadastro.Focus();
                CarregaGridEquipamentos();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Adestramento Magali", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
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

            var includes = new List<string>() { "Cliente", "Funcionario", "Equipamentos", "Equipamentos.Equipamento" };
            var cachorro = _cachorroService.GetById<Cachorro>(id, includes);
            _cachorroEquip = new List<CachorroEquipModel>();
            foreach (var equipamentos in cachorro.Equipamentos)
            {
                var cachorroEquip = new CachorroEquipModel
                {
                    Id = equipamentos.Id,
                    IdEquipamento = equipamentos.Equipamento.Id,
                    Equipamento = equipamentos.Equipamento.Nome
                };
                _cachorroEquip.Add(cachorroEquip);
            }
            CarregaGridEquipamentos();
        }

        private void CarregaGridEquipamentos()
        {
            var source = new BindingSource();
            source.DataSource = _cachorroEquip.ToArray();
            dataGridViewEquip.DataSource = source;
            dataGridViewEquip.Columns["Id"]!.Visible = false;
            dataGridViewEquip.Columns["IdEquipamento"]!.HeaderText = @"Id.Equipamento";
            dataGridViewEquip.Columns["Equipamento"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidaEquip())
            {
                var cachorroEquip = new CachorroEquipModel();
                if (int.TryParse(cboEquipamento.SelectedValue.ToString(), out var idEquipamento))
                {
                    var equipamento = _equipamentoService.GetById<Equipamento>(idEquipamento);
                    cachorroEquip.IdEquipamento = equipamento.Id;
                    cachorroEquip.Equipamento = equipamento.Nome;
                }

                _cachorroEquip.Add(cachorroEquip);
                CarregaGridEquipamentos();
            }
        }

        private bool ValidaEquip()
        {
            return true;
        }
    }
}