using Guna.UI2.WinForms;

namespace RutaSmart.UI.Reportes
{
    partial class FrmReportes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelContainer = new Panel();
            pnlGrid = new Guna2Panel();
            tableGrid = new TableLayoutPanel();
            dgvReportes = new Guna2DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Repartidor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Ruta = new DataGridViewTextBoxColumn();
            panelResumen = new Guna2Panel();
            lblResumen = new Label();
            lblTotalText = new Label();
            lblPendientesText = new Label();
            lblRutaText = new Label();
            lblEntregadosText = new Label();
            lblTotal = new Label();
            lblPendientes = new Label();
            lblRuta = new Label();
            lblEntregados = new Label();
            pnlGraficos = new Guna2Panel();
            tableGraficos = new TableLayoutPanel();
            pnlFiltros = new Guna2Panel();
            tableFiltros = new TableLayoutPanel();
            lblDesde = new Label();
            lblHasta = new Label();
            lblTipo = new Label();
            dtDesde = new Guna2DateTimePicker();
            dtHasta = new Guna2DateTimePicker();
            cmbTipoReporte = new Guna2ComboBox();
            btnGenerar = new Guna2Button();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            panelContainer.SuspendLayout();
            pnlGrid.SuspendLayout();
            tableGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            panelResumen.SuspendLayout();
            pnlGraficos.SuspendLayout();
            pnlFiltros.SuspendLayout();
            tableFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(245, 247, 250);
            panelContainer.Controls.Add(pnlGrid);
            panelContainer.Controls.Add(pnlGraficos);
            panelContainer.Controls.Add(pnlFiltros);
            panelContainer.Controls.Add(lblSubtitulo);
            panelContainer.Controls.Add(lblTitulo);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(20);
            panelContainer.Size = new Size(1200, 700);
            panelContainer.TabIndex = 0;
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGrid.BackColor = Color.Transparent;
            pnlGrid.BorderRadius = 20;
            pnlGrid.Controls.Add(tableGrid);
            pnlGrid.CustomizableEdges = customizableEdges3;
            pnlGrid.FillColor = Color.White;
            pnlGrid.Location = new Point(20, 480);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlGrid.ShadowDecoration.Enabled = true;
            pnlGrid.Size = new Size(1160, 190);
            pnlGrid.TabIndex = 4;
            // 
            // tableGrid
            // 
            tableGrid.ColumnCount = 2;
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableGrid.Controls.Add(dgvReportes, 0, 0);
            tableGrid.Controls.Add(panelResumen, 1, 0);
            tableGrid.Dock = DockStyle.Fill;
            tableGrid.Location = new Point(0, 0);
            tableGrid.Name = "tableGrid";
            tableGrid.Padding = new Padding(10);
            tableGrid.RowCount = 1;
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableGrid.Size = new Size(1160, 190);
            tableGrid.TabIndex = 0;
            // 
            // dgvReportes
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReportes.ColumnHeadersHeight = 40;
            dgvReportes.Columns.AddRange(new DataGridViewColumn[] { ID, Cliente, Fecha, Repartidor, Estado, Ruta });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReportes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReportes.Dock = DockStyle.Fill;
            dgvReportes.GridColor = Color.FromArgb(231, 229, 255);
            dgvReportes.Location = new Point(13, 13);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.Size = new Size(883, 164);
            dgvReportes.TabIndex = 0;
            dgvReportes.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvReportes.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvReportes.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvReportes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvReportes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvReportes.ThemeStyle.BackColor = Color.White;
            dgvReportes.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvReportes.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvReportes.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReportes.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvReportes.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvReportes.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReportes.ThemeStyle.HeaderStyle.Height = 40;
            dgvReportes.ThemeStyle.ReadOnly = false;
            dgvReportes.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvReportes.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReportes.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvReportes.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvReportes.ThemeStyle.RowsStyle.Height = 25;
            dgvReportes.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvReportes.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Repartidor
            // 
            Repartidor.HeaderText = "Repartidor";
            Repartidor.Name = "Repartidor";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.Name = "Ruta";
            // 
            // panelResumen
            // 
            panelResumen.BorderRadius = 15;
            panelResumen.Controls.Add(lblResumen);
            panelResumen.Controls.Add(lblTotalText);
            panelResumen.Controls.Add(lblPendientesText);
            panelResumen.Controls.Add(lblRutaText);
            panelResumen.Controls.Add(lblEntregadosText);
            panelResumen.Controls.Add(lblTotal);
            panelResumen.Controls.Add(lblPendientes);
            panelResumen.Controls.Add(lblRuta);
            panelResumen.Controls.Add(lblEntregados);
            panelResumen.CustomizableEdges = customizableEdges1;
            panelResumen.Dock = DockStyle.Fill;
            panelResumen.FillColor = Color.FromArgb(248, 250, 252);
            panelResumen.Location = new Point(902, 13);
            panelResumen.Name = "panelResumen";
            panelResumen.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelResumen.Size = new Size(245, 164);
            panelResumen.TabIndex = 1;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResumen.Location = new Point(60, 15);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(80, 21);
            lblResumen.TabIndex = 0;
            lblResumen.Text = "Resumen";
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalText.Location = new Point(20, 50);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(37, 15);
            lblTotalText.TabIndex = 1;
            lblTotalText.Text = "Total:";
            // 
            // lblPendientesText
            // 
            lblPendientesText.AutoSize = true;
            lblPendientesText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPendientesText.Location = new Point(20, 75);
            lblPendientesText.Name = "lblPendientesText";
            lblPendientesText.Size = new Size(72, 15);
            lblPendientesText.TabIndex = 2;
            lblPendientesText.Text = "Pendientes:";
            // 
            // lblRutaText
            // 
            lblRutaText.AutoSize = true;
            lblRutaText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRutaText.Location = new Point(20, 100);
            lblRutaText.Name = "lblRutaText";
            lblRutaText.Size = new Size(49, 15);
            lblRutaText.TabIndex = 3;
            lblRutaText.Text = "En ruta:";
            // 
            // lblEntregadosText
            // 
            lblEntregadosText.AutoSize = true;
            lblEntregadosText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEntregadosText.Location = new Point(20, 125);
            lblEntregadosText.Name = "lblEntregadosText";
            lblEntregadosText.Size = new Size(72, 15);
            lblEntregadosText.TabIndex = 4;
            lblEntregadosText.Text = "Entregados:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(130, 50);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(14, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "0";
            // 
            // lblPendientes
            // 
            lblPendientes.AutoSize = true;
            lblPendientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPendientes.Location = new Point(130, 75);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(14, 15);
            lblPendientes.TabIndex = 6;
            lblPendientes.Text = "0";
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRuta.Location = new Point(130, 100);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(14, 15);
            lblRuta.TabIndex = 7;
            lblRuta.Text = "0";
            // 
            // lblEntregados
            // 
            lblEntregados.AutoSize = true;
            lblEntregados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEntregados.Location = new Point(130, 125);
            lblEntregados.Name = "lblEntregados";
            lblEntregados.Size = new Size(14, 15);
            lblEntregados.TabIndex = 8;
            lblEntregados.Text = "0";
            // 
            // pnlGraficos
            // 
            pnlGraficos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlGraficos.BackColor = Color.Transparent;
            pnlGraficos.BorderRadius = 20;
            pnlGraficos.Controls.Add(tableGraficos);
            pnlGraficos.CustomizableEdges = customizableEdges5;
            pnlGraficos.FillColor = Color.White;
            pnlGraficos.Location = new Point(20, 240);
            pnlGraficos.Name = "pnlGraficos";
            pnlGraficos.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlGraficos.ShadowDecoration.Enabled = true;
            pnlGraficos.Size = new Size(1160, 220);
            pnlGraficos.TabIndex = 3;
            // 
            // tableGraficos
            // 
            tableGraficos.ColumnCount = 2;
            tableGraficos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableGraficos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableGraficos.Dock = DockStyle.Fill;
            tableGraficos.Location = new Point(0, 0);
            tableGraficos.Name = "tableGraficos";
            tableGraficos.Padding = new Padding(10);
            tableGraficos.RowCount = 1;
            tableGraficos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableGraficos.Size = new Size(1160, 220);
            tableGraficos.TabIndex = 0;
            // 
            // pnlFiltros
            // 
            pnlFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFiltros.BackColor = Color.Transparent;
            pnlFiltros.BorderRadius = 20;
            pnlFiltros.Controls.Add(tableFiltros);
            pnlFiltros.CustomizableEdges = customizableEdges15;
            pnlFiltros.FillColor = Color.White;
            pnlFiltros.Location = new Point(20, 100);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.ShadowDecoration.CustomizableEdges = customizableEdges16;
            pnlFiltros.ShadowDecoration.Enabled = true;
            pnlFiltros.Size = new Size(1160, 120);
            pnlFiltros.TabIndex = 2;
            // 
            // tableFiltros
            // 
            tableFiltros.ColumnCount = 4;
            tableFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableFiltros.Controls.Add(lblDesde, 0, 0);
            tableFiltros.Controls.Add(lblHasta, 1, 0);
            tableFiltros.Controls.Add(lblTipo, 2, 0);
            tableFiltros.Controls.Add(dtDesde, 0, 1);
            tableFiltros.Controls.Add(dtHasta, 1, 1);
            tableFiltros.Controls.Add(cmbTipoReporte, 2, 1);
            tableFiltros.Controls.Add(btnGenerar, 3, 1);
            tableFiltros.Dock = DockStyle.Fill;
            tableFiltros.Location = new Point(0, 0);
            tableFiltros.Name = "tableFiltros";
            tableFiltros.Padding = new Padding(20);
            tableFiltros.RowCount = 2;
            tableFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableFiltros.Size = new Size(1160, 120);
            tableFiltros.TabIndex = 0;
            // 
            // lblDesde
            // 
            lblDesde.Anchor = AnchorStyles.Left;
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesde.Location = new Point(23, 27);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(75, 15);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Fecha desde";
            // 
            // lblHasta
            // 
            lblHasta.Anchor = AnchorStyles.Left;
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHasta.Location = new Point(303, 27);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(71, 15);
            lblHasta.TabIndex = 1;
            lblHasta.Text = "Fecha hasta";
            // 
            // lblTipo
            // 
            lblTipo.Anchor = AnchorStyles.Left;
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipo.Location = new Point(583, 27);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(94, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo de reporte";
            // 
            // dtDesde
            // 
            dtDesde.BorderRadius = 10;
            dtDesde.Checked = true;
            dtDesde.CustomizableEdges = customizableEdges7;
            dtDesde.Dock = DockStyle.Fill;
            dtDesde.Font = new Font("Segoe UI", 9F);
            dtDesde.Format = DateTimePickerFormat.Short;
            dtDesde.Location = new Point(30, 60);
            dtDesde.Margin = new Padding(10);
            dtDesde.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtDesde.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtDesde.Name = "dtDesde";
            dtDesde.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtDesde.Size = new Size(260, 30);
            dtDesde.TabIndex = 3;
            dtDesde.Value = new DateTime(2026, 5, 9, 16, 56, 36, 290);
            // 
            // dtHasta
            // 
            dtHasta.BorderRadius = 10;
            dtHasta.Checked = true;
            dtHasta.CustomizableEdges = customizableEdges9;
            dtHasta.Dock = DockStyle.Fill;
            dtHasta.Font = new Font("Segoe UI", 9F);
            dtHasta.Format = DateTimePickerFormat.Short;
            dtHasta.Location = new Point(310, 60);
            dtHasta.Margin = new Padding(10);
            dtHasta.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtHasta.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtHasta.Name = "dtHasta";
            dtHasta.ShadowDecoration.CustomizableEdges = customizableEdges10;
            dtHasta.Size = new Size(260, 30);
            dtHasta.TabIndex = 4;
            dtHasta.Value = new DateTime(2026, 5, 9, 16, 56, 36, 341);
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.BackColor = Color.Transparent;
            cmbTipoReporte.BorderRadius = 10;
            cmbTipoReporte.CustomizableEdges = customizableEdges11;
            cmbTipoReporte.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbTipoReporte.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbTipoReporte.Font = new Font("Segoe UI", 10F);
            cmbTipoReporte.ForeColor = Color.FromArgb(68, 88, 112);
            cmbTipoReporte.ItemHeight = 30;
            cmbTipoReporte.Items.AddRange(new object[] { "Resumen general", "Por cliente", "Por repartidor", "Por fecha" });
            cmbTipoReporte.Location = new Point(590, 60);
            cmbTipoReporte.Margin = new Padding(10);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cmbTipoReporte.Size = new Size(316, 36);
            cmbTipoReporte.TabIndex = 5;
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Left;
            btnGenerar.BorderRadius = 10;
            btnGenerar.CustomizableEdges = customizableEdges13;
            btnGenerar.FillColor = Color.FromArgb(37, 99, 235);
            btnGenerar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(919, 57);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnGenerar.Size = new Size(150, 36);
            btnGenerar.TabIndex = 6;
            btnGenerar.Text = "Generar";
            btnGenerar.Click += button1_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(22, 65);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(316, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Visualiza métricas y reportes generales del sistema";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(338, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reportes y Estadísticas";
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1000, 650);
            Name = "FrmReportes";
            Text = "FrmReportes";
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            pnlGrid.ResumeLayout(false);
            tableGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            panelResumen.ResumeLayout(false);
            panelResumen.PerformLayout();
            pnlGraficos.ResumeLayout(false);
            pnlFiltros.ResumeLayout(false);
            tableFiltros.ResumeLayout(false);
            tableFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;

        private Label lblTitulo;
        private Label lblSubtitulo;

        private Guna2Panel pnlFiltros;
        private TableLayoutPanel tableFiltros;

        private Label lblDesde;
        private Label lblHasta;
        private Label lblTipo;

        private Guna2DateTimePicker dtDesde;
        private Guna2DateTimePicker dtHasta;

        private Guna2ComboBox cmbTipoReporte;

        private Guna2Button btnGenerar;

        private Guna2Panel pnlGraficos;
        private TableLayoutPanel tableGraficos;

        private Guna2Panel pnlGrid;
        private TableLayoutPanel tableGrid;

        private Guna2DataGridView dgvReportes;

        private Guna2Panel panelResumen;

        private Label lblResumen;

        private Label lblTotalText;
        private Label lblPendientesText;
        private Label lblRutaText;
        private Label lblEntregadosText;

        private Label lblTotal;
        private Label lblPendientes;
        private Label lblRuta;
        private Label lblEntregados;

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Repartidor;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Ruta;
    }
}