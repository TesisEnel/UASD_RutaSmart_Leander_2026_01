using RutaSmart.Data.Models;
using RutaSmart.UI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RutaSmart.UI.Clientes
{

    public partial class Clientes : Form
    {
        private readonly ClienteService _clienteService;
        private int clienteId = 0;

        public Clientes(ClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            dgvClientes.CellClick += dgvClientes_CellClick;
            this.Load += Clientes_Load;
        }

        private async void Clientes_Load(object sender, EventArgs e)
        {
            await CargarClientes();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre");
                txtNombre.Focus();
                return;
            }
            else errorProvider1.SetError(txtNombre, "");

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Ingrese el email");
                txtEmail.Focus();
                return;
            }
            else errorProvider1.SetError(txtEmail, "");

            var cliente = new Cliente
            {
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };

            bool guardado = await _clienteService.Guardar(cliente);

            if (guardado)
            {
                MessageBox.Show("Cliente guardado correctamente.");
                LimpiarCampos();
                await CargarClientes(); // refresca el grid
            }
            else
            {
                MessageBox.Show("Error al guardar el cliente.");
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private async Task CargarClientes()
        {
            var lista = await _clienteService.GetList(c => true);
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = lista;
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (clienteId == 0)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            var cliente = new Cliente
            {
                ClienteId = clienteId,
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                FechaCreacion = dtpFechaCreacion.Value
            };

            bool modificado = await _clienteService.Guardar(cliente);

            if (modificado)
            {
                MessageBox.Show("Cliente modificado correctamente.");

                LimpiarCampos();
                clienteId = 0;

                await CargarClientes();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el cliente.");
            }
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (clienteId == 0)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Desea eliminar este cliente?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                bool eliminado = await _clienteService.Eliminar(clienteId);

                if (eliminado)
                {
                    MessageBox.Show("Cliente eliminado correctamente.");

                    LimpiarCampos();
                    clienteId = 0;

                    await CargarClientes();
                }
                else
                {
                    MessageBox.Show(
                    "No se puede eliminar el cliente porque tiene pedidos asociados.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                clienteId = Convert.ToInt32(fila.Cells["ClienteId"].Value);

                txtNombre.Text = fila.Cells["Nombre"]?.Value?.ToString();
                txtEmail.Text = fila.Cells["Email"]?.Value?.ToString();
                txtTelefono.Text = fila.Cells["Telefono"]?.Value?.ToString();
                txtDireccion.Text = fila.Cells["Direccion"]?.Value?.ToString();
            }
        }
    }
}
