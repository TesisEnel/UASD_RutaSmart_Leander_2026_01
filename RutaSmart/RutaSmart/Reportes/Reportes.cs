using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RutaSmart.UI.Reportes
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CrearGraficos();
        }

        private void CrearGraficos()
        {
            tableGraficos.Controls.Clear();

            Chart barras = CrearGraficoBarras();
            Chart pastel = CrearGraficoPastel();

            // Agregar al TableLayoutPanel
            tableGraficos.Controls.Add(barras, 0, 0); 
            tableGraficos.Controls.Add(pastel, 1, 0); 
        }

        private Chart CrearGraficoBarras()
        {
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea();
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            chart.ChartAreas.Add(area);

            Series serie = new Series();
            serie.ChartType = SeriesChartType.Column;
            serie.Color = Color.FromArgb(52, 152, 219);

            serie.Points.AddXY("Lun", 4);
            serie.Points.AddXY("Mar", 6);
            serie.Points.AddXY("Mié", 8);
            serie.Points.AddXY("Jue", 5);
            serie.Points.AddXY("Vie", 7);
            serie.Points.AddXY("Sáb", 3);

            chart.Series.Add(serie);

            chart.Titles.Add("Entregas por día");

            return chart;
        }

        private Chart CrearGraficoPastel()
        {
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea();
            chart.ChartAreas.Add(area);

            Series serie = new Series();
            serie.ChartType = SeriesChartType.Pie;

            serie.Points.AddXY("Pendiente", 4);
            serie.Points.AddXY("Entregado", 18);
            serie.Points.AddXY("En ruta", 2);
            serie.Points.AddXY("Retrasado", 1);

            chart.Series.Add(serie);

            chart.Titles.Add("Estados de pedidos");

            return chart;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearGraficos();
        }
    }
}
