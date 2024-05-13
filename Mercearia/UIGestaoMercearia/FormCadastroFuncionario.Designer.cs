namespace UIGestaoMercearia
{
    partial class FormCadastroFuncionario
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
            label1 = new Label();
            textBoxNome = new TextBox();
            bindingSourceCadastrarFuncionario = new BindingSource(components);
            textBoxFone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxProfissao = new TextBox();
            label5 = new Label();
            textBoxSalario = new TextBox();
            ativoCheckBox = new CheckBox();
            buttonSalvar = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarFuncionario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(704, 61);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO DE FUNCIONÁRIO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNome
            // 
            textBoxNome.Cursor = Cursors.IBeam;
            textBoxNome.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFuncionario, "Nome", true));
            textBoxNome.Location = new Point(12, 100);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(611, 27);
            textBoxNome.TabIndex = 2;
            // 
            // bindingSourceCadastrarFuncionario
            // 
            bindingSourceCadastrarFuncionario.DataSource = typeof(Models.Funcionario);
            // 
            // textBoxFone
            // 
            textBoxFone.Cursor = Cursors.IBeam;
            textBoxFone.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFuncionario, "Telefone", true));
            textBoxFone.Location = new Point(335, 153);
            textBoxFone.Name = "textBoxFone";
            textBoxFone.Size = new Size(218, 27);
            textBoxFone.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(49, 18);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(335, 130);
            label3.Name = "label3";
            label3.Size = new Size(42, 18);
            label3.TabIndex = 5;
            label3.Text = "Fone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 8;
            label4.Text = "Profissão";
            // 
            // textBoxProfissao
            // 
            textBoxProfissao.Cursor = Cursors.IBeam;
            textBoxProfissao.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFuncionario, "Profissao", true));
            textBoxProfissao.Location = new Point(12, 206);
            textBoxProfissao.Name = "textBoxProfissao";
            textBoxProfissao.Size = new Size(360, 27);
            textBoxProfissao.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 130);
            label5.Name = "label5";
            label5.Size = new Size(54, 18);
            label5.TabIndex = 3;
            label5.Text = "Salario";
            // 
            // textBoxSalario
            // 
            textBoxSalario.Cursor = Cursors.IBeam;
            textBoxSalario.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFuncionario, "Salario", true));
            textBoxSalario.Location = new Point(12, 153);
            textBoxSalario.Name = "textBoxSalario";
            textBoxSalario.Size = new Size(317, 27);
            textBoxSalario.TabIndex = 4;
            // 
            // ativoCheckBox
            // 
            ativoCheckBox.AutoSize = true;
            ativoCheckBox.DataBindings.Add(new Binding("Checked", bindingSourceCadastrarFuncionario, "Ativo", true));
            ativoCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ativoCheckBox.ForeColor = SystemColors.ButtonHighlight;
            ativoCheckBox.Location = new Point(562, 156);
            ativoCheckBox.Margin = new Padding(3, 4, 3, 4);
            ativoCheckBox.Name = "ativoCheckBox";
            ativoCheckBox.Size = new Size(69, 24);
            ativoCheckBox.TabIndex = 7;
            ativoCheckBox.Text = "Ativo";
            ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.White;
            buttonSalvar.Location = new Point(482, 276);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 10;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(582, 276);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "&Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(704, 316);
            Controls.Add(button2);
            Controls.Add(buttonSalvar);
            Controls.Add(ativoCheckBox);
            Controls.Add(textBoxSalario);
            Controls.Add(label5);
            Controls.Add(textBoxProfissao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxFone);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroFuncionario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCadastroFuncionario_Load;
            KeyDown += FormCadastroFuncionario_KeyDown;
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private TextBox textBoxFone;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxProfissao;
        private Label label5;
        private TextBox textBoxSalario;
        private CheckBox ativoCheckBox;
        private Button buttonSalvar;
        private Button button2;
        private BindingSource bindingSourceCadastrarFuncionario;
    }
}