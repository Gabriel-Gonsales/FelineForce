using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Models
{
    public class Venda : Common
    {
        public decimal TotalCompra { get; set; }
        public string? CPFCliente { get; set; }
        public IEnumerable<ItemVenda> Itens { get;set; }
    }
}
