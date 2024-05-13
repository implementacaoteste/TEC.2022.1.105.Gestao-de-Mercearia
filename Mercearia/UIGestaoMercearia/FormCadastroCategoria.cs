using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormCadastroCategoria : Form
    {
        int id;
        public FormCadastroCategoria(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void FormCadastroCategoria_Load(object sender, EventArgs e)
        {
            if (id == 0)
                categoriaBindingSource.AddNew();
            else
                categoriaBindingSource.DataSource = new CategoriaBLL().BuscarPorId(id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                categoriaBindingSource.EndEdit();
                Categoria categoria = (Categoria)categoriaBindingSource.Current;

                if (id == 0)
                    new CategoriaBLL().Inserir(categoria);
                else
                    new CategoriaBLL().Alterar(categoria);
                MessageBox.Show("Registro salvo com sucesso!");
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

        private void FormCadastroCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
