using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modele_2
{
    internal class RealNumbers : IRealNumbersOperations
    {
        public double[] Data { get; set; }
        
        public RealNumbers(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            int amountOfNums = File.ReadLines(filePath).Count();
            Data = new double[amountOfNums];
            for (int i = 0; i < amountOfNums; i++)
            {
                Data[i] = Convert.ToDouble(sr.ReadLine());
            }
            sr.Close();

        }
        public double ArithmeticMean()
        {
            double sum = 0;
            foreach (double el in this.Data)
            {
                sum += el;
            }
            double arithMean = sum / Data.Length;
            return arithMean;
        }

        public double SumOfNumsLessThanArithMean()
        {
            double sum = 0;
            double arithMean = ArithmeticMean();
            foreach (double el in this.Data)
            {
                if (el < arithMean)
                {
                    sum += el;
                }
            }
            return sum;
        }

        

        public void WriteNumbersToGrid(DataGridView grid)
        {
            grid.RowCount = 1;
            grid.ColumnCount = Data.Length;
            for (int i = 0; i < Data.Length; i++)
            {
                grid[i, 0].Value = Data[i];
            }
        }

    }
}
