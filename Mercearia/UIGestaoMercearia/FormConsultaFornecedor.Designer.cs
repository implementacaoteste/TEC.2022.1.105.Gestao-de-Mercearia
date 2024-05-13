namespace UIGestaoMercearia
{
    partial class FormConsultaFornecedor
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
            dataGridViewFornecedor = new DataGridView();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Endereco = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cEPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            bindingSourceFornecedor = new BindingSource(components);
            buttonBuscar = new Button();
            buttonAlterar = new Button();
            buttonInserir = new Button();
            buttonExcluir = new Button();
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
            textBoxBuscarPor = new TextBox();
            comboBoxBuscarPor = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFornecedor).BeginInit();
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
            label1.Size = new Size(982, 60);
            label1.TabIndex = 0;
            label1.Text = "CONSULTA FORNECEDOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewFornecedor
            // 
            dataGridViewFornecedor.AllowUserToAddRows = false;
            dataGridViewFornecedor.AllowUserToDeleteRows = false;
            dataGridViewFornecedor.AllowUserToOrderColumns = true;
            dataGridViewFornecedor.AutoGenerateColumns = false;
            dataGridViewFornecedor.BackgroundColor = Color.White;
            dataGridViewFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFornecedor.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, Endereco, emailDataGridViewTextBoxColumn, foneDataGridViewTextBoxColumn, cEPDataGridViewTextBoxColumn, Id });
            dataGridViewFornecedor.DataSource = bindingSourceFornecedor;
            dataGridViewFornecedor.Location = new Point(12, 122);
            dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            dataGridViewFornecedor.ReadOnly = true;
            dataGridViewFornecedor.RowHeadersWidth = 51;
            dataGridViewFornecedor.RowTemplate.Height = 29;
            dataGridViewFornecedor.Size = new Size(958, 367);
            dataGridViewFornecedor.TabIndex = 9;
            dataGridViewFornecedor.DoubleClick += dataGridViewFornecedor_DoubleClick;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // Endereco
            // 
            Endereco.DataPropertyName = "Endereco";
            Endereco.HeaderText = "Endereco";
            Endereco.MinimumWidth = 6;
            Endereco.Name = "Endereco";
            Endereco.ReadOnly = true;
            Endereco.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 175;
            // 
            // foneDataGridViewTextBoxColumn
            // 
            foneDataGridViewTextBoxColumn.DataPropertyName = "Fone";
            foneDataGridViewTextBoxColumn.HeaderText = "Fone";
            foneDataGridViewTextBoxColumn.MinimumWidth = 6;
            foneDataGridViewTextBoxColumn.Name = "foneDataGridViewTextBoxColumn";
            foneDataGridViewTextBoxColumn.ReadOnly = true;
            foneDataGridViewTextBoxColumn.Width = 150;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            cEPDataGridViewTextBoxColumn.MinimumWidth = 6;
            cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            cEPDataGridViewTextBoxColumn.ReadOnly = true;
            cEPDataGridViewTextBoxColumn.Width = 175;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // bindingSourceFornecedor
            // 
            bindingSourceFornecedor.DataSource = typeof(Models.Fornecedor);
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(576, 87);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(676, 87);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(94, 29);
            buttonAlterar.TabIndex = 6;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(776, 87);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(94, 29);
            buttonInserir.TabIndex = 7;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(876, 87);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(94, 29);
            buttonExcluir.TabIndex = 8;
            buttonExcluir.Text = "&Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(776, 512);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 29);
            buttonSelecionar.TabIndex = 10;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(876, 512);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Cursor = Cursors.IBeam;
            textBoxBuscarPor.Location = new Point(151, 89);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(419, 27);
            textBoxBuscarPor.TabIndex = 4;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Nome", "Id", "Todos" });
            comboBoxBuscarPor.Location = new Point(12, 89);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(133, 28);
            comboBoxBuscarPor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 1;
            label2.Text = "BUSCAR POR:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(151, 66);
            label3.Name = "label3";
            label3.Size = new Size(197, 18);
            label3.TabIndex = 3;
            label3.Text = "INSIRA AS INFORMAÇÕES:";
            // 
            // FormConsultaFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            CancelButton = buttonCancelar;
            ClientSize = new Size(982, 553);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSelecionar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonInserir);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonBuscar);
            Controls.Add(dataGridViewFornecedor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaFornecedor";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormConsultaFornecedor_Load;
            KeyDown += FormConsultaFornecedor_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewFornecedor;
        private Button buttonBuscar;
        private Button buttonAlterar;
        private Button buttonInserir;
        private Button buttonExcluir;
        private Button buttonSelecionar;
        private Button buttonCancelar;
        private TextBox textBoxBuscarPor;
        private ComboBox comboBoxBuscarPor;
        private BindingSource bindingSourceFornecedor;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Endereco;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Id;
    }
}