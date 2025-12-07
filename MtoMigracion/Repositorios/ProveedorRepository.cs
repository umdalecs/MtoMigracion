using MtoMigracion.Core;
using MtoMigracion.Modelos;

namespace MtoMigracion.Repositorios;

public class ProveedorRepository
{
    private readonly AppDbContext ctx;

    public ProveedorRepository()
    {
        this.ctx = AppDbContextFactory.GetDbContext();
    }

    // Upsert: si no existe inserta, si existe actualiza un proveedor
    public void Upsert(Proveedor proveedor)
    {
        var existente = ctx.Proveedores
           .Find(proveedor.ProveedorID);

        if (existente == null)
        {
            // INSERT
            ctx.Proveedores.Add(proveedor);
        }
        else
        {
            // UPDATE
            ctx.Entry(existente).CurrentValues.SetValues(proveedor);
        }

        ctx.SaveChanges();
    }

    public IEnumerable<Proveedor> GetAll()
    {
        // Lógica para obtener todos los proveedores de la base de datos
        return ctx.Proveedores;
    }
}
