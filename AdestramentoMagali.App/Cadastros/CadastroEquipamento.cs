using AdestramentoMagali.App.Base;
using AdestramentoMagali.App.Models;
using AdestramentoMagali.Domain.Base;
using AdestramentoMagali.Domain.Entities;
using AdestramentoMagali.Service.Validators;

namespace AdestramentoMagali.App.Cadastros
{
    public partial class CadastroEquipamento : CadastroBase
    {
        private readonly IBaseService<Equipamento> _equipamentoService;

        private List<EquipamentoModel>? equipamentos;

        public CadastroEquipamento(IBaseService<Equipamento> equipamentoService)
        {
            _equipamentoService = equipamentoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Equipamento equipamento)
        {
            equipamento.Nome = txtNome.Text;
            if (int.TryParse(txtQuantidade.Text, out var quantidade))
            {
                equipamento.Quantidade = quantidade;
            }
            equipamento.Indicacao = txtIndicacao.Text;
            equipamento.Descricao = txtDescricao.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var equipamento = _equipamentoService.GetById<Equipamento>(id);
                        PreencheObjeto(equipamento);
                        equipamento = _equipamentoService.Update<Equipamento, Equipamento, EquipamentoValidator>(equipamento);
                    }
                }
                else
                {
                    var equipamento = new Equipamento();
                    PreencheObjeto(equipamento);
                    _equipamentoService.Add<Equipamento, Equipamento, EquipamentoValidator>(equipamento);

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
                _equipamentoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Adestramento Magali", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            equipamentos = _equipamentoService.Get<EquipamentoModel>().ToList();
            dataGridViewConsulta.DataSource = equipamentos;
            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtQuantidade.Text = linha?.Cells["Quantidade"].Value.ToString();
            txtIndicacao.Text = linha?.Cells["Indicacao"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
        }

    }
}
