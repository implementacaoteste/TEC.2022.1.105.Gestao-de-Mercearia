using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormPontoDeVenda : Form
    {
        int id;
        private object itemVenda;
        double total;

        public Produto produtoAtual { get; private set; }
        public FormPontoDeVenda(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente cancelar essa venda", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    textBoxCodigodeBarras.Focus();
                    return;
                }
                textBoxCodigodeBarras.Text = "";
                labelpreco.Text = "";
                textBoxQuantidade.Text = "1";
                labelNomeProduto.Text = "NOME DO PRODUTO";
                labelSubtotal.Text = "00,00";

                bindingSourceVenda.CancelEdit();
                bindingSourceVenda.AddNew();
                textBoxCodigodeBarras.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    bindingSourceVenda.EndEdit();
                    Venda venda = (Venda)bindingSourceVenda.Current;

                    if (id == 0)
                        new VendaBLL().Inserir(venda);

                    MessageBox.Show("Registro salvo com sucesso!");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void FormInicializarVenda_Load(object sender, EventArgs e)
        {
            bindingSourceVenda.AddNew();
            textBoxCodigodeBarras.Focus();
        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            using (FormConsultaProduto frm = new FormConsultaProduto(true))
            {
                frm.ShowDialog();
                if (frm.produto != null)
                {
                    ((ItemVenda)bindingSourceVenda.Current).Produto = frm.produto;
                    textBoxCodigodeBarras.Text = frm.produto.CodigoDeBarra;
                    ((ItemVenda)bindingSourceVenda.Current).Id = frm.produto.Id;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (FormConsultaProduto frm = new FormConsultaProduto(true))
            {
                frm.ShowDialog();
                if (frm.produto != null)
                {
                    textBoxCodigodeBarras.Text = frm.produto.CodigoDeBarra;
                    labelNomeProduto.Text = frm.produto.Nome;
                    textBoxPrecoProduto.Text = $" {frm.produto.Preco:C}";
                }
            }
        }
        private void textBoxCodigodeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
                buttonFinalizarVenda_Click(sender, e);
            else if (e.KeyCode == Keys.F11)
                buttonCancelar_Click(sender, e);
            else if (e.KeyCode == Keys.F1)
                buttonAjuda_KeyDown(sender, e);
            else if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void AdicionarProduto()
        {
            Subtotal2.Text = "0,0";
            Produto produto = new ProdutoBLL().BuscarPorCodigoDeBarra(textBoxCodigodeBarras.Text);
            labelNomeProduto.Text = produto.Nome;
            labelpreco.Text = $" {produto.Preco:C}";
            itemVendaListBindingSource.AddNew();
            ((ItemVenda)itemVendaListBindingSource.Current).Produto = produto;
            ((ItemVenda)itemVendaListBindingSource.Current).ValorUnitario = produto.Preco;
            ((ItemVenda)itemVendaListBindingSource.Current).CustoProduto = produto.Custo;
            ((ItemVenda)itemVendaListBindingSource.Current).Quantidade = Convert.ToDouble(textBoxQuantidade.Text);
            ((ItemVenda)itemVendaListBindingSource.Current).SubTotal = ((ItemVenda)itemVendaListBindingSource.Current).Quantidade * ((ItemVenda)itemVendaListBindingSource.Current).ValorUnitario;
            ((Venda)bindingSourceVenda.Current).Total += ((ItemVenda)itemVendaListBindingSource.Current).SubTotal;
            total = ((Venda)bindingSourceVenda.Current).Total;
            Subtotal2.Text = $"{((Venda)bindingSourceVenda.Current).Total:C}";
            textBoxCodigodeBarras.Text = "";
            textBoxCodigodeBarras.Focus();
        }
        private void textBoxCodigodeBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBoxCodigodeBarras.Text))
                {
                    e.Handled = true;
                    AdicionarProduto();
                }
                else
                    textBoxQuantidade.Focus();
            }
        }
        private void textBoxQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBoxQuantidade.Text))
                textBoxCodigodeBarras.Focus();
        }
        private void buttonFinalizarVenda_Click(object sender, EventArgs e)
        {
            textBoxCodigodeBarras.Text = "";
            labelpreco.Text = "";
            textBoxQuantidade.Text = "1";
            labelNomeProduto.Text = "NOME DO PRODUTO";
            labelSubtotal.Text = "00,00";
            try
            {
                FormaPagamento formaPagamento = new FormaPagamento();
                using (FormPagamento frm = new FormPagamento(true))
                {
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        formaPagamento = frm.pagamento;
                        if (formaPagamento.Tipo.ToUpper() == "DINHEIRO" || formaPagamento.Tipo.ToUpper() == "PIX")
                        {
                            using (FormFinalizarVenda formFinalizarVenda = new FormFinalizarVenda(formaPagamento, ((Venda)bindingSourceVenda.Current).Total))
                            {
                                formFinalizarVenda.ShowDialog();
                            }
                        }
                    }
                }
                ((Venda)bindingSourceVenda.Current).IdFormaPagamento = formaPagamento.Id;
                new VendaBLL().Inserir((Venda)bindingSourceVenda.Current);
                bindingSourceVenda.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAjuda_KeyDown(object sender, KeyEventArgs e)
        {
            using (FormConsultaAjuda frm = new FormConsultaAjuda())
            {
                frm.ShowDialog();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }
    }
}