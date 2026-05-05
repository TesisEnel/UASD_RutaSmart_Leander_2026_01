using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RutaSmart.Data.Models;

public partial class Repartidore
{
    [Key]
    public int RepartidorId { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(20)]
    public string? Telefono { get; set; }

    [StringLength(50)]
    public string? Vehiculo { get; set; }

    [StringLength(20)]
    public string? Estado { get; set; }

    [InverseProperty("Repartidor")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
