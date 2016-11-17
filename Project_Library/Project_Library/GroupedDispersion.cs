using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
   public class GroupedDispersion
    {
       SplitClass Splitted;
       GroupedCentralTendency Grouped;
       string Data;

       public GroupedDispersion(string UserData)
       {
           this.Data = UserData;
           InitializeClasses();
       }

       void InitializeClasses()
       {
           Splitted = new SplitClass(Data);
           Grouped = new GroupedCentralTendency(Data);
       }

        public double MeanDeviation()
        {
            PairClass PairValue = new PairClass();
            double Mean = 0;
            if (Data.Contains('-'))
            {
                PairValue = Splitted.SplitMethod3();
                Mean = Grouped.MeanForClassBoundaries();
            }
            else
            {
                PairValue = Splitted.SplitMethod2();
                Mean = Grouped.MeanForGroupedData();
            }
            double[] Frequency = PairValue.FrequencyValues;
            double[] ValuesOfX = PairValue.ValuesOfX;
            double TotalFrequency = 0;
            double[] XValuesMinMean = new double[Frequency.Length];
            double[] FreqAndXValuesMinMean = new double[Frequency.Length];
            double MeanDevSum = 0;
            for (int i = 0; i < Frequency.Length; i++)
            {
                TotalFrequency += Frequency[i];
                XValuesMinMean[i] = PairValue.ValuesOfX[i] - Mean;
                FreqAndXValuesMinMean[i] = Frequency[i] * XValuesMinMean[i];
                MeanDevSum += Math.Abs(FreqAndXValuesMinMean[i]);
            }
            return MeanDevSum / TotalFrequency;
        }

        public double StandardDeviation()
        {
            PairClass PairValue = new PairClass();
            double Mean = 0;
            if (Data.Contains('-'))
            {
                PairValue = Splitted.SplitMethod3();
                Mean = Grouped.MeanForClassBoundaries();
            }
            else
            {
                PairValue = Splitted.SplitMethod2();
                Mean = Grouped.MeanForGroupedData();
            }
            double[] Frequency = PairValue.FrequencyValues;
            double[] ValuesOfX = PairValue.ValuesOfX;
            double[] FreqXSqr = new double[Frequency.Length];
            double TotalFrequency = 0;
            double[] FreqAndX = new double[Frequency.Length];
            double SummationFXSqr = 0;
            double SummationFX = 0; double StandardDevValue = 0;
            for (int i = 0; i < Frequency.Length; i++)
            {
                TotalFrequency += Frequency[i];
                FreqXSqr[i] = Frequency[i] * Math.Pow(ValuesOfX[i],2);
                SummationFXSqr+=FreqXSqr[i];
                FreqAndX[i] = Frequency[i] * ValuesOfX[i];
                SummationFX += FreqAndX[i];
                StandardDevValue = Math.Sqrt((SummationFXSqr / TotalFrequency) - (Math.Pow((SummationFX / TotalFrequency), 2)));
            }
            return StandardDevValue;
        }
        public double Variance()
        {
            PairClass PairValue = new PairClass();
            double Mean = 0;            
            if (Data.Contains('-'))
            {
                PairValue = Splitted.SplitMethod3();
                Mean = Grouped.MeanForClassBoundaries();
            }
            else
            {
                PairValue = Splitted.SplitMethod2();
                Mean = Grouped.MeanForGroupedData();
            }
            double[] Frequency = PairValue.FrequencyValues;
            double[] ValuesOfX = PairValue.ValuesOfX;
            double[] FXMinMeanSqr = new double[Frequency.Length];
            double TotalFrequency = 0;
            double SummationFXMinMeanSqr = 0;
            double VarianceValue = 0;
            for (int i = 0; i < Frequency.Length; i++)
            {
                FXMinMeanSqr[i] =Frequency[i] *  Math.Pow((ValuesOfX[i] - Mean), 2);
                TotalFrequency += Frequency[i];
                SummationFXMinMeanSqr += FXMinMeanSqr[i];
                VarianceValue = SummationFXMinMeanSqr / TotalFrequency;

            }
            return VarianceValue;
        }
    }
}
