using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RutaSmart.Data.Models;

public partial class Pedido
{
    [Key]
    public int PedidoId { get; set; }

    public int ClienteId { get; set; }

    public int? RepartidorId { get; set; }

    public int? RutaId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaPedido { get; set; }

    [StringLength(50)]
    public string? Estado { get; set; }

    [StringLength(200)]
    public string? DireccionEntrega { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Total { get; set; }

    [ForeignKey("ClienteId")]
    [InverseProperty("Pedidos")]
    public virtual Cliente Cliente { get; set; } = null!;

    [ForeignKey("RepartidorId")]
    [InverseProperty("Pedidos")]
    public virtual Repartidore? Repartidor { get; set; }

    [ForeignKey("RutaId")]
    [InverseProperty("Pedidos")]
    public virtual Ruta? Ruta { get; set; }
}
