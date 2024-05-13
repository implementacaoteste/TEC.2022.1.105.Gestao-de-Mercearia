using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int IdProduto
        {
            get
            {
                if (Produto == null)
                    return 0;
                return Produto.Id;
            }
            set { }
        }
        public double Troco { get; set; }
        public int ValorPago { get; set; }
        public int IdVenda { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double CustoProduto { get; set; }
        public double SubTotal { get; set; }
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
