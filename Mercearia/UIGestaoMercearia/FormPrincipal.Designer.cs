namespace UIGestaoMercearia
{
    partial class FormPrincipal
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
            Label MENU;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            buttonUsuario = new Button();
            buttonCliente = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            buttonPagamento = new Button();
            buttonPermissao = new Button();
            buttonCategorias = new Button();
            buttonGrupoUsuario = new Button();
            buttonFornecedores = new Button();
            button8 = new Button();
            buttonFuncionarios = new Button();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            buttonProdutos = new Button();
            buttonMarcas = new Button();
            pictureBoxEstatistica = new PictureBox();
            labelNomeEmpresa = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            splitter1 = new Splitter();
            panel3 = new Panel();
            labelPDV = new Label();
            pictureBox3 = new PictureBox();
            pictureBoxLogo = new PictureBox();
            panel4 = new Panel();
            pictureBoxConfiguração = new PictureBox();
            buttonConsultarVenda = new Button();
            buttonIniciarVenda = new Button();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            buttonAjuda = new Button();
            panel6 = new Panel();
            label1 = new Label();
            label8 = new Label();
            label10 = new Label();
            label12 = new Label();
            label30 = new Label();
            MENU = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEstatistica).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfiguração).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // MENU
            // 
            MENU.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MENU.BackColor = Color.FromArgb(50, 153, 204);
            MENU.Cursor = Cursors.No;
            MENU.FlatStyle = FlatStyle.Popup;
            MENU.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            MENU.ForeColor = Color.White;
            MENU.Location = new Point(135, 9);
            MENU.Name = "MENU";
            MENU.Size = new Size(175, 51);
            MENU.TabIndex = 0;
            MENU.Text = "MENU";
            MENU.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonUsuario
            // 
            buttonUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonUsuario.BackColor = Color.White;
            buttonUsuario.FlatStyle = FlatStyle.Flat;
            buttonUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUsuario.ForeColor = Color.FromArgb(50, 153, 204);
            buttonUsuario.Location = new Point(15, 517);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(374, 73);
            buttonUsuario.TabIndex = 8;
            buttonUsuario.Text = "Usuários";
            buttonUsuario.UseVisualStyleBackColor = false;
            buttonUsuario.Click += buttonUsuario_Click;
            // 
            // buttonCliente
            // 
            buttonCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCliente.BackColor = Color.White;
            buttonCliente.FlatStyle = FlatStyle.Flat;
            buttonCliente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCliente.ForeColor = Color.FromArgb(50, 153, 204);
            buttonCliente.Location = new Point(15, 197);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(374, 75);
            buttonCliente.TabIndex = 3;
            buttonCliente.Text = "Clientes";
            buttonCliente.UseVisualStyleBackColor = false;
            buttonCliente.Click += buttonCliente_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(50, 153, 204);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(buttonPagamento);
            panel2.Controls.Add(buttonPermissao);
            panel2.Controls.Add(buttonCategorias);
            panel2.Controls.Add(buttonGrupoUsuario);
            panel2.Controls.Add(buttonFornecedores);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(buttonCliente);
            panel2.Controls.Add(MENU);
            panel2.Controls.Add(buttonFuncionarios);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(buttonProdutos);
            panel2.Controls.Add(buttonUsuario);
            panel2.Controls.Add(buttonMarcas);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 1116);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(11, 1075);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 11);
            panel1.TabIndex = 2;
            // 
            // buttonPagamento
            // 
            buttonPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonPagamento.BackColor = Color.White;
            buttonPagamento.FlatStyle = FlatStyle.Flat;
            buttonPagamento.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPagamento.ForeColor = Color.FromArgb(50, 153, 204);
            buttonPagamento.Location = new Point(15, 913);
            buttonPagamento.Name = "buttonPagamento";
            buttonPagamento.Size = new Size(374, 73);
            buttonPagamento.TabIndex = 27;
            buttonPagamento.Text = "Formas de Pagamento";
            buttonPagamento.UseVisualStyleBackColor = false;
            buttonPagamento.Click += buttonPagamento_Click;
            // 
            // buttonPermissao
            // 
            buttonPermissao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonPermissao.BackColor = Color.White;
            buttonPermissao.FlatStyle = FlatStyle.Flat;
            buttonPermissao.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPermissao.ForeColor = Color.FromArgb(50, 153, 204);
            buttonPermissao.Location = new Point(15, 835);
            buttonPermissao.Name = "buttonPermissao";
            buttonPermissao.Size = new Size(374, 73);
            buttonPermissao.TabIndex = 25;
            buttonPermissao.Text = "Permissões";
            buttonPermissao.UseVisualStyleBackColor = false;
            buttonPermissao.Click += button9_Click;
            // 
            // buttonCategorias
            // 
            buttonCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCategorias.BackColor = Color.White;
            buttonCategorias.FlatStyle = FlatStyle.Flat;
            buttonCategorias.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCategorias.ForeColor = Color.FromArgb(50, 153, 204);
            buttonCategorias.Location = new Point(15, 676);
            buttonCategorias.Name = "buttonCategorias";
            buttonCategorias.Size = new Size(374, 73);
            buttonCategorias.TabIndex = 9;
            buttonCategorias.Text = "Categorias";
            buttonCategorias.UseVisualStyleBackColor = false;
            buttonCategorias.Click += buttonCategorias_Click;
            // 
            // buttonGrupoUsuario
            // 
            buttonGrupoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonGrupoUsuario.BackColor = Color.White;
            buttonGrupoUsuario.FlatStyle = FlatStyle.Flat;
            buttonGrupoUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGrupoUsuario.ForeColor = Color.FromArgb(50, 153, 204);
            buttonGrupoUsuario.Location = new Point(15, 596);
            buttonGrupoUsuario.Name = "buttonGrupoUsuario";
            buttonGrupoUsuario.Size = new Size(374, 75);
            buttonGrupoUsuario.TabIndex = 7;
            buttonGrupoUsuario.Text = "Grupo de Usuários";
            buttonGrupoUsuario.UseVisualStyleBackColor = false;
            buttonGrupoUsuario.Click += buttonGrupoUsuario_Click_1;
            // 
            // buttonFornecedores
            // 
            buttonFornecedores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonFornecedores.BackColor = Color.White;
            buttonFornecedores.FlatStyle = FlatStyle.Flat;
            buttonFornecedores.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFornecedores.ForeColor = Color.FromArgb(50, 153, 204);
            buttonFornecedores.Location = new Point(15, 437);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(374, 75);
            buttonFornecedores.TabIndex = 6;
            buttonFornecedores.Text = "Fornecedores";
            buttonFornecedores.UseVisualStyleBackColor = false;
            buttonFornecedores.Click += buttonFornecedores_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button8.BackColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.FromArgb(50, 153, 204);
            button8.Location = new Point(15, 357);
            button8.Name = "button8";
            button8.Size = new Size(374, 75);
            button8.TabIndex = 5;
            button8.Text = "Estoque";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // buttonFuncionarios
            // 
            buttonFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonFuncionarios.BackColor = Color.White;
            buttonFuncionarios.FlatStyle = FlatStyle.Flat;
            buttonFuncionarios.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFuncionarios.ForeColor = Color.FromArgb(50, 153, 204);
            buttonFuncionarios.Location = new Point(15, 277);
            buttonFuncionarios.Name = "buttonFuncionarios";
            buttonFuncionarios.Size = new Size(374, 75);
            buttonFuncionarios.TabIndex = 4;
            buttonFuncionarios.Text = "Funcionários";
            buttonFuncionarios.UseVisualStyleBackColor = false;
            buttonFuncionarios.Click += buttonFuncionarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.Location = new Point(15, 83);
            panel5.Name = "panel5";
            panel5.Size = new Size(377, 11);
            panel5.TabIndex = 1;
            // 
            // buttonProdutos
            // 
            buttonProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonProdutos.BackColor = Color.White;
            buttonProdutos.FlatStyle = FlatStyle.Flat;
            buttonProdutos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProdutos.ForeColor = Color.FromArgb(50, 153, 204);
            buttonProdutos.Location = new Point(15, 117);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(374, 73);
            buttonProdutos.TabIndex = 2;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = false;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // buttonMarcas
            // 
            buttonMarcas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonMarcas.BackColor = Color.White;
            buttonMarcas.FlatStyle = FlatStyle.Flat;
            buttonMarcas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMarcas.ForeColor = Color.FromArgb(50, 153, 204);
            buttonMarcas.Location = new Point(15, 755);
            buttonMarcas.Name = "buttonMarcas";
            buttonMarcas.Size = new Size(374, 73);
            buttonMarcas.TabIndex = 10;
            buttonMarcas.Text = "Marcas";
            buttonMarcas.UseVisualStyleBackColor = false;
            buttonMarcas.Click += buttonMarcas_Click;
            // 
            // pictureBoxEstatistica
            // 
            pictureBoxEstatistica.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxEstatistica.BackColor = Color.Transparent;
            pictureBoxEstatistica.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxEstatistica.Cursor = Cursors.Hand;
            pictureBoxEstatistica.ErrorImage = null;
            pictureBoxEstatistica.Image = (Image)resources.GetObject("pictureBoxEstatistica.Image");
            pictureBoxEstatistica.InitialImage = null;
            pictureBoxEstatistica.Location = new Point(23, 23);
            pictureBoxEstatistica.Margin = new Padding(3, 4, 3, 4);
            pictureBoxEstatistica.Name = "pictureBoxEstatistica";
            pictureBoxEstatistica.Size = new Size(134, 96);
            pictureBoxEstatistica.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEstatistica.TabIndex = 21;
            pictureBoxEstatistica.TabStop = false;
            pictureBoxEstatistica.Click += pictureBoxEstatistica_Click;
            // 
            // labelNomeEmpresa
            // 
            labelNomeEmpresa.Anchor = AnchorStyles.Top;
            labelNomeEmpresa.AutoSize = true;
            labelNomeEmpresa.BackColor = Color.Transparent;
            labelNomeEmpresa.Cursor = Cursors.No;
            labelNomeEmpresa.FlatStyle = FlatStyle.Popup;
            labelNomeEmpresa.Font = new Font("Bernard MT Condensed", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelNomeEmpresa.ForeColor = Color.FromArgb(50, 153, 204);
            labelNomeEmpresa.Location = new Point(838, 1);
            labelNomeEmpresa.Name = "labelNomeEmpresa";
            labelNomeEmpresa.Size = new Size(229, 55);
            labelNomeEmpresa.TabIndex = 0;
            labelNomeEmpresa.Text = "MERCEARIA";
            labelNomeEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(5, 999);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(50, 153, 204);
            panel3.Controls.Add(labelPDV);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(399, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(1242, 91);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // labelPDV
            // 
            labelPDV.Anchor = AnchorStyles.Top;
            labelPDV.AutoSize = true;
            labelPDV.BackColor = Color.FromArgb(50, 153, 204);
            labelPDV.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelPDV.ForeColor = Color.White;
            labelPDV.Location = new Point(393, 0);
            labelPDV.Name = "labelPDV";
            labelPDV.Size = new Size(410, 67);
            labelPDV.TabIndex = 0;
            labelPDV.Text = "CAIXA ABERTO";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.FromArgb(50, 153, 204);
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1242, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxLogo.Anchor = AnchorStyles.Top;
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Cursor = Cursors.No;
            pictureBoxLogo.ErrorImage = null;
            pictureBoxLogo.Image = Properties.Resources.shopping_cart_icon_illustration_free_vector2;
            pictureBoxLogo.InitialImage = null;
            pictureBoxLogo.Location = new Point(764, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(67, 52);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Coral;
            panel4.Controls.Add(pictureBoxConfiguração);
            panel4.Controls.Add(buttonConsultarVenda);
            panel4.Controls.Add(buttonIniciarVenda);
            panel4.Controls.Add(pictureBoxEstatistica);
            panel4.Location = new Point(399, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(1240, 135);
            panel4.TabIndex = 1;
            // 
            // pictureBoxConfiguração
            // 
            pictureBoxConfiguração.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxConfiguração.BackColor = Color.Transparent;
            pictureBoxConfiguração.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxConfiguração.Cursor = Cursors.Hand;
            pictureBoxConfiguração.ErrorImage = null;
            pictureBoxConfiguração.Image = Properties.Resources.settings_512px;
            pictureBoxConfiguração.InitialImage = null;
            pictureBoxConfiguração.Location = new Point(175, 25);
            pictureBoxConfiguração.Margin = new Padding(3, 4, 3, 4);
            pictureBoxConfiguração.Name = "pictureBoxConfiguração";
            pictureBoxConfiguração.Size = new Size(114, 93);
            pictureBoxConfiguração.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxConfiguração.TabIndex = 19;
            pictureBoxConfiguração.TabStop = false;
            pictureBoxConfiguração.Click += pictureBoxConfiguracao_Click;
            // 
            // buttonConsultarVenda
            // 
            buttonConsultarVenda.BackColor = Color.Coral;
            buttonConsultarVenda.FlatStyle = FlatStyle.Flat;
            buttonConsultarVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsultarVenda.ForeColor = SystemColors.ButtonHighlight;
            buttonConsultarVenda.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConsultarVenda.Location = new Point(319, 25);
            buttonConsultarVenda.Name = "buttonConsultarVenda";
            buttonConsultarVenda.Size = new Size(484, 84);
            buttonConsultarVenda.TabIndex = 1;
            buttonConsultarVenda.Text = "CONSULTAR VENDA";
            buttonConsultarVenda.UseVisualStyleBackColor = false;
            buttonConsultarVenda.Click += buttonConsultaVenda;
            // 
            // buttonIniciarVenda
            // 
            buttonIniciarVenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonIniciarVenda.FlatStyle = FlatStyle.Flat;
            buttonIniciarVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonIniciarVenda.ForeColor = SystemColors.ButtonHighlight;
            buttonIniciarVenda.Location = new Point(834, 23);
            buttonIniciarVenda.Name = "buttonIniciarVenda";
            buttonIniciarVenda.Size = new Size(229, 84);
            buttonIniciarVenda.TabIndex = 0;
            buttonIniciarVenda.Text = "PONTO DE VENDA";
            buttonIniciarVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonIniciarVenda.UseVisualStyleBackColor = false;
            buttonIniciarVenda.Click += buttonIniciarVenda_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.MenuBar;
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Cursor = Cursors.No;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(399, 268);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1078, 763);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // buttonAjuda
            // 
            buttonAjuda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAjuda.BackColor = Color.FromArgb(50, 153, 204);
            buttonAjuda.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAjuda.Cursor = Cursors.Help;
            buttonAjuda.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjuda.ForeColor = Color.White;
            buttonAjuda.Location = new Point(1398, 3);
            buttonAjuda.Name = "buttonAjuda";
            buttonAjuda.Size = new Size(64, 52);
            buttonAjuda.TabIndex = 22;
            buttonAjuda.Text = "?";
            buttonAjuda.UseVisualStyleBackColor = false;
            buttonAjuda.Click += buttonAjuda_Click;
            buttonAjuda.KeyDown += buttonAjuda_KeyDown;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = SystemColors.ControlLight;
            panel6.Controls.Add(label1);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label30);
            panel6.Location = new Point(399, 935);
            panel6.Name = "panel6";
            panel6.Size = new Size(1078, 64);
            panel6.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(176, 14);
            label1.Name = "label1";
            label1.Size = new Size(213, 28);
            label1.TabIndex = 40;
            label1.Text = "| F1 - Central de Ajuda";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLight;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(395, 14);
            label8.Name = "label8";
            label8.Size = new Size(146, 28);
            label8.TabIndex = 36;
            label8.Text = "| Tab - Avançar";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlLight;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(680, 14);
            label10.Name = "label10";
            label10.Size = new Size(190, 28);
            label10.TabIndex = 37;
            label10.Text = "| F11 - Configuração";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ControlLight;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(876, 14);
            label12.Name = "label12";
            label12.Size = new Size(167, 28);
            label12.TabIndex = 38;
            label12.Text = "| F12 - Estatística ";
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.BackColor = SystemColors.ControlLight;
            label30.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label30.ForeColor = Color.DimGray;
            label30.Location = new Point(544, 14);
            label30.Name = "label30";
            label30.Size = new Size(131, 28);
            label30.TabIndex = 39;
            label30.Text = "| Esc - Fechar";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1475, 999);
            Controls.Add(panel6);
            Controls.Add(pictureBoxLogo);
            Controls.Add(labelNomeEmpresa);
            Controls.Add(panel4);
            Controls.Add(buttonAjuda);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(pictureBox2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1156, 720);
            Name = "FormPrincipal";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Turquoise;
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            ResizeEnd += FormPrincipal_ResizeEnd;
            KeyDown += FormPrincipal_KeyDown;
            Resize += FormPrincipal_Resize;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEstatistica).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfiguração).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonUsuario;
        private Button buttonCliente;
        private Label labelNomeEmpresa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Splitter splitter1;
        private Panel panel2;
        private Button buttonProdutos;
        private Button buttonFornecedores;
        private Button buttonFuncionarios;
        private Panel panel3;
        private PictureBox pictureBoxLogo;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxConfiguração;
        private Button buttonConsultarVenda;
        private Button buttonIniciarVenda;
        private Button buttonGrupoUsuario;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Button buttonMarcas;
        private Button buttonCategorias;
        private Button button8;
        private Button buttonPermissao;
        private ToolTip toolTip1;
        private Button buttonPagamento;
        private PictureBox pictureBoxEstatistica;
        private Panel panel1;
        private Label labelPDV;
        private Button buttonAjuda;
        private PictureBox pictureBox3;
        private Panel panel6;
        private Label label10;
        private Label label12;
        private Label label30;
        private Label label1;
        private Label label8;
    }
}

