
using MtoMigracion.Core;
using MtoMigracion.Modelos;

namespace MtoMigracion.Repositorios;

public class ArticulosRepository
{
    private readonly AppDbContext ctx;

    public ArticulosRepository()
    {
        this.ctx = AppDbContextFactory.GetDbContext();
    }

    // Upsert: si no existe inserta, si existe actualiza el articulo
    public void Upsert(Articulo articulo)
    {
        var existente = ctx.Articulos
           .Find(articulo.ArticuloID);

        if (existente == null)
        {
            // INSERT
            ctx.Articulos.Add(articulo);
        }
        else
        {
            // UPDATE
            ctx.Entry(existente).CurrentValues.SetValues(articulo);
        }

        ctx.SaveChanges();
    }

    public IEnumerable<Articulo> GetAll()
    {
        // Lógica para obtener todos los clientes de la base de datos
        return ctx.Articulos;
    }
}
