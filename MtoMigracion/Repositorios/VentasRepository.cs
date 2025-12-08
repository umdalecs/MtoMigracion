
using Microsoft.EntityFrameworkCore;
using MtoMigracion.Core;
using MtoMigracion.Modelos;

namespace MtoMigracion.Repositorios;

public class VentasRepository
{
    private readonly AppDbContext ctx;

    public VentasRepository()
    {
        this.ctx = AppDbContextFactory.GetDbContext();
    }

    // Upsert: si no existe inserta, si existe actualiza la venta
    public void Upsert(NotaVenta notaVenta)
    {
        var existente = ctx.NotasVenta
           .Find(notaVenta.NotaVentaID);

        if (existente == null)
        {
            // INSERT
            ctx.NotasVenta.Add(notaVenta);
        }
        else
        {
            // UPDATE
            ctx.Entry(existente).CurrentValues.SetValues(notaVenta);
        }

        ctx.SaveChanges();
    }

    public IEnumerable<NotaVenta> GetAll()
    {
        // Lógica para obtener todos los clientes de la base de datos
        return ctx.NotasVenta
            .Include(n => n.Cliente)
            .Include(n => n.DetallesNotaVenta)
                .ThenInclude(d => d.Articulo);
    }
}
