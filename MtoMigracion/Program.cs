using Formulario1;
using Microsoft.EntityFrameworkCore;

using MtoMigracion.Core;
using MtoMigracion.Interfaz;

namespace MtoMigracion;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var ctx = AppDbContextFactory.GetDbContext();
        ctx.Database.Migrate();
        ctx.SaveChanges();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new FInicio());
    }
}