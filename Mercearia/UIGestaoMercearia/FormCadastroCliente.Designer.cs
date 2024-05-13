namespace UIGestaoMercearia
{
    partial class FormCadastroCliente
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
            Label foneLabel;
            Label emailLabel;
            Label label2;
            Label label3;
            nomeTextBox = new TextBox();
            clienteBindingSource = new BindingSource(components);
            TextBoxCpf = new TextBox();
            foneTextBox = new TextBox();
            emailTextBox = new TextBox();
            label1 = new Label();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            textBoxCEP = new TextBox();
            textBoxEndereco = new TextBox();
            nomeLabel = new Label();
            cPFLabel = new Label();
            foneLabel = new Label();
            emailLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nomeLabel.ForeColor = SystemColors.ButtonHighlight;
            nomeLabel.Location = new Point(12, 74);
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
            cPFLabel.Location = new Point(430, 74);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new Size(38, 18);
            cPFLabel.TabIndex = 3;
            cPFLabel.Text = "CPF";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            foneLabel.ForeColor = SystemColors.ButtonHighlight;
            foneLabel.Location = new Point(230, 129);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new Size(42, 18);
            foneLabel.TabIndex = 7;
            foneLabel.Text = "Fone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.ButtonHighlight;
            emailLabel.Location = new Point(12, 129);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(50, 18);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(430, 129);
            label2.Name = "label2";
            label2.Size = new Size(39, 18);
            label2.TabIndex = 9;
            label2.Text = "CEP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(10, 184);
            label3.Name = "label3";
            label3.Size = new Size(72, 18);
            label3.TabIndex = 11;
            label3.Text = "Endereco";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Cursor = Cursors.IBeam;
            nomeTextBox.DataBindings.Add(new Binding("Text", clienteBindingSource, "Nome", true));
            nomeTextBox.ForeColor = SystemColors.ActiveCaptionText;
            nomeTextBox.Location = new Point(12, 98);
            nomeTextBox.Margin = new Padding(3, 4, 3, 4);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(412, 27);
            nomeTextBox.TabIndex = 2;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // TextBoxCpf
            // 
            TextBoxCpf.Cursor = Cursors.IBeam;
            TextBoxCpf.DataBindings.Add(new Binding("Text", clienteBindingSource, "CPF", true));
            TextBoxCpf.ForeColor = SystemColors.ActiveCaptionText;
            TextBoxCpf.Location = new Point(430, 98);
            TextBoxCpf.Margin = new Padding(3, 4, 3, 4);
            TextBoxCpf.Name = "TextBoxCpf";
            TextBoxCpf.Size = new Size(222, 27);
            TextBoxCpf.TabIndex = 4;
            // 
            // foneTextBox
            // 
            foneTextBox.Cursor = Cursors.IBeam;
            foneTextBox.DataBindings.Add(new Binding("Text", clienteBindingSource, "Fone", true));
            foneTextBox.ForeColor = SystemColors.ActiveCaptionText;
            foneTextBox.Location = new Point(230, 153);
            foneTextBox.Margin = new Padding(3, 4, 3, 4);
            foneTextBox.Name = "foneTextBox";
            foneTextBox.Size = new Size(194, 27);
            foneTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            emailTextBox.Cursor = Cursors.IBeam;
            emailTextBox.DataBindings.Add(new Binding("Text", clienteBindingSource, "Email", true));
            emailTextBox.ForeColor = SystemColors.ActiveCaptionText;
            emailTextBox.Location = new Point(12, 153);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(212, 27);
            emailTextBox.TabIndex = 6;
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
            label1.Size = new Size(670, 61);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO DE CLIENTE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.White;
            buttonSalvar.Location = new Point(480, 306);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 29);
            buttonSalvar.TabIndex = 13;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.White;
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(561, 306);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 29);
            buttonCancelar.TabIndex = 14;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxCEP
            // 
            textBoxCEP.Cursor = Cursors.IBeam;
            textBoxCEP.DataBindings.Add(new Binding("Text", clienteBindingSource, "CEP", true));
            textBoxCEP.ForeColor = SystemColors.ActiveCaptionText;
            textBoxCEP.Location = new Point(430, 153);
            textBoxCEP.Margin = new Padding(3, 4, 3, 4);
            textBoxCEP.Name = "textBoxCEP";
            textBoxCEP.Size = new Size(222, 27);
            textBoxCEP.TabIndex = 10;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Cursor = Cursors.IBeam;
            textBoxEndereco.DataBindings.Add(new Binding("Text", clienteBindingSource, "Endereco", true));
            textBoxEndereco.ForeColor = SystemColors.ActiveCaptionText;
            textBoxEndereco.Location = new Point(10, 208);
            textBoxEndereco.Margin = new Padding(3, 4, 3, 4);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(412, 27);
            textBoxEndereco.TabIndex = 12;
            // 
            // FormCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(670, 348);
            Controls.Add(label3);
            Controls.Add(textBoxEndereco);
            Controls.Add(label2);
            Controls.Add(textBoxCEP);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label1);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(foneLabel);
            Controls.Add(foneTextBox);
            Controls.Add(cPFLabel);
            Controls.Add(TextBoxCpf);
            Controls.Add(nomeLabel);
            Controls.Add(nomeTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCadastroCliente_Load;
            KeyDown += FormCadastroCliente_KeyDown;
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox TextBoxCpf;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private TextBox textBoxCEP;
        private TextBox textBoxEndereco;
    }
}