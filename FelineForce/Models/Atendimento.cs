using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Models
{
    public class Atendimento : Common
    {
        public TipoAtendimento Tipo { get; set; }
        public DateTime DataAtendimento { get; set; }
        public enum TipoAtendimento
        {
            Banho = 0,
            Tosa = 1,
            Vacina = 2 
        }
    }
}
