using System;
using System.Windows.Forms;
using DbManager.Abstractions;
using DbManager.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DbManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            using (ServiceProvider sp = serviceCollection.BuildServiceProvider())
            {
                var program = sp.GetRequiredService<DatabaseManager>();
                Application.Run(program);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<DatabaseManager>();
            services.AddSingleton<IFileAccessService,FileAccessService>();
            services.AddSingleton<IDatabaseAccessService,DbAccessService>();
        }
    }
}
