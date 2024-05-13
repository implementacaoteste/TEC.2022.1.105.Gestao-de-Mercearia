namespace UIGestaoMercearia
{
    partial class FormConsultaCategoria
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
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonBuscar = new Button();
            textBoxBuscarPor = new TextBox();
            comboBoxBuscarPor = new ComboBox();
            buttonExcluir = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            dataGridViewCategoria = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bindingSourceCategoria = new BindingSource(components);
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
            panel3 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCategoria).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 80);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(50, 153, 204);
            label3.Location = new Point(93, 20);
            label3.Name = "label3";
            label3.Size = new Size(412, 44);
            label3.TabIndex = 0;
            label3.Text = "INSIRA A INFORMAÇÃO";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(50, 153, 204);
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(155, 95);
            label2.Name = "label2";
            label2.Size = new Size(176, 18);
            label2.TabIndex = 3;
            label2.Text = "INSIRA A INFORMAÇÃO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 95);
            label1.Name = "label1";
            label1.Size = new Size(111, 18);
            label1.TabIndex = 1;
            label1.Text = "BUSCAR POR:";
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.ButtonHighlight;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Location = new Point(471, 117);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscarPor.Cursor = Cursors.IBeam;
            textBoxBuscarPor.Location = new Point(155, 120);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(309, 27);
            textBoxBuscarPor.TabIndex = 4;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id", "Todos" });
            comboBoxBuscarPor.Location = new Point(14, 117);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(137, 28);
            comboBoxBuscarPor.TabIndex = 2;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = SystemColors.ButtonHighlight;
            buttonExcluir.FlatStyle = FlatStyle.System;
            buttonExcluir.ForeColor = SystemColors.ControlText;
            buttonExcluir.Location = new Point(349, 8);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(96, 29);
            buttonExcluir.TabIndex = 3;
            buttonExcluir.Text = "&Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.BackColor = SystemColors.ButtonHighlight;
            buttonInserir.FlatStyle = FlatStyle.System;
            buttonInserir.ForeColor = SystemColors.ControlText;
            buttonInserir.Location = new Point(122, 8);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(96, 29);
            buttonInserir.TabIndex = 1;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = false;
            buttonInserir.Click += buttonInserir_Click_1;
            // 
            // buttonAlterar
            // 
            buttonAlterar.BackColor = SystemColors.ButtonHighlight;
            buttonAlterar.FlatStyle = FlatStyle.System;
            buttonAlterar.ForeColor = SystemColors.ControlText;
            buttonAlterar.Location = new Point(235, 8);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(96, 29);
            buttonAlterar.TabIndex = 2;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = false;
            buttonAlterar.Click += buttonAlterar_Click_1;
            // 
            // dataGridViewCategoria
            // 
            dataGridViewCategoria.AllowUserToAddRows = false;
            dataGridViewCategoria.AllowUserToDeleteRows = false;
            dataGridViewCategoria.AllowUserToOrderColumns = true;
            dataGridViewCategoria.AutoGenerateColumns = false;
            dataGridViewCategoria.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategoria.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn1 });
            dataGridViewCategoria.DataSource = bindingSourceCategoria;
            dataGridViewCategoria.Location = new Point(11, 151);
            dataGridViewCategoria.Name = "dataGridViewCategoria";
            dataGridViewCategoria.ReadOnly = true;
            dataGridViewCategoria.RowHeadersWidth = 51;
            dataGridViewCategoria.RowTemplate.Height = 29;
            dataGridViewCategoria.Size = new Size(553, 387);
            dataGridViewCategoria.TabIndex = 6;
            dataGridViewCategoria.DoubleClick += dataGridViewCategoria_DoubleClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            dataGridViewTextBoxColumn2.HeaderText = "Nome";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 350;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 180;
            // 
            // bindingSourceCategoria
            // 
            bindingSourceCategoria.DataSource = typeof(Models.Categoria);
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.BackColor = SystemColors.ButtonHighlight;
            buttonSelecionar.FlatStyle = FlatStyle.System;
            buttonSelecionar.ForeColor = SystemColors.ControlText;
            buttonSelecionar.Location = new Point(11, 8);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(96, 29);
            buttonSelecionar.TabIndex = 0;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = false;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.ButtonHighlight;
            buttonCancelar.FlatStyle = FlatStyle.System;
            buttonCancelar.ForeColor = SystemColors.ControlText;
            buttonCancelar.Location = new Point(469, 8);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(96, 29);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 153, 204);
            panel3.Controls.Add(buttonInserir);
            panel3.Controls.Add(buttonCancelar);
            panel3.Controls.Add(buttonExcluir);
            panel3.Controls.Add(buttonSelecionar);
            panel3.Controls.Add(buttonAlterar);
            panel3.Location = new Point(0, 544);
            panel3.Name = "panel3";
            panel3.Size = new Size(579, 51);
            panel3.TabIndex = 0;
            // 
            // FormConsultaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            CancelButton = buttonCancelar;
            ClientSize = new Size(579, 593);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(panel2);
            Controls.Add(dataGridViewCategoria);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaCategoria";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormConsultaCategoria_Load;
            KeyDown += FormConsultaCategoria_KeyDown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCategoria).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button buttonExcluir;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonBuscar;
        private TextBox textBoxBuscarPor;
        private ComboBox comboBoxBuscarPor;
        private DataGridView dataGridViewCategoria;
        private BindingSource bindingSourceCategoria;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private Label label2;
        private Label label1;
        private Button buttonSelecionar;
        private Button buttonCancelar;
        private Label label3;
        private Panel panel3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}