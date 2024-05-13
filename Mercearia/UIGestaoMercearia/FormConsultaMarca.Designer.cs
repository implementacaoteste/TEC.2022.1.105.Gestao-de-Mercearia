namespace UIGestaoMercearia
{
    partial class FormConsultaMarca
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
            label2 = new Label();
            label1 = new Label();
            buttonBuscar = new Button();
            textBoxBuscarPor = new TextBox();
            comboBoxBuscarPor = new ComboBox();
            buttonExcluir = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            dataGridViewMarca = new DataGridView();
            bindingSourceMarca = new BindingSource(components);
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
            label3 = new Label();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMarca).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(150, 87);
            label2.Name = "label2";
            label2.Size = new Size(176, 18);
            label2.TabIndex = 3;
            label2.Text = "INSIRA A INFORMAÇÃO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 87);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 1;
            label1.Text = "BUSCAR POR";
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.ButtonHighlight;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Location = new Point(502, 111);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(107, 29);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Cursor = Cursors.IBeam;
            textBoxBuscarPor.Location = new Point(150, 111);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(346, 27);
            textBoxBuscarPor.TabIndex = 4;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id", "Todos" });
            comboBoxBuscarPor.Location = new Point(14, 110);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(131, 28);
            comboBoxBuscarPor.TabIndex = 2;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = SystemColors.ButtonHighlight;
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Location = new Point(314, 530);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(94, 29);
            buttonExcluir.TabIndex = 10;
            buttonExcluir.Text = "&Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.BackColor = SystemColors.ButtonHighlight;
            buttonInserir.FlatStyle = FlatStyle.Flat;
            buttonInserir.Location = new Point(114, 530);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(94, 29);
            buttonInserir.TabIndex = 8;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = false;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.BackColor = SystemColors.ButtonHighlight;
            buttonAlterar.FlatStyle = FlatStyle.Flat;
            buttonAlterar.Location = new Point(14, 530);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(94, 29);
            buttonAlterar.TabIndex = 7;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = false;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // dataGridViewMarca
            // 
            dataGridViewMarca.AllowUserToAddRows = false;
            dataGridViewMarca.AllowUserToDeleteRows = false;
            dataGridViewMarca.AllowUserToOrderColumns = true;
            dataGridViewMarca.AutoGenerateColumns = false;
            dataGridViewMarca.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMarca.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn });
            dataGridViewMarca.DataSource = bindingSourceMarca;
            dataGridViewMarca.Location = new Point(13, 144);
            dataGridViewMarca.Name = "dataGridViewMarca";
            dataGridViewMarca.ReadOnly = true;
            dataGridViewMarca.RowHeadersWidth = 51;
            dataGridViewMarca.RowTemplate.Height = 29;
            dataGridViewMarca.Size = new Size(596, 380);
            dataGridViewMarca.TabIndex = 6;
            dataGridViewMarca.DoubleClick += dataGridViewMarca_DoubleClick;
            // 
            // bindingSourceMarca
            // 
            bindingSourceMarca.DataSource = typeof(Models.Marca);
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.BackColor = SystemColors.ButtonHighlight;
            buttonSelecionar.FlatStyle = FlatStyle.Flat;
            buttonSelecionar.Location = new Point(214, 530);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 29);
            buttonSelecionar.TabIndex = 9;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = false;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.ButtonHighlight;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Location = new Point(515, 530);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(50, 153, 204);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(621, 67);
            label3.TabIndex = 0;
            label3.Text = "GERENCIAMENTO DE MARCAS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 400;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 180;
            // 
            // FormConsultaMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            CancelButton = buttonCancelar;
            ClientSize = new Size(621, 574);
            Controls.Add(label3);
            Controls.Add(buttonCancelar);
            Controls.Add(label2);
            Controls.Add(buttonSelecionar);
            Controls.Add(buttonAlterar);
            Controls.Add(label1);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonInserir);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(buttonExcluir);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(dataGridViewMarca);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaMarca";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormConsultaMarca_Load;
            KeyDown += FormConsultaMarca_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarca).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMarca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonExcluir;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonBuscar;
        private TextBox textBoxBuscarPor;
        private ComboBox comboBoxBuscarPor;
        private DataGridView dataGridViewMarca;
        private BindingSource bindingSourceMarca;
        private Label label2;
        private Label label1;
        private Button buttonSelecionar;
        private Button buttonCancelar;
        private Label label3;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}