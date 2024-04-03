namespace UIGestaoMercearia
{
    partial class FormMenssagem
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
            label4 = new Label();
            buttonCancelar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Unicode MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(41, 26);
            label4.Name = "label4";
            label4.Size = new Size(313, 31);
            label4.TabIndex = 1;
            label4.Text = "Essa venda será cancelada. ";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.ButtonHighlight;
            buttonCancelar.FlatStyle = FlatStyle.System;
            buttonCancelar.Location = new Point(216, 75);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(153, 48);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(41, 75);
            button1.Name = "button1";
            button1.Size = new Size(153, 48);
            button1.TabIndex = 8;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormMenssagem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 140);
            Controls.Add(button1);
            Controls.Add(buttonCancelar);
            Controls.Add(label4);
            Name = "FormMenssagem";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button buttonCancelar;
        private Button button1;
    }
}