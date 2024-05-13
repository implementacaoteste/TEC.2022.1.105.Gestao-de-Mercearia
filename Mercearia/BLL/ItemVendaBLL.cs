using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ItemVendaBLL
    {
        public void Inserir(ItemVenda _item)
        {
            new ItemVendaDAL().Inserir(_item);
        }
        public void Alterar(ItemVenda _item)
        {
            new ItemVendaDAL().Alterar(_item);
        }
        public void Excluir(int _id)
        {
            new ItemVendaDAL().Excluir(_id);
        }
        public ItemVenda BuscarPorIdVenda(int _idVenda)
        {
            return new ItemVendaDAL().BuscarPorIdVenda(_idVenda);
        }
    }
}
