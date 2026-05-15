using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RutaSmart.Data.Data;
using RutaSmart.UI.Clientes;
using RutaSmart.UI.Dashboard;
using RutaSmart.UI.Pedidos;
using RutaSmart.UI.Repartidores;
using RutaSmart.UI.Reportes;
using RutaSmart.UI.Rutas;
using RutaSmart.UI.Services;
using System.Windows.Forms;

namespace RutaSmart
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<RutaSmartContext>(options =>
                options.UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=RutaSmart;Trusted_Connection=True;TrustServerCertificate=True;",
                    sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure();
                    }
                ));

            // Forms
            services.AddTransient<MainForm>();
            services.AddTransient<Rutas>();
            services.AddTransient<Clientes>();
            services.AddTransient<Pedidos>();
            services.AddTransient<Repartidores>();
            services.AddTransient<FrmReportes>();
            services.AddTransient<Dashboard>();

            // Services
            services.AddTransient<ClienteService>();
            services.AddTransient<PedidosService>();
            services.AddTransient<RepartidoresService>();
            services.AddTransient<RutaService>();
        }
    }
}