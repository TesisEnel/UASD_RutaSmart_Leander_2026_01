using Guna.UI2.WinForms;

namespace RutaSmart.UI.Rutas
{
    partial class Rutas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelPrincipal = new Panel();
            panelContenedor = new Guna2Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlFormulario = new Guna2Panel();
            tableFormulario = new TableLayoutPanel();
            txtId = new Guna2TextBox();
            txtNombreRuta = new Guna2TextBox();
            cmbRepartidor = new Guna2ComboBox();
            txtZona = new Guna2TextBox();
            flowBotones = new FlowLayoutPanel();
            btnGuardar = new Guna2Button();
            btnLimpiar = new Guna2Button();
            btnModificar = new Guna2Button();
            btnEliminar = new Guna2Button();
            pnlGrid = new Guna2Panel();
            dgvRutas = new Guna2DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NombreRuta = new DataGridViewTextBoxColumn();
            Repartidor = new DataGridViewTextBoxColumn();
            Zona = new DataGridViewTextBoxColumn();
            panelPrincipal.SuspendLayout();
            panelContenedor.SuspendLayout();
            pnlFormulario.SuspendLayout();
            tableFormulario.SuspendLayout();
            flowBotones.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRutas).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.Controls.Add(panelContenedor);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1000, 600);
            panelPrincipal.TabIndex = 0;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(lblSubtitulo);
            panelContenedor.Controls.Add(pnlFormulario);
            panelContenedor.Controls.Add(pnlGrid);
            panelContenedor.CustomizableEdges = customizableEdges21;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.FillColor = Color.White;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Padding = new Padding(20);
            panelContenedor.ShadowDecoration.CustomizableEdges = customizableEdges22;
            panelContenedor.Size = new Size(1000, 600);
            panelContenedor.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(97, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Rutas";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(23, 68);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(227, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Administra las rutas de repartidores";
            // 
            // pnlFormulario
            // 
            pnlFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFormulario.BackColor = Color.Transparent;
            pnlFormulario.BorderRadius = 20;
            pnlFormulario.Controls.Add(tableFormulario);
            pnlFormulario.CustomizableEdges = customizableEdges17;
            pnlFormulario.FillColor = Color.White;
            pnlFormulario.Location = new Point(20, 100);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.ShadowDecoration.CustomizableEdges = customizableEdges18;
            pnlFormulario.ShadowDecoration.Enabled = true;
            pnlFormulario.Size = new Size(960, 220);
            pnlFormulario.TabIndex = 2;
            // 
            // tableFormulario
            // 
            tableFormulario.ColumnCount = 2;
            tableFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableFormulario.Controls.Add(txtId, 0, 0);
            tableFormulario.Controls.Add(txtNombreRuta, 1, 0);
            tableFormulario.Controls.Add(cmbRepartidor, 0, 1);
            tableFormulario.Controls.Add(txtZona, 1, 1);
            tableFormulario.Controls.Add(flowBotones, 0, 2);
            tableFormulario.Dock = DockStyle.Fill;
            tableFormulario.Location = new Point(0, 0);
            tableFormulario.Name = "tableFormulario";
            tableFormulario.Padding = new Padding(20);
            tableFormulario.RowCount = 3;
            tableFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableFormulario.Size = new Size(960, 220);
            tableFormulario.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.BorderRadius = 10;
            txtId.CustomizableEdges = customizableEdges1;
            txtId.DefaultText = "";
            txtId.Dock = DockStyle.Fill;
            txtId.Font = new Font("Segoe UI", 9F);
            txtId.Location = new Point(30, 30);
            txtId.Margin = new Padding(10);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "ID";
            txtId.ReadOnly = true;
            txtId.SelectedText = "";
            txtId.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtId.Size = new Size(440, 34);
            txtId.TabIndex = 0;
            // 
            // txtNombreRuta
            // 
            txtNombreRuta.BorderRadius = 10;
            txtNombreRuta.CustomizableEdges = customizableEdges3;
            txtNombreRuta.DefaultText = "";
            txtNombreRuta.Dock = DockStyle.Fill;
            txtNombreRuta.Font = new Font("Segoe UI", 9F);
            txtNombreRuta.Location = new Point(490, 30);
            txtNombreRuta.Margin = new Padding(10);
            txtNombreRuta.Name = "txtNombreRuta";
            txtNombreRuta.PlaceholderText = "Nombre de la ruta";
            txtNombreRuta.SelectedText = "";
            txtNombreRuta.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtNombreRuta.Size = new Size(440, 34);
            txtNombreRuta.TabIndex = 1;
            // 
            // cmbRepartidor
            // 
            cmbRepartidor.BackColor = Color.Transparent;
            cmbRepartidor.BorderRadius = 10;
            cmbRepartidor.CustomizableEdges = customizableEdges5;
            cmbRepartidor.Dock = DockStyle.Fill;
            cmbRepartidor.DrawMode = DrawMode.OwnerDrawFixed;
            cmbRepartidor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRepartidor.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbRepartidor.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbRepartidor.Font = new Font("Segoe UI", 10F);
            cmbRepartidor.ForeColor = Color.FromArgb(68, 88, 112);
            cmbRepartidor.ItemHeight = 30;
            cmbRepartidor.Location = new Point(30, 84);
            cmbRepartidor.Margin = new Padding(10);
            cmbRepartidor.Name = "cmbRepartidor";
            cmbRepartidor.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cmbRepartidor.Size = new Size(440, 36);
            cmbRepartidor.TabIndex = 2;
            // 
            // txtZona
            // 
            txtZona.BorderRadius = 10;
            txtZona.CustomizableEdges = customizableEdges7;
            txtZona.DefaultText = "";
            txtZona.Dock = DockStyle.Fill;
            txtZona.Font = new Font("Segoe UI", 9F);
            txtZona.Location = new Point(490, 84);
            txtZona.Margin = new Padding(10);
            txtZona.Name = "txtZona";
            txtZona.PlaceholderText = "Zona o área";
            txtZona.SelectedText = "";
            txtZona.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtZona.Size = new Size(440, 34);
            txtZona.TabIndex = 3;
            // 
            // flowBotones
            // 
            tableFormulario.SetColumnSpan(flowBotones, 2);
            flowBotones.Controls.Add(btnGuardar);
            flowBotones.Controls.Add(btnLimpiar);
            flowBotones.Controls.Add(btnModificar);
            flowBotones.Controls.Add(btnEliminar);
            flowBotones.Dock = DockStyle.Fill;
            flowBotones.Location = new Point(30, 138);
            flowBotones.Margin = new Padding(10);
            flowBotones.Name = "flowBotones";
            flowBotones.Padding = new Padding(5);
            flowBotones.Size = new Size(900, 52);
            flowBotones.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.BorderRadius = 10;
            btnGuardar.CustomizableEdges = customizableEdges9;
            btnGuardar.FillColor = Color.FromArgb(37, 99, 235);
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(8, 8);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BorderRadius = 10;
            btnLimpiar.CustomizableEdges = customizableEdges11;
            btnLimpiar.FillColor = Color.Gray;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(134, 8);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnLimpiar.Size = new Size(120, 40);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            // 
            // btnModificar
            // 
            btnModificar.BorderRadius = 10;
            btnModificar.CustomizableEdges = customizableEdges13;
            btnModificar.FillColor = Color.OrangeRed;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(260, 8);
            btnModificar.Name = "btnModificar";
            btnModificar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnModificar.Size = new Size(120, 40);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            // 
            // btnEliminar
            // 
            btnEliminar.BorderRadius = 10;
            btnEliminar.CustomizableEdges = customizableEdges15;
            btnEliminar.FillColor = Color.OliveDrab;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(386, 8);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGrid.Controls.Add(dgvRutas);
            pnlGrid.CustomizableEdges = customizableEdges19;
            pnlGrid.Location = new Point(20, 340);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.ShadowDecoration.CustomizableEdges = customizableEdges20;
            pnlGrid.Size = new Size(960, 240);
            pnlGrid.TabIndex = 3;
            // 
            // dgvRutas
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvRutas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRutas.ColumnHeadersHeight = 40;
            dgvRutas.Columns.AddRange(new DataGridViewColumn[] { ID, NombreRuta, Repartidor, Zona });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRutas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRutas.Dock = DockStyle.Fill;
            dgvRutas.GridColor = Color.FromArgb(231, 229, 255);
            dgvRutas.Location = new Point(0, 0);
            dgvRutas.Name = "dgvRutas";
            dgvRutas.RowHeadersVisible = false;
            dgvRutas.RowTemplate.Height = 35;
            dgvRutas.Size = new Size(960, 240);
            dgvRutas.TabIndex = 0;
            dgvRutas.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvRutas.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvRutas.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvRutas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvRutas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvRutas.ThemeStyle.BackColor = Color.White;
            dgvRutas.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvRutas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvRutas.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRutas.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvRutas.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvRutas.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRutas.ThemeStyle.HeaderStyle.Height = 40;
            dgvRutas.ThemeStyle.ReadOnly = false;
            dgvRutas.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvRutas.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRutas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvRutas.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvRutas.ThemeStyle.RowsStyle.Height = 35;
            dgvRutas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvRutas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // NombreRuta
            // 
            NombreRuta.HeaderText = "Nombre Ruta";
            NombreRuta.Name = "NombreRuta";
            // 
            // Repartidor
            // 
            Repartidor.HeaderText = "Repartidor";
            Repartidor.Name = "Repartidor";
            // 
            // Zona
            // 
            Zona.HeaderText = "Zona / Área";
            Zona.Name = "Zona";
            // 
            // Rutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(850, 550);
            Name = "Rutas";
            Text = "Rutas";
            panelPrincipal.ResumeLayout(false);
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            pnlFormulario.ResumeLayout(false);
            tableFormulario.ResumeLayout(false);
            flowBotones.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRutas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;

        private Guna2Panel panelContenedor;

        private Label lblTitulo;
        private Label lblSubtitulo;

        private Guna2Panel pnlFormulario;
        private TableLayoutPanel tableFormulario;

        private Guna2TextBox txtId;
        private Guna2TextBox txtNombreRuta;
        private Guna2ComboBox cmbRepartidor;
        private Guna2TextBox txtZona;

        private FlowLayoutPanel flowBotones;

        private Guna2Button btnGuardar;
        private Guna2Button btnLimpiar;
        private Guna2Button btnModificar;
        private Guna2Button btnEliminar;

        private Guna2Panel pnlGrid;
        private Guna2DataGridView dgvRutas;

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NombreRuta;
        private DataGridViewTextBoxColumn Repartidor;
        private DataGridViewTextBoxColumn Zona;
    }
}