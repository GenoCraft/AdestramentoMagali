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
            if (float.TryParse(txtPreco.Text, out var preco))
            {
                equipamento.Preco = preco;
            }

            if (DateTime.TryParse(txtDataCompra.Text, out var dataCompra))
            {
                equipamento.DataCompra = dataCompra;
            }
            equipamento.UnidadeCachorro = txtUnidadeCachorro.Text;
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
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtUnidadeCachorro.Text = linha?.Cells["UnidadeCachorro"].Value.ToString();
            txtPreco.Text = linha?.Cells["Preco"].Value.ToString();
            txtDataCompra.Text = DateTime.TryParse(linha?.Cells["DataCompra"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";

        }

    }
}
