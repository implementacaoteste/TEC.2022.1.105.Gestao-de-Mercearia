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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEstatistica).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(198, 18);
            label1.Name = "label1";
            label1.Size = new Size(188, 52);
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
            panel1.Location = new Point(11, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 130);
            panel1.TabIndex = 1;
            // 
            // labelS
            // 
            labelS.Anchor = AnchorStyles.Top;
            labelS.AutoSize = true;
            labelS.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelS.ForeColor = Color.White;
            labelS.Location = new Point(408, 20);
            labelS.Name = "labelS";
            labelS.Size = new Size(79, 29);
            labelS.TabIndex = 0;
            labelS.Text = "Lucro:";
            // 
            // labelGs
            // 
            labelGs.Anchor = AnchorStyles.Top;
            labelGs.AutoSize = true;
            labelGs.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelGs.ForeColor = Color.White;
            labelGs.Location = new Point(254, 20);
            labelGs.Name = "labelGs";
            labelGs.Size = new Size(94, 29);
            labelGs.TabIndex = 0;
            labelGs.Text = "Gastos:";
            // 
            // labelG
            // 
            labelG.Anchor = AnchorStyles.Top;
            labelG.AutoSize = true;
            labelG.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelG.ForeColor = Color.White;
            labelG.Location = new Point(71, 20);
            labelG.Name = "labelG";
            labelG.Size = new Size(102, 29);
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
            labelSaldo.Location = new Point(391, 55);
            labelSaldo.Name = "labelSaldo";
            labelSaldo.Size = new Size(76, 37);
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
            labelGastos.Location = new Point(233, 58);
            labelGastos.Name = "labelGastos";
            labelGastos.Size = new Size(76, 37);
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
            labelGanhos.Location = new Point(55, 60);
            labelGanhos.Name = "labelGanhos";
            labelGanhos.Size = new Size(76, 37);
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
            panel2.Location = new Point(11, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(587, 430);
            panel2.TabIndex = 2;
            // 
            // dateTimePickerFim
            // 
            dateTimePickerFim.Location = new Point(71, 279);
            dateTimePickerFim.Name = "dateTimePickerFim";
            dateTimePickerFim.Size = new Size(407, 34);
            dateTimePickerFim.TabIndex = 1;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(71, 154);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(405, 34);
            dateTimePickerInicio.TabIndex = 1;
            dateTimePickerInicio.ValueChanged += dateTimePickerInicio_ValueChanged;
            // 
            // labelDataInicio
            // 
            labelDataInicio.AutoSize = true;
            labelDataInicio.BackColor = Color.FromArgb(50, 153, 204);
            labelDataInicio.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataInicio.ForeColor = SystemColors.ControlLightLight;
            labelDataInicio.Location = new Point(208, 99);
            labelDataInicio.Name = "labelDataInicio";
            labelDataInicio.Size = new Size(138, 52);
            labelDataInicio.TabIndex = 0;
            labelDataInicio.Text = "Inicio";
            // 
            // labelDataFim
            // 
            labelDataFim.AutoSize = true;
            labelDataFim.BackColor = Color.FromArgb(50, 153, 204);
            labelDataFim.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataFim.ForeColor = SystemColors.ControlLightLight;
            labelDataFim.Location = new Point(208, 224);
            labelDataFim.Name = "labelDataFim";
            labelDataFim.Size = new Size(123, 52);
            labelDataFim.TabIndex = 0;
            labelDataFim.Text = "Final";
            // 
            // labelPeriodo
            // 
            labelPeriodo.AutoSize = true;
            labelPeriodo.BackColor = Color.FromArgb(50, 153, 204);
            labelPeriodo.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPeriodo.ForeColor = SystemColors.ControlLightLight;
            labelPeriodo.Location = new Point(71, 12);
            labelPeriodo.Name = "labelPeriodo";
            labelPeriodo.Size = new Size(429, 52);
            labelPeriodo.TabIndex = 0;
            labelPeriodo.Text = "Período das Vendas";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 153, 204);
            panel5.Controls.Add(label1);
            panel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(-2, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(615, 81);
            panel5.TabIndex = 3;
            // 
            // FormEstatistica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(610, 670);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
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
    }
}