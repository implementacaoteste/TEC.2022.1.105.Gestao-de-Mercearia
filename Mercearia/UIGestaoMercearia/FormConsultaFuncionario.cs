using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormConsultaFuncionario : Form
    {
        public FormConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 10131 } } };
                        funcionarioBindingSource.DataSource = new FuncionarioBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Nome para fazer a busca.") { Data = { { "Id", 10132 } } };
                        funcionarioBindingSource.DataSource = new FuncionarioBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        funcionarioBindingSource.DataSource = new FuncionarioBLL().BuscarTodos();
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
                if (funcionarioBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe funcionario para ser alterado.");
                    return;
                }

                int id = ((Funcionario)funcionarioBindingSource.Current).Id;

                using (FormCadastroFuncionario frm = new FormCadastroFuncionario(id))
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
                using (FormCadastroFuncionario frm = new FormCadastroFuncionario())
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
                if (funcionarioBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Funcionario)funcionarioBindingSource.Current).Id;
                new FuncionarioBLL().Excluir(id);
                funcionarioBindingSource.RemoveCurrent();
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
                if (funcionarioBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe funcionario para ser selecionado.");
                    return;
                }


                Funcionario selectedFuncionario = (Funcionario)funcionarioBindingSource.Current;


                MessageBox.Show($"Funcionario Selecionado: {selectedFuncionario.Nome}, Id: {selectedFuncionario.Id}");


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

        private void FormConsultaFuncionario_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = comboBoxBuscarPor.Items.Count - 1; //seleciona sempre o ultimo indice da ComboBox
            buttonBuscar_Click(sender, e); //O evento load faz o botão buscar ser clicado
        }

        private void FormConsultaFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}



        
    

