using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Models
{
    public class Cliente : Common
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? CPF { get; set; }
        public IEnumerable<Gato> Gatos { get; set; }
        public IEnumerable<Atendimento> Atendimentos { get; set; }
        public IEnumerable<Venda> Vendas { get; set; }
    }
}
