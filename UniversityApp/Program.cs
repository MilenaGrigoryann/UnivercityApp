using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureServices(new ServiceCollection());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            services.AddServices()
                .AddSingleton(typeof(Univercity))
                .AddSingleton(typeof(StudentDetails));

            var serviceProvider = services.BuildServiceProvider();
            var mainForm = (Univercity)serviceProvider.GetService(typeof(Univercity));
            Application.Run(mainForm);
        }
    }
}
