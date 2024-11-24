using FelineForce.Models;
using Microsoft.EntityFrameworkCore;

public class FelineForceContext : DbContext
{
    public DbSet<ClasseTeste> Testes { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Gato> Gatos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Atendimento> Atendimentos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ItemVenda> ItensVenda { get; set; }
    public DbSet<Venda> Vendas { get; set; }
    public DbSet<ItemCompra> ItensCompra { get; set; }
    public DbSet<Compra> Compras { get; set; }
    public DbSet<LogSistema> Logs { get; set; }

    public FelineForceContext(DbContextOptions<FelineForceContext> options)
        : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Defina a string de conexão com o MySQL
            optionsBuilder.UseMySql("Server=localhost;Database=felineForce;Uid=root;Pwd=gabu43;",
                new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }
}