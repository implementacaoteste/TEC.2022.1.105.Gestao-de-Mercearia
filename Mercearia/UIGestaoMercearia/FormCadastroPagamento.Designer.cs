namespace UIGestaoMercearia
{
    partial class FormCadastroPagamento
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
            textBox1 = new TextBox();
            formaPagamentoBindingSource = new BindingSource(components);
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            label10 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)formaPagamentoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(108, 77);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Tipo:";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.DataBindings.Add(new Binding("Text", formaPagamentoBindingSource, "Tipo", true));
            textBox1.Location = new Point(108, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(401, 27);
            textBox1.TabIndex = 2;
            // 
            // formaPagamentoBindingSource
            // 
            formaPagamentoBindingSource.DataSource = typeof(Models.FormaPagamento);
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.White;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancelar.Location = new Point(313, 334);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Azure;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Location = new Point(213, 334);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(50, 153, 204);
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(694, 61);
            label10.TabIndex = 0;
            label10.Text = "CADASTO DE FORMA DE PAGAMENTO";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", formaPagamentoBindingSource, "Descricao", true));
            textBox2.Location = new Point(108, 166);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(408, 112);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(108, 139);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.DataBindings.Add(new Binding("CheckState", formaPagamentoBindingSource, "Troco", true));
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Swis721 Blk BT", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(231, 294);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(139, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Aceita Troco";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormCadastroPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            CancelButton = buttonCancelar;
            ClientSize = new Size(694, 375);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label10);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroPagamento";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCadastroPagamento_Load;
            KeyDown += FormCadastroPagamento_KeyDown;
            ((System.ComponentModel.ISupportInitialize)formaPagamentoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label label10;
        private TextBox textBox2;
        private Label label2;
        private CheckBox checkBox1;
        private BindingSource formaPagamentoBindingSource;
    }
}