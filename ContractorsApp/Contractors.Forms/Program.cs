using Contractors.DatabaseCore;
using Microsoft.Extensions.DependencyInjection;

namespace Contractors.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);
            var servicesProvider = services.BuildServiceProvider();

            var dbContext = new ContractorsContext();
            dbContext.Database.EnsureCreated();

            Application.Run(servicesProvider.GetRequiredService<MainForm>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ContractorsContext>();
            services.AddSingleton<MainForm>();
        }
    }
}