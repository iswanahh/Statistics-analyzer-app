using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
   public class UngroupedDispersion
    {
       private string Data;
       UngroupedCentralTendency Ungrouped;
       SplitClass Splitted;
       public UngroupedDispersion(string UserData)
       {
           this.Data = UserData;
           InitializeClasses();
       }
       private void InitializeClasses() 
       {
           Ungrouped = new UngroupedCentralTendency(Data);
           Splitted = new SplitClass(Data);
       }
        public double Meandeviation()
        {
            double[] Values = Splitted.SplitMethod();
            double AbsoluteValue = 0;
            double MeanDevValue = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                AbsoluteValue += Math.Abs(Values[i] - Ungrouped.MEAN());
                MeanDevValue = AbsoluteValue / Values.Length;
            }

            return MeanDevValue;
        }
        public double RANGE()
        {
            double[] Values = Splitted.SplitMethod();
            double RangeValue = 0;
            double SmallestValue;
            double HighestValue;
            Values = UngroupedCentralTendency.SortInAscendingOrder(Values);
            for (int i = 0; i < Values.Length; i++)
            {
                Console.WriteLine(Values[i]);

            }
            for (int i = 0; i < Values.Length; i++)
            {
                SmallestValue = (int)Values[0];
                HighestValue = (int)Values[Values.Length - 1];
                RangeValue = HighestValue - SmallestValue;
            }

            return RangeValue;
        }
        public double Standarddeviation()
        {
            double[] Values = Splitted.SplitMethod();
            double StandDevValue = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                StandDevValue = Math.Sqrt(Variance());
            }
            return StandDevValue;

        }
        public  double Semi_Inter_Quatile_Range()
        {
            double[] Values = Splitted.SplitMethod();
            double SemiIntQuatValue = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                SemiIntQuatValue = 3 * (Ungrouped.MEAN() -Ungrouped.Median()) / Standarddeviation();
            }
            return SemiIntQuatValue;
        }
        public double Variance()
        {
            double[] Values = Splitted.SplitMethod();
            double VarianceValue = 0;
            double SummationXSqr = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                SummationXSqr += Math.Pow(Values[i], 2);
                VarianceValue = SummationXSqr / Values.Length - Math.Pow(Ungrouped.MEAN(), 2);
            }

            return VarianceValue;
        }
    }
}
