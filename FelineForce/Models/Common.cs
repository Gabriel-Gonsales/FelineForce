using Microsoft.EntityFrameworkCore;

namespace FelineForce.Models
{
    public class Common
    {
        public Guid Id { get; set; } = Guid.NewGuid();  
        public bool Excluido { get; set; } = false;
        public DateTime Inclusao { get; set; } = DateTime.Now;
        public DateTime Alteracao { get; set; } = DateTime.Now;
    }
}
