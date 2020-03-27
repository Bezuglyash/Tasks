using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondTask
{
    public partial class Form1 : Form
    {
        private int sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            firstMassiv.RowCount = 3;
            firstMassiv.ColumnCount = 4;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    firstMassiv.Rows[i].Cells[j].Value = random.Next(-100, 100);
                    if (i == j)
                    {
                        sum += Convert.ToInt32(firstMassiv.Rows[i].Cells[j].Value);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secondMassiv.RowCount = 3;
            secondMassiv.ColumnCount = 4;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 2 && j == 3)
                    {
                        secondMassiv.Rows[i].Cells[j].Value = sum;
                    }
                    else
                    {
                        secondMassiv.Rows[i].Cells[j].Value = firstMassiv.Rows[i].Cells[j].Value;
                    }
                }
            }
        }
    }
}
