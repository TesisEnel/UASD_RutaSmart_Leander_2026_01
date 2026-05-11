using RutaSmart.Data.Data;
using RutaSmart.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using RutaSmart.UI.Clientes;
using RutaSmart.UI.Pedidos;
using RutaSmart.UI.Repartidores;
using RutaSmart.UI.Rutas;
using RutaSmart.UI.Reportes;
using RutaSmart.UI.Dashboard;

namespace RutaSmart
{
    public partial class MainForm : Form
    {
        private readonly ClienteService? _clienteService;
        private readonly PedidosService? _pedidosService;
        private readonly RepartidoresService? _repartidoresService;
        private readonly RutaService? _rutaService;
        private Form? formularioActivo;
        public MainForm(ClienteService clienteService, PedidosService pedidosService,
        RepartidoresService repartidoresService, RutaService rutaService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _pedidosService = pedidosService;
            _repartidoresService = repartidoresService;
            _rutaService = rutaService;

            AbrirFormulario<Dashboard>();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Dashboard>();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Clientes>();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Pedidos>();
        }

        private void btnRepartidores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Repartidores>();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Rutas>();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmReportes>();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Clientes>();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Pedidos>();
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Repartidores>();
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Rutas>();
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmReportes>();
        }

        private void AbrirFormulario<T>() where T : Form
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = Program.ServiceProvider.GetRequiredService<T>();

            formularioActivo.TopLevel = false;
            formularioActivo.FormBorderStyle = FormBorderStyle.None;
            formularioActivo.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formularioActivo);

            formularioActivo.Show();
        }

    }
}
