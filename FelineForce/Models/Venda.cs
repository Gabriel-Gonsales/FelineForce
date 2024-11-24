using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Models
{
    public class Venda : Common
    {
        public IEnumerable<ItemVenda> Itens { get;set; }
    }
}
