using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormCadastroFornecedor : Form
    {
        int id;
        public FormCadastroFornecedor(int _id = 0)
        {
            InitializeComponent();
            id = _id;
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

        private void FormCadastroFornecedor_Load(object sender, EventArgs e)
        {
            if (id == 0)
                fornecedorBindingSource.AddNew();
            else
                fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarPorId(id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor fornecedor = (Fornecedor)fornecedorBindingSource.Current;

                fornecedorBindingSource.EndEdit();

                if (id == 0)
                    new FornecedorBLL().Inserir(fornecedor);
                else
                    new FornecedorBLL().Alterar(fornecedor);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
