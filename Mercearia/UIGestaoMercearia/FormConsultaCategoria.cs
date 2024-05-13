using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormConsultaCategoria : Form
    {
        public Categoria categoria;
        private bool selecionarRegistro;
        public FormConsultaCategoria(bool _selecionarRegistro = false)
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
                        if (String.IsNullOrEmpty(comboBoxBuscarPor.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 10030 } } };
                        bindingSourceCategoria.DataSource = new CategoriaBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarPor.Text));
                        break;
                    case 1:
                        bindingSourceCategoria.DataSource = new CategoriaBLL().BuscarTodos();
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

        private void buttonAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceCategoria.Count == 0)
                {
                    MessageBox.Show("Não existe categoria para ser alterado.");
                    return;
                }

                int id = ((Categoria)bindingSourceCategoria.Current).Id;

                using (FormCadastroCategoria frm = new FormCadastroCategoria(id))
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

        private void buttonInserir_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroCategoria frm = new FormCadastroCategoria())
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
                if (bindingSourceCategoria.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Categoria)bindingSourceCategoria.Current).Id;
                new CategoriaBLL().Excluir(id);
                bindingSourceCategoria.RemoveCurrent();
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
                if (bindingSourceCategoria.Count == 0)
                {
                    MessageBox.Show("Não existe categoria para ser selecionado.");
                    return;
                }


                categoria = (Categoria)bindingSourceCategoria.Current;
                this.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaCategoria_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = comboBoxBuscarPor.Items.Count - 1; //seleciona sempre o ultimo indice da ComboBox
            buttonBuscar_Click(sender, e); //O evento load faz o botão buscar ser clicado
        }

        private void dataGridViewCategoria_DoubleClick(object sender, EventArgs e)
        {
            buttonSelecionar_Click(sender, e);
        }

        private void dataGridViewCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormConsultaCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
