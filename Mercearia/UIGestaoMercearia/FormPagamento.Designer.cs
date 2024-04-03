namespace UIGestaoMercearia
{
    partial class FormPagamento
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
            panel2 = new Panel();
            panel1 = new Panel();
            buttonAjuda = new Button();
            label4 = new Label();
            label3 = new Label();
            dataGridViewCategoria = new DataGridView();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            trocoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            bindingSourcePagamento = new BindingSource(components);
            panel3 = new Panel();
            buttonInserir = new Button();
            buttonCancelar = new Button();
            buttonExcluir = new Button();
            buttonSelecionar = new Button();
            buttonAlterar = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePagamento).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(154, 108);
            label2.Name = "label2";
            label2.Size = new Size(176, 18);
            label2.TabIndex = 3;
            label2.Text = "INSIRA A INFORMAÇÃO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(111, 18);
            label1.TabIndex = 1;
            label1.Text = "BUSCAR POR:";
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.ButtonHighlight;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Location = new Point(469, 127);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscarPor.Cursor = Cursors.IBeam;
            textBoxBuscarPor.Location = new Point(154, 129);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(309, 27);
            textBoxBuscarPor.TabIndex = 4;
            textBoxBuscarPor.KeyDown += textBoxBuscarPor_KeyDown;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id", "Todos" });
            comboBoxBuscarPor.Location = new Point(12, 130);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(136, 28);
            comboBoxBuscarPor.TabIndex = 2;
            comboBoxBuscarPor.Click += comboBoxBuscarPor_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 153, 204);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 83);
            panel2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonAjuda);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(50, 153, 204);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 83);
            panel1.TabIndex = 0;
            // 
            // buttonAjuda
            // 
            buttonAjuda.BackColor = Color.FromArgb(50, 153, 204);
            buttonAjuda.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAjuda.Cursor = Cursors.Help;
            buttonAjuda.Font = new Font("Swis721 Blk BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjuda.ForeColor = Color.White;
            buttonAjuda.Location = new Point(3, 3);
            buttonAjuda.Name = "buttonAjuda";
            buttonAjuda.Size = new Size(58, 50);
            buttonAjuda.TabIndex = 0;
            buttonAjuda.Text = "?";
            buttonAjuda.UseVisualStyleBackColor = false;
            buttonAjuda.Click += buttonAjuda_Click;
            buttonAjuda.KeyDown += buttonAjuda_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(50, 153, 204);
            label4.Location = new Point(67, 18);
            label4.Name = "label4";
            label4.Size = new Size(426, 44);
            label4.TabIndex = 0;
            label4.Text = "FORMA DE PAGAMENTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 18);
            label3.Name = "label3";
            label3.Size = new Size(423, 44);
            label3.TabIndex = 9;
            label3.Text = "INSIRA A INFORMAÇÃO:";
            // 
            // dataGridViewCategoria
            // 
            dataGridViewCategoria.AllowUserToAddRows = false;
            dataGridViewCategoria.AllowUserToDeleteRows = false;
            dataGridViewCategoria.AllowUserToOrderColumns = true;
            dataGridViewCategoria.AutoGenerateColumns = false;
            dataGridViewCategoria.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategoria.Columns.AddRange(new DataGridViewColumn[] { tipoDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, trocoDataGridViewCheckBoxColumn });
            dataGridViewCategoria.DataSource = bindingSourcePagamento;
            dataGridViewCategoria.Location = new Point(12, 172);
            dataGridViewCategoria.Name = "dataGridViewCategoria";
            dataGridViewCategoria.ReadOnly = true;
            dataGridViewCategoria.RowHeadersWidth = 51;
            dataGridViewCategoria.RowTemplate.Height = 29;
            dataGridViewCategoria.Size = new Size(553, 294);
            dataGridViewCategoria.TabIndex = 0;
            dataGridViewCategoria.DoubleClick += dataGridViewCategoria_DoubleClick;
            dataGridViewCategoria.KeyDown += textBoxBuscarPor_KeyDown;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            tipoDataGridViewTextBoxColumn.Width = 175;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            descricaoDataGridViewTextBoxColumn.Width = 175;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 75;
            // 
            // trocoDataGridViewCheckBoxColumn
            // 
            trocoDataGridViewCheckBoxColumn.DataPropertyName = "Troco";
            trocoDataGridViewCheckBoxColumn.HeaderText = "Troco";
            trocoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            trocoDataGridViewCheckBoxColumn.Name = "trocoDataGridViewCheckBoxColumn";
            trocoDataGridViewCheckBoxColumn.ReadOnly = true;
            trocoDataGridViewCheckBoxColumn.Width = 75;
            // 
            // bindingSourcePagamento
            // 
            bindingSourcePagamento.DataSource = typeof(Models.FormaPagamento);
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 153, 204);
            panel3.Controls.Add(buttonInserir);
            panel3.Controls.Add(buttonCancelar);
            panel3.Controls.Add(buttonExcluir);
            panel3.Controls.Add(buttonSelecionar);
            panel3.Controls.Add(buttonAlterar);
            panel3.Location = new Point(0, 472);
            panel3.Name = "panel3";
            panel3.Size = new Size(583, 50);
            panel3.TabIndex = 6;
            // 
            // buttonInserir
            // 
            buttonInserir.BackColor = SystemColors.ButtonHighlight;
            buttonInserir.FlatStyle = FlatStyle.System;
            buttonInserir.Location = new Point(239, 8);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(96, 29);
            buttonInserir.TabIndex = 2;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = false;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.ButtonHighlight;
            buttonCancelar.FlatStyle = FlatStyle.System;
            buttonCancelar.Location = new Point(469, 8);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(96, 29);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = SystemColors.ButtonHighlight;
            buttonExcluir.FlatStyle = FlatStyle.System;
            buttonExcluir.Location = new Point(358, 8);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(96, 29);
            buttonExcluir.TabIndex = 3;
            buttonExcluir.Text = "&Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.BackColor = SystemColors.ButtonHighlight;
            buttonSelecionar.FlatStyle = FlatStyle.System;
            buttonSelecionar.Location = new Point(11, 8);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(96, 29);
            buttonSelecionar.TabIndex = 0;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = false;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.BackColor = SystemColors.ButtonHighlight;
            buttonAlterar.FlatStyle = FlatStyle.System;
            buttonAlterar.Location = new Point(127, 8);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(96, 29);
            buttonAlterar.TabIndex = 1;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = false;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // FormPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            CancelButton = buttonCancelar;
            ClientSize = new Size(583, 520);
            Controls.Add(label2);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(label1);
            Controls.Add(buttonBuscar);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(panel2);
            Controls.Add(dataGridViewCategoria);
            Controls.Add(panel3);
            ImeMode = ImeMode.Disable;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPagamento";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormPagamento_Load;
            KeyDown += FormPagamento_KeyDown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePagamento).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button buttonBuscar;
        private TextBox textBoxBuscarPor;
        private ComboBox comboBoxBuscarPor;
        private Panel panel2;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private DataGridView dataGridViewCategoria;
        private Panel panel3;
        private Button buttonInserir;
        private Button buttonCancelar;
        private Button buttonExcluir;
        private Button buttonSelecionar;
        private Button buttonAlterar;
        private BindingSource bindingSourcePagamento;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn trocoDataGridViewCheckBoxColumn;
        private Button buttonAjuda;
    }
}