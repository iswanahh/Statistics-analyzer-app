using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
   public class UngroupedCentralTendency
    {

       SplitClass Splitted;
       string Data;
       public UngroupedCentralTendency(string UserData) 
       {
           this.Data = UserData;
       }

        public static double[] SortInAscendingOrder(double[] ValuesToBeSorted)
        {
            for (int i = 0; i < ValuesToBeSorted.Length; i++)
            {
                for (int j = ValuesToBeSorted.Length - 1; j > i; j--)
                {
                    if (ValuesToBeSorted[j] < ValuesToBeSorted[j - 1])
                    {
                        double a = ValuesToBeSorted[j];
                        ValuesToBeSorted[j] = ValuesToBeSorted[j - 1];
                        ValuesToBeSorted[j - 1] = a;
                    }
                }

            }
            return ValuesToBeSorted;
        }

        public double MEAN()
        {
            Splitted = new SplitClass(Data);
            double SumOfValues = 0; double Mean = 0;
            double[] Values = Splitted.SplitMethod();

            for (int i = 0; i < Values.Length; i++)
            {
                SumOfValues += Values[i];
            }
            Mean = SumOfValues / Values.Length;
            return Mean;
        }
        public double GeometricMean()
        {
            Splitted = new SplitClass(Data);
            double[] Values = Splitted.SplitMethod();
            double SumOfValues = 0; double GeoMean = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                SumOfValues += (Values[i]);
            }
            GeoMean = Math.Pow(SumOfValues, (1 / Values.Length));
            return GeoMean;
        }
        public double HarmonicMean()
        {
            Splitted = new SplitClass(Data);
            double[] Values = Splitted.SplitMethod();
            double SumOfValues = 0; double TotalSum = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                SumOfValues += (1 / Values[i]);
                TotalSum = Values.Length / SumOfValues;

            }
            return TotalSum;
        }

        public double Median()
        {
            Splitted = new SplitClass(Data);
            double[] Values = Splitted.SplitMethod();
            Values = SortInAscendingOrder(Values);
            for (int i = 0; i < Values.Length; i++)
            {
                Console.WriteLine(Values[i]);

            }
            double MedianValue = 0;
            if (Values.Length % 2 == 1)
            {
                MedianValue = (int)Values.Length / 2;
                MedianValue = (int)Values[(int)MedianValue];
            }
            else if (Values.Length % 2 == 0)
            {
                MedianValue = (int)Values.Length / 2;
                double MedianVal1 = (int)Values[(int)MedianValue];
                double MedianVal2 = Values[(int)MedianValue - 1];
                MedianValue = (MedianVal2 + MedianVal1) / 2;

            }
            return MedianValue;
        }

        public double Mode()
        {
            Splitted = new SplitClass(Data);
            double[] Values = Splitted.SplitMethod();

            List<double> Number = new List<double>();
            List<double> Frequency = new List<double>();
            double ModeValue = 0;
            double NewFrequency = 0;
            bool[] Check = new bool[Values.Length];
            int Occurence = 0;
            for (int i = 0; i < Values.Length; i++)
            {

                if (Number.Contains(Values[i]))
                {
                    continue;
                }

                for (int j = 0; j < Values.Length; j++)
                {
                    if (Check[j] == false && Values[i] == Values[j])
                    {
                        Occurence++;
                        Check[j] = true;

                    }
                }
                Number.Add(Values[i]);
                if (NewFrequency > Occurence)
                {
                    Occurence = 0;
                    continue;

                }
                else
                {
                    ModeValue = Values[i];
                    NewFrequency = Occurence;
                }

                Occurence = 0;
            }
            return ModeValue;
        }
    }
}
