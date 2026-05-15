using Microsoft.EntityFrameworkCore;
using RutaSmart.Data.Models;
using RutaSmart.UI.Services;
using System.Threading.Tasks;
using RutaSmart.Test.Infraestructura;
using Xunit;

namespace RutaSmart.Test;

public class RepartidoresServiceTests
{
    [Fact]
    public async Task Buscar_CuandoExisteRepartidor_RetornaEntidad()
    {
        var dbName = TestDbContextFactory.NewDatabase();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Repartidores.Add(CreateRepartidor(1, "Pedro"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new RepartidoresService(context);

        var result = await service.Buscar(1);

        Assert.NotNull(result);
        Assert.Equal(1, result!.RepartidorId);
        Assert.Equal("Pedro", result.Nombre);
    }

    [Fact]
    public async Task Buscar_CuandoNoExisteRepartidor_RetornaNull()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabase());
        var service = new RepartidoresService(context);

        var result = await service.Buscar(99);

        Assert.Null(result);
    }

    [Fact]
    public async Task GetList_CuandoSeFiltraPorNombre_RetornaCoincidencias()
    {
        var dbName = TestDbContextFactory.NewDatabase();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Repartidores.AddRange(
                CreateRepartidor(1, "Ana"),
                CreateRepartidor(2, "Andres"),
                CreateRepartidor(3, "Luis")
            );
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new RepartidoresService(context);

        var result = await service.GetList(r => r.Nombre.StartsWith("An"));

        Assert.Equal(2, result.Count);
        Assert.Contains(result, r => r.RepartidorId == 1);
        Assert.Contains(result, r => r.RepartidorId == 2);
    }

    [Fact]
    public async Task Guardar_CuandoRepartidorNoExiste_InsertaYRetornaTrue()
    {
        var dbName = TestDbContextFactory.NewDatabase();
        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new RepartidoresService(context);

        var nuevo = CreateRepartidor(0, "Nuevo");

        var result = await service.Guardar(nuevo);

        Assert.True(result);

        var saved = await context.Repartidores.FirstOrDefaultAsync(r => r.Nombre == "Nuevo");
        Assert.NotNull(saved);
    }

    [Fact]
    public async Task Guardar_CuandoRepartidorExiste_ModificaYRetornaTrue()
    {
        var dbName = TestDbContextFactory.NewDatabase();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Repartidores.Add(CreateRepartidor(20, "Original"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new RepartidoresService(context);

        var actualizado = CreateRepartidor(20, "Modificado");

        var result = await service.Guardar(actualizado);

        Assert.True(result);

        var saved = await context.Repartidores.FindAsync(20);
        Assert.NotNull(saved);
        Assert.Equal("Modificado", saved!.Nombre);
    }

    [Fact]
    public async Task Eliminar_CuandoExisteRepartidor_LoBorraYRetornaTrue()
    {
        var dbName = TestDbContextFactory.NewDatabase();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Repartidores.Add(CreateRepartidor(30, "ParaBorrar"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new RepartidoresService(context);

        var result = await service.Eliminar(30);

        Assert.True(result);

        var eliminado = await context.Repartidores.FindAsync(30);
        Assert.Null(eliminado);
    }

    private static Repartidore CreateRepartidor(int id, string nombre)
    {
        return new Repartidore
        {
            RepartidorId = id,
            Nombre = nombre,
            Telefono = null,
            Estado = null
        };
    }
}
