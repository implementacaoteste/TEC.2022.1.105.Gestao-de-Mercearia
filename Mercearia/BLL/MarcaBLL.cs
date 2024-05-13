using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MarcaBLL
    {
        public void Inserir(Marca _marca)
        {
            new MarcaDAL().Inserir(_marca);
        }
        public void Alterar(Marca _marca)
        {
            new MarcaDAL().Alterar(_marca);
        }
        public void Excluir(int _id)
        {
            new MarcaDAL().Excluir(_id);
        }
        public List<Marca> BuscarTodos()
        {
            return new MarcaDAL().BuscarTudo();
        }
        public Marca BuscarPorId(int _id)
        {
            return new MarcaDAL().BuscarPorId(_id);
        }
    }
}
