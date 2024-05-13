namespace UIGestaoMercearia
{
    partial class FormCadastroCategoria
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
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            label10 = new Label();
            textBox1Nome = new TextBox();
            categoriaBindingSource = new BindingSource(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.White;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = Color.Black;
            buttonCancelar.Location = new Point(664, 159);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Azure;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Location = new Point(564, 159);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 3;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(50, 153, 204);
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(782, 61);
            label10.TabIndex = 0;
            label10.Text = "CADASTRO DE CATEGORIA";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1Nome
            // 
            textBox1Nome.Cursor = Cursors.IBeam;
            textBox1Nome.DataBindings.Add(new Binding("Text", categoriaBindingSource, "Nome", true));
            textBox1Nome.Location = new Point(26, 110);
            textBox1Nome.Name = "textBox1Nome";
            textBox1Nome.Size = new Size(728, 27);
            textBox1Nome.TabIndex = 2;
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Models.Categoria);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(26, 89);
            label1.Name = "label1";
            label1.Size = new Size(182, 18);
            label1.TabIndex = 1;
            label1.Text = "INSIRA UMA CATEGORIA";
            // 
            // FormCadastroCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            CancelButton = buttonCancelar;
            ClientSize = new Size(782, 203);
            Controls.Add(label1);
            Controls.Add(textBox1Nome);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label10);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroCategoria";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCadastroCategoria_Load;
            KeyDown += FormCadastroCategoria_KeyDown;
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label label10;
        private TextBox textBox1Nome;
        private Label label1;
        private BindingSource categoriaBindingSource;
    }
}