namespace UIGestaoMercearia
{
    partial class FormBuscarGrupoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarGrupoUsuario));
            grupoUsuarioDataGridView = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            grupoUsuarioBindingSource = new BindingSource(components);
            permissoesDataGridView = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            permissoesBindingSource = new BindingSource(components);
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            buttonAlterar = new Button();
            buttonAdicionarGrupoUsuario = new Button();
            buttonExcluirGrupoUsuario = new Button();
            buttonAdicionarPermissao = new Button();
            buttonExcluirPermissao = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)permissoesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)permissoesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grupoUsuarioDataGridView
            // 
            grupoUsuarioDataGridView.AllowUserToAddRows = false;
            grupoUsuarioDataGridView.AllowUserToDeleteRows = false;
            grupoUsuarioDataGridView.AllowUserToOrderColumns = true;
            grupoUsuarioDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grupoUsuarioDataGridView.AutoGenerateColumns = false;
            grupoUsuarioDataGridView.BackgroundColor = Color.White;
            grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grupoUsuarioDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2 });
            grupoUsuarioDataGridView.DataSource = grupoUsuarioBindingSource;
            grupoUsuarioDataGridView.Location = new Point(12, 154);
            grupoUsuarioDataGridView.Margin = new Padding(3, 4, 3, 4);
            grupoUsuarioDataGridView.MultiSelect = false;
            grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            grupoUsuarioDataGridView.ReadOnly = true;
            grupoUsuarioDataGridView.RowHeadersWidth = 51;
            grupoUsuarioDataGridView.RowTemplate.Height = 24;
            grupoUsuarioDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grupoUsuarioDataGridView.Size = new Size(559, 468);
            grupoUsuarioDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            dataGridViewTextBoxColumn2.HeaderText = "Grupos de usuário";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // grupoUsuarioBindingSource
            // 
            grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // permissoesDataGridView
            // 
            permissoesDataGridView.AllowUserToAddRows = false;
            permissoesDataGridView.AllowUserToDeleteRows = false;
            permissoesDataGridView.AllowUserToOrderColumns = true;
            permissoesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            permissoesDataGridView.AutoGenerateColumns = false;
            permissoesDataGridView.BackgroundColor = Color.White;
            permissoesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            permissoesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4 });
            permissoesDataGridView.DataSource = permissoesBindingSource;
            permissoesDataGridView.Location = new Point(577, 155);
            permissoesDataGridView.Margin = new Padding(3, 4, 3, 4);
            permissoesDataGridView.Name = "permissoesDataGridView";
            permissoesDataGridView.ReadOnly = true;
            permissoesDataGridView.RowHeadersWidth = 51;
            permissoesDataGridView.RowTemplate.Height = 24;
            permissoesDataGridView.Size = new Size(543, 466);
            permissoesDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            dataGridViewTextBoxColumn4.HeaderText = "Permissões do grupo";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // permissoesBindingSource
            // 
            permissoesBindingSource.DataMember = "Permissoes";
            permissoesBindingSource.DataSource = grupoUsuarioBindingSource;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Cursor = Cursors.IBeam;
            textBoxBuscar.Location = new Point(12, 120);
            textBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(235, 27);
            textBoxBuscar.TabIndex = 0;
            textBoxBuscar.KeyDown += textBoxBuscar_KeyDown;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(253, 120);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 28);
            buttonBuscar.TabIndex = 1;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(334, 119);
            buttonAlterar.Margin = new Padding(3, 4, 3, 4);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(75, 28);
            buttonAlterar.TabIndex = 2;
            buttonAlterar.Text = "Al&terar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonAdicionarGrupoUsuario
            // 
            buttonAdicionarGrupoUsuario.Location = new Point(415, 121);
            buttonAdicionarGrupoUsuario.Margin = new Padding(3, 4, 3, 4);
            buttonAdicionarGrupoUsuario.Name = "buttonAdicionarGrupoUsuario";
            buttonAdicionarGrupoUsuario.Size = new Size(81, 27);
            buttonAdicionarGrupoUsuario.TabIndex = 3;
            buttonAdicionarGrupoUsuario.Text = "&Adicionar";
            buttonAdicionarGrupoUsuario.UseVisualStyleBackColor = true;
            buttonAdicionarGrupoUsuario.Click += buttonAdicionarGrupoUsuario_Click;
            // 
            // buttonExcluirGrupoUsuario
            // 
            buttonExcluirGrupoUsuario.Location = new Point(502, 121);
            buttonExcluirGrupoUsuario.Margin = new Padding(3, 4, 3, 4);
            buttonExcluirGrupoUsuario.Name = "buttonExcluirGrupoUsuario";
            buttonExcluirGrupoUsuario.Size = new Size(69, 27);
            buttonExcluirGrupoUsuario.TabIndex = 4;
            buttonExcluirGrupoUsuario.Text = "&Excluir";
            buttonExcluirGrupoUsuario.UseVisualStyleBackColor = true;
            buttonExcluirGrupoUsuario.Click += buttonExcluirGrupoUsuario_Click;
            // 
            // buttonAdicionarPermissao
            // 
            buttonAdicionarPermissao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdicionarPermissao.Location = new Point(955, 121);
            buttonAdicionarPermissao.Margin = new Padding(3, 4, 3, 4);
            buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            buttonAdicionarPermissao.Size = new Size(84, 31);
            buttonAdicionarPermissao.TabIndex = 5;
            buttonAdicionarPermissao.Text = "A&dicionar";
            buttonAdicionarPermissao.UseVisualStyleBackColor = true;
            buttonAdicionarPermissao.Click += buttonAdicionarPermissao_Click;
            // 
            // buttonExcluirPermissao
            // 
            buttonExcluirPermissao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExcluirPermissao.Location = new Point(1045, 121);
            buttonExcluirPermissao.Margin = new Padding(3, 4, 3, 4);
            buttonExcluirPermissao.Name = "buttonExcluirPermissao";
            buttonExcluirPermissao.Size = new Size(75, 31);
            buttonExcluirPermissao.TabIndex = 6;
            buttonExcluirPermissao.Text = "E&xcluir";
            buttonExcluirPermissao.UseVisualStyleBackColor = true;
            buttonExcluirPermissao.Click += buttonExcluirPermissao_Click;
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
            label1.Size = new Size(1132, 72);
            label1.TabIndex = 9;
            label1.Text = "   GESTÃO DE GRUPOS DE USUÁRIO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(211, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 13;
            label2.Text = "BUSCAR POR:";
            // 
            // FormBuscarGrupoUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(1132, 636);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(buttonExcluirPermissao);
            Controls.Add(buttonExcluirGrupoUsuario);
            Controls.Add(buttonAdicionarPermissao);
            Controls.Add(buttonAdicionarGrupoUsuario);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(permissoesDataGridView);
            Controls.Add(grupoUsuarioDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1150, 683);
            Name = "FormBuscarGrupoUsuario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "    ";
            KeyDown += FormBuscarGrupoUsuario_KeyDown;
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)permissoesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)permissoesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonAdicionarGrupoUsuario;
        private System.Windows.Forms.Button buttonExcluirGrupoUsuario;
        private System.Windows.Forms.Button buttonAdicionarPermissao;
        private System.Windows.Forms.Button buttonExcluirPermissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private PictureBox pictureBox1;
        private Label label2;
    }
}