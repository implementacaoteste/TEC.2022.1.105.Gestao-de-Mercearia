namespace UIGestaoMercearia
{
    partial class FormCadastroEstoque
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
            panel1 = new Panel();
            textBoxNomeProduto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            bindingSourceEstoque = new BindingSource(components);
            textBoxQtdEstoque = new TextBox();
            textBoxEstoqueMaximo = new TextBox();
            textBoxDataEntrada = new TextBox();
            textBoxEstoqueMinimo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonBuscarProduto = new Button();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEstoque).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(380, 44);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO ESTOQUE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 75);
            panel1.TabIndex = 0;
            // 
            // textBoxNomeProduto
            // 
            textBoxNomeProduto.Location = new Point(41, 121);
            textBoxNomeProduto.Name = "textBoxNomeProduto";
            textBoxNomeProduto.Size = new Size(215, 27);
            textBoxNomeProduto.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(343, 100);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 8;
            label2.Text = "Data de Entrada:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(343, 185);
            label3.Name = "label3";
            label3.Size = new Size(104, 18);
            label3.TabIndex = 10;
            label3.Text = "Data de Saída:";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSourceEstoque, "DatadeSaida", true));
            textBox2.Location = new Point(343, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 27);
            textBox2.TabIndex = 11;
            // 
            // bindingSourceEstoque
            // 
            bindingSourceEstoque.DataSource = typeof(Models.Estoque);
            // 
            // textBoxQtdEstoque
            // 
            textBoxQtdEstoque.Location = new Point(41, 206);
            textBoxQtdEstoque.Name = "textBoxQtdEstoque";
            textBoxQtdEstoque.Size = new Size(215, 27);
            textBoxQtdEstoque.TabIndex = 5;
            // 
            // textBoxEstoqueMaximo
            // 
            textBoxEstoqueMaximo.DataBindings.Add(new Binding("Text", bindingSourceEstoque, "EstoqueMaximo", true));
            textBoxEstoqueMaximo.Location = new Point(41, 293);
            textBoxEstoqueMaximo.Name = "textBoxEstoqueMaximo";
            textBoxEstoqueMaximo.Size = new Size(216, 27);
            textBoxEstoqueMaximo.TabIndex = 7;
            // 
            // textBoxDataEntrada
            // 
            textBoxDataEntrada.DataBindings.Add(new Binding("Text", bindingSourceEstoque, "DatadeEntrada", true));
            textBoxDataEntrada.Location = new Point(343, 121);
            textBoxDataEntrada.Name = "textBoxDataEntrada";
            textBoxDataEntrada.Size = new Size(216, 27);
            textBoxDataEntrada.TabIndex = 9;
            // 
            // textBoxEstoqueMinimo
            // 
            textBoxEstoqueMinimo.DataBindings.Add(new Binding("Text", bindingSourceEstoque, "EstoqueMinimo", true));
            textBoxEstoqueMinimo.Location = new Point(343, 293);
            textBoxEstoqueMinimo.Name = "textBoxEstoqueMinimo";
            textBoxEstoqueMinimo.Size = new Size(215, 27);
            textBoxEstoqueMinimo.TabIndex = 13;
            textBoxEstoqueMinimo.TextChanged += textBox6_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(41, 272);
            label4.Name = "label4";
            label4.Size = new Size(120, 18);
            label4.TabIndex = 6;
            label4.Text = "Estoque Máximo";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(343, 272);
            label5.Name = "label5";
            label5.Size = new Size(116, 18);
            label5.TabIndex = 12;
            label5.Text = "Estoque Mínimo";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(41, 100);
            label6.Name = "label6";
            label6.Size = new Size(61, 18);
            label6.TabIndex = 1;
            label6.Text = "Produto";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(41, 185);
            label7.Name = "label7";
            label7.Size = new Size(167, 18);
            label7.TabIndex = 4;
            label7.Text = "Quantidade em Estoque";
            // 
            // buttonBuscarProduto
            // 
            buttonBuscarProduto.Location = new Point(262, 119);
            buttonBuscarProduto.Name = "buttonBuscarProduto";
            buttonBuscarProduto.Size = new Size(36, 29);
            buttonBuscarProduto.TabIndex = 3;
            buttonBuscarProduto.Text = "...";
            buttonBuscarProduto.UseVisualStyleBackColor = true;
            buttonBuscarProduto.Click += buttonBuscarProduto_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(465, 350);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 15;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(365, 350);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 14;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // FormCadastroEstoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 155, 205);
            CancelButton = buttonCancelar;
            ClientSize = new Size(653, 411);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonBuscarProduto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxEstoqueMinimo);
            Controls.Add(textBoxDataEntrada);
            Controls.Add(textBoxEstoqueMaximo);
            Controls.Add(textBoxQtdEstoque);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxNomeProduto);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroEstoque";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormeCadastroEstoque_Load;
            KeyDown += FormCadastroEstoque_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textBoxNomeProduto;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBoxQtdEstoque;
        private TextBox textBoxEstoqueMaximo;
        private TextBox textBoxDataEntrada;
        private TextBox textBoxEstoqueMinimo;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonBuscarProduto;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private BindingSource bindingSourceEstoque;
    }
}