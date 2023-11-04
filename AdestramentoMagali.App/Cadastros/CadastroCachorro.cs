using AdestramentoMagali.App.Base;
using AdestramentoMagali.Domain.Base;
using AdestramentoMagali.Domain.Entities;
using AdestramentoMagali.Service.Validators;

namespace AdestramentoMagali.App.Cadastros
{
    public partial class CadastroCachorro : CadastroBase
    {
        private readonly IBaseService<Cachorro> _cachorroService;

        private List<Cachorro>? cachorros;

        public CadastroCachorro(IBaseService<Cachorro> cachorroService)
        {
            _cachorroService = cachorroService;
            InitializeComponent();
        }

        private void PreencheObjeto(Cachorro cachorro)
        {
            //cachorro.Nome = txtNome.Text;
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
                        cachorro = _cachorroService.Update<Cachorro, Cachorro, CachorroValidator>(cachorro);
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
            cachorros = _cachorroService.Get<Cachorro>().ToList();
            dataGridViewConsulta.DataSource = cachorros;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            //txtNome.Text = linha?.Cells["Nome"].Value.ToString();
        }

        private void txtVlUnitario_Click(object sender, EventArgs e)
        {

        }
    }
}
