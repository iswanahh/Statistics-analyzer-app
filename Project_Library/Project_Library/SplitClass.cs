using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    public class SplitClass
    {
        private string Data;
        public double[] ValueForChecked;

        public SplitClass(string UserData) 
        {
            this.Data = UserData;
        }

        
        public double[] SplitMethod()
        {
            char[] SplitType = { ' ' };
            string[] Values = Data.Split(SplitType, StringSplitOptions.RemoveEmptyEntries);
            double[] CollectedValues = new double[Values.Length];

            for (int i = 0; i < CollectedValues.Length; i++)
            {
                CollectedValues[i] = double.Parse(Values[i]);

            }
            return CollectedValues;

        }

        public PairClass SplitMethod2()
        {
            PairClass PairValue = new PairClass();
            char [] SplitType = { ';' };
            string[] Values = Data.Split(SplitType, StringSplitOptions.RemoveEmptyEntries);
            char[] SplitType2 = { ' ' };
            string[] Values2 = Values[0].Split(SplitType2, StringSplitOptions.RemoveEmptyEntries);
            double[] CollectedValues = new double[Values2.Length];
            for (int i = 0; i < CollectedValues.Length; i++)
            {
                CollectedValues[i] = double.Parse(Values2[i]);
            }
            PairValue.ValuesOfX = CollectedValues;
            Values2 = Values[1].Split(SplitType2, StringSplitOptions.RemoveEmptyEntries);
            CollectedValues = new double[Values2.Length];
            for (int i = 0; i < CollectedValues.Length; i++)
            {
                CollectedValues[i] = double.Parse(Values2[i]);
            }

            PairValue.FrequencyValues = CollectedValues;
            return PairValue;
            
        }

        public PairClass SplitMethod3()
        {
            PairClass PairValue = new PairClass();
            char [] SplitType = { ';' };
            string[] Values = Data.Split(SplitType, StringSplitOptions.RemoveEmptyEntries);
            PairValue.ValuesOfX = PrepareMidValueOfData(Values[0]);
            char[] SplitType2 = { ' ' };
            string[] Values2 = Values[1].Split(SplitType2, StringSplitOptions.RemoveEmptyEntries);
            double[] CollectedValues = new double[Values2.Length];
            for (int i = 0; i < CollectedValues.Length; i++)
            {
                CollectedValues[i] = double.Parse(Values2[i]);
            }
            PairValue.FrequencyValues = CollectedValues;
            return PairValue;
        }

        public double[] PrepareMidValueOfData(string Data)
        {
            char[] SplitType = { ' ' };
            char[] SplitType2 = { '-' };
            string[] Values = Data.Split(SplitType, StringSplitOptions.RemoveEmptyEntries);
            int[,] CollectedValues = new int[Values.Length, 2];
            double[] ClassBoundaryTotal = new double[Values.Length];
            double[] MidValueOfX = new double[Values.Length];
            for (int i = 0; i < Values.Length; i++)
            {
                string[] Splitted = Values[i].Split(SplitType2, StringSplitOptions.RemoveEmptyEntries);
                CollectedValues[i, 0] = int.Parse(Splitted[0]);
                CollectedValues[i, 1] = int.Parse(Splitted[1]);
                ClassBoundaryTotal[i] = CollectedValues[i, 0] + CollectedValues[i, 1];
                MidValueOfX[i] = ClassBoundaryTotal[i] / 2;
            }
            return MidValueOfX;
        }

        
        public string Table()
        {
            PairClass PairValue = new PairClass();
            char[] SplitType = { ';' };
            string[] Values = Data.Split(SplitType, StringSplitOptions.RemoveEmptyEntries);
            char[] SplitType2 = { ' ' };
            string[] Values2 = Values[0].Split(SplitType2, StringSplitOptions.RemoveEmptyEntries);
            double[] CollectedValues = new double[Values2.Length];
            for (int i = 0; i < CollectedValues.Length; i++)
            {
                CollectedValues[i] = double.Parse(Values2[i]);
            }
            PairValue.ValuesOfX = CollectedValues;
            Values2 = Values[1].Split(SplitType2, StringSplitOptions.RemoveEmptyEntries);
            CollectedValues = new double[Values2.Length];
            for (int i = 0; i < CollectedValues.Length; i++)
            {
                CollectedValues[i] = double.Parse(Values2[i]);
            }
            PairValue.FrequencyValues = CollectedValues;

            var ans = "x\t|\tf\t|\tfx\n";
            ans += "----------------------------------------------\n";


            for (int i = 0; i < PairValue.ValuesOfX.Length; i++)
            {
                ans += PairValue.ValuesOfX[i] + "\t|\t" + PairValue.FrequencyValues[i] + "\t|\t" + PairValue.ValuesOfX[i] * PairValue.FrequencyValues[i] + "\n";
            }

            return ans;
        }

        //public bool CheckData()
        //{
        //    string[] pv = Data.Split(';');
        //    if (pv[0].Split(' ').Length == pv[1].Split(' ').Length)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
