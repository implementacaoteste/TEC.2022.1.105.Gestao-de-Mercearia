namespace UIGestaoMercearia
{
    partial class FormConsultaGrupoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaGrupoUsuario));
            grupoUsuarioBindingSource = new BindingSource(components);
            grupoUsuarioDataGridView = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            NomeGrupo = new DataGridViewTextBoxColumn();
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // grupoUsuarioBindingSource
            // 
            grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // grupoUsuarioDataGridView
            // 
            grupoUsuarioDataGridView.AutoGenerateColumns = false;
            grupoUsuarioDataGridView.BackgroundColor = Color.White;
            grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grupoUsuarioDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, NomeGrupo });
            grupoUsuarioDataGridView.DataSource = grupoUsuarioBindingSource;
            grupoUsuarioDataGridView.Location = new Point(12, 131);
            grupoUsuarioDataGridView.Margin = new Padding(3, 4, 3, 4);
            grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            grupoUsuarioDataGridView.RowHeadersWidth = 51;
            grupoUsuarioDataGridView.RowTemplate.Height = 24;
            grupoUsuarioDataGridView.Size = new Size(1019, 391);
            grupoUsuarioDataGridView.TabIndex = 5;
            grupoUsuarioDataGridView.MouseDoubleClick += grupoUsuarioDataGridView_MouseDoubleClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            dataGridViewTextBoxColumn2.HeaderText = "Grupos de usuário";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // NomeGrupo
            // 
            NomeGrupo.DataPropertyName = "NomeGrupo";
            NomeGrupo.HeaderText = "NomeGrupo";
            NomeGrupo.MinimumWidth = 6;
            NomeGrupo.Name = "NomeGrupo";
            NomeGrupo.Width = 125;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(849, 530);
            buttonSelecionar.Margin = new Padding(3, 4, 3, 4);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(93, 35);
            buttonSelecionar.TabIndex = 6;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(948, 530);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 35);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Cursor = Cursors.IBeam;
            textBoxBuscar.Location = new Point(12, 96);
            textBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(695, 27);
            textBoxBuscar.TabIndex = 2;
            textBoxBuscar.KeyDown += textBoxBuscar_KeyDown;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(713, 89);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 35);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(241, 18);
            label1.TabIndex = 1;
            label1.Text = "NOME DO GRUPO DE USUÁRIO:";
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
            label2.Size = new Size(1035, 66);
            label2.TabIndex = 0;
            label2.Text = "CONSULTAR GRUPO DE USUÁRIO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(794, 88);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(229, 35);
            button1.TabIndex = 4;
            button1.Text = "&Gerenciar grupos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(170, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // FormConsultaGrupoUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(1035, 573);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonSelecionar);
            Controls.Add(grupoUsuarioDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaGrupoUsuario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormConsultaGrupoUsuario_Load;
            KeyDown += FormConsultaGrupoUsuario_KeyDown;
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataGridViewTextBoxColumn NomeGrupo;
        private Button button1;
        private PictureBox pictureBox2;
    }
}