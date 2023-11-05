namespace AdestramentoMagali.App.Cadastros
{
    partial class CadastroCachorro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            cboAdestrador = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIdade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboSexo = new ReaLTaiizor.Controls.MaterialComboBox();
            txtRaca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPorte = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPeso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTemperamento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTipoAdestramento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPlano = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboEquipamento = new ReaLTaiizor.Controls.MaterialComboBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(629, 486);
            materialTabControl.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtIdade);
            tabPageCadastro.Controls.Add(cboSexo);
            tabPageCadastro.Controls.Add(txtRaca);
            tabPageCadastro.Controls.Add(txtPorte);
            tabPageCadastro.Controls.Add(txtPeso);
            tabPageCadastro.Controls.Add(txtTemperamento);
            tabPageCadastro.Controls.Add(txtTipoAdestramento);
            tabPageCadastro.Controls.Add(txtPlano);
            tabPageCadastro.Controls.Add(cboAdestrador);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(groupBox1);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(621, 451);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(groupBox1, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAdestrador, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPlano, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTipoAdestramento, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTemperamento, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPeso, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPorte, 0);
            tabPageCadastro.Controls.SetChildIndex(txtRaca, 0);
            tabPageCadastro.Controls.SetChildIndex(cboSexo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtIdade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(504, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(107, 48);
            txtId.TabIndex = 11;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboEquipamento);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(6, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 238);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Equipamentos necessários";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(602, 150);
            dataGridView1.TabIndex = 13;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(255, 255, 255);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.Hint = "Cliente";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(9, 61);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(489, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 14;
            // 
            // cboAdestrador
            // 
            cboAdestrador.AutoResize = false;
            cboAdestrador.BackColor = Color.FromArgb(255, 255, 255);
            cboAdestrador.Depth = 0;
            cboAdestrador.DrawMode = DrawMode.OwnerDrawVariable;
            cboAdestrador.DropDownHeight = 174;
            cboAdestrador.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAdestrador.DropDownWidth = 121;
            cboAdestrador.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAdestrador.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAdestrador.FormattingEnabled = true;
            cboAdestrador.Hint = "Adestrador responsável";
            cboAdestrador.IntegralHeight = false;
            cboAdestrador.ItemHeight = 43;
            cboAdestrador.Location = new Point(222, 6);
            cboAdestrador.MaxDropDownItems = 4;
            cboAdestrador.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAdestrador.Name = "cboAdestrador";
            cboAdestrador.Size = new Size(276, 49);
            cboAdestrador.StartIndex = 0;
            cboAdestrador.TabIndex = 15;
            // 
            // cboEquipamento
            // 
            cboEquipamento.AutoResize = false;
            cboEquipamento.BackColor = Color.FromArgb(255, 255, 255);
            cboEquipamento.Depth = 0;
            cboEquipamento.DrawMode = DrawMode.OwnerDrawVariable;
            cboEquipamento.DropDownHeight = 174;
            cboEquipamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEquipamento.DropDownWidth = 121;
            cboEquipamento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEquipamento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEquipamento.FormattingEnabled = true;
            cboEquipamento.Hint = "Equipamento";
            cboEquipamento.IntegralHeight = false;
            cboEquipamento.ItemHeight = 43;
            cboEquipamento.Location = new Point(3, 22);
            cboEquipamento.MaxDropDownItems = 4;
            cboEquipamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEquipamento.Name = "cboEquipamento";
            cboEquipamento.Size = new Size(215, 49);
            cboEquipamento.StartIndex = 0;
            cboEquipamento.TabIndex = 15;
            // 
            // CadastroCachorro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 553);
            Location = new Point(0, 0);
            Name = "CadastroCachorro";
            Text = "Cadastro de Cachorros";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialComboBox cboAdestrador;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIdade;
        private ReaLTaiizor.Controls.MaterialComboBox cboSexo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtRaca;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPorte;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPeso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTemperamento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTipoAdestramento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPlano;
        private ReaLTaiizor.Controls.MaterialComboBox cboEquipamento;
    }
}