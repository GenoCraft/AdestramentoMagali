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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCachorro));
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboEquipamento = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            cboFuncionario = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIdade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboSexo = new ReaLTaiizor.Controls.MaterialComboBox();
            txtRaca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPorte = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPeso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTemperamento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTipoAdestramento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPlano = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewEquip = new DataGridView();
            btnAdicionar = new ReaLTaiizor.Controls.MaterialButton();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquip).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(629, 448);
            materialTabControl.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnAdicionar);
            tabPageCadastro.Controls.Add(dataGridViewEquip);
            tabPageCadastro.Controls.Add(materialButton1);
            tabPageCadastro.Controls.Add(cboEquipamento);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtIdade);
            tabPageCadastro.Controls.Add(cboSexo);
            tabPageCadastro.Controls.Add(txtRaca);
            tabPageCadastro.Controls.Add(txtPorte);
            tabPageCadastro.Controls.Add(txtPeso);
            tabPageCadastro.Controls.Add(txtTemperamento);
            tabPageCadastro.Controls.Add(txtTipoAdestramento);
            tabPageCadastro.Controls.Add(txtPlano);
            tabPageCadastro.Controls.Add(cboFuncionario);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(621, 413);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFuncionario, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPlano, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTipoAdestramento, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTemperamento, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPeso, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPorte, 0);
            tabPageCadastro.Controls.SetChildIndex(txtRaca, 0);
            tabPageCadastro.Controls.SetChildIndex(cboSexo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtIdade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(cboEquipamento, 0);
            tabPageCadastro.Controls.SetChildIndex(materialButton1, 0);
            tabPageCadastro.Controls.SetChildIndex(dataGridViewEquip, 0);
            tabPageCadastro.Controls.SetChildIndex(btnAdicionar, 0);
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
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
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
            cboEquipamento.Hint = "Equipamentos";
            cboEquipamento.IntegralHeight = false;
            cboEquipamento.ItemHeight = 43;
            cboEquipamento.Location = new Point(303, 222);
            cboEquipamento.MaxDropDownItems = 4;
            cboEquipamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEquipamento.Name = "cboEquipamento";
            cboEquipamento.Size = new Size(237, 49);
            cboEquipamento.StartIndex = 0;
            cboEquipamento.TabIndex = 11;
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
            cboCliente.Location = new Point(319, 168);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(292, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 9;
            // 
            // cboFuncionario
            // 
            cboFuncionario.AutoResize = false;
            cboFuncionario.BackColor = Color.FromArgb(255, 255, 255);
            cboFuncionario.Depth = 0;
            cboFuncionario.DrawMode = DrawMode.OwnerDrawVariable;
            cboFuncionario.DropDownHeight = 174;
            cboFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuncionario.DropDownWidth = 121;
            cboFuncionario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFuncionario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFuncionario.FormattingEnabled = true;
            cboFuncionario.Hint = "Adestrador responsável";
            cboFuncionario.IntegralHeight = false;
            cboFuncionario.ItemHeight = 43;
            cboFuncionario.Location = new Point(6, 168);
            cboFuncionario.MaxDropDownItems = 4;
            cboFuncionario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFuncionario.Name = "cboFuncionario";
            cboFuncionario.Size = new Size(307, 49);
            cboFuncionario.StartIndex = 0;
            cboFuncionario.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 6);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(272, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtIdade
            // 
            txtIdade.AnimateReadOnly = false;
            txtIdade.AutoCompleteMode = AutoCompleteMode.None;
            txtIdade.AutoCompleteSource = AutoCompleteSource.None;
            txtIdade.BackgroundImageLayout = ImageLayout.None;
            txtIdade.CharacterCasing = CharacterCasing.Normal;
            txtIdade.Depth = 0;
            txtIdade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIdade.HideSelection = true;
            txtIdade.Hint = "Idade";
            txtIdade.LeadingIcon = null;
            txtIdade.Location = new Point(285, 6);
            txtIdade.MaxLength = 32767;
            txtIdade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtIdade.Name = "txtIdade";
            txtIdade.PasswordChar = '\0';
            txtIdade.PrefixSuffixText = null;
            txtIdade.ReadOnly = false;
            txtIdade.RightToLeft = RightToLeft.No;
            txtIdade.SelectedText = "";
            txtIdade.SelectionLength = 0;
            txtIdade.SelectionStart = 0;
            txtIdade.ShortcutsEnabled = true;
            txtIdade.Size = new Size(86, 48);
            txtIdade.TabIndex = 1;
            txtIdade.TabStop = false;
            txtIdade.TextAlign = HorizontalAlignment.Left;
            txtIdade.TrailingIcon = null;
            txtIdade.UseSystemPasswordChar = false;
            // 
            // cboSexo
            // 
            cboSexo.AutoResize = false;
            cboSexo.BackColor = Color.FromArgb(255, 255, 255);
            cboSexo.Depth = 0;
            cboSexo.DrawMode = DrawMode.OwnerDrawVariable;
            cboSexo.DropDownHeight = 174;
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.DropDownWidth = 121;
            cboSexo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboSexo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboSexo.Hint = "Sexo";
            cboSexo.IntegralHeight = false;
            cboSexo.ItemHeight = 43;
            cboSexo.Items.AddRange(new object[] { "Macho", "Fêmea" });
            cboSexo.Location = new Point(377, 6);
            cboSexo.MaxDropDownItems = 4;
            cboSexo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(121, 49);
            cboSexo.StartIndex = 0;
            cboSexo.TabIndex = 2;
            // 
            // txtRaca
            // 
            txtRaca.AnimateReadOnly = false;
            txtRaca.AutoCompleteMode = AutoCompleteMode.None;
            txtRaca.AutoCompleteSource = AutoCompleteSource.None;
            txtRaca.BackgroundImageLayout = ImageLayout.None;
            txtRaca.CharacterCasing = CharacterCasing.Normal;
            txtRaca.Depth = 0;
            txtRaca.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRaca.HideSelection = true;
            txtRaca.Hint = "Raça";
            txtRaca.LeadingIcon = null;
            txtRaca.Location = new Point(6, 60);
            txtRaca.MaxLength = 32767;
            txtRaca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtRaca.Name = "txtRaca";
            txtRaca.PasswordChar = '\0';
            txtRaca.PrefixSuffixText = null;
            txtRaca.ReadOnly = false;
            txtRaca.RightToLeft = RightToLeft.No;
            txtRaca.SelectedText = "";
            txtRaca.SelectionLength = 0;
            txtRaca.SelectionStart = 0;
            txtRaca.ShortcutsEnabled = true;
            txtRaca.Size = new Size(262, 48);
            txtRaca.TabIndex = 3;
            txtRaca.TabStop = false;
            txtRaca.TextAlign = HorizontalAlignment.Left;
            txtRaca.TrailingIcon = null;
            txtRaca.UseSystemPasswordChar = false;
            // 
            // txtPorte
            // 
            txtPorte.AnimateReadOnly = false;
            txtPorte.AutoCompleteMode = AutoCompleteMode.None;
            txtPorte.AutoCompleteSource = AutoCompleteSource.None;
            txtPorte.BackgroundImageLayout = ImageLayout.None;
            txtPorte.CharacterCasing = CharacterCasing.Normal;
            txtPorte.Depth = 0;
            txtPorte.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPorte.HideSelection = true;
            txtPorte.Hint = "Porte";
            txtPorte.LeadingIcon = null;
            txtPorte.Location = new Point(274, 60);
            txtPorte.MaxLength = 32767;
            txtPorte.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPorte.Name = "txtPorte";
            txtPorte.PasswordChar = '\0';
            txtPorte.PrefixSuffixText = null;
            txtPorte.ReadOnly = false;
            txtPorte.RightToLeft = RightToLeft.No;
            txtPorte.SelectedText = "";
            txtPorte.SelectionLength = 0;
            txtPorte.SelectionStart = 0;
            txtPorte.ShortcutsEnabled = true;
            txtPorte.Size = new Size(224, 48);
            txtPorte.TabIndex = 4;
            txtPorte.TabStop = false;
            txtPorte.TextAlign = HorizontalAlignment.Left;
            txtPorte.TrailingIcon = null;
            txtPorte.UseSystemPasswordChar = false;
            // 
            // txtPeso
            // 
            txtPeso.AnimateReadOnly = false;
            txtPeso.AutoCompleteMode = AutoCompleteMode.None;
            txtPeso.AutoCompleteSource = AutoCompleteSource.None;
            txtPeso.BackgroundImageLayout = ImageLayout.None;
            txtPeso.CharacterCasing = CharacterCasing.Normal;
            txtPeso.Depth = 0;
            txtPeso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPeso.HideSelection = true;
            txtPeso.Hint = "Peso";
            txtPeso.LeadingIcon = null;
            txtPeso.Location = new Point(504, 60);
            txtPeso.MaxLength = 32767;
            txtPeso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPeso.Name = "txtPeso";
            txtPeso.PasswordChar = '\0';
            txtPeso.PrefixSuffixText = null;
            txtPeso.ReadOnly = false;
            txtPeso.RightToLeft = RightToLeft.No;
            txtPeso.SelectedText = "";
            txtPeso.SelectionLength = 0;
            txtPeso.SelectionStart = 0;
            txtPeso.ShortcutsEnabled = true;
            txtPeso.Size = new Size(107, 48);
            txtPeso.TabIndex = 5;
            txtPeso.TabStop = false;
            txtPeso.TextAlign = HorizontalAlignment.Left;
            txtPeso.TrailingIcon = null;
            txtPeso.UseSystemPasswordChar = false;
            // 
            // txtTemperamento
            // 
            txtTemperamento.AnimateReadOnly = false;
            txtTemperamento.AutoCompleteMode = AutoCompleteMode.None;
            txtTemperamento.AutoCompleteSource = AutoCompleteSource.None;
            txtTemperamento.BackgroundImageLayout = ImageLayout.None;
            txtTemperamento.CharacterCasing = CharacterCasing.Normal;
            txtTemperamento.Depth = 0;
            txtTemperamento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTemperamento.HideSelection = true;
            txtTemperamento.Hint = "Temperamento";
            txtTemperamento.LeadingIcon = null;
            txtTemperamento.Location = new Point(6, 114);
            txtTemperamento.MaxLength = 32767;
            txtTemperamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTemperamento.Name = "txtTemperamento";
            txtTemperamento.PasswordChar = '\0';
            txtTemperamento.PrefixSuffixText = null;
            txtTemperamento.ReadOnly = false;
            txtTemperamento.RightToLeft = RightToLeft.No;
            txtTemperamento.SelectedText = "";
            txtTemperamento.SelectionLength = 0;
            txtTemperamento.SelectionStart = 0;
            txtTemperamento.ShortcutsEnabled = true;
            txtTemperamento.Size = new Size(326, 48);
            txtTemperamento.TabIndex = 6;
            txtTemperamento.TabStop = false;
            txtTemperamento.TextAlign = HorizontalAlignment.Left;
            txtTemperamento.TrailingIcon = null;
            txtTemperamento.UseSystemPasswordChar = false;
            // 
            // txtTipoAdestramento
            // 
            txtTipoAdestramento.AnimateReadOnly = false;
            txtTipoAdestramento.AutoCompleteMode = AutoCompleteMode.None;
            txtTipoAdestramento.AutoCompleteSource = AutoCompleteSource.None;
            txtTipoAdestramento.BackgroundImageLayout = ImageLayout.None;
            txtTipoAdestramento.CharacterCasing = CharacterCasing.Normal;
            txtTipoAdestramento.Depth = 0;
            txtTipoAdestramento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTipoAdestramento.HideSelection = true;
            txtTipoAdestramento.Hint = "Tipo de adestramento";
            txtTipoAdestramento.LeadingIcon = null;
            txtTipoAdestramento.Location = new Point(338, 114);
            txtTipoAdestramento.MaxLength = 32767;
            txtTipoAdestramento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTipoAdestramento.Name = "txtTipoAdestramento";
            txtTipoAdestramento.PasswordChar = '\0';
            txtTipoAdestramento.PrefixSuffixText = null;
            txtTipoAdestramento.ReadOnly = false;
            txtTipoAdestramento.RightToLeft = RightToLeft.No;
            txtTipoAdestramento.SelectedText = "";
            txtTipoAdestramento.SelectionLength = 0;
            txtTipoAdestramento.SelectionStart = 0;
            txtTipoAdestramento.ShortcutsEnabled = true;
            txtTipoAdestramento.Size = new Size(273, 48);
            txtTipoAdestramento.TabIndex = 7;
            txtTipoAdestramento.TabStop = false;
            txtTipoAdestramento.TextAlign = HorizontalAlignment.Left;
            txtTipoAdestramento.TrailingIcon = null;
            txtTipoAdestramento.UseSystemPasswordChar = false;
            // 
            // txtPlano
            // 
            txtPlano.AnimateReadOnly = false;
            txtPlano.AutoCompleteMode = AutoCompleteMode.None;
            txtPlano.AutoCompleteSource = AutoCompleteSource.None;
            txtPlano.BackgroundImageLayout = ImageLayout.None;
            txtPlano.CharacterCasing = CharacterCasing.Normal;
            txtPlano.Depth = 0;
            txtPlano.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPlano.HideSelection = true;
            txtPlano.Hint = "Plano";
            txtPlano.LeadingIcon = null;
            txtPlano.Location = new Point(6, 223);
            txtPlano.MaxLength = 32767;
            txtPlano.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPlano.Name = "txtPlano";
            txtPlano.PasswordChar = '\0';
            txtPlano.PrefixSuffixText = null;
            txtPlano.ReadOnly = false;
            txtPlano.RightToLeft = RightToLeft.No;
            txtPlano.SelectedText = "";
            txtPlano.SelectionLength = 0;
            txtPlano.SelectionStart = 0;
            txtPlano.ShortcutsEnabled = true;
            txtPlano.Size = new Size(291, 48);
            txtPlano.TabIndex = 10;
            txtPlano.TabStop = false;
            txtPlano.TextAlign = HorizontalAlignment.Left;
            txtPlano.TrailingIcon = null;
            txtPlano.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(1033, 218);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 12;
            materialButton1.Text = "+";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEquip
            // 
            dataGridViewEquip.AccessibleDescription = "";
            dataGridViewEquip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEquip.Location = new Point(6, 277);
            dataGridViewEquip.Name = "dataGridViewEquip";
            dataGridViewEquip.RowTemplate.Height = 25;
            dataGridViewEquip.Size = new Size(605, 79);
            dataGridViewEquip.TabIndex = 13;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionar.Depth = 0;
            btnAdicionar.HighEmphasis = true;
            btnAdicionar.Icon = null;
            btnAdicionar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdicionar.Location = new Point(547, 226);
            btnAdicionar.Margin = new Padding(4, 6, 4, 6);
            btnAdicionar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.NoAccentTextColor = Color.Empty;
            btnAdicionar.Size = new Size(64, 36);
            btnAdicionar.TabIndex = 14;
            btnAdicionar.Text = "+";
            btnAdicionar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionar.UseAccentColor = false;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // CadastroCachorro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 515);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(0, 0);
            Name = "CadastroCachorro";
            Text = "Cadastro de Cachorros";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquip).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboFuncionario;
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
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private DataGridView dataGridViewEquip;
        private ReaLTaiizor.Controls.MaterialButton btnAdicionar;
    }
}