﻿using Models;

namespace UIGestaoMercearia
{
    public partial class FormFinalizarVenda : Form
    {
        private double totalVenda;
        public FormaPagamento FormaPagamento;
        public Cliente Cliente;
        public FormFinalizarVenda(FormaPagamento _formaPagamento, double _totalVenda)
        {
            InitializeComponent();
            totalVenda = _totalVenda;
            FormaPagamento = _formaPagamento;
            AjustarLayout();
        }

        private void AjustarLayout()
        {
            if (FormaPagamento.Tipo.ToUpper() == "DINHEIRO")
            {
                textBoxValorPago.Visible = true;
                textBoxTotal.Visible = true;
                textBoxTotal.Text = totalVenda.ToString();
                labelValorPago.Visible = true;
                labelTotal.Visible = true;
                labelFormaPagamento.Visible = true;
                textBoxFormaPagamento.Text = FormaPagamento.Tipo;
                pictureBox1.Visible = false;
            }
            else if (FormaPagamento.Tipo.ToUpper() == "PIX")
            {
                pictureBox1.Visible = true;
                labelFormaPagamento.Visible = true;
                textBoxFormaPagamento.Text = FormaPagamento.Tipo;
                textBoxTotal.Visible = true;
                textBoxTotal.Text = totalVenda.ToString();
                labelExTroco.Visible = false;
                labelTroco.Visible = false;
                labelTotal.Visible = true;
            }
            else if (FormaPagamento.Tipo.ToUpper() == "CARTÃO DE DÉBITO")
            {

            }
        }

        private void textBoxValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                if (string.IsNullOrEmpty(textBoxValorPago.Text))
                {
                    textBoxValorPago.Focus();
                }
                else
                {
                    e.Handled = true;
                    AdicionarTroco();
                }
            }
        }
        private void AdicionarTroco()
        {
            double troco;

            if (FormaPagamento.Id == 1 && Convert.ToDouble(textBoxValorPago.Text) != 0)
            {
                troco = Convert.ToDouble(textBoxValorPago.Text) - totalVenda;
                labelTroco.Text = troco.ToString();
                MessageBox.Show("Venda Concluida com sucesso!");
                Close();
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Venda Concluída!");
            Close();
        }


        private void FormFinalizarVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AdicionarTroco();
            else if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
            else if (e.KeyCode == Keys.F11)
                buttonBuscarFormaPagamento_Click(sender, e);
            else if (e.KeyCode == Keys.F12)
                buttonOk_Click(sender, e);
            else if (e.KeyCode == Keys.F10) ;
        }

        private void buttonBuscarFormaPagamento_Click(object sender, KeyEventArgs e)
        {

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
        private void button1_Click(object sender, EventArgs e)
        {
            using (FormCadastroCliente frm = new FormCadastroCliente())
            {
                frm.ShowDialog();
            }
        }

        private void FormFinalizarVenda_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscarFormaPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormPagamento frm = new FormPagamento(true))
                {
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        FormaPagamento = frm.pagamento;
                        AjustarLayout();
                        //if (frm.pagamento.Tipo.ToUpper() == "DINHEIRO" || frm.pagamento.Tipo.ToUpper() == "PIX")
                        //{
                        //    using (FormFinalizarVenda formFinalizarVenda = new FormFinalizarVenda(frm.pagamento, 40))//((Venda)bindingSourceFinalizarVenda.Current).Total))
                        //    {
                        //        formFinalizarVenda.ShowDialog();
                        //    }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
