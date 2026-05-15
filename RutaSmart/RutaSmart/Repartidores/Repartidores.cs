using RutaSmart.Data.Models;
using RutaSmart.UI.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RutaSmart.UI.Repartidores
{
    public partial class Repartidores : Form
    {
        private readonly RepartidoresService _repartidoresService;
        private int repartidorId = 0;

        public Repartidores(RepartidoresService repartidoresService)
        {
            InitializeComponent();

            _repartidoresService = repartidoresService;

            // Cargar opciones del combo de estado
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });

            dgvRepartidores.CellClick += dgvRepartidores_CellClick;
            btnLimpiar.Click += btnLimpiar_Click;
            guna2Button1.Click += guna2Button1_Click;   // Eliminar

            this.Load += Repartidores_Load;
        }

        // ─── Carga inicial ────────────────────────────────────────────────────

        private async void Repartidores_Load(object sender, EventArgs e)
        {
            await CargarRepartidores();
        }

        private async Task CargarRepartidores()
        {
            var lista = await _repartidoresService.GetList(r => true);

            dgvRepartidores.AutoGenerateColumns = false;
            dgvRepartidores.DataSource = null;
            dgvRepartidores.DataSource = lista;
        }

        // ─── Guardar ──────────────────────────────────────────────────────────

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Nombre obligatorio");
                valido = false;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbEstado, "Seleccione un estado");
                valido = false;
            }

            if (!valido) return;

            var repartidor = new Repartidore
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Estado = cmbEstado.Text
            };

            bool guardado = await _repartidoresService.Guardar(repartidor);

            if (guardado)
            {
                MessageBox.Show("Repartidor guardado correctamente.");
                LimpiarCampos();
                await CargarRepartidores();
            }
            else
            {
                MessageBox.Show("No se pudo guardar.");
            }
        }

        // ─── Actualizar ───────────────────────────────────────────────────────

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (repartidorId == 0)
            {
                MessageBox.Show("Seleccione un repartidor.");
                return;
            }

            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Nombre obligatorio");
                return;
            }

            var repartidor = new Repartidore
            {
                RepartidorId = repartidorId,
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Estado = cmbEstado.Text
            };

            bool modificado = await _repartidoresService.Guardar(repartidor);

            if (modificado)
            {
                MessageBox.Show("Repartidor actualizado correctamente.");
                LimpiarCampos();
                repartidorId = 0;
                await CargarRepartidores();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar.");
            }
        }

        // ─── Eliminar ─────────────────────────────────────────────────────────

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (repartidorId == 0)
            {
                MessageBox.Show("Seleccione un repartidor.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Desea eliminar este repartidor?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                bool eliminado = await _repartidoresService.Eliminar(repartidorId);

                if (eliminado)
                {
                    MessageBox.Show("Repartidor eliminado correctamente.");
                    LimpiarCampos();
                    repartidorId = 0;
                    await CargarRepartidores();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el repartidor porque tiene pedidos asociados.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ─── Limpiar ──────────────────────────────────────────────────────────

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            cmbEstado.SelectedIndex = -1;
            errorProvider1.Clear();
        }

        // ─── Selección en grid ────────────────────────────────────────────────

        private void dgvRepartidores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvRepartidores.Rows[e.RowIndex];

            repartidorId = Convert.ToInt32(fila.Cells["ID"].Value);

            txtId.Text = fila.Cells["ID"].Value?.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
            txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
            cmbEstado.Text = fila.Cells["Estado"].Value?.ToString();
        }
    }
}