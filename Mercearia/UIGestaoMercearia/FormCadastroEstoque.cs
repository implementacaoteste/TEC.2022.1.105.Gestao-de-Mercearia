using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormCadastroEstoque : Form
    {
        int id;
        public FormCadastroEstoque(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarProduto_Click(object sender, EventArgs e)
        {
            using (FormConsultaProduto frm = new FormConsultaProduto(true))
            {
                frm.ShowDialog();
                if (frm.produto != null)
                {
                    ((Estoque)bindingSourceEstoque.Current).Produto = frm.produto;
                    textBoxNomeProduto.Text = frm.produto.Nome;
                    ((Estoque)bindingSourceEstoque.Current).IdProduto = frm.produto.Id;
                }
            }
        }

        private void FormeCadastroEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                    bindingSourceEstoque.AddNew();
                else
                    bindingSourceEstoque.DataSource = new EstoqueBLL().BuscarPorId(id);
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

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Estoque estoque = (Estoque)bindingSourceEstoque.Current;

                bindingSourceEstoque.EndEdit();

                if (id == 0)
                    new EstoqueBLL().Inserir(estoque);
                else
                    new EstoqueBLL().Alterar(estoque);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
