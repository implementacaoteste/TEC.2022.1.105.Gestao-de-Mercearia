namespace UIGestaoMercearia
{
    partial class FormCadastroMarca
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
            marcaBindingSource = new BindingSource(components);
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            label10 = new Label();
            marcaBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)marcaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)marcaBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(29, 100);
            label1.Name = "label1";
            label1.Size = new Size(153, 18);
            label1.TabIndex = 1;
            label1.Text = "INSIRA UMA MARCA:";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.DataBindings.Add(new Binding("Text", marcaBindingSource, "Nome", true));
            textBox1.Location = new Point(29, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(728, 27);
            textBox1.TabIndex = 2;
            // 
            // marcaBindingSource
            // 
            marcaBindingSource.DataSource = typeof(Models.Marca);
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.White;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancelar.Location = new Point(663, 172);
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
            buttonSalvar.Location = new Point(563, 172);
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
            label10.Text = "CADASTO DE MARCA";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // marcaBindingSource1
            // 
            marcaBindingSource1.DataSource = typeof(Models.Marca);
            // 
            // FormCadastroMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(782, 213);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroMarca";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCadastroMarca_Load;
            KeyDown += FormCadastroMarca_KeyDown;
            ((System.ComponentModel.ISupportInitialize)marcaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)marcaBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label label10;
        private BindingSource marcaBindingSource;
        private BindingSource marcaBindingSource1;
    }
}