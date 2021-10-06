using ProductosApp.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Infraestructure.Empleados;
using Domain.Entities.Interfaces;
using AppCore.Interfaces;
using AppCore.Services;

namespace ProductosApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EmpleadoModel>().As<IEmpleadoModel>();
            builder.RegisterType<EmpleadoService>().As<IEmpleadoService>();

            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmGestionEmpleados(container.Resolve<IEmpleadoService>()));
        }
    }
}
