using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProdutoBLL
    {
        public void Inserir(Produto _produto)
        {
            new ProdutoDAL().Inserir(_produto);
        }
        public List<Produto> BuscarTodos()
        {
            return new ProdutoDAL().BuscarTodos();
        }
        public List<Produto> BuscarPorNome(string _nome)
        {
            return new ProdutoDAL().BuscarPorNome(_nome);
        }
        public Produto BuscarPorId(int _id)
        {
            return new ProdutoDAL().BuscarPorId(_id);
        }
        public Produto BuscarPorCodigoDeBarra(string _codigodebarra)
        {
            return new ProdutoDAL().BuscarPorCodigoDeBarra(_codigodebarra);
        }
        public void Alterar(Produto _produto)
        {
            new ProdutoDAL().Alterar(_produto);
        }
        public void Excluir(int _id)
        {
            new ProdutoDAL().Excluir(_id);
        }
    }
}
