namespace AdestramentoMagali.App.Cadastros
{
    partial class CadastroAdestrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAdestrador));
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTelefone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEspecialidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataCadastro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            chkAtivo = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(629, 332);
            materialTabControl.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(chkAtivo);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtEmail);
            tabPageCadastro.Controls.Add(txtDataCadastro);
            tabPageCadastro.Controls.Add(txtSenha);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(txtEspecialidade);
            tabPageCadastro.Size = new Size(621, 297);
            tabPageCadastro.Controls.SetChildIndex(txtEspecialidade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtSenha, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataCadastro, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEmail, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(chkAtivo, 0);
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = Properties.Resources.baseline_fingerprint_black_24dp;
            txtSenha.Location = new Point(416, 60);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(177, 48);
            txtSenha.TabIndex = 2;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
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
            // txtTelefone
            // 
            txtTelefone.AnimateReadOnly = false;
            txtTelefone.AutoCompleteMode = AutoCompleteMode.None;
            txtTelefone.AutoCompleteSource = AutoCompleteSource.None;
            txtTelefone.BackgroundImageLayout = ImageLayout.None;
            txtTelefone.CharacterCasing = CharacterCasing.Normal;
            txtTelefone.Depth = 0;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefone.HideSelection = true;
            txtTelefone.Hint = "Telefone";
            txtTelefone.LeadingIcon = null;
            txtTelefone.Location = new Point(14, 114);
            txtTelefone.MaxLength = 32767;
            txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.PrefixSuffixText = null;
            txtTelefone.ReadOnly = false;
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.ShortcutsEnabled = true;
            txtTelefone.Size = new Size(216, 48);
            txtTelefone.TabIndex = 3;
            txtTelefone.TabStop = false;
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.AnimateReadOnly = false;
            txtEspecialidade.AutoCompleteMode = AutoCompleteMode.None;
            txtEspecialidade.AutoCompleteSource = AutoCompleteSource.None;
            txtEspecialidade.BackgroundImageLayout = ImageLayout.None;
            txtEspecialidade.CharacterCasing = CharacterCasing.Normal;
            txtEspecialidade.Depth = 0;
            txtEspecialidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEspecialidade.HideSelection = true;
            txtEspecialidade.Hint = "Especialidade";
            txtEspecialidade.LeadingIcon = null;
            txtEspecialidade.Location = new Point(236, 114);
            txtEspecialidade.MaxLength = 32767;
            txtEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.PasswordChar = '\0';
            txtEspecialidade.PrefixSuffixText = null;
            txtEspecialidade.ReadOnly = false;
            txtEspecialidade.RightToLeft = RightToLeft.No;
            txtEspecialidade.SelectedText = "";
            txtEspecialidade.SelectionLength = 0;
            txtEspecialidade.SelectionStart = 0;
            txtEspecialidade.ShortcutsEnabled = true;
            txtEspecialidade.Size = new Size(357, 48);
            txtEspecialidade.TabIndex = 4;
            txtEspecialidade.TabStop = false;
            txtEspecialidade.TextAlign = HorizontalAlignment.Left;
            txtEspecialidade.TrailingIcon = null;
            txtEspecialidade.UseSystemPasswordChar = false;
            // 
            // txtDataCadastro
            // 
            txtDataCadastro.AnimateReadOnly = false;
            txtDataCadastro.AutoCompleteMode = AutoCompleteMode.None;
            txtDataCadastro.AutoCompleteSource = AutoCompleteSource.None;
            txtDataCadastro.BackgroundImageLayout = ImageLayout.None;
            txtDataCadastro.CharacterCasing = CharacterCasing.Normal;
            txtDataCadastro.Depth = 0;
            txtDataCadastro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataCadastro.HideSelection = true;
            txtDataCadastro.Hint = "Data de Cadastro";
            txtDataCadastro.LeadingIcon = null;
            txtDataCadastro.Location = new Point(14, 168);
            txtDataCadastro.MaxLength = 32767;
            txtDataCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataCadastro.Name = "txtDataCadastro";
            txtDataCadastro.PasswordChar = '\0';
            txtDataCadastro.PrefixSuffixText = null;
            txtDataCadastro.ReadOnly = true;
            txtDataCadastro.RightToLeft = RightToLeft.No;
            txtDataCadastro.SelectedText = "";
            txtDataCadastro.SelectionLength = 0;
            txtDataCadastro.SelectionStart = 0;
            txtDataCadastro.ShortcutsEnabled = true;
            txtDataCadastro.Size = new Size(447, 48);
            txtDataCadastro.TabIndex = 5;
            txtDataCadastro.TabStop = false;
            txtDataCadastro.TextAlign = HorizontalAlignment.Left;
            txtDataCadastro.TrailingIcon = null;
            txtDataCadastro.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(14, 60);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(396, 48);
            txtEmail.TabIndex = 1;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
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
            txtId.TabIndex = 7;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Depth = 0;
            chkAtivo.Location = new Point(464, 168);
            chkAtivo.Margin = new Padding(0);
            chkAtivo.MouseLocation = new Point(-1, -1);
            chkAtivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chkAtivo.Name = "chkAtivo";
            chkAtivo.ReadOnly = false;
            chkAtivo.Ripple = true;
            chkAtivo.Size = new Size(129, 37);
            chkAtivo.TabIndex = 6;
            chkAtivo.Text = "Usuário Ativo";
            chkAtivo.UseAccentColor = false;
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // CadastroAdestrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 399);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(0, 0);
            Name = "CadastroAdestrador";
            Text = "Cadastro de Adestradores";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTelefone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEspecialidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDataCadastro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialCheckBox chkAtivo;
    }
}