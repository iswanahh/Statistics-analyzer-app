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
    public partial class Central_Tendency : Form
    {
        GroupedCentralTendency Grouped;
        GroupedDispersion Grouped2;
        UngroupedCentralTendency Ungrouped;
        UngroupedDispersion Ungrouped2;
        SplitClass Splitted;
        string Data;


        public void InitializeClasses()
        {
            Grouped = new GroupedCentralTendency(Data);
            Grouped2 = new GroupedDispersion(Data);
            Ungrouped = new UngroupedCentralTendency(Data);
            Ungrouped2 = new UngroupedDispersion(Data);
            Splitted = new SplitClass(Data);
        }

        public Central_Tendency()
        {
            InitializeComponent();
            

        }

        private void Central_Tendency_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            //label5.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data = textBox1.Text;
            InitializeClasses();
            if (radioButton1.Checked)
            {
                //label5.Text = "Enter the values of X and F separated by space in the text box";
                //label5.Show();
                Descriptive CentralTend = (Descriptive)comboBox1.SelectedIndex;
                switch (CentralTend)
                {
                    case Descriptive.Mean:
                        double Mean = Grouped.CheckBeforeCalculating();
                        label2.Text = "Mean is "+Mean.ToString();
                        break;
                    case Descriptive.Median:
                        label2.Text = "Median is Null";
                        break;
                    case Descriptive.Mode:
                        label2.Text = "Mode is Null";
                        break;
                    default:
                        break;
                }
            }
            else if (radioButton2.Checked)
            {
                Descriptive CentralTend = (Descriptive)comboBox1.SelectedIndex;
                switch (CentralTend)
                {
                    case Descriptive.Mean:
                        double Mean = Ungrouped.MEAN();
                        label2.Text = "Mean is " + Mean.ToString();
                        break;
                    case Descriptive.Median:
                        double Median = Ungrouped.Median();
                        label2.Text = "Median is " + Median.ToString();
                        break;
                    case Descriptive.Mode:
                        double Mode = Ungrouped.Mode();
                        label2.Text = "Mode is " + Mode.ToString();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Central_Tendency Tendency = new Central_Tendency();
            Tendency.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
