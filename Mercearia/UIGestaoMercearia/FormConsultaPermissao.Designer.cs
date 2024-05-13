namespace UIGestaoMercearia
{
    partial class FormConsultaPermissao
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
            permissaoDataGridView = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            permissaoBindingSource = new BindingSource(components);
            label2 = new Label();
            label1 = new Label();
            textBoxBuscar = new TextBox();
            buttonCancelar = new Button();
            buttonBuscar = new Button();
            buttonSelecionar = new Button();
            ((System.ComponentModel.ISupportInitialize)permissaoDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)permissaoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // permissaoDataGridView
            // 
            permissaoDataGridView.AutoGenerateColumns = false;
            permissaoDataGridView.BackgroundColor = Color.White;
            permissaoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            permissaoDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2 });
            permissaoDataGridView.DataSource = permissaoBindingSource;
            permissaoDataGridView.GridColor = Color.Silver;
            permissaoDataGridView.Location = new Point(12, 147);
            permissaoDataGridView.Margin = new Padding(3, 4, 3, 4);
            permissaoDataGridView.Name = "permissaoDataGridView";
            permissaoDataGridView.RowHeadersWidth = 51;
            permissaoDataGridView.RowTemplate.Height = 24;
            permissaoDataGridView.Size = new Size(776, 411);
            permissaoDataGridView.TabIndex = 4;
            permissaoDataGridView.MouseDoubleClick += permissaoDataGridView_MouseDoubleClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            dataGridViewTextBoxColumn2.HeaderText = "Permissões a serem adicionadas";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // permissaoBindingSource
            // 
            permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(50, 153, 204);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(800, 67);
            label2.TabIndex = 0;
            label2.Text = "CONSULTA PERMISSÃO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(251, 18);
            label1.TabIndex = 1;
            label1.Text = "INFORME O QUE DESEJA BUSCA:";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Cursor = Cursors.IBeam;
            textBoxBuscar.Location = new Point(12, 112);
            textBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(692, 27);
            textBoxBuscar.TabIndex = 2;
            textBoxBuscar.KeyDown += textBoxBuscar_KeyDown;
            // 
            // buttonCancelar
            // 
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(710, 566);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(78, 35);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(710, 105);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 35);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(611, 566);
            buttonSelecionar.Margin = new Padding(3, 4, 3, 4);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(93, 35);
            buttonSelecionar.TabIndex = 5;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // FormConsultaPermissao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(800, 619);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonSelecionar);
            Controls.Add(permissaoDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaPermissao";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            KeyDown += FormConsultaPermissao_KeyDown;
            ((System.ComponentModel.ISupportInitialize)permissaoDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)permissaoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonSelecionar;
    }
}