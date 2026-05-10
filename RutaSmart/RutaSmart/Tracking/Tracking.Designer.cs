using Guna.UI2.WinForms;

namespace RutaSmart.UI.Tracking
{
    partial class Tracking
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
            components = new System.ComponentModel.Container();

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

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();

            System.Windows.Forms.DataVisualization.Charting.Legend legend1 =
                new System.Windows.Forms.DataVisualization.Charting.Legend();

            System.Windows.Forms.DataVisualization.Charting.Series series1 =
                new System.Windows.Forms.DataVisualization.Charting.Series();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();

            System.Windows.Forms.DataVisualization.Charting.Legend legend2 =
                new System.Windows.Forms.DataVisualization.Charting.Legend();

            System.Windows.Forms.DataVisualization.Charting.Series series2 =
                new System.Windows.Forms.DataVisualization.Charting.Series();

            pnlMain = new Panel();
            pnlContainer = new Guna2Panel();

            lblTitulo = new Label();
            lblSubtitulo = new Label();

            pnlFiltros = new Guna2Panel();
            lblFechaDesde = new Label();
            lblFechaHasta = new Label();
            lblTipoReporte = new Label();

            dtpDesde = new Guna2DateTimePicker();
            dtpHasta = new Guna2DateTimePicker();

            cbTipoReporte = new Guna2ComboBox();

            btnGenerar = new Guna2Button();
            btnExportar = new Guna2Button();

            pnlCharts = new TableLayoutPanel();

            chartBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartEstados = new System.Windows.Forms.DataVisualization.Charting.Chart();

            pnlTabla = new Guna2Panel();

            dgvTracking = new Guna2DataGridView();

            colId = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colRepartidor = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colRuta = new DataGridViewTextBoxColumn();

            lblResumen = new Label();

            pnlMain.SuspendLayout();
            pnlContainer.SuspendLayout();
            pnlFiltros.SuspendLayout();
            pnlCharts.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(chartBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(chartEstados)).BeginInit();

            pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvTracking)).BeginInit();

            SuspendLayout();

            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(236, 240, 241);
            pnlMain.Controls.Add(pnlContainer);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1200, 700);
            pnlMain.TabIndex = 0;

            // 
            // pnlContainer
            // 
            pnlContainer.CustomizableEdges = customizableEdges1;
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.FillColor = Color.Transparent;
            pnlContainer.Controls.Add(lblTitulo);
            pnlContainer.Controls.Add(lblSubtitulo);
            pnlContainer.Controls.Add(pnlFiltros);
            pnlContainer.Controls.Add(pnlCharts);
            pnlContainer.Controls.Add(pnlTabla);
            pnlContainer.Padding = new Padding(20);
            pnlContainer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1200, 700);
            pnlContainer.TabIndex = 0;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(366, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reportes y Estadísticas";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(23, 67);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(334, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Monitorea entregas y estadísticas del sistema";

            // 
            // pnlFiltros
            // 
            pnlFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFiltros.BorderRadius = 15;
            pnlFiltros.Controls.Add(lblFechaDesde);
            pnlFiltros.Controls.Add(lblFechaHasta);
            pnlFiltros.Controls.Add(lblTipoReporte);

            pnlFiltros.Controls.Add(dtpDesde);
            pnlFiltros.Controls.Add(dtpHasta);

            pnlFiltros.Controls.Add(cbTipoReporte);

            pnlFiltros.Controls.Add(btnGenerar);
            pnlFiltros.Controls.Add(btnExportar);

            pnlFiltros.CustomizableEdges = customizableEdges3;
            pnlFiltros.FillColor = Color.White;
            pnlFiltros.Location = new Point(20, 100);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlFiltros.ShadowDecoration.Enabled = true;
            pnlFiltros.Size = new Size(1160, 110);
            pnlFiltros.TabIndex = 2;

            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new Font("Segoe UI", 9F);
            lblFechaDesde.ForeColor = Color.Gray;
            lblFechaDesde.Location = new Point(25, 15);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(77, 15);
            lblFechaDesde.Text = "Fecha desde";

            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Font = new Font("Segoe UI", 9F);
            lblFechaHasta.ForeColor = Color.Gray;
            lblFechaHasta.Location = new Point(240, 15);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(73, 15);
            lblFechaHasta.Text = "Fecha hasta";

            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Font = new Font("Segoe UI", 9F);
            lblTipoReporte.ForeColor = Color.Gray;
            lblTipoReporte.Location = new Point(455, 15);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(92, 15);
            lblTipoReporte.Text = "Tipo de reporte";

            // 
            // dtpDesde
            // 
            dtpDesde.BorderRadius = 10;
            dtpDesde.Checked = true;
            dtpDesde.CustomizableEdges = customizableEdges5;
            dtpDesde.Font = new Font("Segoe UI", 9F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(25, 40);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpDesde.Size = new Size(180, 40);
            dtpDesde.TabIndex = 0;

            // 
            // dtpHasta
            // 
            dtpHasta.BorderRadius = 10;
            dtpHasta.Checked = true;
            dtpHasta.CustomizableEdges = customizableEdges7;
            dtpHasta.Font = new Font("Segoe UI", 9F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(240, 40);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpHasta.Size = new Size(180, 40);
            dtpHasta.TabIndex = 1;

            // 
            // cbTipoReporte
            // 
            cbTipoReporte.BackColor = Color.Transparent;
            cbTipoReporte.BorderRadius = 10;
            cbTipoReporte.CustomizableEdges = customizableEdges9;
            cbTipoReporte.DrawMode = DrawMode.OwnerDrawFixed;
            cbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoReporte.FocusedColor = Color.FromArgb(94, 148, 255);
            cbTipoReporte.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbTipoReporte.Font = new Font("Segoe UI", 9F);
            cbTipoReporte.ForeColor = Color.FromArgb(68, 88, 112);
            cbTipoReporte.ItemHeight = 30;
            cbTipoReporte.Items.AddRange(new object[]
            {
                "Resumen general",
                "Entregas",
                "Rutas",
                "Repartidores"
            });

            cbTipoReporte.Location = new Point(455, 40);
            cbTipoReporte.Name = "cbTipoReporte";
            cbTipoReporte.Size = new Size(220, 36);
            cbTipoReporte.TabIndex = 2;

            // 
            // btnGenerar
            // 
            btnGenerar.BorderRadius = 10;
            btnGenerar.CustomizableEdges = customizableEdges10;
            btnGenerar.FillColor = Color.FromArgb(52, 152, 219);
            btnGenerar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(710, 40);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnGenerar.Size = new Size(130, 40);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar";

            // 
            // btnExportar
            // 
            btnExportar.BorderRadius = 10;
            btnExportar.CustomizableEdges = customizableEdges12;
            btnExportar.FillColor = Color.FromArgb(231, 76, 60);
            btnExportar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(860, 40);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(120, 40);
            btnExportar.TabIndex = 4;
            btnExportar.Text = "Exportar PDF";

            // 
            // pnlCharts
            // 
            pnlCharts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCharts.ColumnCount = 2;
            pnlCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlCharts.Controls.Add(chartBarras, 0, 0);
            pnlCharts.Controls.Add(chartEstados, 1, 0);
            pnlCharts.Location = new Point(20, 230);
            pnlCharts.Name = "pnlCharts";
            pnlCharts.RowCount = 1;
            pnlCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlCharts.Size = new Size(1160, 240);
            pnlCharts.TabIndex = 3;

            // 
            // chartBarras
            // 
            chartArea1.Name = "ChartArea1";
            chartBarras.ChartAreas.Add(chartArea1);

            legend1.Name = "Legend1";
            chartBarras.Legends.Add(legend1);

            chartBarras.Dock = DockStyle.Fill;
            chartBarras.Location = new Point(3, 3);
            chartBarras.Name = "chartBarras";

            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Entregas";

            chartBarras.Series.Add(series1);
            chartBarras.Size = new Size(690, 234);
            chartBarras.TabIndex = 0;

            series1.Points.AddXY("Lun", 4);
            series1.Points.AddXY("Mar", 6);
            series1.Points.AddXY("Mié", 8);
            series1.Points.AddXY("Jue", 5);
            series1.Points.AddXY("Vie", 7);
            series1.Points.AddXY("Sáb", 3);

            // 
            // chartEstados
            // 
            chartArea2.Name = "ChartArea1";
            chartEstados.ChartAreas.Add(chartArea2);

            legend2.Name = "Legend1";
            chartEstados.Legends.Add(legend2);

            chartEstados.Dock = DockStyle.Fill;
            chartEstados.Location = new Point(699, 3);
            chartEstados.Name = "chartEstados";

            series2.ChartArea = "ChartArea1";
            series2.ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            series2.Legend = "Legend1";
            series2.Name = "Estados";

            chartEstados.Series.Add(series2);
            chartEstados.Size = new Size(458, 234);
            chartEstados.TabIndex = 1;

            series2.Points.AddXY("Pendiente", 4);
            series2.Points.AddXY("Entregado", 18);
            series2.Points.AddXY("En ruta", 2);
            series2.Points.AddXY("Retrasado", 1);

            // 
            // pnlTabla
            // 
            pnlTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                              AnchorStyles.Left | AnchorStyles.Right;

            pnlTabla.BorderRadius = 15;
            pnlTabla.Controls.Add(dgvTracking);
            pnlTabla.Controls.Add(lblResumen);
            pnlTabla.CustomizableEdges = customizableEdges1;
            pnlTabla.FillColor = Color.White;
            pnlTabla.Location = new Point(20, 490);
            pnlTabla.Name = "pnlTabla";
            pnlTabla.Size = new Size(1160, 180);
            pnlTabla.TabIndex = 4;

            // 
            // dgvTracking
            // 
            dgvTracking.AllowUserToAddRows = false;
            dgvTracking.AllowUserToDeleteRows = false;
            dgvTracking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                                 AnchorStyles.Left | AnchorStyles.Right;

            dgvTracking.ColumnHeadersHeight = 40;

            dgvTracking.Columns.AddRange(new DataGridViewColumn[]
            {
                colId,
                colCliente,
                colFecha,
                colRepartidor,
                colEstado,
                colRuta
            });

            dgvTracking.Location = new Point(20, 20);
            dgvTracking.Name = "dgvTracking";
            dgvTracking.RowHeadersVisible = false;
            dgvTracking.Size = new Size(850, 140);
            dgvTracking.TabIndex = 0;

            // 
            // Columnas
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";

            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";

            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";

            colRepartidor.HeaderText = "Repartidor";
            colRepartidor.Name = "colRepartidor";

            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";

            colRuta.HeaderText = "Ruta";
            colRuta.Name = "colRuta";

            // 
            // lblResumen
            // 
            lblResumen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblResumen.BackColor = Color.FromArgb(232, 248, 245);
            lblResumen.BorderStyle = BorderStyle.FixedSingle;
            lblResumen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResumen.ForeColor = Color.FromArgb(22, 160, 133);
            lblResumen.Location = new Point(900, 20);
            lblResumen.Name = "lblResumen";
            lblResumen.Padding = new Padding(10);
            lblResumen.Size = new Size(220, 120);
            lblResumen.TabIndex = 1;

            lblResumen.Text =
                "Resumen del período\r\n\r\n" +
                "Total pedidos: 24\r\n" +
                "Entregados: 18\r\n" +
                "Pendientes: 4\r\n" +
                "En ruta: 2";

            // 
            // Tracking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1000, 650);
            Name = "Tracking";
            Text = "Tracking";

            pnlMain.ResumeLayout(false);
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();

            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();

            pnlCharts.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(chartBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(chartEstados)).EndInit();

            pnlTabla.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(dgvTracking)).EndInit();

            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Guna2Panel pnlContainer;

        private Label lblTitulo;
        private Label lblSubtitulo;

        private Guna2Panel pnlFiltros;

        private Label lblFechaDesde;
        private Label lblFechaHasta;
        private Label lblTipoReporte;

        private Guna2DateTimePicker dtpDesde;
        private Guna2DateTimePicker dtpHasta;

        private Guna2ComboBox cbTipoReporte;

        private Guna2Button btnGenerar;
        private Guna2Button btnExportar;

        private TableLayoutPanel pnlCharts;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBarras;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstados;

        private Guna2Panel pnlTabla;

        private Guna2DataGridView dgvTracking;

        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colRepartidor;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colRuta;

        private Label lblResumen;
    }
}