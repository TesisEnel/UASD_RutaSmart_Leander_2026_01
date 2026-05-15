using RutaSmart.UI.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RutaSmart.UI.Dashboard
{
    public partial class Dashboard : Form
    {
        private readonly ClienteService _clienteService;
        private readonly PedidosService _pedidosService;
        private readonly RepartidoresService _repartidoresService;
        private readonly RutaService _rutaService;

        public Dashboard(
            ClienteService clienteService,
            PedidosService pedidosService,
            RepartidoresService repartidoresService,
            RutaService rutaService)
        {
            InitializeComponent();

            _clienteService = clienteService;
            _pedidosService = pedidosService;
            _repartidoresService = repartidoresService;
            _rutaService = rutaService;

            this.Load += Dashboard_Load;
        }

        // ─── Carga inicial ────────────────────────────────────────────────────

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy",
                new System.Globalization.CultureInfo("es-ES"));

            await CargarTarjetas();
            await CargarUltimosPedidos();
        }

        // ─── Tarjetas de resumen ──────────────────────────────────────────────

        private async Task CargarTarjetas()
        {
            try
            {
                var clientes = await _clienteService.GetList(c => true);
                var pedidos = await _pedidosService.GetList(p => true);
                var repartidores = await _repartidoresService.GetList(r => true);
                var rutas = await _rutaService.GetList(r => true);

                lblClientesTotal.Text = clientes.Count.ToString();
                lblPedidosTotal.Text = pedidos.Count.ToString();
                lblRepartidoresTotal.Text = repartidores.Count.ToString();
                lblRutasTotal.Text = rutas.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el resumen: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Últimos pedidos ──────────────────────────────────────────────────

        private async Task CargarUltimosPedidos()
        {
            try
            {
                // Carga todos los pedidos con sus relaciones de navegación
                var pedidos = await _pedidosService.GetList(p => true);

                // Proyección para el grid (últimos 10, más recientes primero)
                var datos = pedidos
                    .OrderByDescending(p => p.FechaPedido)
                    .Take(10)
                    .Select(p => new
                    {
                        ID = p.PedidoId,
                        Cliente = p.Cliente?.Nombre ?? "—",
                        Repartidor = p.Repartidor?.Nombre ?? "Sin asignar",
                        Estado = p.Estado ?? "Pendiente",
                        Fecha = p.FechaPedido?.ToString("dd/MM/yyyy") ?? "—"
                    })
                    .ToList();

                dgvUltimosPedidos.AutoGenerateColumns = false;
                dgvUltimosPedidos.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los últimos pedidos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}