using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FuncionarioBLL
    {
        public void Inserir(Funcionario _funcionario)
        {
            new FuncionarioDAL().Inserir(_funcionario);
        }
        public List<Funcionario> BuscarTodos()
        {
            return new FuncionarioDAL().BuscarTodos();
        }
        public List<Funcionario> BuscarPorNome(string _nome)
        {
            return new FuncionarioDAL().BuscarPorNome(_nome);
        }
        public void Alterar(Funcionario _funcionario)
        {
            new FuncionarioDAL().Alterar(_funcionario);
        }
        public void Excluir(int _id)
        {
            new FuncionarioDAL().Excluir(_id);
        }

        public Funcionario BuscarPorId(int _id)
        {
            return new FuncionarioDAL().BuscarPorId(_id);
        }
    }
}
