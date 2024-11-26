using ERP_com_relatorio;
using FelineForce.Repository;
using FelineForce.Repository.Interfaces;
using FelineForce.Services;
using FelineForce.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace FelineForce
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Configuração da string de conexão a partir do arquivo appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionString = configuration.GetConnectionString("FelineForceDB");

            // Configuração do ServiceProvider com DI
            /*var serviceProvider = new ServiceCollection()
                .AddDbContext<FelineForceContext>(options =>
                    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21))),
                    ServiceLifetime.Scoped) // Mantém escopado para segurança
                .AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>))
                .AddScoped<IUsuarioRepository, UsuarioRepository>()
                .AddScoped<UsuarioService>()
                .AddScoped<IClienteService, ClienteService>()
                .AddTransient<frmLogin>()
                .AddTransient<frmAreaComum>()
                .AddTransient<frmCadastroCliente>()
                .BuildServiceProvider();*/
            var serviceProvider = new ServiceCollection()
                .AddDbContext<FelineForceContext>(options =>
                    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21))),
                    ServiceLifetime.Singleton) // Aqui o DbContext está como Scoped
                .AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>))
                .AddScoped<IClienteService, ClienteService>()
                .AddScoped<IEstoqueService, EstoqueService>()
                .AddScoped<ILogService, LogService>()
                .AddScoped<IGatoService, GatoService>()
                .AddScoped<IAutenticacaoService, AutenticacaoService>()
                .AddScoped<ILogRepository, LogRepository>()
                .AddScoped<IGatoRepository, GatoRepository>()
                .AddScoped<IUsuarioRepository, UsuarioRepository>()
                .AddScoped<IUsuarioService, UsuarioService>()
                .AddScoped<IAgendamentoService, AgendamentoService>()
                .AddScoped<IVendasRepository, VendasRepository>()
                .AddScoped<IVendaService, VendaService>()
                .AddTransient<frmLogin>()
                .AddTransient<frmAreaComum>()
                .AddTransient<frmCadastroCliente>()
                .BuildServiceProvider();

            // Configurações de inicialização do Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializando a aplicação com o formulário de login
            using (var scope = serviceProvider.CreateScope()) // Mantém o escopo da aplicação durante todo o ciclo
            {
                var loginForm = scope.ServiceProvider.GetRequiredService<frmLogin>();
                Application.Run(loginForm);  // Esse será o ponto de entrada
            }
        }
    }
}