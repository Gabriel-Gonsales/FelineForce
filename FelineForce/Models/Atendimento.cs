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
        public string? Descricao { get; set; }
        public Gato Gato { get; set; }
        public Usuario? Atendente { get; set; }
        public Cliente Tutor { get; set; }  
        public enum TipoAtendimento
        {
            Banho = 0,
            Tosa = 1,
            BanhoTosa = 2,
            Vacina = 3
        }
    }
}
