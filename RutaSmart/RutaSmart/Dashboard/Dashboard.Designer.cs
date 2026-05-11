using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace RutaSmart.UI.Dashboard
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelTop;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblFecha;

        private TableLayoutPanel tableCards;

        private Guna2Panel panelClientes;
        private Label lblClientes;
        private Label lblClientesTotal;

        private Guna2Panel panelPedidos;
        private Label lblPedidos;
        private Label lblPedidosTotal;

        private Guna2Panel panelRepartidores;
        private Label lblRepartidores;
        private Label lblRepartidoresTotal;

        private Guna2Panel panelRutas;
        private Label lblRutas;
        private Label lblRutasTotal;

        private Label lblUltimosPedidos;
        private Guna2DataGridView dgvUltimosPedidos;

        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colRepartidor;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colFecha;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelTop = new Guna2Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblFecha = new Label();
            tableCards = new TableLayoutPanel();
            panelClientes = new Guna2Panel();
            guna2PictureBox1 = new Guna2PictureBox();
            lblClientes = new Label();
            lblClientesTotal = new Label();
            panelPedidos = new Guna2Panel();
            guna2PictureBox2 = new Guna2PictureBox();
            lblPedidos = new Label();
            lblPedidosTotal = new Label();
            panelRepartidores = new Guna2Panel();
            guna2PictureBox3 = new Guna2PictureBox();
            lblRepartidores = new Label();
            lblRepartidoresTotal = new Label();
            panelRutas = new Guna2Panel();
            guna2PictureBox4 = new Guna2PictureBox();
            lblRutas = new Label();
            lblRutasTotal = new Label();
            lblUltimosPedidos = new Label();
            dgvUltimosPedidos = new Guna2DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colRepartidor = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            tableCards.SuspendLayout();
            panelClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            panelPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).BeginInit();
            panelRepartidores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox3).BeginInit();
            panelRutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUltimosPedidos).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTop.BackColor = Color.Transparent;
            panelTop.BorderRadius = 20;
            panelTop.Controls.Add(lblTitulo);
            panelTop.Controls.Add(lblSubtitulo);
            panelTop.Controls.Add(lblFecha);
            panelTop.CustomizableEdges = customizableEdges1;
            panelTop.FillColor = Color.White;
            panelTop.Location = new Point(20, 20);
            panelTop.Name = "panelTop";
            panelTop.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelTop.ShadowDecoration.Enabled = true;
            panelTop.Size = new Size(1140, 120);
            panelTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(251, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Panel de Control";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(35, 70);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(242, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gestiona pedidos, rutas y repartidores";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(59, 130, 246);
            lblFecha.Location = new Point(860, 50);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(187, 19);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "lunes, 11 de mayo de 2026";
            // 
            // tableCards
            // 
            tableCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableCards.BackColor = Color.Transparent;
            tableCards.ColumnCount = 4;
            tableCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableCards.Controls.Add(panelClientes, 0, 0);
            tableCards.Controls.Add(panelPedidos, 1, 0);
            tableCards.Controls.Add(panelRepartidores, 2, 0);
            tableCards.Controls.Add(panelRutas, 3, 0);
            tableCards.Location = new Point(20, 170);
            tableCards.Name = "tableCards";
            tableCards.RowCount = 1;
            tableCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableCards.Size = new Size(1140, 150);
            tableCards.TabIndex = 1;
            // 
            // panelClientes
            // 
            panelClientes.BackColor = Color.Transparent;
            panelClientes.BorderRadius = 20;
            panelClientes.Controls.Add(guna2PictureBox1);
            panelClientes.Controls.Add(lblClientes);
            panelClientes.Controls.Add(lblClientesTotal);
            panelClientes.CustomizableEdges = customizableEdges5;
            panelClientes.Dock = DockStyle.Fill;
            panelClientes.FillColor = Color.White;
            panelClientes.Location = new Point(10, 10);
            panelClientes.Margin = new Padding(10);
            panelClientes.Name = "panelClientes";
            panelClientes.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelClientes.ShadowDecoration.Enabled = true;
            panelClientes.Size = new Size(265, 130);
            panelClientes.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(119, 15);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(130, 100);
            guna2PictureBox1.TabIndex = 2;
            guna2PictureBox1.TabStop = false;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 12F);
            lblClientes.ForeColor = Color.Gray;
            lblClientes.Location = new Point(25, 25);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(65, 21);
            lblClientes.TabIndex = 0;
            lblClientes.Text = "Clientes";
            // 
            // lblClientesTotal
            // 
            lblClientesTotal.AutoSize = true;
            lblClientesTotal.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblClientesTotal.ForeColor = Color.FromArgb(59, 130, 246);
            lblClientesTotal.Location = new Point(25, 55);
            lblClientesTotal.Name = "lblClientesTotal";
            lblClientesTotal.Size = new Size(88, 51);
            lblClientesTotal.TabIndex = 1;
            lblClientesTotal.Text = "120";
            // 
            // panelPedidos
            // 
            panelPedidos.BackColor = Color.Transparent;
            panelPedidos.BorderRadius = 20;
            panelPedidos.Controls.Add(guna2PictureBox2);
            panelPedidos.Controls.Add(lblPedidos);
            panelPedidos.Controls.Add(lblPedidosTotal);
            panelPedidos.CustomizableEdges = customizableEdges9;
            panelPedidos.Dock = DockStyle.Fill;
            panelPedidos.FillColor = Color.White;
            panelPedidos.Location = new Point(295, 10);
            panelPedidos.Margin = new Padding(10);
            panelPedidos.Name = "panelPedidos";
            panelPedidos.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelPedidos.ShadowDecoration.Enabled = true;
            panelPedidos.Size = new Size(265, 130);
            panelPedidos.TabIndex = 1;
            // 
            // guna2PictureBox2
            // 
            guna2PictureBox2.CustomizableEdges = customizableEdges7;
            guna2PictureBox2.Image = (Image)resources.GetObject("guna2PictureBox2.Image");
            guna2PictureBox2.ImageRotate = 0F;
            guna2PictureBox2.Location = new Point(122, 6);
            guna2PictureBox2.Name = "guna2PictureBox2";
            guna2PictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2PictureBox2.Size = new Size(130, 100);
            guna2PictureBox2.TabIndex = 3;
            guna2PictureBox2.TabStop = false;
            // 
            // lblPedidos
            // 
            lblPedidos.AutoSize = true;
            lblPedidos.Font = new Font("Segoe UI", 12F);
            lblPedidos.ForeColor = Color.Gray;
            lblPedidos.Location = new Point(25, 25);
            lblPedidos.Name = "lblPedidos";
            lblPedidos.Size = new Size(64, 21);
            lblPedidos.TabIndex = 0;
            lblPedidos.Text = "Pedidos";
            // 
            // lblPedidosTotal
            // 
            lblPedidosTotal.AutoSize = true;
            lblPedidosTotal.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblPedidosTotal.ForeColor = Color.FromArgb(16, 185, 129);
            lblPedidosTotal.Location = new Point(25, 55);
            lblPedidosTotal.Name = "lblPedidosTotal";
            lblPedidosTotal.Size = new Size(66, 51);
            lblPedidosTotal.TabIndex = 1;
            lblPedidosTotal.Text = "58";
            // 
            // panelRepartidores
            // 
            panelRepartidores.BackColor = Color.Transparent;
            panelRepartidores.BorderRadius = 20;
            panelRepartidores.Controls.Add(guna2PictureBox3);
            panelRepartidores.Controls.Add(lblRepartidores);
            panelRepartidores.Controls.Add(lblRepartidoresTotal);
            panelRepartidores.CustomizableEdges = customizableEdges13;
            panelRepartidores.Dock = DockStyle.Fill;
            panelRepartidores.FillColor = Color.White;
            panelRepartidores.Location = new Point(580, 10);
            panelRepartidores.Margin = new Padding(10);
            panelRepartidores.Name = "panelRepartidores";
            panelRepartidores.ShadowDecoration.CustomizableEdges = customizableEdges14;
            panelRepartidores.ShadowDecoration.Enabled = true;
            panelRepartidores.Size = new Size(265, 130);
            panelRepartidores.TabIndex = 2;
            // 
            // guna2PictureBox3
            // 
            guna2PictureBox3.CustomizableEdges = customizableEdges11;
            guna2PictureBox3.Image = (Image)resources.GetObject("guna2PictureBox3.Image");
            guna2PictureBox3.ImageRotate = 0F;
            guna2PictureBox3.Location = new Point(130, 15);
            guna2PictureBox3.Name = "guna2PictureBox3";
            guna2PictureBox3.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2PictureBox3.Size = new Size(130, 100);
            guna2PictureBox3.TabIndex = 3;
            guna2PictureBox3.TabStop = false;
            // 
            // lblRepartidores
            // 
            lblRepartidores.AutoSize = true;
            lblRepartidores.Font = new Font("Segoe UI", 12F);
            lblRepartidores.ForeColor = Color.Gray;
            lblRepartidores.Location = new Point(25, 25);
            lblRepartidores.Name = "lblRepartidores";
            lblRepartidores.Size = new Size(99, 21);
            lblRepartidores.TabIndex = 0;
            lblRepartidores.Text = "Repartidores";
            // 
            // lblRepartidoresTotal
            // 
            lblRepartidoresTotal.AutoSize = true;
            lblRepartidoresTotal.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblRepartidoresTotal.ForeColor = Color.FromArgb(245, 158, 11);
            lblRepartidoresTotal.Location = new Point(25, 55);
            lblRepartidoresTotal.Name = "lblRepartidoresTotal";
            lblRepartidoresTotal.Size = new Size(66, 51);
            lblRepartidoresTotal.TabIndex = 1;
            lblRepartidoresTotal.Text = "15";
            // 
            // panelRutas
            // 
            panelRutas.BackColor = Color.Transparent;
            panelRutas.BorderRadius = 20;
            panelRutas.Controls.Add(guna2PictureBox4);
            panelRutas.Controls.Add(lblRutas);
            panelRutas.Controls.Add(lblRutasTotal);
            panelRutas.CustomizableEdges = customizableEdges17;
            panelRutas.Dock = DockStyle.Fill;
            panelRutas.FillColor = Color.White;
            panelRutas.Location = new Point(865, 10);
            panelRutas.Margin = new Padding(10);
            panelRutas.Name = "panelRutas";
            panelRutas.ShadowDecoration.CustomizableEdges = customizableEdges18;
            panelRutas.ShadowDecoration.Enabled = true;
            panelRutas.Size = new Size(265, 130);
            panelRutas.TabIndex = 3;
            // 
            // guna2PictureBox4
            // 
            guna2PictureBox4.CustomizableEdges = customizableEdges15;
            guna2PictureBox4.Image = (Image)resources.GetObject("guna2PictureBox4.Image");
            guna2PictureBox4.ImageRotate = 0F;
            guna2PictureBox4.Location = new Point(107, 15);
            guna2PictureBox4.Name = "guna2PictureBox4";
            guna2PictureBox4.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2PictureBox4.Size = new Size(130, 100);
            guna2PictureBox4.TabIndex = 3;
            guna2PictureBox4.TabStop = false;
            // 
            // lblRutas
            // 
            lblRutas.AutoSize = true;
            lblRutas.Font = new Font("Segoe UI", 12F);
            lblRutas.ForeColor = Color.Gray;
            lblRutas.Location = new Point(25, 25);
            lblRutas.Name = "lblRutas";
            lblRutas.Size = new Size(49, 21);
            lblRutas.TabIndex = 0;
            lblRutas.Text = "Rutas";
            // 
            // lblRutasTotal
            // 
            lblRutasTotal.AutoSize = true;
            lblRutasTotal.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblRutasTotal.ForeColor = Color.FromArgb(239, 68, 68);
            lblRutasTotal.Location = new Point(25, 55);
            lblRutasTotal.Name = "lblRutasTotal";
            lblRutasTotal.Size = new Size(66, 51);
            lblRutasTotal.TabIndex = 1;
            lblRutasTotal.Text = "12";
            // 
            // lblUltimosPedidos
            // 
            lblUltimosPedidos.AutoSize = true;
            lblUltimosPedidos.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblUltimosPedidos.ForeColor = Color.FromArgb(30, 41, 59);
            lblUltimosPedidos.Location = new Point(20, 340);
            lblUltimosPedidos.Name = "lblUltimosPedidos";
            lblUltimosPedidos.Size = new Size(182, 30);
            lblUltimosPedidos.TabIndex = 2;
            lblUltimosPedidos.Text = "Últimos pedidos";
            // 
            // dgvUltimosPedidos
            // 
            dgvUltimosPedidos.AllowUserToAddRows = false;
            dgvUltimosPedidos.AllowUserToDeleteRows = false;
            dgvUltimosPedidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvUltimosPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUltimosPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUltimosPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUltimosPedidos.ColumnHeadersHeight = 45;
            dgvUltimosPedidos.Columns.AddRange(new DataGridViewColumn[] { colId, colCliente, colRepartidor, colEstado, colFecha });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUltimosPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUltimosPedidos.GridColor = Color.FromArgb(231, 229, 255);
            dgvUltimosPedidos.Location = new Point(20, 390);
            dgvUltimosPedidos.Name = "dgvUltimosPedidos";
            dgvUltimosPedidos.RowHeadersVisible = false;
            dgvUltimosPedidos.Size = new Size(1140, 250);
            dgvUltimosPedidos.TabIndex = 3;
            dgvUltimosPedidos.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUltimosPedidos.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUltimosPedidos.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUltimosPedidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUltimosPedidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUltimosPedidos.ThemeStyle.BackColor = Color.White;
            dgvUltimosPedidos.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvUltimosPedidos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(59, 130, 246);
            dgvUltimosPedidos.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUltimosPedidos.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvUltimosPedidos.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUltimosPedidos.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUltimosPedidos.ThemeStyle.HeaderStyle.Height = 45;
            dgvUltimosPedidos.ThemeStyle.ReadOnly = false;
            dgvUltimosPedidos.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUltimosPedidos.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUltimosPedidos.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvUltimosPedidos.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvUltimosPedidos.ThemeStyle.RowsStyle.Height = 25;
            dgvUltimosPedidos.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvUltimosPedidos.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            // 
            // colRepartidor
            // 
            colRepartidor.HeaderText = "Repartidor";
            colRepartidor.Name = "colRepartidor";
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1200, 700);
            Controls.Add(panelTop);
            Controls.Add(tableCards);
            Controls.Add(lblUltimosPedidos);
            Controls.Add(dgvUltimosPedidos);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1000, 650);
            Name = "Dashboard";
            Padding = new Padding(20);
            Text = "Dashboard";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            tableCards.ResumeLayout(false);
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            panelPedidos.ResumeLayout(false);
            panelPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).EndInit();
            panelRepartidores.ResumeLayout(false);
            panelRepartidores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox3).EndInit();
            panelRutas.ResumeLayout(false);
            panelRutas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUltimosPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna2PictureBox guna2PictureBox1;
        private Guna2PictureBox guna2PictureBox2;
        private Guna2PictureBox guna2PictureBox3;
        private Guna2PictureBox guna2PictureBox4;
    }
}