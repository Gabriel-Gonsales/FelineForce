using ERP_com_relatorio;
using ERP_com_relatorio.Services;
using FelineForce.Repository;
using FelineForce.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FelineForce
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionString = configuration.GetConnectionString("FelineForceDB");

            // Configuração do ServiceProvider com DI
            var serviceProvider = new ServiceCollection()
                .AddDbContext<FelineForceContext>(options =>
                    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21))))
                .AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>))
                .AddScoped<IUsuarioRepository, UsuarioRepository>()
                .AddScoped<UsuarioService>()
                .BuildServiceProvider();

            var usuarioService = serviceProvider.GetService<UsuarioService>();

            // Usar o contexto FelineForceContext com o ServiceProvider
            using (var context = serviceProvider.GetRequiredService<FelineForceContext>())
            {
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
