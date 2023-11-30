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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEquipamento));
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.txtDescricao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtIndicacao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(629, 255);
            this.materialTabControl.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.txtQuantidade);
            this.tabPageCadastro.Controls.Add(this.txtIndicacao);
            this.tabPageCadastro.Controls.Add(this.txtDescricao);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Size = new System.Drawing.Size(621, 220);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtDescricao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtIndicacao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtQuantidade, 0);
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(14, 6);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(310, 48);
            this.txtNome.TabIndex = 0;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.HideSelection = true;
            this.txtId.Hint = "Id";
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(504, 6);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.ReadOnly = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(89, 48);
            this.txtId.TabIndex = 4;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // txtDescricao
            // 
            this.txtDescricao.AllowPromptAsInput = true;
            this.txtDescricao.AnimateReadOnly = false;
            this.txtDescricao.AsciiOnly = false;
            this.txtDescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescricao.BeepOnError = false;
            this.txtDescricao.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDescricao.Depth = 0;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescricao.HidePromptOnLeave = false;
            this.txtDescricao.HideSelection = true;
            this.txtDescricao.Hint = "Descrição";
            this.txtDescricao.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDescricao.LeadingIcon = null;
            this.txtDescricao.Location = new System.Drawing.Point(14, 114);
            this.txtDescricao.Mask = "";
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.PrefixSuffixText = null;
            this.txtDescricao.PromptChar = '_';
            this.txtDescricao.ReadOnly = false;
            this.txtDescricao.RejectInputOnFirstFailure = false;
            this.txtDescricao.ResetOnPrompt = true;
            this.txtDescricao.ResetOnSpace = true;
            this.txtDescricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(579, 48);
            this.txtDescricao.SkipLiterals = true;
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDescricao.TrailingIcon = null;
            this.txtDescricao.UseSystemPasswordChar = false;
            this.txtDescricao.ValidatingType = null;
            // 
            // txtIndicacao
            // 
            this.txtIndicacao.AllowPromptAsInput = true;
            this.txtIndicacao.AnimateReadOnly = false;
            this.txtIndicacao.AsciiOnly = false;
            this.txtIndicacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIndicacao.BeepOnError = false;
            this.txtIndicacao.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtIndicacao.Depth = 0;
            this.txtIndicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIndicacao.HidePromptOnLeave = false;
            this.txtIndicacao.HideSelection = true;
            this.txtIndicacao.Hint = "Indicação";
            this.txtIndicacao.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtIndicacao.LeadingIcon = null;
            this.txtIndicacao.Location = new System.Drawing.Point(14, 60);
            this.txtIndicacao.Mask = "";
            this.txtIndicacao.MaxLength = 32767;
            this.txtIndicacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtIndicacao.Name = "txtIndicacao";
            this.txtIndicacao.PasswordChar = '\0';
            this.txtIndicacao.PrefixSuffixText = null;
            this.txtIndicacao.PromptChar = '_';
            this.txtIndicacao.ReadOnly = false;
            this.txtIndicacao.RejectInputOnFirstFailure = false;
            this.txtIndicacao.ResetOnPrompt = true;
            this.txtIndicacao.ResetOnSpace = true;
            this.txtIndicacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIndicacao.SelectedText = "";
            this.txtIndicacao.SelectionLength = 0;
            this.txtIndicacao.SelectionStart = 0;
            this.txtIndicacao.ShortcutsEnabled = true;
            this.txtIndicacao.Size = new System.Drawing.Size(579, 48);
            this.txtIndicacao.SkipLiterals = true;
            this.txtIndicacao.TabIndex = 2;
            this.txtIndicacao.TabStop = false;
            this.txtIndicacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIndicacao.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtIndicacao.TrailingIcon = null;
            this.txtIndicacao.UseSystemPasswordChar = false;
            this.txtIndicacao.ValidatingType = null;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AnimateReadOnly = false;
            this.txtQuantidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuantidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuantidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQuantidade.Depth = 0;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantidade.HideSelection = true;
            this.txtQuantidade.Hint = "Quantidade";
            this.txtQuantidade.LeadingIcon = null;
            this.txtQuantidade.Location = new System.Drawing.Point(330, 6);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PrefixSuffixText = null;
            this.txtQuantidade.ReadOnly = false;
            this.txtQuantidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.ShortcutsEnabled = true;
            this.txtQuantidade.Size = new System.Drawing.Size(168, 48);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.TabStop = false;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantidade.TrailingIcon = null;
            this.txtQuantidade.UseSystemPasswordChar = false;
            // 
            // CadastroEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 322);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroEquipamento";
            this.Text = "Cadastro de Equipamentos";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDescricao;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtIndicacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
    }
}