namespace UIGestaoMercearia
{
    partial class FormEstatistica
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
            label1 = new Label();
            panel1 = new Panel();
            labelS = new Label();
            labelGs = new Label();
            labelG = new Label();
            labelSaldo = new Label();
            bindingSourceEstatistica = new BindingSource(components);
            labelGastos = new Label();
            labelGanhos = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            dateTimePickerFim = new DateTimePicker();
            dateTimePickerInicio = new DateTimePicker();
            labelDataInicio = new Label();
            labelDataFim = new Label();
            labelPeriodo = new Label();
            panel5 = new Panel();
            panel3 = new Panel();
            labelQuantClientes = new Label();
            panel4 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            labelClientCadast = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEstatistica).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 42);
            label1.TabIndex = 0;
            label1.Text = "LUCROS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(labelS);
            panel1.Controls.Add(labelGs);
            panel1.Controls.Add(labelG);
            panel1.Controls.Add(labelSaldo);
            panel1.Controls.Add(labelGastos);
            panel1.Controls.Add(labelGanhos);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(12, 531);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 98);
            panel1.TabIndex = 1;
            // 
            // labelS
            // 
            labelS.Anchor = AnchorStyles.Top;
            labelS.AutoSize = true;
            labelS.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelS.ForeColor = Color.White;
            labelS.Location = new Point(416, 15);
            labelS.Name = "labelS";
            labelS.Size = new Size(63, 24);
            labelS.TabIndex = 0;
            labelS.Text = "Lucro:";
            // 
            // labelGs
            // 
            labelGs.Anchor = AnchorStyles.Top;
            labelGs.AutoSize = true;
            labelGs.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelGs.ForeColor = Color.White;
            labelGs.Location = new Point(281, 15);
            labelGs.Name = "labelGs";
            labelGs.Size = new Size(72, 24);
            labelGs.TabIndex = 0;
            labelGs.Text = "Gastos:";
            // 
            // labelG
            // 
            labelG.Anchor = AnchorStyles.Top;
            labelG.AutoSize = true;
            labelG.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelG.ForeColor = Color.White;
            labelG.Location = new Point(121, 15);
            labelG.Name = "labelG";
            labelG.Size = new Size(81, 24);
            labelG.TabIndex = 0;
            labelG.Text = "Ganhos:";
            // 
            // labelSaldo
            // 
            labelSaldo.Anchor = AnchorStyles.Top;
            labelSaldo.AutoSize = true;
            labelSaldo.DataBindings.Add(new Binding("Text", bindingSourceEstatistica, "Saldo", true));
            labelSaldo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelSaldo.ForeColor = Color.Lime;
            labelSaldo.Location = new Point(401, 41);
            labelSaldo.Name = "labelSaldo";
            labelSaldo.Size = new Size(59, 28);
            labelSaldo.TabIndex = 1;
            labelSaldo.Text = "R$ 0";
            // 
            // bindingSourceEstatistica
            // 
            bindingSourceEstatistica.DataSource = typeof(Models.Estatistica);
            // 
            // labelGastos
            // 
            labelGastos.Anchor = AnchorStyles.Top;
            labelGastos.AutoSize = true;
            labelGastos.DataBindings.Add(new Binding("Text", bindingSourceEstatistica, "Gastos", true));
            labelGastos.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelGastos.ForeColor = Color.White;
            labelGastos.Location = new Point(263, 44);
            labelGastos.Name = "labelGastos";
            labelGastos.Size = new Size(59, 28);
            labelGastos.TabIndex = 1;
            labelGastos.Text = "R$ 0";
            // 
            // labelGanhos
            // 
            labelGanhos.Anchor = AnchorStyles.Top;
            labelGanhos.AutoSize = true;
            labelGanhos.DataBindings.Add(new Binding("Text", bindingSourceEstatistica, "Ganhos", true));
            labelGanhos.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelGanhos.ForeColor = Color.White;
            labelGanhos.Location = new Point(107, 45);
            labelGanhos.Name = "labelGanhos";
            labelGanhos.Size = new Size(59, 28);
            labelGanhos.TabIndex = 1;
            labelGanhos.Text = "R$ 0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 153, 204);
            panel2.Controls.Add(dateTimePickerFim);
            panel2.Controls.Add(dateTimePickerInicio);
            panel2.Controls.Add(labelDataInicio);
            panel2.Controls.Add(labelDataFim);
            panel2.Controls.Add(labelPeriodo);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(12, 205);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 322);
            panel2.TabIndex = 2;
            // 
            // dateTimePickerFim
            // 
            dateTimePickerFim.Location = new Point(62, 209);
            dateTimePickerFim.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerFim.Name = "dateTimePickerFim";
            dateTimePickerFim.Size = new Size(357, 29);
            dateTimePickerFim.TabIndex = 1;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(62, 116);
            dateTimePickerInicio.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(355, 29);
            dateTimePickerInicio.TabIndex = 1;
            dateTimePickerInicio.ValueChanged += dateTimePickerInicio_ValueChanged;
            // 
            // labelDataInicio
            // 
            labelDataInicio.AutoSize = true;
            labelDataInicio.BackColor = Color.FromArgb(50, 153, 204);
            labelDataInicio.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataInicio.ForeColor = SystemColors.ControlLightLight;
            labelDataInicio.Location = new Point(182, 74);
            labelDataInicio.Name = "labelDataInicio";
            labelDataInicio.Size = new Size(113, 42);
            labelDataInicio.TabIndex = 0;
            labelDataInicio.Text = "Inicio";
            // 
            // labelDataFim
            // 
            labelDataFim.AutoSize = true;
            labelDataFim.BackColor = Color.FromArgb(50, 153, 204);
            labelDataFim.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataFim.ForeColor = SystemColors.ControlLightLight;
            labelDataFim.Location = new Point(182, 168);
            labelDataFim.Name = "labelDataFim";
            labelDataFim.Size = new Size(99, 42);
            labelDataFim.TabIndex = 0;
            labelDataFim.Text = "Final";
            // 
            // labelPeriodo
            // 
            labelPeriodo.AutoSize = true;
            labelPeriodo.BackColor = Color.FromArgb(50, 153, 204);
            labelPeriodo.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPeriodo.ForeColor = SystemColors.ControlLightLight;
            labelPeriodo.Location = new Point(62, 9);
            labelPeriodo.Name = "labelPeriodo";
            labelPeriodo.Size = new Size(348, 42);
            labelPeriodo.TabIndex = 0;
            labelPeriodo.Text = "Período das Vendas";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 153, 204);
            panel5.Controls.Add(label1);
            panel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(-2, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(662, 61);
            panel5.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 153, 204);
            panel3.Controls.Add(labelClientCadast);
            panel3.Controls.Add(labelQuantClientes);
            panel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(10, 80);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 83);
            panel3.TabIndex = 4;
            // 
            // labelQuantClientes
            // 
            labelQuantClientes.AutoSize = true;
            labelQuantClientes.Font = new Font("Book Antiqua", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuantClientes.ForeColor = Color.White;
            labelQuantClientes.Location = new Point(27, 0);
            labelQuantClientes.Name = "labelQuantClientes";
            labelQuantClientes.Size = new Size(130, 79);
            labelQuantClientes.TabIndex = 0;
            labelQuantClientes.Text = "123";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 153, 204);
            panel4.Controls.Add(label2);
            panel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(438, 78);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(207, 83);
            panel4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 79);
            label2.TabIndex = 0;
            label2.Text = "123";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 153, 204);
            panel6.Controls.Add(label3);
            panel6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.Location = new Point(225, 80);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(207, 83);
            panel6.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 79);
            label3.TabIndex = 0;
            label3.Text = "123";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label5);
            panel7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel7.Location = new Point(10, 161);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(207, 30);
            panel7.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label7);
            panel8.Controls.Add(label6);
            panel8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel8.Location = new Point(225, 161);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(207, 30);
            panel8.TabIndex = 6;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(label8);
            panel9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel9.Location = new Point(438, 161);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(207, 30);
            panel9.TabIndex = 6;
            // 
            // labelClientCadast
            // 
            labelClientCadast.AutoSize = true;
            labelClientCadast.Font = new Font("Book Antiqua", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelClientCadast.ForeColor = Color.White;
            labelClientCadast.Location = new Point(38, 2);
            labelClientCadast.Name = "labelClientCadast";
            labelClientCadast.Size = new Size(130, 79);
            labelClientCadast.TabIndex = 1;
            labelClientCadast.Text = "123";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(27, 4);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 2;
            label5.Text = "Clientes Cadastrados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(91, 4);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 3;
            label6.Text = "123";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(25, 4);
            label7.Name = "label7";
            label7.Size = new Size(155, 20);
            label7.TabIndex = 4;
            label7.Text = "Vendas Cadastradas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(91, 5);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 3;
            label8.Text = "123";
            // 
            // FormEstatistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(687, 623);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEstatistica";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormEstatistica_Load;
            KeyDown += FormEstatistica_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEstatistica).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label labelGanhos;
        private Label labelG;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private Panel panel5;
        private Label labelS;
        private Label labelGs;
        private Label labelSaldo;
        private Label labelGastos;
        private DateTimePicker dateTimePickerInicio;
        private Label labelPeriodo;
        private Label labelDataInicio;
        private Label labelDataFim;
        private DateTimePicker dateTimePickerFim;
        private BindingSource bindingSourceEstatistica;
        private Panel panel3;
        private Label labelQuantClientes;
        private Label labelClientCadast;
        private Panel panel4;
        private Label label2;
        private Panel panel6;
        private Label label3;
        private Panel panel7;
        private Label label5;
        private Panel panel8;
        private Panel panel9;
        private Label label7;
        private Label label6;
        private Label label8;
    }
}