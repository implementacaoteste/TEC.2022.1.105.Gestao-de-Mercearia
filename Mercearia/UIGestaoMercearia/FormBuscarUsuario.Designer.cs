namespace UIGestaoMercearia
{
    partial class FormBuscarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarUsuario));
            usuarioBindingSource = new BindingSource(components);
            usuarioDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            grupoUsuariosBindingSource = new BindingSource(components);
            grupoUsuariosDataGridView = new DataGridView();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            buttonBuscar = new Button();
            buttonAlterar = new Button();
            buttonAdicionarUsuario = new Button();
            buttonExcluirUsuario = new Button();
            buttonAdicionarGrupoUsuario = new Button();
            buttonExcluirGrupoUsuario = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grupoUsuariosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grupoUsuariosDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // usuarioDataGridView
            // 
            usuarioDataGridView.AllowUserToAddRows = false;
            usuarioDataGridView.AllowUserToDeleteRows = false;
            usuarioDataGridView.AllowUserToOrderColumns = true;
            usuarioDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usuarioDataGridView.AutoGenerateColumns = false;
            usuarioDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            usuarioDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usuarioDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewCheckBoxColumn1 });
            usuarioDataGridView.DataSource = usuarioBindingSource;
            usuarioDataGridView.Location = new Point(12, 150);
            usuarioDataGridView.Margin = new Padding(3, 4, 3, 4);
            usuarioDataGridView.Name = "usuarioDataGridView";
            usuarioDataGridView.ReadOnly = true;
            usuarioDataGridView.RowHeadersWidth = 51;
            usuarioDataGridView.RowTemplate.Height = 24;
            usuarioDataGridView.Size = new Size(729, 610);
            usuarioDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            dataGridViewTextBoxColumn2.HeaderText = "Nome";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "NomeUsuario";
            dataGridViewTextBoxColumn3.HeaderText = "Nome de usuário";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            dataGridViewTextBoxColumn5.HeaderText = "E-mail";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "CPF";
            dataGridViewTextBoxColumn6.HeaderText = "CPF";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.ReadOnly = true;
            dataGridViewCheckBoxColumn1.Width = 47;
            // 
            // grupoUsuariosBindingSource
            // 
            grupoUsuariosBindingSource.DataMember = "GrupoUsuarios";
            grupoUsuariosBindingSource.DataSource = usuarioBindingSource;
            // 
            // grupoUsuariosDataGridView
            // 
            grupoUsuariosDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grupoUsuariosDataGridView.AutoGenerateColumns = false;
            grupoUsuariosDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            grupoUsuariosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grupoUsuariosDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn8 });
            grupoUsuariosDataGridView.DataSource = grupoUsuariosBindingSource;
            grupoUsuariosDataGridView.Location = new Point(747, 150);
            grupoUsuariosDataGridView.Margin = new Padding(3, 4, 3, 4);
            grupoUsuariosDataGridView.Name = "grupoUsuariosDataGridView";
            grupoUsuariosDataGridView.RowHeadersWidth = 51;
            grupoUsuariosDataGridView.RowTemplate.Height = 24;
            grupoUsuariosDataGridView.Size = new Size(584, 610);
            grupoUsuariosDataGridView.TabIndex = 10;

            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn8.DataPropertyName = "NomeGrupo";
            dataGridViewTextBoxColumn8.HeaderText = "Grupos do usuário";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(12, 118);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 27);
            textBox1.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBuscar.Location = new Point(423, 118);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 28);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAlterar.Location = new Point(504, 118);
            buttonAlterar.Margin = new Padding(3, 4, 3, 4);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(75, 28);
            buttonAlterar.TabIndex = 4;
            buttonAlterar.Text = "Al&terar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonAdicionarUsuario
            // 
            buttonAdicionarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdicionarUsuario.Location = new Point(585, 118);
            buttonAdicionarUsuario.Margin = new Padding(3, 4, 3, 4);
            buttonAdicionarUsuario.Name = "buttonAdicionarUsuario";
            buttonAdicionarUsuario.Size = new Size(84, 28);
            buttonAdicionarUsuario.TabIndex = 5;
            buttonAdicionarUsuario.Text = "&Adicionar";
            buttonAdicionarUsuario.UseVisualStyleBackColor = true;
            buttonAdicionarUsuario.Click += buttonAdicionarUsuario_Click;
            // 
            // buttonExcluirUsuario
            // 
            buttonExcluirUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExcluirUsuario.Location = new Point(675, 118);
            buttonExcluirUsuario.Margin = new Padding(3, 4, 3, 4);
            buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            buttonExcluirUsuario.Size = new Size(66, 28);
            buttonExcluirUsuario.TabIndex = 6;
            buttonExcluirUsuario.Text = "&Excluir";
            buttonExcluirUsuario.UseVisualStyleBackColor = true;
            buttonExcluirUsuario.Click += buttonExcluirUsuario_Click;
            // 
            // buttonAdicionarGrupoUsuario
            // 
            buttonAdicionarGrupoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdicionarGrupoUsuario.Location = new Point(1159, 105);
            buttonAdicionarGrupoUsuario.Margin = new Padding(3, 4, 3, 4);
            buttonAdicionarGrupoUsuario.Name = "buttonAdicionarGrupoUsuario";
            buttonAdicionarGrupoUsuario.Size = new Size(91, 40);
            buttonAdicionarGrupoUsuario.TabIndex = 7;
            buttonAdicionarGrupoUsuario.Text = "A&dicionar";
            buttonAdicionarGrupoUsuario.UseVisualStyleBackColor = true;
            buttonAdicionarGrupoUsuario.Click += buttonAdicionarGrupoUsuario_Click;
            // 
            // buttonExcluirGrupoUsuario
            // 
            buttonExcluirGrupoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExcluirGrupoUsuario.Location = new Point(1256, 105);
            buttonExcluirGrupoUsuario.Margin = new Padding(3, 4, 3, 4);
            buttonExcluirGrupoUsuario.Name = "buttonExcluirGrupoUsuario";
            buttonExcluirGrupoUsuario.Size = new Size(75, 40);
            buttonExcluirGrupoUsuario.TabIndex = 8;
            buttonExcluirGrupoUsuario.Text = "E&xcluir";
            buttonExcluirGrupoUsuario.UseVisualStyleBackColor = true;
            buttonExcluirGrupoUsuario.Click += buttonExcluirGrupoUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(189, 18);
            label1.TabIndex = 1;
            label1.Text = "OQUE DESEJA BUSCAR?";
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
            label2.Size = new Size(1343, 78);
            label2.TabIndex = 0;
            label2.Text = "GESTÃO DE USUÁRIO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(405, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FormBuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(1343, 785);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonExcluirGrupoUsuario);
            Controls.Add(buttonAdicionarGrupoUsuario);
            Controls.Add(buttonExcluirUsuario);
            Controls.Add(buttonAdicionarUsuario);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBox1);
            Controls.Add(grupoUsuariosDataGridView);
            Controls.Add(usuarioDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1361, 832);
            Name = "FormBuscarUsuario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            KeyDown += FormBuscarUsuario_KeyDown;
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)grupoUsuariosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)grupoUsuariosDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.BindingSource grupoUsuariosBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonAdicionarUsuario;
        private System.Windows.Forms.Button buttonExcluirUsuario;
        private System.Windows.Forms.Button buttonAdicionarGrupoUsuario;
        private System.Windows.Forms.Button buttonExcluirGrupoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label2;
        private PictureBox pictureBox1;
    }
}