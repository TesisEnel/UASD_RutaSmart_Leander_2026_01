using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aplicada1.Core;
using RutaSmart.Data.Data;
using RutaSmart.Data.Models;

namespace RutaSmart.UI.Services;

public class RepartidoresService(RutaSmartContext context) : IService<Repartidore, int>
{
    public async Task<Repartidore?> Buscar(int id)
    {
        return await context.Repartidores.FindAsync(id);
    }

    public async Task<bool> Eliminar(int id)
    {
        var repartidor = await context.Repartidores
           .Include(r => r.Pedidos) 
           .FirstOrDefaultAsync(r => r.RepartidorId == id);

        if (repartidor == null)
            return false;

        if (repartidor.Pedidos != null && repartidor.Pedidos.Any())
            return false;

        context.Repartidores.Remove(repartidor);

        return (await context.SaveChangesAsync()) > 0;
    }

    public async Task<List<Repartidore>> GetList(Expression<Func<Repartidore, bool>> criterio)
    {
        return await context.Repartidores
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Guardar(Repartidore entidad)
    {
        if (entidad.RepartidorId == 0)
            return await Insertar(entidad);
        else
            return await Modificar(entidad);
    }

    public async Task<bool> Insertar(Repartidore repartidor)
    {
        context.Repartidores.Add(repartidor);
        return (await context.SaveChangesAsync()) > 0;
    }

    public async Task<bool> Modificar(Repartidore repartidor)
    {

        var local = context.Set<Repartidore>()
        .Local
        .FirstOrDefault(x => x.RepartidorId == repartidor.RepartidorId);

        if (local != null)
            context.Entry(local).State = EntityState.Detached;

        context.Update(repartidor);

        return (await context.SaveChangesAsync()) > 0;
    }
}
