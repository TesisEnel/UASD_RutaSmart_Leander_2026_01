using RutaSmart.Data.Models;
using RutaSmart.UI.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RutaSmart.UI.Pedidos
{
    public partial class Pedidos : Form
    {
        private readonly PedidosService _pedidosService;
        private readonly ClienteService _clienteService;
        private readonly RepartidoresService _repartidoresService;
        private readonly RutaService _rutaService;

        private int pedidoId = 0;

        public Pedidos(
            PedidosService pedidosService,
            ClienteService clienteService,
            RepartidoresService repartidoresService,
            RutaService rutaService)
        {
            InitializeComponent();

            _pedidosService = pedidosService;
            _clienteService = clienteService;
            _repartidoresService = repartidoresService;
            _rutaService = rutaService;

            dgvPedidos.CellClick += dgvPedidos_CellClick;
            this.Load += Pedidos_Load;
        }

        // ─── Carga inicial ────────────────────────────────────────────────────

        private async void Pedidos_Load(object sender, EventArgs e)
        {
            await CargarCombos();
            await CargarPedidos();
        }

        // ─── Combos ───────────────────────────────────────────────────────────

        private async Task CargarCombos()
        {
            // Clientes
            var clientes = await _clienteService.GetList(c => true);
            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "ClienteId";
            cmbCliente.SelectedIndex = -1;

            // Repartidores
            var repartidores = await _repartidoresService.GetList(r => true);
            cmbRepartidor.DataSource = repartidores;
            cmbRepartidor.DisplayMember = "Nombre";
            cmbRepartidor.ValueMember = "RepartidorId";
            cmbRepartidor.SelectedIndex = -1;

            // Rutas
            var rutas = await _rutaService.GetList(r => true);
            cmbRuta.DataSource = rutas;
            cmbRuta.DisplayMember = "Nombre";
            cmbRuta.ValueMember = "RutaId";
            cmbRuta.SelectedIndex = -1;
        }

        // ─── Grid ─────────────────────────────────────────────────────────────

        private async Task CargarPedidos()
        {
            var lista = await _pedidosService.GetList(p => true);

            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = lista;
        }

        // ─── Guardar ──────────────────────────────────────────────────────────

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            var pedido = new Pedido
            {
                ClienteId = Convert.ToInt32(cmbCliente.SelectedValue),

                RepartidorId = cmbRepartidor.SelectedValue != null
                    ? Convert.ToInt32(cmbRepartidor.SelectedValue)
                    : null,

                RutaId = cmbRuta.SelectedValue != null
                    ? Convert.ToInt32(cmbRuta.SelectedValue)
                    : null,

                FechaPedido = dtpFechaPedido.Value,
                DireccionEntrega = txtDireccionEntrega.Text,
                DireccionRecolecion = txtDireccionRecoleccion.Text,
                Estado = guna2ComboBox1.Text,
                Total = Convert.ToDecimal(guna2TextBox1.Text)
            };

            bool guardado = await _pedidosService.Guardar(pedido);

            if (guardado)
            {
                MessageBox.Show("Pedido guardado correctamente.");
                LimpiarCampos();
                await CargarPedidos();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el pedido.");
            }
        }

        // ─── Editar / Modificar ───────────────────────────────────────────────

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (pedidoId == 0)
            {
                MessageBox.Show("Seleccione un pedido.");
                return;
            }

            var pedido = new Pedido
            {
                PedidoId = pedidoId,

                ClienteId = Convert.ToInt32(cmbCliente.SelectedValue),

                RepartidorId = cmbRepartidor.SelectedValue != null
                    ? Convert.ToInt32(cmbRepartidor.SelectedValue)
                    : null,

                RutaId = cmbRuta.SelectedValue != null
                    ? Convert.ToInt32(cmbRuta.SelectedValue)
                    : null,

                FechaPedido = dtpFechaPedido.Value,
                DireccionEntrega = txtDireccionEntrega.Text,
                DireccionRecolecion = txtDireccionRecoleccion.Text,
                Estado = guna2ComboBox1.Text,
                Total = Convert.ToDecimal(guna2TextBox1.Text)
            };

            bool modificado = await _pedidosService.Guardar(pedido);

            if (modificado)
            {
                MessageBox.Show("Pedido modificado correctamente.");
                LimpiarCampos();
                pedidoId = 0;
                await CargarPedidos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el pedido.");
            }
        }

        // ─── Eliminar ─────────────────────────────────────────────────────────

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pedidoId == 0)
            {
                MessageBox.Show("Seleccione un pedido.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Desea eliminar este pedido?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                bool eliminado = await _pedidosService.Eliminar(pedidoId);

                if (eliminado)
                {
                    MessageBox.Show("Pedido eliminado correctamente.");
                    LimpiarCampos();
                    pedidoId = 0;
                    await CargarPedidos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el pedido.");
                }
            }
        }

        // ─── Limpiar ──────────────────────────────────────────────────────────

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            txtIdPedido.Clear();
            txtDireccionEntrega.Clear();
            txtDireccionRecoleccion.Clear();

            cmbCliente.SelectedIndex = -1;
            cmbRuta.SelectedIndex = -1;
            cmbRepartidor.SelectedIndex = -1;

            dtpFechaPedido.Value = DateTime.Now;

            guna2ComboBox1.SelectedIndex = -1;
            guna2TextBox1.Clear();
        }

        // ─── Selección en grid ────────────────────────────────────────────────

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvPedidos.Rows[e.RowIndex];

            pedidoId = Convert.ToInt32(fila.Cells["colId"].Value);

            txtIdPedido.Text = fila.Cells["colId"].Value?.ToString();
            txtDireccionEntrega.Text = fila.Cells["colEntrega"].Value?.ToString();

            if (DateTime.TryParse(fila.Cells["colFecha"].Value?.ToString(), out DateTime fecha))
                dtpFechaPedido.Value = fecha;

            // Seleccionar valores en los combos usando los IDs guardados en el objeto
            if (dgvPedidos.DataSource is System.Collections.Generic.List<Pedido> lista)
            {
                var pedido = lista.FirstOrDefault(p => p.PedidoId == pedidoId);
                if (pedido != null)
                {
                    cmbCliente.SelectedValue = pedido.ClienteId;
                    cmbRepartidor.SelectedValue = pedido.RepartidorId;
                    cmbRuta.SelectedValue = pedido.RutaId;
                    txtDireccionRecoleccion.Text = pedido.DireccionRecolecion;
                    guna2ComboBox1.Text = pedido.Estado;
                    guna2TextBox1.Text = pedido.Total.ToString();
                }
            }
        }
    }
}