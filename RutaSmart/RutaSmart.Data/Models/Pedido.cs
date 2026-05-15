using System;
using System.Collections.Generic;

namespace RutaSmart.Data.Models;

public partial class Pedido
{
    public int PedidoId { get; set; }

    public int ClienteId { get; set; }

    public int? RepartidorId { get; set; }

    public int? RutaId { get; set; }

    public DateTime? FechaPedido { get; set; }

    public string? DireccionEntrega { get; set; }

    public string? DireccionRecolecion { get; set; }

    public string? Estado { get; set; }

    public decimal? Total { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual Repartidore? Repartidor { get; set; }

    public virtual Ruta? Ruta { get; set; }
}
