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
    public partial class Form1 : Form
    {
        GroupedCentralTendency Grouped;
        GroupedDispersion Grouped2;
        UngroupedCentralTendency Ungrouped;
        UngroupedDispersion Ungrouped2;
        string Data;

        public Form1()
        {
            InitializeComponent();
            //InitializeClasses();
        }
        public void InitializeClasses()
        {
            Grouped = new GroupedCentralTendency(Data);
            Grouped2 = new GroupedDispersion(Data);
            Ungrouped = new UngroupedCentralTendency(Data);
            Ungrouped2 = new UngroupedDispersion(Data);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void graphPlotterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph_Plotter Graph = new Graph_Plotter();
            Graph.Show();
            this.Hide();
        }

        private void measureOfDispersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Central_Tendency CentralTendency = new Central_Tendency();
            CentralTendency.Show();
            this.Hide();
        }

        private void measureOfDispersionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Measure_of_Dispersion Dispersion = new Measure_of_Dispersion();
            Dispersion.Show();
            this.Hide();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 MainMenu = new Form1();
            MainMenu.Show();
            this.Hide();
        }

      

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
