namespace UIGestaoMercearia
{
    partial class FormPontoDeVenda
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            buttonAjuda = new Button();
            labelPDV = new Label();
            labelNomeProduto = new Label();
            panel2 = new Panel();
            pictureBoxLogo = new PictureBox();
            panel3 = new Panel();
            label4 = new Label();
            labelSubtotal = new Label();
            buttonFinalizarVenda = new Button();
            label6 = new Label();
            textBoxQuantidade = new TextBox();
            textBoxCodigodeBarras = new TextBox();
            label11 = new Label();
            buttonCancelar = new Button();
            dataGridView1 = new DataGridView();
            NomeProduto = new DataGridViewTextBoxColumn();
            ValorUnitario = new DataGridViewTextBoxColumn();
            subTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemVendaListBindingSource = new BindingSource(components);
            bindingSourceVenda = new BindingSource(components);
            label12 = new Label();
            labelpreco = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            subtotal1 = new Label();
            Subtotal2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemVendaListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(buttonAjuda);
            panel1.Controls.Add(labelPDV);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 84);
            panel1.TabIndex = 2;
            // 
            // buttonAjuda
            // 
            buttonAjuda.BackColor = Color.FromArgb(50, 153, 204);
            buttonAjuda.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAjuda.Cursor = Cursors.Help;
            buttonAjuda.Font = new Font("Swis721 Blk BT", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjuda.ForeColor = Color.White;
            buttonAjuda.Location = new Point(12, 9);
            buttonAjuda.Name = "buttonAjuda";
            buttonAjuda.Size = new Size(84, 67);
            buttonAjuda.TabIndex = 23;
            buttonAjuda.Text = "?";
            buttonAjuda.UseVisualStyleBackColor = false;
            buttonAjuda.KeyDown += buttonAjuda_KeyDown;
            // 
            // labelPDV
            // 
            labelPDV.Anchor = AnchorStyles.Top;
            labelPDV.AutoSize = true;
            labelPDV.BackColor = Color.FromArgb(50, 153, 204);
            labelPDV.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelPDV.ForeColor = Color.White;
            labelPDV.Location = new Point(357, 9);
            labelPDV.Name = "labelPDV";
            labelPDV.Size = new Size(488, 67);
            labelPDV.TabIndex = 1;
            labelPDV.Text = "PONTO DE VENDA";
            // 
            // labelNomeProduto
            // 
            labelNomeProduto.Anchor = AnchorStyles.Top;
            labelNomeProduto.AutoSize = true;
            labelNomeProduto.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomeProduto.Location = new Point(197, 13);
            labelNomeProduto.Name = "labelNomeProduto";
            labelNomeProduto.Size = new Size(448, 56);
            labelNomeProduto.TabIndex = 0;
            labelNomeProduto.Text = "Nome do Produto";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(labelNomeProduto);
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Location = new Point(399, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 92);
            panel2.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxLogo.Anchor = AnchorStyles.Right;
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Cursor = Cursors.No;
            pictureBoxLogo.ErrorImage = null;
            pictureBoxLogo.Image = Properties.Resources.shopping_cart_icon_illustration_free_vector2;
            pictureBoxLogo.InitialImage = null;
            pictureBoxLogo.Location = new Point(629, -3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(165, 88);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(labelSubtotal);
            panel3.Location = new Point(399, 857);
            panel3.Name = "panel3";
            panel3.Size = new Size(527, 183);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(210, 49);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 3;
            label4.Text = "Subtotal:";
            // 
            // labelSubtotal
            // 
            labelSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelSubtotal.AutoSize = true;
            labelSubtotal.Font = new Font("Stencil", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubtotal.Location = new Point(115, 77);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(187, 59);
            labelSubtotal.TabIndex = 2;
            labelSubtotal.Text = "000,00";
            // 
            // buttonFinalizarVenda
            // 
            buttonFinalizarVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonFinalizarVenda.BackColor = Color.FromArgb(50, 153, 204);
            buttonFinalizarVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFinalizarVenda.ForeColor = SystemColors.Window;
            buttonFinalizarVenda.Location = new Point(915, 745);
            buttonFinalizarVenda.Name = "buttonFinalizarVenda";
            buttonFinalizarVenda.Size = new Size(208, 66);
            buttonFinalizarVenda.TabIndex = 22;
            buttonFinalizarVenda.Text = "Finalizar Venda";
            buttonFinalizarVenda.UseVisualStyleBackColor = false;
            buttonFinalizarVenda.Click += buttonFinalizarVenda_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(960, 193);
            label6.Name = "label6";
            label6.Size = new Size(163, 31);
            label6.TabIndex = 3;
            label6.Text = "QUANTIDADE";
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxQuantidade.BackColor = Color.WhiteSmoke;
            textBoxQuantidade.BorderStyle = BorderStyle.None;
            textBoxQuantidade.Cursor = Cursors.IBeam;
            textBoxQuantidade.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxQuantidade.Location = new Point(931, 257);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(179, 72);
            textBoxQuantidade.TabIndex = 10;
            textBoxQuantidade.Text = "1";
            textBoxQuantidade.TextAlign = HorizontalAlignment.Right;
            textBoxQuantidade.TextChanged += textBoxQuantidade_TextChanged;
            textBoxQuantidade.KeyDown += textBoxQuantidade_KeyDown;
            // 
            // textBoxCodigodeBarras
            // 
            textBoxCodigodeBarras.BackColor = Color.WhiteSmoke;
            textBoxCodigodeBarras.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodigodeBarras.Location = new Point(445, 244);
            textBoxCodigodeBarras.Name = "textBoxCodigodeBarras";
            textBoxCodigodeBarras.Size = new Size(289, 79);
            textBoxCodigodeBarras.TabIndex = 11;
            textBoxCodigodeBarras.KeyDown += textBoxCodigodeBarras_KeyDown;
            textBoxCodigodeBarras.KeyPress += textBoxCodigodeBarras_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(489, 196);
            label11.Name = "label11";
            label11.Size = new Size(219, 31);
            label11.TabIndex = 3;
            label11.Text = "CÓDIGO DE BARRA";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.BackColor = Color.Coral;
            buttonCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ForeColor = SystemColors.ButtonHighlight;
            buttonCancelar.Location = new Point(704, 745);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(205, 66);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(50, 153, 204);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NomeProduto, ValorUnitario, subTotalDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = itemVendaListBindingSource;
            dataGridView1.Location = new Point(445, 337);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(665, 330);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // NomeProduto
            // 
            NomeProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NomeProduto.DataPropertyName = "NomeProduto";
            NomeProduto.HeaderText = "Nome do produto";
            NomeProduto.MinimumWidth = 6;
            NomeProduto.Name = "NomeProduto";
            NomeProduto.ReadOnly = true;
            // 
            // ValorUnitario
            // 
            ValorUnitario.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            ValorUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            ValorUnitario.HeaderText = "Valor unitário";
            ValorUnitario.MinimumWidth = 6;
            ValorUnitario.Name = "ValorUnitario";
            ValorUnitario.ReadOnly = true;
            ValorUnitario.Width = 150;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            subTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            subTotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            subTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            subTotalDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopRight;
            quantidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            quantidadeDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemVendaListBindingSource
            // 
            itemVendaListBindingSource.DataMember = "ItemVendaList";
            itemVendaListBindingSource.DataSource = bindingSourceVenda;
            // 
            // bindingSourceVenda
            // 
            bindingSourceVenda.DataSource = typeof(Models.Venda);
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ImageAlign = ContentAlignment.TopCenter;
            label12.Location = new Point(727, 194);
            label12.Name = "label12";
            label12.Size = new Size(200, 31);
            label12.TabIndex = 2;
            label12.Text = "PREÇO UNITÁRIO";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelpreco
            // 
            labelpreco.Anchor = AnchorStyles.Top;
            labelpreco.AutoSize = true;
            labelpreco.FlatStyle = FlatStyle.System;
            labelpreco.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelpreco.ImageAlign = ContentAlignment.TopCenter;
            labelpreco.Location = new Point(694, 258);
            labelpreco.Name = "labelpreco";
            labelpreco.Size = new Size(87, 71);
            labelpreco.TabIndex = 0;
            labelpreco.Text = "...";
            labelpreco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2024_01_31_0909582;
            pictureBox1.Location = new Point(-570, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1022, 1046);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Location = new Point(399, 828);
            panel4.Name = "panel4";
            panel4.Size = new Size(799, 11);
            panel4.TabIndex = 4;
            // 
            // subtotal1
            // 
            subtotal1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            subtotal1.AutoSize = true;
            subtotal1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            subtotal1.Location = new Point(458, 704);
            subtotal1.Name = "subtotal1";
            subtotal1.Size = new Size(125, 31);
            subtotal1.TabIndex = 23;
            subtotal1.Text = "SUBTOTAL";
            subtotal1.Click += subtotal1_Click;
            // 
            // Subtotal2
            // 
            Subtotal2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Subtotal2.BackColor = Color.WhiteSmoke;
            Subtotal2.BorderStyle = BorderStyle.None;
            Subtotal2.Cursor = Cursors.IBeam;
            Subtotal2.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Subtotal2.Location = new Point(458, 739);
            Subtotal2.Name = "Subtotal2";
            Subtotal2.ReadOnly = true;
            Subtotal2.Size = new Size(333, 72);
            Subtotal2.TabIndex = 24;
            Subtotal2.Text = "00,00";
            // 
            // FormPontoDeVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1198, 835);
            Controls.Add(Subtotal2);
            Controls.Add(subtotal1);
            Controls.Add(panel4);
            Controls.Add(buttonFinalizarVenda);
            Controls.Add(textBoxCodigodeBarras);
            Controls.Add(labelpreco);
            Controls.Add(textBoxQuantidade);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(buttonCancelar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPontoDeVenda";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FormInicializarVenda_Load;
            KeyDown += textBoxCodigodeBarras_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemVendaListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelNomeProduto;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label labelSubtotal;
        private Label label6;
        private Button buttonCancelar;
        private Label label11;
        private DataGridView dataGridView1;
        private BindingSource bindingSourceVenda;
        private EventHandler bindingSourceVenda_CurrentChanged;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idFormaPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private TextBox textBoxQuantidade;
        private Label label12;
        private TextBox textBoxCodigodeBarras;
        private Label labelpreco;
        private BindingSource itemVendaListBindingSource;
        private TextBox textBox1;
        private TextBox textBoxPrecoProduto;
        private Button button1;
        private PictureBox pictureBox1;
        private Button buttonFinalizarVenda;
        private Label labelPDV;
        private PictureBox pictureBoxLogo;
        private Panel panel4;
        private Label subtotal1;
        private TextBox Subtotal2;
        private DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private Button buttonAjuda;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn ValorUnitario;
        private DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
    }
}