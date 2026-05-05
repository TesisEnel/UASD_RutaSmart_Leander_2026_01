using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RutaSmart.Data.Models;

namespace RutaSmart.Data.Data;

public partial class RutaSmartContext : DbContext
{
    public RutaSmartContext()
    {
    }

    public RutaSmartContext(DbContextOptions<RutaSmartContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Repartidore> Repartidores { get; set; }

    public virtual DbSet<Ruta> Rutas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=RutaSmart;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__Clientes__71ABD0872400CD64");

            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.PedidoId).HasName("PK__Pedidos__09BA1430458471C2");

            entity.Property(e => e.Estado).HasDefaultValue("Pendiente");
            entity.Property(e => e.FechaPedido).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Pedidos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedidos_Clientes");

            entity.HasOne(d => d.Repartidor).WithMany(p => p.Pedidos).HasConstraintName("FK_Pedidos_Repartidores");

            entity.HasOne(d => d.Ruta).WithMany(p => p.Pedidos).HasConstraintName("FK_Pedidos_Rutas");
        });

        modelBuilder.Entity<Repartidore>(entity =>
        {
            entity.HasKey(e => e.RepartidorId).HasName("PK__Repartid__2BEB7503B44D6F51");

            entity.Property(e => e.Estado).HasDefaultValue("Disponible");
        });

        modelBuilder.Entity<Ruta>(entity =>
        {
            entity.HasKey(e => e.RutaId).HasName("PK__Rutas__7B61998E7BF65666");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
