using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormPagamento : Form
    {
        public FormaPagamento pagamento;
        private bool selecionarRegistro;

        public FormPagamento(bool _selecionarRegistro = false)
        {
            InitializeComponent();
            this.selecionarRegistro = _selecionarRegistro;
            buttonSelecionar.Visible = selecionarRegistro;
            bindingSourcePagamento.MoveNext();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroPagamento frm = new FormCadastroPagamento())
                {
                    frm.ShowDialog();
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
                if (bindingSourcePagamento.Count == 0)
                {
                    MessageBox.Show("Não existe Pagamento para ser alterado.");
                    return;
                }

                int id = ((FormaPagamento)bindingSourcePagamento.Current).Id;

                using (FormCadastroPagamento frm = new FormCadastroPagamento(id))
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(comboBoxBuscarPor.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 10030 } } };
                        bindingSourcePagamento.DataSource = new FormaPagamentoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarPor.Text));
                        break;
                    case 1:
                        bindingSourcePagamento.DataSource = new FormaPagamentoBLL().BuscarTodos();
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

        private void FormPagamento_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = comboBoxBuscarPor.Items.Count - 1; //seleciona sempre o ultimo indice da ComboBox
            buttonBuscar_Click(sender, e); //O evento load faz o botão buscar ser clicado
            HabilitarComponentes();

        }

        private void HabilitarComponentes()
        {
            HabilitarBotao(buttonInserir, new UsuarioBLL().ValidarPermissao(36, false));
            HabilitarBotao(buttonAlterar, new UsuarioBLL().ValidarPermissao(37, false));
            HabilitarBotao(buttonExcluir, new UsuarioBLL().ValidarPermissao(38, false));
        }
        private void HabilitarBotao(System.Windows.Forms.Button button, bool ativo)
        {
            if (ativo)
            {
                button.BackColor = Color.White;
                button.ForeColor = SystemColors.ControlText;
            }
            else
            {
                button.BackColor = SystemColors.Control;
                button.ForeColor = SystemColors.ControlText;
            }
            button.Enabled = ativo;
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

        private void dataGridViewCategoria_DoubleClick(object sender, EventArgs e)
        {
            buttonSelecionar_Click(sender, e);
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selecionarRegistro)
                    return;
                if (bindingSourcePagamento.Count == 0)
                {
                    MessageBox.Show("Não existe forma de pagamento para ser selecionado.");
                    return;
                }

                pagamento = (FormaPagamento)bindingSourcePagamento.Current;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourcePagamento.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((FormaPagamento)bindingSourcePagamento.Current).Id;
                new FormaPagamentoBLL().Excluir(id);
                bindingSourcePagamento.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxBuscarPor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSelecionar_Click(sender, e);
            else if (e.KeyCode == Keys.Down)
                bindingSourcePagamento.MoveNext();
            else if (e.KeyCode == Keys.Up)
                bindingSourcePagamento.MovePrevious();
            else if (e.KeyCode == Keys.F1)
                buttonAjuda_KeyDown(sender, e);
            else if (e.KeyCode == Keys.F2)
                comboBoxBuscarPor_Click(sender, e);
        }
        private void FormPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape);
        }
        private void buttonAjuda_KeyDown(object sender, KeyEventArgs e)
        {
            using (FormConsultaAjuda frm = new FormConsultaAjuda())
            {
                frm.ShowDialog();
            }
        }
        private void buttonAjuda_Click(object sender, EventArgs e)
        {
            using (FormConsultaAjuda frm = new FormConsultaAjuda())
            {
                frm.ShowDialog();
            }
        }

        private void comboBoxBuscarPor_Click(object sender, EventArgs e)
        {
            using (FormPagamento frm = new FormPagamento())
            {
                frm.ShowDialog();
            }
        }
    }
}