using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBLL
    {
        public void Inserir(Categoria _categoria)
        {
            new CategoriaDAL().Inserir(_categoria);
        }
        public void Alterar(Categoria _categoria)
        {
            new CategoriaDAL().Alterar(_categoria);
        }
        public void Excluir(int _id)
        {
            new CategoriaDAL().Excluir(_id);
        }
        public List<Categoria> BuscarTodos()
        {
            return new CategoriaDAL().BuscarTudo();
        }
        public Categoria BuscarPorId(int _id)
        {
            return new CategoriaDAL().BuscarPorId(_id);
        }
    }
}
