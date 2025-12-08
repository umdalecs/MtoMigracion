
using Microsoft.EntityFrameworkCore;
using MtoMigracion.Core;
using MtoMigracion.Modelos;

namespace MtoMigracion.Repositorios;

public class ClientesRepository
{
    private readonly AppDbContext ctx;

    public ClientesRepository()
    {
        this.ctx = AppDbContextFactory.GetDbContext();
    }

    // Upsert: si no existe inserta, si existe actualiza el cliente
    public void Upsert(Cliente cliente)
    {
        var existente = ctx.Clientes
           .Find(cliente.ClienteID);

        if (existente == null)
        {
            // INSERT
            ctx.Clientes.Add(cliente);
        }
        else
        {
            // UPDATE
            ctx.Entry(existente).CurrentValues.SetValues(cliente);
        }

        ctx.SaveChanges();
    }

    public IEnumerable<Cliente> GetAll()
    {
        // Lógica para obtener todos los clientes de la base de datos
        return ctx.Clientes
            .Include(n => n.NotasVenta);
    }
}
