using System;
using System.Collections.Generic;

namespace RutaSmart.Data.Models;

public partial class Ruta
{
    public int RutaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Repartidor { get; set; }

    public string? Zona { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
