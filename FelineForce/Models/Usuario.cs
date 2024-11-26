namespace FelineForce.Models
{
    public class Usuario : Common
    {
        public string Nome { get; set; }  
        public string? Email { get; set; }
        public decimal Salario { get; set; }
        public int HorasTrabalhadas { get; set; }
        public string Senha { get; set; }  
        public TipoUsuario Tipo { get; set; }  
        public bool Bloqueado { get; set; }
        public IEnumerable<Atendimento>? Atendimentos { get; set; }
        public IEnumerable<Venda>? Vendas { get; set; }
        public IEnumerable<LogSistema>? Logs { get; set; }
        public enum TipoUsuario
        {
            Administrador = 0,
            Atendente = 1,
            Tosador = 2,
            Veterinario = 3
        }
    }
}
