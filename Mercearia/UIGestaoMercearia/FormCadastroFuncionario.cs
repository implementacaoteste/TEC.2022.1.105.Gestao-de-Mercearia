using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormCadastroFuncionario : Form
    {
        public int Id { get; set; }

        public FormCadastroFuncionario(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = (Funcionario)bindingSourceCadastrarFuncionario.Current;

                bindingSourceCadastrarFuncionario.EndEdit();

                if (Id == 0)
                    new FuncionarioBLL().Inserir(funcionario);
                else
                    new FuncionarioBLL().Alterar(funcionario);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastroFuncionario_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                bindingSourceCadastrarFuncionario.AddNew();
            else
                bindingSourceCadastrarFuncionario.DataSource = new FuncionarioBLL().BuscarPorId(Id);
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
        private void FormCadastroFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
