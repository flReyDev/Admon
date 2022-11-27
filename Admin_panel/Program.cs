using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_panel.Helpers;
using Admin_panel.Helpers.Functions;
using Admin_panel.Helpers.Web;
using Admin_panel.Views.Login;
using Microsoft.Extensions.DependencyInjection;

namespace Admin_panel
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            Services(services);

            using (var provider = services.BuildServiceProvider())
            {
                var form1 = provider.GetRequiredService<Home>();
                Application.Run(form1);
            }
        }

        private static void Services( ServiceCollection service )
        {
            service.AddScoped<IHelperF, HelperF>()
                .AddScoped<IHttpHelper, HttpHelper>()
                .AddScoped<Home>();
        }
    }
}
