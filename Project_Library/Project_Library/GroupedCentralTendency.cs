using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    public class GroupedCentralTendency
    {
        SplitClass Splitted;
        string Data;

        public GroupedCentralTendency(string UserData)
        {
            this.Data = UserData;
            InitializeClasses();
        }

        void InitializeClasses()
        {
            Splitted = new SplitClass(Data);
        }

        public double CheckBeforeCalculating()
        {
            if (Data.Contains('-'))
            {
                return MeanForClassBoundaries();
            }
            else
            {
                return MeanForGroupedData();
            }
        }
        public double MeanForClassBoundaries()
        {
            PairClass PairValue = new PairClass();
            PairValue = Splitted.SplitMethod3();
            double[] Frequency = PairValue.FrequencyValues;
            double[] ValuesOfX = PairValue.ValuesOfX;
            double[] FXValues = new double[PairValue.ValuesOfX.Length];
            double SummationFX = 0; double MeanValue = 0; double TotalFrequency = 0;
            for (int i = 0; i < Frequency.Length; i++)
            {
                FXValues[i] = Frequency[i] * ValuesOfX[i];
                SummationFX += FXValues[i];
                TotalFrequency += Frequency[i];
                MeanValue = SummationFX / TotalFrequency;
            }
            return MeanValue;
        }
        public double MeanForGroupedData()
        {
            PairClass PairValue = new PairClass();
            PairValue = Splitted.SplitMethod2();
            double[] Frequency = PairValue.FrequencyValues;
            double[] ValuesOfX = PairValue.ValuesOfX;
            double[] FXValues = new double[PairValue.ValuesOfX.Length]; double SummationFX = 0; double MeanValue = 0; double TotalFrequency = 0;
            for (int i = 0; i < Frequency.Length; i++)
            {
                FXValues[i] = Frequency[i] * ValuesOfX[i];
                SummationFX += FXValues[i];
                TotalFrequency += Frequency[i];
                MeanValue = SummationFX / TotalFrequency;
            }
            return MeanValue;
        }

        
    }
}
