using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RutaSmart.Data.Models;

public partial class Ruta
{
    [Key]
    public int RutaId { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(200)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Distancia { get; set; }

    public int? TiempoEstimado { get; set; }

    [InverseProperty("Ruta")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
