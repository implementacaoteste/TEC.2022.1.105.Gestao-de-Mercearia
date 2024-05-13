using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormConsultaMarca : Form
    {
        public Marca marca;
        private bool selecionarRegistro;
        public FormConsultaMarca(bool _selecionarRegistro = false)
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
                        bindingSourceMarca.DataSource = new MarcaBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarPor.Text));
                        break;
                    case 1:
                        bindingSourceMarca.DataSource = new MarcaBLL().BuscarTodos();
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
                if (bindingSourceMarca.Count == 0)
                {
                    MessageBox.Show("Não existe Marca para ser alterado.");
                    return;
                }

                int id = ((Marca)bindingSourceMarca.Current).Id;

                using (FormCadastroMarca frm = new FormCadastroMarca(id))
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
                using (FormCadastroMarca frm = new FormCadastroMarca())
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
                if (bindingSourceMarca.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Marca)bindingSourceMarca.Current).Id;
                new MarcaBLL().Excluir(id);
                bindingSourceMarca.RemoveCurrent();
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
                if (bindingSourceMarca.Count == 0)
                {
                    MessageBox.Show("Não existe marca para ser selecionado.");
                    return;
                }

                marca = (Marca)bindingSourceMarca.Current;
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

        private void FormConsultaMarca_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = comboBoxBuscarPor.Items.Count - 1; //seleciona sempre o ultimo indice da ComboBox
            buttonBuscar_Click(sender, e); //O evento load faz o botão buscar ser clicado
        }

        private void dataGridViewMarca_DoubleClick(object sender, EventArgs e)
        {
            buttonSelecionar_Click(sender, e);
        }
        private void FormConsultaMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
