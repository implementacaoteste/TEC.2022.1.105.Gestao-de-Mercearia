namespace UIGestaoMercearia
{
    partial class FormConsultaProduto
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
            panel1 = new Panel();
            buttonCancelar = new Button();
            buttonSelecionar = new Button();
            dataGridViewProduto = new DataGridView();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Custo = new DataGridViewTextBoxColumn();
            codigoDeBarraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSourceProduto = new BindingSource(components);
            comboBoxBuscarPor = new ComboBox();
            textBoxProduto = new TextBox();
            buttonBuscar = new Button();
            buttonAlterar = new Button();
            buttonInserir = new Button();
            buttonEcluir = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProduto).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonSelecionar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 472);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 81);
            panel1.TabIndex = 2;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(842, 25);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(733, 25);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 29);
            buttonSelecionar.TabIndex = 0;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.AllowUserToAddRows = false;
            dataGridViewProduto.AllowUserToDeleteRows = false;
            dataGridViewProduto.AllowUserToOrderColumns = true;
            dataGridViewProduto.AutoGenerateColumns = false;
            dataGridViewProduto.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, precoDataGridViewTextBoxColumn, Custo, codigoDeBarraDataGridViewTextBoxColumn, Quantidade, idDataGridViewTextBoxColumn });
            dataGridViewProduto.DataSource = bindingSourceProduto;
            dataGridViewProduto.Location = new Point(3, 132);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.ReadOnly = true;
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.RowTemplate.Height = 29;
            dataGridViewProduto.Size = new Size(976, 334);
            dataGridViewProduto.TabIndex = 1;
            dataGridViewProduto.DoubleClick += dataGridViewProduto_DoubleClick;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 275;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            descricaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            precoDataGridViewTextBoxColumn.MinimumWidth = 6;
            precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            precoDataGridViewTextBoxColumn.ReadOnly = true;
            precoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Custo
            // 
            Custo.DataPropertyName = "Custo";
            Custo.HeaderText = "Custo";
            Custo.MinimumWidth = 6;
            Custo.Name = "Custo";
            Custo.ReadOnly = true;
            Custo.Width = 125;
            // 
            // codigoDeBarraDataGridViewTextBoxColumn
            // 
            codigoDeBarraDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeBarra";
            codigoDeBarraDataGridViewTextBoxColumn.HeaderText = "CodigoDeBarra";
            codigoDeBarraDataGridViewTextBoxColumn.MinimumWidth = 6;
            codigoDeBarraDataGridViewTextBoxColumn.Name = "codigoDeBarraDataGridViewTextBoxColumn";
            codigoDeBarraDataGridViewTextBoxColumn.ReadOnly = true;
            codigoDeBarraDataGridViewTextBoxColumn.Width = 150;
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 6;
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            Quantidade.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceProduto
            // 
            bindingSourceProduto.DataSource = typeof(Models.Produto);
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id", "Nome", "CodigoDeBarra", "Todos" });
            comboBoxBuscarPor.Location = new Point(3, 108);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(155, 28);
            comboBoxBuscarPor.TabIndex = 2;
            // 
            // textBoxProduto
            // 
            textBoxProduto.Cursor = Cursors.IBeam;
            textBoxProduto.Location = new Point(164, 108);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(402, 27);
            textBoxProduto.TabIndex = 4;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(572, 106);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(672, 106);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(94, 29);
            buttonAlterar.TabIndex = 6;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(772, 106);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(94, 29);
            buttonInserir.TabIndex = 7;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonEcluir
            // 
            buttonEcluir.Location = new Point(868, 106);
            buttonEcluir.Name = "buttonEcluir";
            buttonEcluir.Size = new Size(94, 29);
            buttonEcluir.TabIndex = 8;
            buttonEcluir.Text = "&Excluir";
            buttonEcluir.UseVisualStyleBackColor = true;
            buttonEcluir.Click += buttonExcluir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 153, 204);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(buttonEcluir);
            panel2.Controls.Add(textBoxProduto);
            panel2.Controls.Add(comboBoxBuscarPor);
            panel2.Controls.Add(buttonInserir);
            panel2.Controls.Add(buttonBuscar);
            panel2.Controls.Add(buttonAlterar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 138);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(164, 87);
            label3.Name = "label3";
            label3.Size = new Size(201, 18);
            label3.TabIndex = 3;
            label3.Text = "INSIRA A INFORMAÇÃO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 87);
            label2.Name = "label2";
            label2.Size = new Size(120, 18);
            label2.TabIndex = 1;
            label2.Text = "BUSCAR POR:";
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(987, 46);
            label1.TabIndex = 0;
            label1.Text = "                     CONSULTA DE PRODUTO                        ";
            // 
            // FormConsultaProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(982, 553);
            Controls.Add(panel2);
            Controls.Add(dataGridViewProduto);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaProduto";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormConsultaProduto_Load;
            KeyDown += FormConsultaProduto_KeyDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProduto).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewProduto;
        private BindingSource bindingSourceProduto;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private ComboBox comboBoxBuscarPor;
        private TextBox textBoxProduto;
        private Button buttonBuscar;
        private Button buttonAlterar;
        private Button buttonInserir;
        private Button buttonEcluir;
        private Panel panel2;
        private Button buttonCancelar;
        private Button buttonSelecionar;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Custo;
        private DataGridViewTextBoxColumn codigoDeBarraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}