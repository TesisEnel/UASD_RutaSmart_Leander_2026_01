using RutaSmart.Data.Data;
using RutaSmart.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Aplicada1.Core;
using System.Linq.Expressions;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RutaSmart.UI.Services;

public class PedidosService(RutaSmartContext context) : IService<Pedido, int>
{
    public async Task<Pedido?> Buscar(int id)
    {
        return await context.Pedidos.FindAsync(id);
    }

    public async Task<bool> Eliminar(int id)
    {
        var pedido = await context.Pedidos.FindAsync(id);

        if (pedido == null)
            return false;

        context.Pedidos.Remove(pedido);
        return (await context.SaveChangesAsync()) > 0;
    }

    public async Task<List<Pedido>> GetList(Expression<Func<Pedido, bool>> criterio)
    {
        return await context.Pedidos
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Guardar(Pedido entidad)
    {
        if (entidad.PedidoId == 0)
            return await Insertar(entidad);
        else
            return await Modificar(entidad);
    }

    public async Task<bool> Insertar(Pedido pedido)
    {
        context.Pedidos.Add(pedido);
        return (await context.SaveChangesAsync()) > 0;
    }

    public async Task<bool> Modificar(Pedido pedido)
    {
        context.Update(pedido);
        return (await context.SaveChangesAsync()) > 0;
    }
}
