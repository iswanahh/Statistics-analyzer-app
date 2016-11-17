using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Library;

namespace StatisticsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("***************PROGRAM TO CALCULATE STATISTICAL OPERATION***************");
                Console.WriteLine();
                Console.WriteLine("WARNING !!!!!! Type exactly what you see, if there is space,put space. Else, do otherwise.");
                Console.WriteLine();
                Console.WriteLine("Statistics are of two types:\nDESCRIPTIVE STATISTICS\nINFERENTIAL STATISTICS\n");
                Console.WriteLine("Descriptive statistics is of two types also:\nMeasure ofCentral Tendency\nMeasure of Dispersion\n");
                Console.WriteLine("For measure of Central Tendency, we have the following:\n1a.Mean\n2a.Median\n3a.Mode");
                Console.WriteLine("For Measure of Dispersion, we have the following:\n1b.Mean Deviation\n2b.Standard Deviation\n3b.Range\n4.Variance\n5.Semiinterquatilerange");
                Console.WriteLine();
                Console.WriteLine("If you want to perform any of these operations, type yes");
                string Y = Console.ReadLine();
                bool Continue=true;
               while (Continue)
            {
                    Console.WriteLine("Type 1 for Ungrouped data and 2 for Grouped data");
                    int Data = int.Parse(Console.ReadLine());
                    if (Data == 1)
                    {

                        Console.WriteLine("ENter Values Separated By space ( )");
                        string CollectedValues = Console.ReadLine();
                        Console.WriteLine("Enter Index for the statistical operation you want to perform...");
                        string Operation = Console.ReadLine();
                        UngroupedCentralTendency Ungrouped = new UngroupedCentralTendency(CollectedValues);
                        UngroupedDispersion Ungrouped2 = new UngroupedDispersion(CollectedValues);
                        SplitClass Splitted = new SplitClass(CollectedValues);

                        if (Operation == "1a")
                        {
                            double Mean = Ungrouped.MEAN();
                            double GeometricMean = Ungrouped.GeometricMean();
                            double HarmonicMean = Ungrouped.HarmonicMean();
                            Console.WriteLine("The mean is " + Mean);
                            Console.WriteLine("The Geometric mean is: " + GeometricMean);
                            Console.WriteLine("The harmonic mmean is : " + HarmonicMean);
                        }
                        else if (Operation == "2a")
                        {
                            double solution = Ungrouped.Median();
                            Console.Write("The median is: " + solution);

                        }
                        else if (Operation == "3a")
                        {
                            double mode = Ungrouped.Mode();
                            Console.WriteLine("The mode is " + mode);
                        }
                        else if (Operation == "1b")
                        {
                            double meand = Ungrouped2.Meandeviation();
                            Console.WriteLine("The mean deviation is : " + meand);
                        }
                        else if (Operation == "2b")
                        {
                            double dev = Ungrouped2.Standarddeviation();
                            Console.WriteLine("The Standard Deviation is : " + dev);
                        }
                        else if (Operation == "3b")
                        {
                            double wat = Ungrouped2.RANGE();
                            Console.WriteLine("The range is : " + wat);
                        }

                        else if (Operation == "4")
                        {
                            double var = Ungrouped2.Variance();
                            Console.WriteLine("The variance is : " + var);
                        }

                        else if (Operation == "5")
                        {
                            double range = Ungrouped2.Semi_Inter_Quatile_Range();
                            Console.WriteLine("Semi interquatile range is : " + range);

                        }
                    }
                    //Console.WriteLine("\nIf you want to perform another operation, type yes.");
                    //Y = Console.ReadLine();
                    //Console.Clear();

                    else if (Data == 2)
                    {
                        Console.WriteLine("Enter Values of the data Separated By a comma (,) then semi colon to separate them from the frequency");
                        string CollectedValues = Console.ReadLine();
                        Console.WriteLine("Enter Index for the statistical operation you want to perform...");
                        string Operation = Console.ReadLine();
                        GroupedCentralTendency Grouped = new GroupedCentralTendency(CollectedValues);
                        GroupedDispersion Grouped2 = new GroupedDispersion(CollectedValues);
                        SplitClass Splitted = new SplitClass(CollectedValues);


                        if (Operation == "1a")
                        {
                            Console.WriteLine(Splitted.Table());
                            Console.WriteLine();
                            double mean = Grouped.CheckBeforeCalculating();
                            Console.WriteLine("The mean is : " + mean);

                            //if (Splitted.CheckData())
                            //{
                            //    Console.WriteLine("Data is okay");
                            //    Console.WriteLine(Splitted.Table());
                            //    Console.WriteLine();
                            //    Console.WriteLine();
                            //    double mean = Grouped.CheckBeforeCalculating();
                            //    Console.WriteLine("The mean is : " + mean);
                            //}
                            //else
                            //{
                            //    Console.WriteLine("Data is not okay");
                            //}
                        }
                        else if (Operation == "1b")
                        {
                            double meandev = Grouped2.MeanDeviation();
                            Console.WriteLine("Mean Deviation is " + meandev);
                        }
                        else if (Operation == "2b")
                        {
                            double StandardDeviation = Grouped2.StandardDeviation();
                            Console.WriteLine("Standard Deviation is " + StandardDeviation);

                        }
                        else if (Operation == "4")
                        {
                            double Variance = Grouped2.Variance();
                            Console.WriteLine("Variance is " + Variance);
                        }
                    }

                    //Console.Clear();
                   Console.WriteLine("press Yes to continue");
                   string response=Console.ReadLine();
                   switch (response)
	                {
                       case "Yes":
                       case "yes":
                       case "YES":
                           Continue=true;
                           break;

		                default:
                           Continue= false;
                           break;
	                }

                }
               Console.ReadKey();
            }

        }

    }
