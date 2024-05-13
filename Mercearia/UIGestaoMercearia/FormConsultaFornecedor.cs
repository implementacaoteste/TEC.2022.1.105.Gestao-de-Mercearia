using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormConsultaFornecedor : Form
    {
        public Fornecedor fornecedor;
        private bool selecionarRegistro;

        public FormConsultaFornecedor(bool _selecionarRegistro = false)
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
                        if (String.IsNullOrEmpty(textBoxBuscarPor.Text))
                            throw new Exception("Informe um nome para fazer a busca.") { Data = { { "Id", 10031 } } };
                        bindingSourceFornecedor.DataSource = new FornecedorBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        if (String.IsNullOrEmpty(textBoxBuscarPor.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 10031 } } };
                        bindingSourceFornecedor.DataSource = new FornecedorBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarPor.Text));
                        break;
                    case 2:
                        bindingSourceFornecedor.DataSource = new FornecedorBLL().BuscarTodos();
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

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceFornecedor.Count == 0)
                {
                    MessageBox.Show("Não existe produto para ser alterado.");
                    return;
                }

                int id = ((Fornecedor)bindingSourceFornecedor.Current).Id;

                using (FormCadastroFornecedor frm = new FormCadastroFornecedor(id))
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

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroFornecedor frm = new FormCadastroFornecedor())
                {
                    frm.ShowDialog();
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
                if (bindingSourceFornecedor.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Fornecedor)bindingSourceFornecedor.Current).Id;
                new FornecedorBLL().Excluir(id);
                bindingSourceFornecedor.RemoveCurrent();
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
                if (bindingSourceFornecedor.Count == 0)
                {
                    MessageBox.Show("Não existe fornecedor para ser selecionado.");
                    return;
                }


                fornecedor = (Fornecedor)bindingSourceFornecedor.Current;


                this.Close();

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

        private void FormConsultaFornecedor_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = comboBoxBuscarPor.Items.Count - 1;
            buttonBuscar_Click(sender, e);
        }

        private void dataGridViewFornecedor_DoubleClick(object sender, EventArgs e)
        {
            buttonSelecionar_Click(sender, e);
        }

        private void FormConsultaFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }

}
