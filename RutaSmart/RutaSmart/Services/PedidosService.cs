using RutaSmart.Data.Data;
using RutaSmart.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Aplicada1.Core;
using System.Linq.Expressions;

namespace RutaSmart.UI.Services;

public class PedidosService(RutaSmartContext context) : IService<Pedido, int>
{
    public Task<Pedido?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Pedido>> GetList(Expression<Func<Pedido, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Pedido entidad)
    {
        throw new NotImplementedException();
    }
}
