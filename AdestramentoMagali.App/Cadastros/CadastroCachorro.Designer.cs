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
            txtValorTotalCachorro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataCachorro = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboEquipamento = new ReaLTaiizor.Controls.MaterialComboBox();
            txtVlUnitario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtVlTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            tabPageCadastro.Controls.Add(txtDataCachorro);
            tabPageCadastro.Controls.Add(txtValorTotalCachorro);
            tabPageCadastro.Controls.Add(cboAdestrador);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(groupBox1);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(621, 451);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(groupBox1, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAdestrador, 0);
            tabPageCadastro.Controls.SetChildIndex(txtValorTotalCachorro, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataCachorro, 0);
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
            groupBox1.Controls.Add(txtVlTotal);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(txtVlUnitario);
            groupBox1.Controls.Add(cboEquipamento);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(6, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 238);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Equipamentos da Cachorro";
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
            cboAdestrador.Hint = "Usuário/Vendedor";
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
            // txtValorTotalCachorro
            // 
            txtValorTotalCachorro.AnimateReadOnly = false;
            txtValorTotalCachorro.AutoCompleteMode = AutoCompleteMode.None;
            txtValorTotalCachorro.AutoCompleteSource = AutoCompleteSource.None;
            txtValorTotalCachorro.BackgroundImageLayout = ImageLayout.None;
            txtValorTotalCachorro.CharacterCasing = CharacterCasing.Normal;
            txtValorTotalCachorro.Depth = 0;
            txtValorTotalCachorro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValorTotalCachorro.HideSelection = true;
            txtValorTotalCachorro.Hint = "Valor Total";
            txtValorTotalCachorro.LeadingIcon = null;
            txtValorTotalCachorro.Location = new Point(504, 62);
            txtValorTotalCachorro.MaxLength = 32767;
            txtValorTotalCachorro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValorTotalCachorro.Name = "txtValorTotalCachorro";
            txtValorTotalCachorro.PasswordChar = '\0';
            txtValorTotalCachorro.PrefixSuffixText = null;
            txtValorTotalCachorro.ReadOnly = true;
            txtValorTotalCachorro.RightToLeft = RightToLeft.No;
            txtValorTotalCachorro.SelectedText = "";
            txtValorTotalCachorro.SelectionLength = 0;
            txtValorTotalCachorro.SelectionStart = 0;
            txtValorTotalCachorro.ShortcutsEnabled = true;
            txtValorTotalCachorro.Size = new Size(107, 48);
            txtValorTotalCachorro.TabIndex = 16;
            txtValorTotalCachorro.TabStop = false;
            txtValorTotalCachorro.TextAlign = HorizontalAlignment.Left;
            txtValorTotalCachorro.TrailingIcon = null;
            txtValorTotalCachorro.UseSystemPasswordChar = false;
            // 
            // txtDataCachorro
            // 
            txtDataCachorro.AllowPromptAsInput = true;
            txtDataCachorro.AnimateReadOnly = false;
            txtDataCachorro.AsciiOnly = false;
            txtDataCachorro.BackgroundImageLayout = ImageLayout.None;
            txtDataCachorro.BeepOnError = false;
            txtDataCachorro.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataCachorro.Depth = 0;
            txtDataCachorro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataCachorro.HidePromptOnLeave = false;
            txtDataCachorro.HideSelection = true;
            txtDataCachorro.Hint = "Data Cachorro";
            txtDataCachorro.InsertKeyMode = InsertKeyMode.Default;
            txtDataCachorro.LeadingIcon = null;
            txtDataCachorro.Location = new Point(9, 7);
            txtDataCachorro.Mask = "99/99/9999";
            txtDataCachorro.MaxLength = 32767;
            txtDataCachorro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataCachorro.Name = "txtDataCachorro";
            txtDataCachorro.PasswordChar = '\0';
            txtDataCachorro.PrefixSuffixText = null;
            txtDataCachorro.PromptChar = '_';
            txtDataCachorro.ReadOnly = false;
            txtDataCachorro.RejectInputOnFirstFailure = false;
            txtDataCachorro.ResetOnPrompt = true;
            txtDataCachorro.ResetOnSpace = true;
            txtDataCachorro.RightToLeft = RightToLeft.No;
            txtDataCachorro.SelectedText = "";
            txtDataCachorro.SelectionLength = 0;
            txtDataCachorro.SelectionStart = 0;
            txtDataCachorro.ShortcutsEnabled = true;
            txtDataCachorro.Size = new Size(177, 48);
            txtDataCachorro.SkipLiterals = true;
            txtDataCachorro.TabIndex = 17;
            txtDataCachorro.TabStop = false;
            txtDataCachorro.Text = "  /  /";
            txtDataCachorro.TextAlign = HorizontalAlignment.Center;
            txtDataCachorro.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataCachorro.TrailingIcon = null;
            txtDataCachorro.UseSystemPasswordChar = false;
            txtDataCachorro.ValidatingType = null;
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
            // txtVlUnitario
            // 
            txtVlUnitario.AnimateReadOnly = false;
            txtVlUnitario.AutoCompleteMode = AutoCompleteMode.None;
            txtVlUnitario.AutoCompleteSource = AutoCompleteSource.None;
            txtVlUnitario.BackgroundImageLayout = ImageLayout.None;
            txtVlUnitario.CharacterCasing = CharacterCasing.Normal;
            txtVlUnitario.Depth = 0;
            txtVlUnitario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVlUnitario.HideSelection = true;
            txtVlUnitario.Hint = "Valor Unitário";
            txtVlUnitario.LeadingIcon = null;
            txtVlUnitario.Location = new Point(224, 23);
            txtVlUnitario.MaxLength = 32767;
            txtVlUnitario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtVlUnitario.Name = "txtVlUnitario";
            txtVlUnitario.PasswordChar = '\0';
            txtVlUnitario.PrefixSuffixText = null;
            txtVlUnitario.ReadOnly = false;
            txtVlUnitario.RightToLeft = RightToLeft.No;
            txtVlUnitario.SelectedText = "";
            txtVlUnitario.SelectionLength = 0;
            txtVlUnitario.SelectionStart = 0;
            txtVlUnitario.ShortcutsEnabled = true;
            txtVlUnitario.Size = new Size(133, 48);
            txtVlUnitario.TabIndex = 16;
            txtVlUnitario.TabStop = false;
            txtVlUnitario.TextAlign = HorizontalAlignment.Left;
            txtVlUnitario.TrailingIcon = null;
            txtVlUnitario.UseSystemPasswordChar = false;
            txtVlUnitario.Click += txtVlUnitario_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantidade.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantidade.BackgroundImageLayout = ImageLayout.None;
            txtQuantidade.CharacterCasing = CharacterCasing.Normal;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.Hint = "Quantidade";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(363, 22);
            txtQuantidade.MaxLength = 32767;
            txtQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PasswordChar = '\0';
            txtQuantidade.PrefixSuffixText = null;
            txtQuantidade.ReadOnly = false;
            txtQuantidade.RightToLeft = RightToLeft.No;
            txtQuantidade.SelectedText = "";
            txtQuantidade.SelectionLength = 0;
            txtQuantidade.SelectionStart = 0;
            txtQuantidade.ShortcutsEnabled = true;
            txtQuantidade.Size = new Size(98, 48);
            txtQuantidade.TabIndex = 17;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtVlTotal
            // 
            txtVlTotal.AnimateReadOnly = false;
            txtVlTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtVlTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtVlTotal.BackgroundImageLayout = ImageLayout.None;
            txtVlTotal.CharacterCasing = CharacterCasing.Normal;
            txtVlTotal.Depth = 0;
            txtVlTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVlTotal.HideSelection = true;
            txtVlTotal.Hint = "Valor Total";
            txtVlTotal.LeadingIcon = null;
            txtVlTotal.Location = new Point(467, 22);
            txtVlTotal.MaxLength = 32767;
            txtVlTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtVlTotal.Name = "txtVlTotal";
            txtVlTotal.PasswordChar = '\0';
            txtVlTotal.PrefixSuffixText = null;
            txtVlTotal.ReadOnly = true;
            txtVlTotal.RightToLeft = RightToLeft.No;
            txtVlTotal.SelectedText = "";
            txtVlTotal.SelectionLength = 0;
            txtVlTotal.SelectionStart = 0;
            txtVlTotal.ShortcutsEnabled = true;
            txtVlTotal.Size = new Size(135, 48);
            txtVlTotal.TabIndex = 18;
            txtVlTotal.TabStop = false;
            txtVlTotal.TextAlign = HorizontalAlignment.Left;
            txtVlTotal.TrailingIcon = null;
            txtVlTotal.UseSystemPasswordChar = false;
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
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorTotalCachorro;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataCachorro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtVlUnitario;
        private ReaLTaiizor.Controls.MaterialComboBox cboEquipamento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtVlTotal;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
    }
}