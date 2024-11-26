using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Models
{
    public class ItemCompra : Common
    {
        public string? Nome { get; set; }
        public string? Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public float Preco { get; set; }
        public decimal Total { get; set; }  
    }
}
