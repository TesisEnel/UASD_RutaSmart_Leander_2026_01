using RutaSmart.Data.Models;
using RutaSmart.UI.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RutaSmart.UI.Rutas
{
    public partial class Rutas : Form
    {
        private readonly RutaService _rutaService;
        private readonly RepartidoresService _repartidoresService;

        private int rutaId = 0;

        public Rutas(RutaService rutaService, RepartidoresService repartidoresService)
        {
            InitializeComponent();

            _rutaService = rutaService;
            _repartidoresService = repartidoresService;

            btnGuardar.Click += BtnGuardar_Click;
            btnModificar.Click += BtnModificar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnLimpiar.Click += BtnLimpiar_Click;
            dgvRutas.CellClick += DgvRutas_CellClick;

            this.Load += Rutas_Load;
        }

        // ─── Carga inicial ────────────────────────────────────────────────────

        private async void Rutas_Load(object sender, EventArgs e)
        {
            await CargarRepartidoresCombo();
            await CargarRutas();
        }

        private async Task CargarRepartidoresCombo()
        {
            var repartidores = await _repartidoresService.GetList(r => true);

            cmbRepartidor.DataSource = repartidores;
            cmbRepartidor.DisplayMember = "Nombre";
            cmbRepartidor.ValueMember = "Nombre";   // guardamos el nombre como texto en el modelo Ruta
            cmbRepartidor.SelectedIndex = -1;
        }

        private async Task CargarRutas()
        {
            var lista = await _rutaService.GetList(r => true);

            dgvRutas.AutoGenerateColumns = false;
            dgvRutas.DataSource = null;
            dgvRutas.DataSource = lista;
        }

        // ─── Guardar ──────────────────────────────────────────────────────────

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            var ruta = new Ruta
            {
                Nombre = txtNombreRuta.Text.Trim(),
                Repartidor = cmbRepartidor.Text,
                Zona = txtZona.Text.Trim()
            };

            bool guardado = await _rutaService.Guardar(ruta);

            if (guardado)
            {
                MessageBox.Show("Ruta guardada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                await CargarRutas();
            }
            else
            {
                MessageBox.Show("No se pudo guardar la ruta.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Modificar ────────────────────────────────────────────────────────

        private async void BtnModificar_Click(object sender, EventArgs e)
        {
            if (rutaId == 0)
            {
                MessageBox.Show("Seleccione una ruta de la tabla para modificar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validar()) return;

            var ruta = new Ruta
            {
                RutaId = rutaId,
                Nombre = txtNombreRuta.Text.Trim(),
                Repartidor = cmbRepartidor.Text,
                Zona = txtZona.Text.Trim()
            };

            bool modificado = await _rutaService.Guardar(ruta);

            if (modificado)
            {
                MessageBox.Show("Ruta modificada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                rutaId = 0;
                await CargarRutas();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la ruta.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Eliminar ─────────────────────────────────────────────────────────

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (rutaId == 0)
            {
                MessageBox.Show("Seleccione una ruta de la tabla para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta ruta?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                bool eliminado = await _rutaService.Eliminar(rutaId);

                if (eliminado)
                {
                    MessageBox.Show("Ruta eliminada correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    rutaId = 0;
                    await CargarRutas();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la ruta porque tiene pedidos asociados.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ─── Limpiar ──────────────────────────────────────────────────────────

        private void BtnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            txtNombreRuta.Text = string.Empty;
            txtZona.Text = string.Empty;
            cmbRepartidor.SelectedIndex = -1;
            rutaId = 0;
        }

        // ─── Validación ───────────────────────────────────────────────────────

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombreRuta.Text))
            {
                MessageBox.Show("El nombre de la ruta es obligatorio.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreRuta.Focus();
                return false;
            }

            if (cmbRepartidor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un repartidor.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRepartidor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtZona.Text))
            {
                MessageBox.Show("La zona es obligatoria.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtZona.Focus();
                return false;
            }

            return true;
        }

        // ─── Selección en grid ────────────────────────────────────────────────

        private void DgvRutas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvRutas.Rows[e.RowIndex];

            rutaId = Convert.ToInt32(fila.Cells["ID"].Value);

            txtId.Text = fila.Cells["ID"].Value?.ToString();
            txtNombreRuta.Text = fila.Cells["NombreRuta"].Value?.ToString();
            txtZona.Text = fila.Cells["Zona"].Value?.ToString();

            string? repartidor = fila.Cells["Repartidor"].Value?.ToString();
            if (!string.IsNullOrEmpty(repartidor))
                cmbRepartidor.Text = repartidor;
            else
                cmbRepartidor.SelectedIndex = -1;
        }
    }
}