using Microsoft.EntityFrameworkCore;
using RutaSmart.Data.Models;
using RutaSmart.UI.Services;
using System;
using System.Threading.Tasks;
using RutaSmart.Test.Infraestructura;
using Xunit;

namespace RutaSmart.Test
{
    public class PedidosServiceTest
    {
        [Fact]
        public async Task Buscar_CuandoExistePedido_RetornaEntidad()
        {
            var dbName = TestDbContextFactory.NewDatabase();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Clientes.Add(CreateCliente(1, "Cliente A"));
                seedContext.Pedidos.Add(CreatePedido(1, 1, "Pendiente", "Dir1", 100m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new PedidosService(context);

            var result = await service.Buscar(1);

            Assert.NotNull(result);
            Assert.Equal(1, result!.PedidoId);
            //Assert.Equal("Pendiente", result.Estado);
            Assert.Equal(1, result.ClienteId);
        }

        [Fact]
        public async Task Buscar_CuandoNoExistePedido_RetornaNull()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabase());
            var service = new PedidosService(context);

            var result = await service.Buscar(99);

            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorEstado_RetornaCoincidencias()
        {
            var dbName = TestDbContextFactory.NewDatabase();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Clientes.Add(CreateCliente(2, "Cliente B"));
                seedContext.Pedidos.AddRange(
                    CreatePedido(2, 2, "Pendiente", "D1", 10m),
                    CreatePedido(3, 2, "Entregado", "D2", 20m),
                    CreatePedido(4, 2, "Pendiente", "D3", 30m)
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new PedidosService(context);

            var result = await service.GetList(p => p.Estado == "Pendiente");

           Assert.Equal(2, result.Count);
           Assert.Contains(result, p => p.PedidoId == 2);
          Assert.Contains(result, p => p.PedidoId == 4);
        }

        [Fact]
        public async Task Guardar_CuandoPedidoNoExiste_InsertaYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabase();
            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new PedidosService(context);

            // Ensure the related cliente exists
            context.Clientes.Add(CreateCliente(5, "ClienteX"));
            await context.SaveChangesAsync();

            var nuevo = CreatePedido(0, 5, "Pendiente", "DireccionNuevo", 55m);

            var result = await service.Guardar(nuevo);

            Assert.True(result);

            var saved = await context.Pedidos.FirstOrDefaultAsync(p => p.DireccionEntrega == "DireccionNuevo");
            Assert.NotNull(saved);
        }

        [Fact]
        public async Task Guardar_CuandoPedidoExiste_ModificaYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabase();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Clientes.Add(CreateCliente(20, "ClienteY"));
                seedContext.Pedidos.Add(CreatePedido(20, 20, "Pendiente", "Original", 15m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new PedidosService(context);

            var actualizado = CreatePedido(20, 20, "Entregado", "Modificado", 15m);

            var result = await service.Guardar(actualizado);

            Assert.True(result);

            var saved = await context.Pedidos.FindAsync(20);
            Assert.NotNull(saved);
            Assert.Equal("Modificado", saved!.DireccionEntrega);
            Assert.Equal("Entregado", saved.Estado);
        }

        [Fact]
        public async Task Eliminar_CuandoExistePedido_LoBorraYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabase();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Clientes.Add(CreateCliente(30, "ClienteZ"));
                seedContext.Pedidos.Add(CreatePedido(30, 30, "Pendiente", "ParaBorrar", 5m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new PedidosService(context);

            var result = await service.Eliminar(30);

            Assert.True(result);

            var eliminado = await context.Pedidos.FindAsync(30);
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

        private static Pedido CreatePedido(int id, int clienteId, string estado, string direccion, decimal total)
        {
            return new Pedido
            {
                PedidoId = id,
                ClienteId = clienteId,
                Estado = estado,
                DireccionEntrega = direccion,
                Total = total,
                FechaPedido = DateTime.Now
            };
        }
    }
}
