using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public DateTime DatadeEntrada { get; set; }
        public DateTime DatadeSaida { get; set; }
        public int EstoqueMinimo { get; set; }
        public int EstoqueMaximo { get; set; }
        public int QtdEstoque { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public string NomeProduto
        {
            get
            {
                if (Produto == null)
                    return string.Empty;
                return Produto.Nome;
            }
        }
    }
}
