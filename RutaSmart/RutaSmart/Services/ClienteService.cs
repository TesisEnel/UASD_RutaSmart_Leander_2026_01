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


public class ClienteService(RutaSmartContext context) : IService<Cliente, int>
{
    public async Task<Cliente?> Buscar(int id)
    {
        return await context.Clientes.FindAsync(id);
    }

    public async Task<bool> Eliminar(int id)
    {
        var cliente = await context.Clientes.FindAsync(id);

        if (cliente == null)
            return false;

        context.Clientes.Remove(cliente);
        return (await context.SaveChangesAsync()) > 0;
    }

    public async Task<List<Cliente>> GetList(Expression<Func<Cliente, bool>> criterio)
    {
        return await context.Clientes
        .Where(criterio)
        .ToListAsync();
    }

    public async Task<bool> Guardar(Cliente entidad)
    {
        if (entidad.ClienteId == 0)
            return await Insertar(entidad);
        else
            return await Modificar(entidad);
    }

    public async Task<bool> Insertar(Cliente cliente)
    {
        context.Clientes.Add(cliente);
        return (await context.SaveChangesAsync()) > 0;
    }

    public async Task<bool> Modificar(Cliente cliente)
    {
        context.Update(cliente);
        return (await context.SaveChangesAsync()) > 0;
    }
}
