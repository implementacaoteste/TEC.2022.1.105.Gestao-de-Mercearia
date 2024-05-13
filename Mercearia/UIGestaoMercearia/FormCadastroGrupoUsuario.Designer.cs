namespace UIGestaoMercearia
{
    partial class FormCadastroGrupoUsuario
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
            Label nomeGrupoLabel;
            Label label1;
            Label label2;
            nomeGrupoTextBox = new TextBox();
            grupoUsuarioBindingSource = new BindingSource(components);
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            textBoxPermissoes = new TextBox();
            nomeGrupoLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nomeGrupoLabel.ForeColor = SystemColors.ButtonHighlight;
            nomeGrupoLabel.Location = new Point(12, 80);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new Size(145, 18);
            nomeGrupoLabel.TabIndex = 1;
            nomeGrupoLabel.Text = "NOME DO GRUPO:";
            nomeGrupoLabel.Click += nomeGrupoLabel_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(621, 58);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de grupo de usuário";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 3;
            label2.Text = "PERMISSÕES:";
            // 
            // nomeGrupoTextBox
            // 
            nomeGrupoTextBox.Cursor = Cursors.IBeam;
            nomeGrupoTextBox.DataBindings.Add(new Binding("Text", grupoUsuarioBindingSource, "NomeGrupo", true));
            nomeGrupoTextBox.Location = new Point(12, 104);
            nomeGrupoTextBox.Margin = new Padding(3, 4, 3, 4);
            nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            nomeGrupoTextBox.Size = new Size(536, 27);
            nomeGrupoTextBox.TabIndex = 2;
            // 
            // grupoUsuarioBindingSource
            // 
            grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Azure;
            buttonSalvar.ForeColor = SystemColors.ControlText;
            buttonSalvar.Location = new Point(438, 259);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 29);
            buttonSalvar.TabIndex = 5;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.AliceBlue;
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(519, 259);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 29);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxPermissoes
            // 
            textBoxPermissoes.Cursor = Cursors.IBeam;
            textBoxPermissoes.Location = new Point(12, 167);
            textBoxPermissoes.Name = "textBoxPermissoes";
            textBoxPermissoes.Size = new Size(536, 27);
            textBoxPermissoes.TabIndex = 4;
            // 
            // FormCadastroGrupoUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(621, 301);
            Controls.Add(textBoxPermissoes);
            Controls.Add(label2);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label1);
            Controls.Add(nomeGrupoLabel);
            Controls.Add(nomeGrupoTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroGrupoUsuario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCadastroGrupoUsuario_Load;
            KeyDown += FormCadastroGrupoUsuario_KeyDown;
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private TextBox textBoxPermissoes;
    }
}