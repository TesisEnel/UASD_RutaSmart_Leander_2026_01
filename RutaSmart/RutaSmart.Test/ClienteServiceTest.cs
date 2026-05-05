using Microsoft.EntityFrameworkCore;
using RutaSmart.Data.Models;
using RutaSmart.UI.Services;
using System;
using System.Threading.Tasks;
using RutaSmart.Test.Infraestructura;
using Xunit;

namespace RutaSmart.Test;

public class ClienteServiceTests
{
    [Fact]
    public async Task Buscar_CuandoExisteCliente_RetornaEntidad()
    {
        // Arrange
        var dbName = TestDbContextFactory.NewDatabase();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Clientes.Add(CreateCliente(1, "Juan Pérez"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new ClienteService(context);

        // Act
        var result = await service.Buscar(1);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(1, result!.ClienteId);
        Assert.Equal("Juan Pérez", result.Nombre);
    }

    [Fact]
    public async Task Buscar_CuandoNoExisteCliente_RetornaNull()
    {
        // Arrange
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabase());
        var service = new ClienteService(context);

        // Act
        var result = await service.Buscar(99);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public async Task GetList_CuandoSeFiltraPorNombre_RetornaCoincidencias()
    {
        // Arrange
        var dbName = TestDbContextFactory.NewDatabase();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Clientes.AddRange(
                CreateCliente(1, "Ana"),
                CreateCliente(2, "Antonio"),
                CreateCliente(3, "Beatriz")
            );
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new ClienteService(context);

        // Act
        var result = await service.GetList(c => c.Nombre.StartsWith("An"));

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Contains(result, c => c.ClienteId == 1);
        Assert.Contains(result, c => c.ClienteId == 2);
    }

    [Fact]
    public async Task Guardar_CuandoClienteNoExiste_InsertaYRetornaTrue()
    {
        // Arrange
        var dbName = TestDbContextFactory.NewDatabase();
        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new ClienteService(context);

        var nuevo = CreateCliente(0, "Carlos"); // ID 0 = insertar

        // Act
        var result = await service.Guardar(nuevo);

        // Assert
        Assert.True(result);

        var saved = await context.Clientes.FirstOrDefaultAsync(c => c.Nombre == "Carlos");
        Assert.NotNull(saved);
    }

    [Fact]
    public async Task Guardar_CuandoClienteExiste_ModificaYRetornaTrue()
    {
        // Arrange
        var dbName = TestDbContextFactory.NewDatabase();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Clientes.Add(CreateCliente(20, "Original"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new ClienteService(context);

        var actualizado = CreateCliente(20, "Modificado");

        // Act
        var result = await service.Guardar(actualizado);

        // Assert
        Assert.True(result);

        var saved = await context.Clientes.FindAsync(20);
        Assert.NotNull(saved);
        Assert.Equal("Modificado", saved!.Nombre);
    }

    [Fact]
    public async Task Eliminar_CuandoExisteCliente_LoBorraYRetornaTrue()
    {
        // Arrange
        var dbName = TestDbContextFactory.NewDatabase();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Clientes.Add(CreateCliente(30, "ParaBorrar"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new ClienteService(context);

        // Act
        var result = await service.Eliminar(30);

        // Assert
        Assert.True(result);

        var eliminado = await context.Clientes.FindAsync(30);
        Assert.Null(eliminado);
    }

    private static Cliente CreateCliente(int id, string nombre)
    {
        return new Cliente
        {
            ClienteId = id,
            Nombre = nombre,
            Email = ($"{nombre.Replace(" ", "").ToLower()}@test.local")
        };
    }
}