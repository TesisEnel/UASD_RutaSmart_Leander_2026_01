using RutaSmart.Data.Data;
using RutaSmart.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using RutaSmart.UI.Clientes;
using RutaSmart.UI.Pedidos;
using RutaSmart.UI.Repartidores;
using RutaSmart.UI.Rutas;
using RutaSmart.UI.Reportes;

namespace RutaSmart
{
    public partial class MainForm : Form
    {
        private readonly ClienteService? _clienteService;
        private readonly PedidosService? _pedidosService;
        private readonly RepartidoresService? _repartidoresService;
        private readonly RutaService? _rutaService;
        public MainForm(ClienteService clienteService, PedidosService pedidosService,
        RepartidoresService repartidoresService, RutaService rutaService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _pedidosService = pedidosService;
            _repartidoresService = repartidoresService;
            _rutaService = rutaService;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            foreach (Control c in guna2Panel3.Controls)
            {
                if (c is Form f) f.Close();
            }

            guna2Panel3.Controls.Clear();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<Clientes>();
            AbrirFormEnPanel(form);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<Pedidos>();
            AbrirFormEnPanel(form);
        }

        private void btnRepartidores_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<Repartidores>();
            AbrirFormEnPanel(form);
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<Rutas>();
            AbrirFormEnPanel(form);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<FrmReportes>();
            AbrirFormEnPanel(form);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<Clientes>();
            AbrirFormEnPanel(form);
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<Pedidos>();
            AbrirFormEnPanel(form);
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<Repartidores>();
            AbrirFormEnPanel(form);
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<Rutas>();
            AbrirFormEnPanel(form);
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<Repartidores>();
            AbrirFormEnPanel(form);
        }
        private void AbrirFormEnPanel(Form form)
        {

            foreach (Control c in guna2Panel3.Controls)
            {
                if (c is Form f) f.Close();
            }
            guna2Panel3.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            guna2Panel3.Controls.Add(form);
            form.Show();
        }
    }
}
