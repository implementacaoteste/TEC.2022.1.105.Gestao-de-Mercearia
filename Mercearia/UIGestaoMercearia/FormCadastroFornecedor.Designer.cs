namespace UIGestaoMercearia
{
    partial class FormCadastroFornecedor
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
            label2 = new Label();
            textBoxNome = new TextBox();
            fornecedorBindingSource = new BindingSource(components);
            label3 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            textBoxFone = new TextBox();
            label5 = new Label();
            textBoxCep = new TextBox();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            textBoxEndereco = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)fornecedorBindingSource).BeginInit();
            SuspendLayout();
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
            label1.Size = new Size(636, 61);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO DE FORNECEDOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(49, 18);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.DataBindings.Add(new Binding("Text", fornecedorBindingSource, "Nome", true));
            textBoxNome.Location = new Point(12, 94);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(539, 27);
            textBoxNome.TabIndex = 2;
            // 
            // fornecedorBindingSource
            // 
            fornecedorBindingSource.DataSource = typeof(Models.Fornecedor);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(42, 18);
            label3.TabIndex = 3;
            label3.Text = "Fone";
            // 
            // textBoxEmail
            // 
            textBoxEmail.DataBindings.Add(new Binding("Text", fornecedorBindingSource, "Email", true));
            textBoxEmail.Location = new Point(288, 147);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(263, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(288, 124);
            label4.Name = "label4";
            label4.Size = new Size(50, 18);
            label4.TabIndex = 5;
            label4.Text = "E-mail";
            // 
            // textBoxFone
            // 
            textBoxFone.DataBindings.Add(new Binding("Text", fornecedorBindingSource, "Fone", true));
            textBoxFone.Location = new Point(12, 147);
            textBoxFone.Name = "textBoxFone";
            textBoxFone.Size = new Size(270, 27);
            textBoxFone.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 186);
            label5.Name = "label5";
            label5.Size = new Size(39, 18);
            label5.TabIndex = 7;
            label5.Text = "CEP";
            // 
            // textBoxCep
            // 
            textBoxCep.DataBindings.Add(new Binding("Text", fornecedorBindingSource, "CEP", true));
            textBoxCep.Location = new Point(12, 209);
            textBoxCep.Name = "textBoxCep";
            textBoxCep.Size = new Size(131, 27);
            textBoxCep.TabIndex = 8;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.White;
            buttonSalvar.ForeColor = SystemColors.ControlText;
            buttonSalvar.Location = new Point(448, 290);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 29);
            buttonSalvar.TabIndex = 11;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.White;
            buttonCancelar.Location = new Point(529, 290);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(82, 29);
            buttonCancelar.TabIndex = 12;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += button2_Click;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.DataBindings.Add(new Binding("Text", fornecedorBindingSource, "Endereco", true));
            textBoxEndereco.Location = new Point(149, 209);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(402, 27);
            textBoxEndereco.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(149, 186);
            label6.Name = "label6";
            label6.Size = new Size(48, 18);
            label6.TabIndex = 9;
            label6.Text = "Bairro";
            // 
            // FormCadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            CancelButton = buttonCancelar;
            ClientSize = new Size(636, 331);
            Controls.Add(label6);
            Controls.Add(textBoxEndereco);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxCep);
            Controls.Add(label5);
            Controls.Add(textBoxFone);
            Controls.Add(label4);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(textBoxNome);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroFornecedor";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCadastroFornecedor_Load;
            KeyDown += FormCadastroFornecedor_KeyDown;
            ((System.ComponentModel.ISupportInitialize)fornecedorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNome;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private TextBox textBoxFone;
        private Label label5;
        private TextBox textBoxCep;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private BindingSource fornecedorBindingSource;
        private TextBox textBoxEndereco;
        private Label label6;
    }
}