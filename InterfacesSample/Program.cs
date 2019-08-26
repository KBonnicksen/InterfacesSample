using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using SimpleInjector.Lifestyles;

namespace InterfacesSample
{
    static class Program
    {
        private static Container container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureDIContainer();
        }

        /// <summary>
        /// Configure Dependency Injection Container.
        /// Registers all types and forms that need to be instantiated.
        /// </summary>
        private static void ConfigureDIContainer()
        {
            //Instantiate DI (Dependency Injection) container
            container = new Container();
            container.Options.DefaultScopedLifestyle = new ThreadScopedLifestyle();


            // Register types
            container.Register<ILogger, ConsoleLogger>(Lifestyle.Transient);
            container.Register<frmLogger>(Lifestyle.Transient);

            Registration r = container.GetRegistration(typeof(frmLogger)).Registration;
            r.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent, 
                "WelcomeForm is automatically disposed");

            //Optionally verify the ocntainer
            container.Verify();
        }
    }
}
