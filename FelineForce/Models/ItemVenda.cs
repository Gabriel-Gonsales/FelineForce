using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Models
{
    public class ItemVenda : Common
    {
        public string? Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
        [NotMapped]
        public Guid ItemProdId { get; set; }
    }
}
