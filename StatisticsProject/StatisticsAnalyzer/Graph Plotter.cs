using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Library;

namespace StatisticsAnalyzer
{
    public partial class Graph_Plotter : Form
    {
        System.Windows.Forms.DataVisualization.Charting.SeriesChartType r;
        public double[] Data;
        public double[] Freq;
        string Values;
        SplitClass Splitted;

        public Graph_Plotter()
        {
            InitializeComponent();
            InitializeClasses();
        }
        void InitializeClasses()
        {
            Splitted = new SplitClass(Values);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series["Statistics"].Color = Color.CornflowerBlue;
            PlotTypes P = (PlotTypes)comboBox1.SelectedIndex;
            if (P == PlotTypes.Area)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.Bar)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chart1.Series["Statistics"].ChartType = r;
            }

            else if (P == PlotTypes.LinePlot)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.ScatterDiagram)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.BoxPlot)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.FastPoint)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.FastLine)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.PointAndFigure)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.PointAndFigure;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.ThreeLineBreak)
            {

                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.Range)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.RangeBar)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.StackedBar)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.StackedArea)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.Polar)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.Column)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Series["Statistics"].ChartType = r;
            }
            else if (P == PlotTypes.stackedColumn)
            {
                r = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                chart1.Series["Statistics"].ChartType = r;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PairClass C = new PairClass();
            C = Splitted.SplitMethod2();
            Data = C.ValuesOfX;
            Freq = C.FrequencyValues;
            chart1.Series["Statistics"].ChartType = r;
            for (int i = 0; i < Data.Length; i++)
            {
                chart1.Series["Statistics"].Points.AddXY(Data[i], Freq[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Values = textBox1.Text;
            InitializeClasses();

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 MainMenu = new Form1();
            MainMenu.Show();
            this.Hide();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph_Plotter Graph = new Graph_Plotter();
            Graph.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void measureOfCentralTendencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Central_Tendency Tendency = new Central_Tendency();
            Tendency.Show();
            this.Hide();
        }

        private void measureOfDispersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Measure_of_Dispersion Dispersion = new Measure_of_Dispersion();
            Dispersion.Show();
            this.Hide();
        }

        private void graphPlotterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph_Plotter Graph = new Graph_Plotter();
            Graph.Show();
            this.Hide();
        }

        private void Graph_Plotter_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
