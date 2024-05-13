using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FormaPagamentoBLL
    {
        public void Inserir(FormaPagamento _pagamento)
        {
            new FormaPagamentoDAL().Inserir(_pagamento);
        }
        public void Alterar(FormaPagamento _pagamento)
        {
            new FormaPagamentoDAL().Alterar(_pagamento);
        }
        public void Excluir(int _id)
        {
            new FormaPagamentoDAL().Excluir(_id);
        }
        public List<FormaPagamento> BuscarTodos()
        {
            return new FormaPagamentoDAL().BuscarTudo();
        }
        public FormaPagamento BuscarPorId(int _id)
        {
            return new FormaPagamentoDAL().BuscarPorId(_id);
        }
    }
}
