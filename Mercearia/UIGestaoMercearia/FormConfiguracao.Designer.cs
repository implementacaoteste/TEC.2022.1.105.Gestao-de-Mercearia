namespace UIGestaoMercearia
{
    partial class FormConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracao));
            panel1 = new Panel();
            buttonCancelar = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            buttonAjuda = new Button();
            label7 = new Label();
            label10 = new Label();
            textBoxNovoNomeUsuario = new TextBox();
            label3 = new Label();
            label9 = new Label();
            textBoxNomeUsuario = new TextBox();
            label8 = new Label();
            label5 = new Label();
            buttonAlterarSenha = new Button();
            buttonAlterarNomeUsuario = new Button();
            textBoxSenha = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxConfirmacaoSenha = new TextBox();
            textBoxNovaSenha = new TextBox();
            pictureBoxLogo = new PictureBox();
            panel5 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBoxNovoNomeUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBoxNomeUsuario);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonAlterarSenha);
            panel1.Controls.Add(buttonAlterarNomeUsuario);
            panel1.Controls.Add(textBoxSenha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxConfirmacaoSenha);
            panel1.Controls.Add(textBoxNovaSenha);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 648);
            panel1.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Right;
            buttonCancelar.BackColor = Color.White;
            buttonCancelar.Location = new Point(310, 597);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(133, 29);
            buttonCancelar.TabIndex = 16;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 153, 204);
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 57);
            panel3.TabIndex = 31;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 153, 204);
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Controls.Add(buttonAjuda);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(455, 59);
            panel4.TabIndex = 0;
            // 
            // buttonAjuda
            // 
            buttonAjuda.BackColor = Color.FromArgb(50, 153, 204);
            buttonAjuda.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAjuda.Cursor = Cursors.Help;
            buttonAjuda.Font = new Font("Swis721 Blk BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjuda.ForeColor = Color.White;
            buttonAjuda.Location = new Point(3, 3);
            buttonAjuda.Name = "buttonAjuda";
            buttonAjuda.Size = new Size(57, 46);
            buttonAjuda.TabIndex = 42;
            buttonAjuda.Text = "?";
            buttonAjuda.UseVisualStyleBackColor = false;
            buttonAjuda.Click += buttonAjuda_Click;
            buttonAjuda.KeyDown += buttonAjuda_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(78, 5);
            label7.Name = "label7";
            label7.Size = new Size(293, 44);
            label7.TabIndex = 0;
            label7.Text = "CONFIGURAÇÃO";
            label7.Click += label7_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(18, 387);
            label10.Name = "label10";
            label10.Size = new Size(376, 29);
            label10.TabIndex = 10;
            label10.Text = "ALTERAR NOME DE USUÁRIO";
            // 
            // textBoxNovoNomeUsuario
            // 
            textBoxNovoNomeUsuario.Anchor = AnchorStyles.Left;
            textBoxNovoNomeUsuario.Location = new Point(246, 473);
            textBoxNovoNomeUsuario.Name = "textBoxNovoNomeUsuario";
            textBoxNovoNomeUsuario.Size = new Size(188, 27);
            textBoxNovoNomeUsuario.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(18, 477);
            label3.Name = "label3";
            label3.Size = new Size(198, 18);
            label3.TabIndex = 13;
            label3.Text = "NOVO NOME DE USUÁRIO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(11, 144);
            label9.Name = "label9";
            label9.Size = new Size(223, 29);
            label9.TabIndex = 1;
            label9.Text = "ALTERAR SENHA";
            // 
            // textBoxNomeUsuario
            // 
            textBoxNomeUsuario.Anchor = AnchorStyles.Left;
            textBoxNomeUsuario.Location = new Point(246, 429);
            textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            textBoxNomeUsuario.Size = new Size(188, 27);
            textBoxNomeUsuario.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(69, 73);
            label8.Name = "label8";
            label8.Size = new Size(347, 36);
            label8.TabIndex = 0;
            label8.Text = "Privacidade e Segurança";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(18, 435);
            label5.Name = "label5";
            label5.Size = new Size(200, 18);
            label5.TabIndex = 11;
            label5.Text = "NOME DE USUÁRIO ATUAL";
            // 
            // buttonAlterarSenha
            // 
            buttonAlterarSenha.BackColor = Color.White;
            buttonAlterarSenha.ForeColor = Color.Black;
            buttonAlterarSenha.Location = new Point(18, 309);
            buttonAlterarSenha.Name = "buttonAlterarSenha";
            buttonAlterarSenha.Size = new Size(107, 29);
            buttonAlterarSenha.TabIndex = 8;
            buttonAlterarSenha.Text = "&Salvar";
            buttonAlterarSenha.UseVisualStyleBackColor = false;
            buttonAlterarSenha.Click += buttonAlterarSenha_Click;
            // 
            // buttonAlterarNomeUsuario
            // 
            buttonAlterarNomeUsuario.BackColor = Color.White;
            buttonAlterarNomeUsuario.Location = new Point(17, 515);
            buttonAlterarNomeUsuario.Name = "buttonAlterarNomeUsuario";
            buttonAlterarNomeUsuario.Size = new Size(109, 29);
            buttonAlterarNomeUsuario.TabIndex = 15;
            buttonAlterarNomeUsuario.Text = "&Salvar";
            buttonAlterarNomeUsuario.UseVisualStyleBackColor = false;
            buttonAlterarNomeUsuario.Click += buttonAlterarNomeUsuario_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = AnchorStyles.Left;
            textBoxSenha.Location = new Point(147, 181);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(287, 27);
            textBoxSenha.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(18, 187);
            label4.Name = "label4";
            label4.Size = new Size(109, 18);
            label4.TabIndex = 2;
            label4.Text = "SENHA ATUAL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(18, 273);
            label6.Name = "label6";
            label6.Size = new Size(198, 18);
            label6.TabIndex = 6;
            label6.Text = "CONFIRMAR NOVA SENHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(18, 229);
            label2.Name = "label2";
            label2.Size = new Size(104, 18);
            label2.TabIndex = 4;
            label2.Text = "NOVA SENHA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 5);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 26;
            // 
            // textBoxConfirmacaoSenha
            // 
            textBoxConfirmacaoSenha.Anchor = AnchorStyles.Left;
            textBoxConfirmacaoSenha.Location = new Point(242, 273);
            textBoxConfirmacaoSenha.Name = "textBoxConfirmacaoSenha";
            textBoxConfirmacaoSenha.PasswordChar = '*';
            textBoxConfirmacaoSenha.Size = new Size(191, 27);
            textBoxConfirmacaoSenha.TabIndex = 7;
            // 
            // textBoxNovaSenha
            // 
            textBoxNovaSenha.Anchor = AnchorStyles.Left;
            textBoxNovaSenha.Location = new Point(147, 225);
            textBoxNovaSenha.Name = "textBoxNovaSenha";
            textBoxNovaSenha.PasswordChar = '*';
            textBoxNovaSenha.Size = new Size(287, 27);
            textBoxNovaSenha.TabIndex = 5;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Cursor = Cursors.No;
            pictureBoxLogo.ErrorImage = null;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.InitialImage = null;
            pictureBoxLogo.Location = new Point(11, 64);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(51, 45);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 28;
            pictureBoxLogo.TabStop = false;
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.BackColor = Color.FromArgb(50, 153, 204);
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(-9, 364);
            panel5.Name = "panel5";
            panel5.Size = new Size(468, 216);
            panel5.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 0;
            // 
            // FormConfiguracao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 639);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfiguracao";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            KeyDown += FormConfiguracao_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonIniciarVenda;
        private TextBox textBoxNovaSenha;
        private Label label2;
        private Label label1;
        private TextBox textBoxSenha;
        private Label label4;
        private Button buttonAlterarSenha;
        private Label label6;
        private TextBox textBoxConfirmacaoSenha;
        private Label label8;
        private Label label9;
        private PictureBox pictureBoxLogo;
        private Label label10;
        private TextBox textBoxNovoNomeUsuario;
        private Label label3;
        private TextBox textBoxNomeUsuario;
        private Label label5;
        private Panel panel2;
        private Button buttonCancelar;
        private Button buttonAlterarNomeUsuario;
        private Panel panel3;
        private Label label7;
        private Panel panel4;
        private Panel panel5;
        private Button buttonAjuda;
    }
}