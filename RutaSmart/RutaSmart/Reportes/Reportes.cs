using RutaSmart.UI.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RutaSmart.UI.Reportes
{
    public partial class FrmReportes : Form
    {
        private readonly PedidosService _pedidosService;
        private readonly RepartidoresService _repartidoresService;

        public FrmReportes(PedidosService pedidosService, RepartidoresService repartidoresService)
        {
            InitializeComponent();

            _pedidosService = pedidosService;
            _repartidoresService = repartidoresService;

            btnGenerar.Click += BtnGenerar_Click;
            this.Load += FrmReportes_Load;
        }

        // ─── Carga inicial ────────────────────────────────────────────────────

        private async void FrmReportes_Load(object sender, EventArgs e)
        {
            dtDesde.Value = DateTime.Today.AddDays(-7);
            dtHasta.Value = DateTime.Today;

            await GenerarReporte();
        }

        // ─── Botón Generar ────────────────────────────────────────────────────

        private async void BtnGenerar_Click(object sender, EventArgs e)
        {
            await GenerarReporte();
        }

        // ─── Lógica central ───────────────────────────────────────────────────

        private async Task GenerarReporte()
        {
            btnGenerar.Enabled = false; 
            try
            {
                DateTime desde = dtDesde.Value.Date;
                DateTime hasta = dtHasta.Value.Date.AddDays(1).AddTicks(-1);

                var pedidos = await _pedidosService.GetList(
                    p => p.FechaPedido >= desde && p.FechaPedido <= hasta);

                var datos = pedidos
                    .OrderByDescending(p => p.FechaPedido)
                    .Select(p => new
                    {
                        ID = p.PedidoId,
                        Cliente = p.Cliente?.Nombre ?? "—",
                        Fecha = p.FechaPedido?.ToString("dd/MM/yyyy") ?? "—",
                        Repartidor = p.Repartidor?.Nombre ?? "Sin asignar",
                        Estado = p.Estado ?? "Pendiente",
                        Ruta = p.Ruta?.Nombre ?? "—"
                    })
                    .ToList();

                dgvReportes.AutoGenerateColumns = false;
                dgvReportes.DataSource = datos;

                ActualizarGraficos(pedidos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGenerar.Enabled = true; 
            }
        }

        // ─── Gráficos ─────────────────────────────────────────────────────────

        private void ActualizarGraficos(List<RutaSmart.Data.Models.Pedido> pedidos)
        {
            tableGraficos.Controls.Clear();

            Chart barras = CrearGraficoBarrasPorDia(pedidos);
            Chart pastel = CrearGraficoPastelEstados(pedidos);

            tableGraficos.Controls.Add(barras, 0, 0);
            tableGraficos.Controls.Add(pastel, 1, 0);
        }

        private Chart CrearGraficoBarrasPorDia(List<RutaSmart.Data.Models.Pedido> pedidos)
        {
            Chart chart = new Chart { Dock = DockStyle.Fill };

            ChartArea area = new ChartArea();
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas.Add(area);

            Series serie = new Series
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(52, 152, 219)
            };

            var porDia = pedidos
                .Where(p => p.FechaPedido.HasValue)
                .GroupBy(p => p.FechaPedido!.Value.DayOfWeek)
                .ToDictionary(g => g.Key, g => g.Count());

            var dias = new[] { "Dom", "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb" };
            for (int i = 0; i < 7; i++)
            {
                var dow = (DayOfWeek)i;
                serie.Points.AddXY(dias[i], porDia.TryGetValue(dow, out int c) ? c : 0);
            }

            chart.Series.Add(serie);
            chart.Titles.Add("Pedidos por día de la semana");
            return chart;
        }

        private Chart CrearGraficoPastelEstados(List<RutaSmart.Data.Models.Pedido> pedidos)
        {
            Chart chart = new Chart { Dock = DockStyle.Fill };

            ChartArea area = new ChartArea();
            chart.ChartAreas.Add(area);

            Series serie = new Series { ChartType = SeriesChartType.Pie };

            var grupos = pedidos
                .GroupBy(p => p.Estado ?? "Pendiente")
                .Select(g => new { Estado = g.Key, Total = g.Count() });

            foreach (var g in grupos)
                serie.Points.AddXY(g.Estado, g.Total);

            if (!serie.Points.Any())
                serie.Points.AddXY("Sin datos", 1);

            chart.Series.Add(serie);
            chart.Titles.Add("Estados de pedidos");
            return chart;
        }
    }
}