using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormConsultaProduto : Form
    {
        public Produto produto;
        private bool selecionarRegistro;
        public FormConsultaProduto(bool _selecionarRegistro = false)
        {
            InitializeComponent();
            this.selecionarRegistro = _selecionarRegistro;
            buttonSelecionar.Visible = selecionarRegistro;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxProduto.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 10030 } } };

                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarPorId(Convert.ToInt32(textBoxProduto.Text));
                        break;
                    case 1:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarPorNome(textBoxProduto.Text);
                        break;
                    case 2:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarPorCodigoDeBarra(textBoxProduto.Text);
                        break;
                    case 3:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarTodos();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceProduto.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Produto)bindingSourceProduto.Current).Id;
                new ProdutoBLL().Excluir(id);
                bindingSourceProduto.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroProduto frm = new FormCadastroProduto())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceProduto.Count == 0)
                {
                    MessageBox.Show("Não existe produto para ser alterado.");
                    return;
                }

                int id = ((Produto)bindingSourceProduto.Current).Id;

                using (FormCadastroProduto frm = new FormCadastroProduto(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selecionarRegistro)
                    return;
                if (bindingSourceProduto.Count == 0)
                {
                    MessageBox.Show("Não existe produto para ser selecionado.");
                    return;
                }


                produto = (Produto)bindingSourceProduto.Current;


                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaProduto_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = comboBoxBuscarPor.Items.Count - 1; //seleciona sempre o ultimo indice da ComboBox
            buttonBuscar_Click(sender, e); //O evento load faz o botão buscar ser clicado
            HabilitarComponentes();
        }

        private void HabilitarComponentes()
        {
            HabilitarBotao(buttonInserir, new UsuarioBLL().ValidarPermissao(12, false));
            HabilitarBotao(buttonAlterar, new UsuarioBLL().ValidarPermissao(13, false));
            HabilitarBotao(buttonEcluir, new UsuarioBLL().ValidarPermissao(14, false));

        }
        private void HabilitarBotao(System.Windows.Forms.Button button, bool ativo)
        {
            if (ativo)
            {
                button.BackColor = Color.White;
                button.ForeColor = SystemColors.ControlText;
            }
            else
            {
                button.BackColor = SystemColors.Control;
                button.ForeColor = SystemColors.ControlText;
            }
            button.Enabled = ativo;
        }

        private void dataGridViewProduto_DoubleClick(object sender, EventArgs e)
        {
            buttonSelecionar_Click(sender, e);
        }

        private void FormConsultaProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
