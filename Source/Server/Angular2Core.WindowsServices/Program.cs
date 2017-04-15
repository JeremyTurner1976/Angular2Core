using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Angular2Core.WindowsServices
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new FileMaintenanceService(),
                new DatabaseMaintenanceService(),
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
