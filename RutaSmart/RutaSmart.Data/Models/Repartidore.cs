using System;
using System.Collections.Generic;

namespace RutaSmart.Data.Models;

public partial class Repartidore
{
    public int RepartidorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
