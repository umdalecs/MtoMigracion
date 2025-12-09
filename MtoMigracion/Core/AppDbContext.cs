using Microsoft.EntityFrameworkCore;
using MtoMigracion.Modelos;

namespace MtoMigracion.Core;

// Provee un singleton de AppDbContext
public class AppDbContextFactory
{
    private static AppDbContext? _ctx;
    private AppDbContextFactory() {  }
    public static AppDbContext GetDbContext()
    {
        _ctx ??= new AppDbContext();
        return _ctx;
    }
}

// Contexto de la base de datos
// Define los DbSet(tablas) para las entidades
// y establece la configuración de la conexión
public class AppDbContext: DbContext
{
    public DbSet<Usuario> Usuarios { get; init; }
    public DbSet<Proveedor> Proveedores { get; init; }
    public DbSet<Cliente> Clientes { get; init; }
    public DbSet<Articulo> Articulos { get; init; }
    public DbSet<NotaVenta> NotasVenta{ get; init; }
    public DbSet<DetalleNotaVenta> DetalleNotasVenta { get; init; }


    public AppDbContext() {  }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Es posible que sea necesario ajustar la cadena de conexión
        optionsBuilder.UseSqlServer(
            @"Server=DESKTOP-5VL67M5\GESTION;Database=RYCSEM;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
