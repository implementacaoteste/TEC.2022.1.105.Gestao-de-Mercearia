using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormConfiguracao : Form
    {
        private Usuario usuario;
        private string senha;
        private string nomeUsuario;
        public FormConfiguracao(int _id)
        {
            InitializeComponent();

            usuario = new UsuarioBLL().BuscarPorId(_id);
            senha = usuario.Senha;
            nomeUsuario = usuario.NomeUsuario;
        }



        private void buttonAlterarSenha_Click(object sender, EventArgs e)
        {

            try
            {
                string senhaAtual = textBoxSenha.Text;

                if (senhaAtual != senha)
                    throw new Exception("Senha incorreta!");

                usuario.Senha = textBoxNovaSenha.Text;

                new UsuarioBLL().AlterarSenha(usuario, textBoxConfirmacaoSenha.Text);

                MessageBox.Show("Senha alterada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar senha: {ex.Message}");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlterarNomeUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxNomeUsuario.Text.ToUpper() != nomeUsuario.ToUpper())
                    throw new Exception("Nome de usuário incorreto");

                usuario.NomeUsuario = textBoxNovoNomeUsuario.Text;

                new UsuarioBLL().AlterarNomeUsuario(usuario);

                MessageBox.Show("Nome de usuário alterado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar nome de usuário: {ex.Message}");
            }
        }

        private void FormConfiguracao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonAjuda_Click(object sender, EventArgs e)
        {
            using (FormConsultaAjuda frm = new FormConsultaAjuda())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAjuda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                buttonAjuda_Click(sender, e);
        }
    }


}