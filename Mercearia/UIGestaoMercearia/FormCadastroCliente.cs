using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormCadastroCliente : Form
    {
        int id;
        public FormCadastroCliente(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)clienteBindingSource.Current;

                clienteBindingSource.EndEdit();

                if (id == 0)
                    new ClienteBLL().Inserir(cliente);
                else
                    new ClienteBLL().Alterar(cliente);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                    clienteBindingSource.AddNew();
                else
                    clienteBindingSource.DataSource = new ClienteBLL().BuscarPorId(id);
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

        private void FormCadastroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
