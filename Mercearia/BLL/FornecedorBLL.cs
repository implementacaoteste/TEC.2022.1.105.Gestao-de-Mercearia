using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FornecedorBLL
    {
        public void Inserir(Fornecedor _Fornecedor)
        {
            new FornecedorDAL().Inserir(_Fornecedor);
        }
        public List<Fornecedor> BuscarTodos()
        {
            return new FornecedorDAL().BuscarTodos();
        }
        public List<Fornecedor> BuscarPorNome(string _nome)
        {
            return new FornecedorDAL().BuscarPorNome(_nome);
        }
        public void Alterar(Fornecedor _Fornecedor)
        {
            new FornecedorDAL().Alterar(_Fornecedor);
        }
        public void Excluir(int _id)
        {
            new FornecedorDAL().Excluir(_id);
        }
        public Fornecedor BuscarPorId(int _id)
        {
            return new FornecedorDAL().BuscarPorId(_id);
        }
    }
}
