namespace UIGestaoMercearia
{
    partial class FormFinalizarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinalizarVenda));
            buttonBuscarFormaPagamento = new Button();
            labelFormaPagamento = new Label();
            textBoxFormaPagamento = new TextBox();
            textBoxValorPago = new TextBox();
            labelValorPago = new Label();
            pictureBox1 = new PictureBox();
            buttonCancelar = new Button();
            buttonOk = new Button();
            label3 = new Label();
            bindingSourceFinalizarVenda = new BindingSource(components);
            labelTroco = new Label();
            textBoxTotal = new TextBox();
            labelTotal = new Label();
            labelExTroco = new Label();
            buttonCadastrarCliente = new Button();
            buttonAjuda = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFinalizarVenda).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscarFormaPagamento
            // 
            buttonBuscarFormaPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBuscarFormaPagamento.Location = new Point(542, 149);
            buttonBuscarFormaPagamento.Name = "buttonBuscarFormaPagamento";
            buttonBuscarFormaPagamento.Size = new Size(54, 43);
            buttonBuscarFormaPagamento.TabIndex = 2;
            buttonBuscarFormaPagamento.Text = "...";
            buttonBuscarFormaPagamento.UseVisualStyleBackColor = true;
            buttonBuscarFormaPagamento.Click += buttonBuscarFormaPagamento_Click;
            // 
            // labelFormaPagamento
            // 
            labelFormaPagamento.AutoSize = true;
            labelFormaPagamento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormaPagamento.ForeColor = Color.White;
            labelFormaPagamento.Location = new Point(25, 123);
            labelFormaPagamento.Name = "labelFormaPagamento";
            labelFormaPagamento.Size = new Size(250, 25);
            labelFormaPagamento.TabIndex = 3;
            labelFormaPagamento.Text = "FORMA DE PAGAMENTO";
            // 
            // textBoxFormaPagamento
            // 
            textBoxFormaPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFormaPagamento.Cursor = Cursors.IBeam;
            textBoxFormaPagamento.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFormaPagamento.Location = new Point(25, 149);
            textBoxFormaPagamento.Name = "textBoxFormaPagamento";
            textBoxFormaPagamento.Size = new Size(511, 43);
            textBoxFormaPagamento.TabIndex = 3;
            textBoxFormaPagamento.TabStop = false;
            // 
            // textBoxValorPago
            // 
            textBoxValorPago.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxValorPago.Cursor = Cursors.IBeam;
            textBoxValorPago.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValorPago.Location = new Point(894, 149);
            textBoxValorPago.Name = "textBoxValorPago";
            textBoxValorPago.Size = new Size(223, 43);
            textBoxValorPago.TabIndex = 1;
            textBoxValorPago.Visible = false;
            textBoxValorPago.KeyPress += textBoxValorPago_KeyPress;
            // 
            // labelValorPago
            // 
            labelValorPago.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelValorPago.AutoSize = true;
            labelValorPago.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorPago.ForeColor = Color.White;
            labelValorPago.Location = new Point(894, 123);
            labelValorPago.Name = "labelValorPago";
            labelValorPago.Size = new Size(143, 25);
            labelValorPago.TabIndex = 1;
            labelValorPago.Text = "VALOR PAGO";
            labelValorPago.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(819, 533);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(1022, 1063);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(107, 37);
            buttonCancelar.TabIndex = 38;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOk.Location = new Point(909, 1063);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(107, 35);
            buttonOk.TabIndex = 38;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(50, 153, 204);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1143, 93);
            label3.TabIndex = 5;
            label3.Text = "FINALIZAR VENDA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTroco
            // 
            labelTroco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelTroco.AutoSize = true;
            labelTroco.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelTroco.ForeColor = SystemColors.ButtonHighlight;
            labelTroco.Location = new Point(846, 401);
            labelTroco.Name = "labelTroco";
            labelTroco.Size = new Size(124, 135);
            labelTroco.TabIndex = 6;
            labelTroco.Text = "0";
            labelTroco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotal.Location = new Point(623, 149);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(237, 43);
            textBoxTotal.TabIndex = 0;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.ForeColor = Color.White;
            labelTotal.Location = new Point(623, 123);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(79, 25);
            labelTotal.TabIndex = 0;
            labelTotal.Text = "TOTAL";
            labelTotal.Visible = false;
            // 
            // labelExTroco
            // 
            labelExTroco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelExTroco.AutoSize = true;
            labelExTroco.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelExTroco.ForeColor = SystemColors.ButtonHighlight;
            labelExTroco.Location = new Point(142, 401);
            labelExTroco.Name = "labelExTroco";
            labelExTroco.Size = new Size(709, 135);
            labelExTroco.TabIndex = 6;
            labelExTroco.Text = "TROCO: R$";
            // 
            // buttonCadastrarCliente
            // 
            buttonCadastrarCliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastrarCliente.ForeColor = Color.FromArgb(50, 153, 204);
            buttonCadastrarCliente.Location = new Point(321, 763);
            buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            buttonCadastrarCliente.Size = new Size(530, 69);
            buttonCadastrarCliente.TabIndex = 4;
            buttonCadastrarCliente.Text = "CADASTRAR CLIENTE";
            buttonCadastrarCliente.UseVisualStyleBackColor = true;
            buttonCadastrarCliente.Click += button1_Click;
            // 
            // buttonAjuda
            // 
            buttonAjuda.BackColor = Color.FromArgb(50, 153, 204);
            buttonAjuda.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAjuda.Cursor = Cursors.Help;
            buttonAjuda.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjuda.ForeColor = Color.White;
            buttonAjuda.Location = new Point(12, 15);
            buttonAjuda.Name = "buttonAjuda";
            buttonAjuda.Size = new Size(76, 60);
            buttonAjuda.TabIndex = 5;
            buttonAjuda.Text = "?";
            buttonAjuda.UseVisualStyleBackColor = false;
            buttonAjuda.Click += buttonAjuda_Click;
            buttonAjuda.KeyDown += buttonAjuda_KeyDown;
            // 
            // FormFinalizarVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(1143, 844);
            Controls.Add(buttonAjuda);
            Controls.Add(buttonCadastrarCliente);
            Controls.Add(label3);
            Controls.Add(labelTroco);
            Controls.Add(textBoxTotal);
            Controls.Add(labelExTroco);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancelar);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBuscarFormaPagamento);
            Controls.Add(labelTotal);
            Controls.Add(labelValorPago);
            Controls.Add(labelFormaPagamento);
            Controls.Add(textBoxValorPago);
            Controls.Add(textBoxFormaPagamento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFinalizarVenda";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormFinalizarVenda_Load;
            KeyDown += FormFinalizarVenda_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFinalizarVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscarFormaPagamento;
        private Label labelFormaPagamento;
        private TextBox textBoxFormaPagamento;
        private TextBox textBoxValorPago;
        private Label labelValorPago;
        private PictureBox pictureBox1;
        private Button buttonCancelar;
        private Button buttonOk;
        private Label label3;
        private BindingSource bindingSourceFinalizarVenda;
        private Label labelTroco;
        private TextBox textBoxTotal;
        private Label labelTotal;
        private Label labelExTroco;
        private Button button1;
        private Button buttonCadastrarCliente;
        private Button buttonAjuda;
    }
}