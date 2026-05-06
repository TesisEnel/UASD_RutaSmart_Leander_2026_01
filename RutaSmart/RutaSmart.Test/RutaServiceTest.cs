using Microsoft.EntityFrameworkCore;
using RutaSmart.Data.Models;
using RutaSmart.UI.Services;
using System.Threading.Tasks;
using RutaSmart.Test.Infraestructura;
using Xunit;

namespace RutaSmart.Test;

public class RutaServiceTests
{
    [Fact]
    public async Task Buscar_CuandoExisteRuta_RetornaEntidad()
    {
        var dbName = TestDbContextFactory.NewDatabase();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Rutas.Add(CreateRuta(1, "Ruta A"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new RutaService(context);

        var result = await service.Buscar(1);

        Assert.NotNull(result);
        Assert.Equal(1, result!.RutaId);
        Assert.Equal("Ruta A", result.Nombre);
    }

    [Fact]
    public async Task Buscar_CuandoNoExisteRuta_RetornaNull()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabase());
        var service = new RutaService(context);

        var result = await service.Buscar(99);

        Assert.Null(result);
    }

    [Fact]
    public async Task GetList_CuandoSeFiltraPorNombre_RetornaCoincidencias()
    {
        var dbName = TestDbContextFactory.NewDatabase();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Rutas.AddRange(
                CreateRuta(1, "Central"),
                CreateRuta(2, "Centro"),
                CreateRuta(3, "Sur")
            );
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new RutaService(context);

        var result = await service.GetList(r => r.Nombre.StartsWith("Cent"));

        Assert.Equal(2, result.Count);
        Assert.Contains(result, r => r.RutaId == 1);
        Assert.Contains(result, r => r.RutaId == 2);
    }

    [Fact]
    public async Task Guardar_CuandoRutaNoExiste_InsertaYRetornaTrue()
    {
        var dbName = TestDbContextFactory.NewDatabase();
        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new RutaService(context);

        var nuevo = CreateRuta(0, "Ruta Nueva");

        var result = await service.Guardar(nuevo);

        Assert.True(result);

        var saved = await context.Rutas.FirstOrDefaultAsync(r => r.Nombre == "Ruta Nueva");
        Assert.NotNull(saved);
    }

    [Fact]
    public async Task Guardar_CuandoRutaExiste_ModificaYRetornaTrue()
    {
        var dbName = TestDbContextFactory.NewDatabase();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Rutas.Add(CreateRuta(20, "Original"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new RutaService(context);

        var actualizado = CreateRuta(20, "Modificado");

        var result = await service.Guardar(actualizado);

        Assert.True(result);

        var saved = await context.Rutas.FindAsync(20);
        Assert.NotNull(saved);
        Assert.Equal("Modificado", saved!.Nombre);
    }

    [Fact]
    public async Task Eliminar_CuandoExisteRuta_LaBorraYRetornaTrue()
    {
        var dbName = TestDbContextFactory.NewDatabase();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Rutas.Add(CreateRuta(30, "ParaBorrar"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new RutaService(context);

        var result = await service.Eliminar(30);

        Assert.True(result);

        var eliminado = await context.Rutas.FindAsync(30);
        Assert.Null(eliminado);
    }

    private static Ruta CreateRuta(int id, string nombre)
    {
        return new Ruta
        {
            RutaId = id,
            Nombre = nombre,
            Descripcion = null,
            Distancia = null,
            TiempoEstimado = null
        };
    }
}
