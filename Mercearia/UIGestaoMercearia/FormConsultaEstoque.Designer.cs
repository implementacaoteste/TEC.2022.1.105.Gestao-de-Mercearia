namespace UIGestaoMercearia
{
    partial class FormConsultaEstoque
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
            bindingSourceEstoque = new BindingSource(components);
            dataGridViewEstoque = new DataGridView();
            datadeEntradaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datadeSaidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estoqueMinimoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estoqueMaximoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IdProduto = new DataGridViewTextBoxColumn();
            labelGerenProd = new Label();
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
            panel1 = new Panel();
            button2 = new Button();
            comboBoxBuscarPor = new ComboBox();
            textBoxBuscarPor = new TextBox();
            buttonBuscar = new Button();
            buttonAlterar = new Button();
            buttonInserir = new Button();
            buttonExcluir = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // bindingSourceEstoque
            // 
            bindingSourceEstoque.DataSource = typeof(Models.Estoque);
            // 
            // dataGridViewEstoque
            // 
            dataGridViewEstoque.AllowUserToAddRows = false;
            dataGridViewEstoque.AllowUserToDeleteRows = false;
            dataGridViewEstoque.AllowUserToOrderColumns = true;
            dataGridViewEstoque.AutoGenerateColumns = false;
            dataGridViewEstoque.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstoque.Columns.AddRange(new DataGridViewColumn[] { datadeEntradaDataGridViewTextBoxColumn, datadeSaidaDataGridViewTextBoxColumn, estoqueMinimoDataGridViewTextBoxColumn, estoqueMaximoDataGridViewTextBoxColumn, IdProduto });
            dataGridViewEstoque.DataSource = bindingSourceEstoque;
            dataGridViewEstoque.Location = new Point(12, 154);
            dataGridViewEstoque.Name = "dataGridViewEstoque";
            dataGridViewEstoque.ReadOnly = true;
            dataGridViewEstoque.RowHeadersWidth = 51;
            dataGridViewEstoque.RowTemplate.Height = 29;
            dataGridViewEstoque.Size = new Size(820, 234);
            dataGridViewEstoque.TabIndex = 8;
            dataGridViewEstoque.DoubleClick += dataGridViewEstoque_DoubleClick;
            // 
            // datadeEntradaDataGridViewTextBoxColumn
            // 
            datadeEntradaDataGridViewTextBoxColumn.DataPropertyName = "DatadeEntrada";
            datadeEntradaDataGridViewTextBoxColumn.HeaderText = "Data de Entrada";
            datadeEntradaDataGridViewTextBoxColumn.MinimumWidth = 6;
            datadeEntradaDataGridViewTextBoxColumn.Name = "datadeEntradaDataGridViewTextBoxColumn";
            datadeEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            datadeEntradaDataGridViewTextBoxColumn.Width = 175;
            // 
            // datadeSaidaDataGridViewTextBoxColumn
            // 
            datadeSaidaDataGridViewTextBoxColumn.DataPropertyName = "DatadeSaida";
            datadeSaidaDataGridViewTextBoxColumn.HeaderText = "Data de Saida";
            datadeSaidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            datadeSaidaDataGridViewTextBoxColumn.Name = "datadeSaidaDataGridViewTextBoxColumn";
            datadeSaidaDataGridViewTextBoxColumn.ReadOnly = true;
            datadeSaidaDataGridViewTextBoxColumn.Width = 175;
            // 
            // estoqueMinimoDataGridViewTextBoxColumn
            // 
            estoqueMinimoDataGridViewTextBoxColumn.DataPropertyName = "EstoqueMinimo";
            estoqueMinimoDataGridViewTextBoxColumn.HeaderText = "Estoque Minimo";
            estoqueMinimoDataGridViewTextBoxColumn.MinimumWidth = 6;
            estoqueMinimoDataGridViewTextBoxColumn.Name = "estoqueMinimoDataGridViewTextBoxColumn";
            estoqueMinimoDataGridViewTextBoxColumn.ReadOnly = true;
            estoqueMinimoDataGridViewTextBoxColumn.Width = 150;
            // 
            // estoqueMaximoDataGridViewTextBoxColumn
            // 
            estoqueMaximoDataGridViewTextBoxColumn.DataPropertyName = "EstoqueMaximo";
            estoqueMaximoDataGridViewTextBoxColumn.HeaderText = "Estoque Maximo";
            estoqueMaximoDataGridViewTextBoxColumn.MinimumWidth = 6;
            estoqueMaximoDataGridViewTextBoxColumn.Name = "estoqueMaximoDataGridViewTextBoxColumn";
            estoqueMaximoDataGridViewTextBoxColumn.ReadOnly = true;
            estoqueMaximoDataGridViewTextBoxColumn.Width = 150;
            // 
            // IdProduto
            // 
            IdProduto.DataPropertyName = "IdProduto";
            IdProduto.HeaderText = "Código do Produto";
            IdProduto.MinimumWidth = 6;
            IdProduto.Name = "IdProduto";
            IdProduto.ReadOnly = true;
            IdProduto.Width = 125;
            // 
            // labelGerenProd
            // 
            labelGerenProd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelGerenProd.AutoSize = true;
            labelGerenProd.BackColor = Color.FromArgb(50, 153, 204);
            labelGerenProd.BorderStyle = BorderStyle.Fixed3D;
            labelGerenProd.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelGerenProd.ForeColor = SystemColors.ButtonFace;
            labelGerenProd.Location = new Point(0, 0);
            labelGerenProd.Name = "labelGerenProd";
            labelGerenProd.Size = new Size(980, 46);
            labelGerenProd.TabIndex = 0;
            labelGerenProd.Text = "                   GERENCIAMENTO DE ESTOQUE                 ";
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSelecionar.Cursor = Cursors.Cross;
            buttonSelecionar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSelecionar.Location = new Point(641, 525);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 38);
            buttonSelecionar.TabIndex = 1;
            buttonSelecionar.Text = "Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Cursor = Cursors.Cross;
            buttonCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(742, 525);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 38);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonSelecionar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 60);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(742, 19);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "&Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id", "Todos" });
            comboBoxBuscarPor.Location = new Point(10, 123);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(105, 28);
            comboBoxBuscarPor.TabIndex = 2;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Cursor = Cursors.IBeam;
            textBoxBuscarPor.Location = new Point(121, 122);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(387, 27);
            textBoxBuscarPor.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(514, 121);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(78, 27);
            buttonBuscar.TabIndex = 4;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(598, 121);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(79, 27);
            buttonAlterar.TabIndex = 5;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(683, 120);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(73, 28);
            buttonInserir.TabIndex = 6;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(762, 120);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(70, 27);
            buttonExcluir.TabIndex = 7;
            buttonExcluir.Text = "&Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 153, 204);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridViewEstoque);
            panel2.Controls.Add(buttonExcluir);
            panel2.Controls.Add(labelGerenProd);
            panel2.Controls.Add(buttonInserir);
            panel2.Controls.Add(buttonAlterar);
            panel2.Controls.Add(buttonBuscar);
            panel2.Controls.Add(textBoxBuscarPor);
            panel2.Controls.Add(comboBoxBuscarPor);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 509);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(848, 66);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(215, 16);
            label2.Name = "label2";
            label2.Size = new Size(375, 44);
            label2.TabIndex = 0;
            label2.Text = "CONSULTA ESTOQUE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(111, 18);
            label1.TabIndex = 1;
            label1.Text = "BUSCAR POR:";
            // 
            // FormConsultaEstoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(848, 456);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaEstoque";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormConsultaEstoque_Load;
            KeyDown += FormConsultaEstoque_KeyDown;
            ((System.ComponentModel.ISupportInitialize)bindingSourceEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSourceEstoque;
        private DataGridView dataGridViewEstoque;
        private Label labelGerenProd;
        private Button buttonSelecionar;
        private Button buttonCancelar;
        private Panel panel1;
        private ComboBox comboBoxBuscarPor;
        private TextBox textBoxBuscarPor;
        private Button buttonBuscar;
        private Button buttonAlterar;
        private Button buttonInserir;
        private Button buttonExcluir;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Button button2;
        private DataGridViewTextBoxColumn datadeEntradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datadeSaidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estoqueMinimoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estoqueMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IdProduto;
    }
}