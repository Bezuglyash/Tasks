using System;
using System.Windows.Forms;

namespace FirstTask
{
    public partial class Form1 : Form
    {
        private float[] massiv = new float[25];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < 25; i++)
            {
                massiv[i] = (float)random.Next(-100, 100) / 10f; ;
                massivX.Items.Add("Mas[" + Convert.ToString(i) + "] = " + massiv[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double min = 100000000;
            int minIndex = 0;
            for (int i = 0; i < 25; i++)
            {
                if (massiv[i] < min)
                {
                    minIndex = i;
                    min = massiv[i];
                }
            }

            float saveNumber = massiv[0];
            massiv[0] = massiv[minIndex];
            massiv[minIndex] = saveNumber;

            for (int i = 0; i < 25; i++)
            {
                massivY.Items.Add("Mas[" + Convert.ToString(i) + "] = " + massiv[i].ToString());
            }
        }
    }
}
