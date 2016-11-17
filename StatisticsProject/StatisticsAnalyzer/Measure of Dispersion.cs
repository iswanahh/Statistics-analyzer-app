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
    public partial class Measure_of_Dispersion : Form
    {
        GroupedCentralTendency Grouped;
        GroupedDispersion Grouped2;
        UngroupedCentralTendency Ungrouped;
        UngroupedDispersion Ungrouped2;
        string Data;


        public void InitializeClasses()
        {
            Grouped = new GroupedCentralTendency(Data);
            Grouped2 = new GroupedDispersion(Data);
            Ungrouped = new UngroupedCentralTendency(Data);
            Ungrouped2 = new UngroupedDispersion(Data);
        }
        public Measure_of_Dispersion()
        {
            InitializeComponent();
            InitializeClasses();
        }

        private void Measure_of_Dispersion_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Descriptive2 Dispersion = (Descriptive2)comboBox1.SelectedIndex;
                switch (Dispersion)
                {
                    case Descriptive2.Meandeviation:
                        double MeanDeviation = Grouped2.MeanDeviation();
                        label2.Text = "Mean Deviation is " + MeanDeviation.ToString();
                        break;
                    case Descriptive2.Range:
                        label2.Text = "Range is Null";
                        break;
                    case Descriptive2.SemiInterquatilerange:
                        label2.Text = "Value is Null";
                        break;
                    case Descriptive2.Standarddeviation:
                        double StandardDev = Grouped2.StandardDeviation();
                        label2.Text = "Standard Deviation is " + StandardDev.ToString();
                        break;
                    case Descriptive2.Variance:
                        double Variance = Grouped2.Variance();
                        label2.Text = "Variance is " + Variance.ToString();
                        break;
                    default:
                        break;
                }
            }
            else if (radioButton2.Checked)
            {
                Descriptive2 Dispersion = (Descriptive2)comboBox1.SelectedIndex;
                switch (Dispersion)
                {
                    case Descriptive2.Meandeviation:
                        double MeandDev = Ungrouped2.Meandeviation();
                        label2.Text = "Mean Deviation is " + MeandDev.ToString();
                        break;
                    case Descriptive2.Range:
                        double Range = Ungrouped2.RANGE();
                        label2.Text = "Range is " + Range.ToString();
                        break;
                    case Descriptive2.SemiInterquatilerange:
                        double SemiInterQuat = Ungrouped2.Semi_Inter_Quatile_Range();
                        label2.Text = "Semi-Inter Quatile Range is " + SemiInterQuat.ToString();
                        break;
                    case Descriptive2.Standarddeviation:
                        double StandardDev = Ungrouped2.Standarddeviation();
                        label2.Text = "Standard Deviation is " + StandardDev.ToString();
                        break;
                    case Descriptive2.Variance:
                         double Variance = Ungrouped2.Variance();
                        label2.Text = "Variance is " + Variance.ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Data = textBox1.Text;
            InitializeClasses();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 MainMenu = new Form1();
            MainMenu.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Measure_of_Dispersion Dispersion = new Measure_of_Dispersion();
            Dispersion.Show();
            this.Hide();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
