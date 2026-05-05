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
    public Task<Cliente?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Cliente>> GetList(Expression<Func<Cliente, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Cliente entidad)
    {
        throw new NotImplementedException();
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
