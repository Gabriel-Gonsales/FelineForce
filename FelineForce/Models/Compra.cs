using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Models
{
    public class Compra : Common
    {
        public IEnumerable<ItemCompra> Itens { get;set; }
    }
}
