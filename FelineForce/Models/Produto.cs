using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Models
{
    public class Produto : Common
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public float Preco { get; set; }
        public IEnumerable<ItemVenda> ItensVenda { get; set; }
        public IEnumerable<ItemCompra> ItensCompra { get; set; }
    }
}
