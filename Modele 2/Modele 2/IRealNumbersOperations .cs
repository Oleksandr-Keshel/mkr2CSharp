using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modele_2
{
    internal interface IRealNumbersOperations
    {
        double[] Data { get; set; }
        void WriteNumbersToGrid(DataGridView grid);
        double ArithmeticMean();
        double SumOfNumsLessThanArithMean();
    }
}
