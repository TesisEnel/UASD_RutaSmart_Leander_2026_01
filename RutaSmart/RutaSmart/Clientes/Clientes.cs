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
        private int filaSeleccionada = -1;
    
        public Clientes(ClienteService clienteService)
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre");
                txtNombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Ingrese el email");
                txtEmail.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            dgvClientes.Rows.Add(
                dgvClientes.Rows.Count + 1,
                txtNombre.Text,
                txtEmail.Text,
                txtTelefono.Text,
                txtDireccion.Text
            );

            LimpiarCampos();
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
    }
}
