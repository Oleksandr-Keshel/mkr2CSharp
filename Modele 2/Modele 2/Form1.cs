using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modele_2
{
    public partial class Form1 : Form
    {
        List<Buhhalter> BuhList;
        BindingSource BindSource;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuhList = new List<Buhhalter>();
            BuhList.Add(new Buhhalter("AB3427", "Russel", "Engineer", 6000, 2));
            BuhList.Add(new Buhhalter("AB8943", "Keith", "Driver", 2000, 4));
            BuhList.Add(new Buhhalter("BC3247", "Brien", "Engineer", 8000, 6));
            BuhList.Add(new Buhhalter("BC7589", "Smith", "Manager", 8000, 10));
            BuhList.Add(new Buhhalter("CD5689", "Potter", "Engineer", 7000, 3));

            BindSource = new BindingSource();
            BindSource.DataSource = BuhList;
            buhInfoGridView.DataSource = BindSource;
        }

        List<Buhhalter> BuhListFiltered;
        BindingSource BindSourceFiltered;

        private void FindBtn_Click(object sender, EventArgs e)  
        {
            string userInput = searchByIdTextBox.Text.Trim();
            userInput = userInput.ToUpper();
            BuhListFiltered = new List<Buhhalter>();
            foreach(Buhhalter buhElem in BuhList)
            {
                string firstTwoCharsOfCode = buhElem.Id.Substring(0, 2);
                if (userInput == firstTwoCharsOfCode)
                {
                    BuhListFiltered.Add(buhElem);
                }
            }
            BindSourceFiltered = new BindingSource();
            BindSourceFiltered.DataSource = BuhListFiltered;
            searchResultGridView.DataSource= BindSourceFiltered;
            searchResultGridView.Columns["Id"].Visible = false;
            searchResultGridView.Columns["Position"].Visible = false;
            searchResultGridView.Columns["Salary"].Visible = false;
        }

        private void ReduceSalaryOfEngineersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReduceSalaryForm reduceSalaryForm = new ReduceSalaryForm();
            if (reduceSalaryForm.ShowDialog() == DialogResult.OK)
            {
                int minExperience = (int)reduceSalaryForm.experienceNumericUpDown.Value;
                double reductionPercent = ((double)reduceSalaryForm.PercentNumericUpDown.Value) / 100;
                List<Buhhalter> engineerList = BuhList.FindAll(emp => emp.Position == "Engineer");
                foreach (var engineer in engineerList)
                {
                    if (engineer.Experience < minExperience)
                    {
                        engineer.Salary -= engineer.Salary * reductionPercent;

                        int index = BuhList.FindIndex(emp => emp.Id == engineer.Id);
                        BuhList[index].Salary = engineer.Salary;
                    }
                }
                BindSource.ResetBindings(false);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, BuhList);
                fs.Close();
            }
            
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                BinaryFormatter bf = new BinaryFormatter();
                BindSource.Clear();
                foreach (Buhhalter emp in (List<Buhhalter>)bf.Deserialize(fs))
                    BindSource.Add(emp);
                fs.Close();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExcelConverter.SaveGridToExcel(buhInfoGridView, saveFileDialog1.FileName, "Buhhalter_Data");
            }
        }
    }
}
