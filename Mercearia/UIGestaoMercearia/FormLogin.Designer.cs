namespace UIGestaoMercearia
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            buttonEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxUsuario.Cursor = Cursors.IBeam;
            textBoxUsuario.Location = new Point(48, 476);
            textBoxUsuario.Margin = new Padding(3, 4, 3, 4);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(366, 27);
            textBoxUsuario.TabIndex = 2;
            textBoxUsuario.KeyDown += textBoxUsuario_KeyDown;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxSenha.Cursor = Cursors.IBeam;
            textBoxSenha.Location = new Point(48, 542);
            textBoxSenha.Margin = new Padding(3, 4, 3, 4);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(366, 27);
            textBoxSenha.TabIndex = 4;
            textBoxSenha.KeyDown += textBoxSenha_KeyDown;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Anchor = AnchorStyles.Top;
            buttonEntrar.BackColor = Color.FromArgb(50, 205, 153);
            buttonEntrar.FlatStyle = FlatStyle.Flat;
            buttonEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEntrar.ForeColor = Color.White;
            buttonEntrar.Location = new Point(48, 595);
            buttonEntrar.Margin = new Padding(3, 4, 3, 4);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(366, 39);
            buttonEntrar.TabIndex = 5;
            buttonEntrar.Text = "Login";
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(48, 518);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Senha";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(50, 153, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(48, 452);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-7, -20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2000, 1125);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.FromArgb(50, 153, 204);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(139, 372);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxSenha);
            panel1.Controls.Add(buttonEntrar);
            panel1.Location = new Point(416, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 782);
            panel1.TabIndex = 8;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1231, 751);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            KeyDown += FormLogin_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}