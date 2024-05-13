namespace UIGestaoMercearia
{
    partial class FormCadastroUsuario
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
            components = new System.ComponentModel.Container();
            Label nomeLabel;
            Label cPFLabel;
            Label emailLabel;
            Label nomeUsuarioLabel;
            Label senhaLabel;
            Label label1;
            usuarioBindingSource = new BindingSource(components);
            nomeTextBox = new TextBox();
            cPFTextBox = new TextBox();
            emailTextBox = new TextBox();
            nomeUsuarioTextBox = new TextBox();
            senhaTextBox = new TextBox();
            ativoCheckBox = new CheckBox();
            textBoxConfirmarSenha = new TextBox();
            label2 = new Label();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            nomeLabel = new Label();
            cPFLabel = new Label();
            emailLabel = new Label();
            nomeUsuarioLabel = new Label();
            senhaLabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nomeLabel.ForeColor = SystemColors.ButtonHighlight;
            nomeLabel.Location = new Point(3, 97);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(49, 18);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cPFLabel.ForeColor = SystemColors.ButtonHighlight;
            cPFLabel.Location = new Point(225, 156);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new Size(38, 18);
            cPFLabel.TabIndex = 7;
            cPFLabel.Text = "CPF";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.ButtonHighlight;
            emailLabel.Location = new Point(330, 97);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(50, 18);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "E-mail";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nomeUsuarioLabel.ForeColor = SystemColors.ButtonHighlight;
            nomeUsuarioLabel.Location = new Point(3, 156);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new Size(122, 18);
            nomeUsuarioLabel.TabIndex = 5;
            nomeUsuarioLabel.Text = "Nome de usuário";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            senhaLabel.ForeColor = SystemColors.ButtonHighlight;
            senhaLabel.Location = new Point(6, 213);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(50, 18);
            senhaLabel.TabIndex = 9;
            senhaLabel.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(112, 213);
            label1.Name = "label1";
            label1.Size = new Size(118, 18);
            label1.TabIndex = 11;
            label1.Text = "Confirmar senha";
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // nomeTextBox
            // 
            nomeTextBox.Cursor = Cursors.IBeam;
            nomeTextBox.DataBindings.Add(new Binding("Text", usuarioBindingSource, "Nome", true));
            nomeTextBox.Location = new Point(6, 121);
            nomeTextBox.Margin = new Padding(3, 4, 3, 4);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(318, 27);
            nomeTextBox.TabIndex = 2;
            // 
            // cPFTextBox
            // 
            cPFTextBox.Cursor = Cursors.IBeam;
            cPFTextBox.DataBindings.Add(new Binding("Text", usuarioBindingSource, "CPF", true));
            cPFTextBox.Location = new Point(225, 180);
            cPFTextBox.Margin = new Padding(3, 4, 3, 4);
            cPFTextBox.Name = "cPFTextBox";
            cPFTextBox.Size = new Size(331, 27);
            cPFTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            emailTextBox.Cursor = Cursors.IBeam;
            emailTextBox.DataBindings.Add(new Binding("Text", usuarioBindingSource, "Email", true));
            emailTextBox.Location = new Point(330, 121);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(393, 27);
            emailTextBox.TabIndex = 4;
            // 
            // nomeUsuarioTextBox
            // 
            nomeUsuarioTextBox.Cursor = Cursors.IBeam;
            nomeUsuarioTextBox.DataBindings.Add(new Binding("Text", usuarioBindingSource, "NomeUsuario", true));
            nomeUsuarioTextBox.Location = new Point(6, 180);
            nomeUsuarioTextBox.Margin = new Padding(3, 4, 3, 4);
            nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            nomeUsuarioTextBox.Size = new Size(213, 27);
            nomeUsuarioTextBox.TabIndex = 6;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Cursor = Cursors.IBeam;
            senhaTextBox.DataBindings.Add(new Binding("Text", usuarioBindingSource, "Senha", true));
            senhaTextBox.Location = new Point(6, 236);
            senhaTextBox.Margin = new Padding(3, 4, 3, 4);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.Size = new Size(100, 27);
            senhaTextBox.TabIndex = 10;
            // 
            // ativoCheckBox
            // 
            ativoCheckBox.AutoSize = true;
            ativoCheckBox.DataBindings.Add(new Binding("CheckState", usuarioBindingSource, "Ativo", true));
            ativoCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ativoCheckBox.ForeColor = SystemColors.ButtonHighlight;
            ativoCheckBox.Location = new Point(283, 239);
            ativoCheckBox.Margin = new Padding(3, 4, 3, 4);
            ativoCheckBox.Name = "ativoCheckBox";
            ativoCheckBox.Size = new Size(69, 24);
            ativoCheckBox.TabIndex = 13;
            ativoCheckBox.Text = "Ativo";
            ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBoxConfirmarSenha
            // 
            textBoxConfirmarSenha.Cursor = Cursors.IBeam;
            textBoxConfirmarSenha.Location = new Point(112, 237);
            textBoxConfirmarSenha.Margin = new Padding(3, 4, 3, 4);
            textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            textBoxConfirmarSenha.Size = new Size(165, 27);
            textBoxConfirmarSenha.TabIndex = 12;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(50, 153, 204);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Dock = DockStyle.Top;
            label2.Enabled = false;
            label2.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(731, 73);
            label2.TabIndex = 0;
            label2.Text = "CADASTRO DE USUÁRIO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(567, 263);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 39);
            buttonSalvar.TabIndex = 14;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(648, 263);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 39);
            buttonCancelar.TabIndex = 15;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(731, 313);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label2);
            Controls.Add(textBoxConfirmarSenha);
            Controls.Add(ativoCheckBox);
            Controls.Add(label1);
            Controls.Add(senhaLabel);
            Controls.Add(senhaTextBox);
            Controls.Add(nomeUsuarioLabel);
            Controls.Add(nomeUsuarioTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(cPFLabel);
            Controls.Add(cPFTextBox);
            Controls.Add(nomeLabel);
            Controls.Add(nomeTextBox);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroUsuario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCadastroUsuario_Load;
            KeyDown += FormCadastroUsuario_KeyDown;
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox textBoxConfirmarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}