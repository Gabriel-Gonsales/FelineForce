using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FelineForce
{
    public class FelineForceContextFactory : IDesignTimeDbContextFactory<FelineForceContext>
    {
        public FelineForceContext CreateDbContext(string[] args)
        {
            // Obtém a string de conexão do arquivo de configuração (appsettings.json)
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionString = configuration.GetConnectionString("FelineForceDB");

            var optionsBuilder = new DbContextOptionsBuilder<FelineForceContext>();
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21)));

            return new FelineForceContext(optionsBuilder.Options);
        }
    }
}