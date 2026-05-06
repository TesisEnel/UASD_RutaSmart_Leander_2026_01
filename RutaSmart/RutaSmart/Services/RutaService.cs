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

public class RutaService(RutaSmartContext context) : IService<Ruta, int>
{
    public async Task<Ruta?> Buscar(int id)
    {
        return await context.Rutas.FindAsync(id);
    }

    public async Task<bool> Eliminar(int id)
    {
        var ruta = await context.Rutas.FindAsync(id);

        if (ruta == null)
            return false;

        context.Rutas.Remove(ruta);
        return (await context.SaveChangesAsync()) > 0;
    }

    public async Task<List<Ruta>> GetList(Expression<Func<Ruta, bool>> criterio)
    {
        return await context.Rutas
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Guardar(Ruta entidad)
    {
        if (entidad.RutaId == 0)
            return await Insertar(entidad);
        else
            return await Modificar(entidad);
    }

    public async Task<bool> Insertar(Ruta ruta)
    {
        context.Rutas.Add(ruta);
        return (await context.SaveChangesAsync()) > 0;
    }

    public async Task<bool> Modificar(Ruta ruta)
    {
        context.Update(ruta);
        return (await context.SaveChangesAsync()) > 0;
    }
}
