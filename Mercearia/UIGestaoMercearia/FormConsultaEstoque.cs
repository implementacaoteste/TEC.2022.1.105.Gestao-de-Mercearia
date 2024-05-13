using BLL;
using Models;

namespace UIGestaoMercearia
{

    public partial class FormConsultaEstoque : Form
    {
        //private BindingSource EstoqueBindingSource = new BindingSource();
        //public int Id;
        public Estoque estoque;
        private bool selecionarRegistro;

        public FormConsultaEstoque(bool _selecionarRegistro = false)
        {
            InitializeComponent();
            this.selecionarRegistro = _selecionarRegistro;
            buttonSelecionar.Visible = selecionarRegistro;
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selecionarRegistro)
                    return;
                if (bindingSourceEstoque.Count == 0)
                {
                    MessageBox.Show("Não existe estoque para ser selecionado.");
                    return;
                }


                estoque = (Estoque)bindingSourceEstoque.Current;


                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscarPor.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 10030 } } };
                        bindingSourceEstoque.DataSource = new EstoqueBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarPor.Text));
                        break;
                    case 1:
                        bindingSourceEstoque.DataSource = new EstoqueBLL().BuscarTudo();
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
                if (bindingSourceEstoque.Count == 0)
                {
                    MessageBox.Show("Não existe grupo listado para ser alterado.");
                    return;
                }

                int id = ((Estoque)bindingSourceEstoque.Current).Id;

                using (FormCadastroEstoque frm = new FormCadastroEstoque(((Estoque)bindingSourceEstoque.Current).Id))
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
                using (FormCadastroEstoque frm = new FormCadastroEstoque())
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
                if (bindingSourceEstoque.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Estoque)bindingSourceEstoque.Current).Id;
                new EstoqueBLL().Excluir(id);
                bindingSourceEstoque.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void FormConsultaEstoque_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = comboBoxBuscarPor.Items.Count - 1; //seleciona sempre o ultimo indice da ComboBox
            buttonBuscar_Click(sender, e); //O evento load faz o botão buscar ser clicado
        }

        private void dataGridViewEstoque_DoubleClick(object sender, EventArgs e)
        {
            buttonSelecionar_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void FormConsultaEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}

