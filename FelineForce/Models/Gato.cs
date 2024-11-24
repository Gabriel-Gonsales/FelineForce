using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Models
{
    public class Gato : Common
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public Guid TutorId { get; set; }
        public Usuario Tutor { get; set; }
        public IEnumerable<Atendimento> Atendimentos { get; set; }
    }
}
