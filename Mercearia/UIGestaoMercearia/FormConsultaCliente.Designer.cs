namespace UIGestaoMercearia
{
    partial class FormConsultaCliente
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
            clienteDataGridView = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
            buttonAlterar = new Button();
            buttonInserir = new Button();
            buttonExcluir = new Button();
            comboBoxBuscarPor = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)clienteDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // clienteDataGridView
            // 
            clienteDataGridView.AllowUserToAddRows = false;
            clienteDataGridView.AllowUserToDeleteRows = false;
            clienteDataGridView.AllowUserToOrderColumns = true;
            clienteDataGridView.AutoGenerateColumns = false;
            clienteDataGridView.BackgroundColor = Color.White;
            clienteDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clienteDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn6, CEP, dataGridViewTextBoxColumn1 });
            clienteDataGridView.DataSource = clienteBindingSource;
            clienteDataGridView.Location = new Point(13, 125);
            clienteDataGridView.Margin = new Padding(3, 4, 3, 4);
            clienteDataGridView.Name = "clienteDataGridView";
            clienteDataGridView.ReadOnly = true;
            clienteDataGridView.RowHeadersWidth = 51;
            clienteDataGridView.RowTemplate.Height = 24;
            clienteDataGridView.Size = new Size(835, 291);
            clienteDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            dataGridViewTextBoxColumn2.HeaderText = "Nome";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 225;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            dataGridViewTextBoxColumn5.HeaderText = "Email";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "CPF";
            dataGridViewTextBoxColumn3.HeaderText = "CPF";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Fone";
            dataGridViewTextBoxColumn6.HeaderText = "Fone";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // CEP
            // 
            CEP.DataPropertyName = "CEP";
            CEP.HeaderText = "CEP";
            CEP.MinimumWidth = 6;
            CEP.Name = "CEP";
            CEP.ReadOnly = true;
            CEP.Width = 130;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Models.Cliente);
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
            label1.Size = new Size(848, 55);
            label1.TabIndex = 0;
            label1.Text = "CONSULTA CLIENTE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 1;
            label2.Text = "BUSCAR POR:";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Cursor = Cursors.IBeam;
            textBoxBuscar.Location = new Point(163, 89);
            textBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(349, 27);
            textBoxBuscar.TabIndex = 4;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(518, 89);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 29);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(664, 424);
            buttonSelecionar.Margin = new Padding(3, 4, 3, 4);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(91, 29);
            buttonSelecionar.TabIndex = 10;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(761, 424);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 29);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(599, 89);
            buttonAlterar.Margin = new Padding(3, 4, 3, 4);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(75, 29);
            buttonAlterar.TabIndex = 6;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(680, 89);
            buttonInserir.Margin = new Padding(3, 4, 3, 4);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(75, 29);
            buttonInserir.TabIndex = 7;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(761, 89);
            buttonExcluir.Margin = new Padding(3, 4, 3, 4);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 29);
            buttonExcluir.TabIndex = 8;
            buttonExcluir.Text = "&Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id", "Nome", "CPF", "Todos" });
            comboBoxBuscarPor.Location = new Point(13, 89);
            comboBoxBuscarPor.Margin = new Padding(3, 4, 3, 4);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(144, 28);
            comboBoxBuscarPor.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(163, 67);
            label3.Name = "label3";
            label3.Size = new Size(197, 18);
            label3.TabIndex = 3;
            label3.Text = "INSIRA AS INFORMAÇÕES:";
            // 
            // FormConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            CancelButton = buttonCancelar;
            ClientSize = new Size(848, 464);
            Controls.Add(label3);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSelecionar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonInserir);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clienteDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaCliente";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormConsultaCliente_Load;
            KeyDown += FormConsultaCliente_KeyDown;
            ((System.ComponentModel.ISupportInitialize)clienteDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor;
        private Label label3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}