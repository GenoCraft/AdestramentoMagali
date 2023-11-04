namespace AdestramentoMagali.App.Cadastros
{
    partial class CadastroEquipamento
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            txtDescricao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtIndicacao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(629, 255);
            materialTabControl.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtIndicacao);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Size = new Size(621, 220);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtIndicacao, 0);
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
            txtNome.Location = new Point(14, 6);
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
            txtNome.Size = new Size(484, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
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
            txtId.Size = new Size(89, 48);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // txtDescricao
            // 
            txtDescricao.AllowPromptAsInput = true;
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.AsciiOnly = false;
            txtDescricao.BackgroundImageLayout = ImageLayout.None;
            txtDescricao.BeepOnError = false;
            txtDescricao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.HidePromptOnLeave = false;
            txtDescricao.HideSelection = true;
            txtDescricao.Hint = "Descrição";
            txtDescricao.InsertKeyMode = InsertKeyMode.Default;
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(14, 114);
            txtDescricao.Mask = "";
            txtDescricao.MaxLength = 32767;
            txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.PrefixSuffixText = null;
            txtDescricao.PromptChar = '_';
            txtDescricao.ReadOnly = false;
            txtDescricao.RejectInputOnFirstFailure = false;
            txtDescricao.ResetOnPrompt = true;
            txtDescricao.ResetOnSpace = true;
            txtDescricao.RightToLeft = RightToLeft.No;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.ShortcutsEnabled = true;
            txtDescricao.Size = new Size(579, 48);
            txtDescricao.SkipLiterals = true;
            txtDescricao.TabIndex = 11;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            txtDescricao.ValidatingType = null;
            // 
            // txtIndicacao
            // 
            txtIndicacao.AllowPromptAsInput = true;
            txtIndicacao.AnimateReadOnly = false;
            txtIndicacao.AsciiOnly = false;
            txtIndicacao.BackgroundImageLayout = ImageLayout.None;
            txtIndicacao.BeepOnError = false;
            txtIndicacao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtIndicacao.Depth = 0;
            txtIndicacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIndicacao.HidePromptOnLeave = false;
            txtIndicacao.HideSelection = true;
            txtIndicacao.Hint = "Indicação";
            txtIndicacao.InsertKeyMode = InsertKeyMode.Default;
            txtIndicacao.LeadingIcon = null;
            txtIndicacao.Location = new Point(14, 60);
            txtIndicacao.Mask = "";
            txtIndicacao.MaxLength = 32767;
            txtIndicacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtIndicacao.Name = "txtIndicacao";
            txtIndicacao.PasswordChar = '\0';
            txtIndicacao.PrefixSuffixText = null;
            txtIndicacao.PromptChar = '_';
            txtIndicacao.ReadOnly = false;
            txtIndicacao.RejectInputOnFirstFailure = false;
            txtIndicacao.ResetOnPrompt = true;
            txtIndicacao.ResetOnSpace = true;
            txtIndicacao.RightToLeft = RightToLeft.No;
            txtIndicacao.SelectedText = "";
            txtIndicacao.SelectionLength = 0;
            txtIndicacao.SelectionStart = 0;
            txtIndicacao.ShortcutsEnabled = true;
            txtIndicacao.Size = new Size(579, 48);
            txtIndicacao.SkipLiterals = true;
            txtIndicacao.TabIndex = 12;
            txtIndicacao.TabStop = false;
            txtIndicacao.TextAlign = HorizontalAlignment.Left;
            txtIndicacao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtIndicacao.TrailingIcon = null;
            txtIndicacao.UseSystemPasswordChar = false;
            txtIndicacao.ValidatingType = null;
            // 
            // CadastroEquipamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 322);
            Location = new Point(0, 0);
            Name = "CadastroEquipamento";
            Text = "Cadastro de Equipamentos";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDescricao;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtIndicacao;
    }
}