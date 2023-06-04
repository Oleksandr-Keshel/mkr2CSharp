using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modele_2
{
  
    public partial class Form2 : Form
    {
        RealNumbers realNumbers;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                realNumbers = new RealNumbers(openFileDialog1.FileName);
                realNumbers.WriteNumbersToGrid(RealNumbersGridView);
            }
        }

        private void GetSumOfNumsLessThanArithMeanBtn_Click(object sender, EventArgs e)
        {
            if (RealNumbersGridView.RowCount == 0)
            {
                MessageBox.Show("There are no numbers!");
            }
            else
            {
                double sum = realNumbers.SumOfNumsLessThanArithMean();
                MessageBox.Show(sum.ToString(), "Sum");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
