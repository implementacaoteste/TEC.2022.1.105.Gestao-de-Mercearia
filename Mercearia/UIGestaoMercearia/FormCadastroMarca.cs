using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormCadastroMarca : Form
    {
        int id;
        public FormCadastroMarca(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                marcaBindingSource.EndEdit();
                Marca marca = (Marca)marcaBindingSource.Current;

                if (id == 0)
                    new MarcaBLL().Inserir(marca);
                else
                    new MarcaBLL().Alterar(marca);
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroMarca_Load(object sender, EventArgs e)
        {
            if (id == 0)
                marcaBindingSource.AddNew();
            else
                marcaBindingSource.DataSource = new MarcaBLL().BuscarPorId(id);
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

        private void FormCadastroMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
