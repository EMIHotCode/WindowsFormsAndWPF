using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lesson6_1
{
    public partial class площадь_треугольника_по_формуле_Герона : Form
    {
        public площадь_треугольника_по_формуле_Герона()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();
            if (double.TryParse(textBoxA.Text, out double A))
            {
            }
            else
                errors.Add($"поле сторона A - введена не цифра {Environment.NewLine}");

            if (double.TryParse(textBoxB.Text, out double B))
            {
            }
            else
                errors.Add($"поле сторона B - введена не цифра {Environment.NewLine}");

            if (double.TryParse(textBoxC.Text, out double C))
            {
            }
            else
                errors.Add($"поле сторона C - введена не цифра {Environment.NewLine}");

            if (errors.Count != 0)
            {
                string itog = "";
                foreach (var item in errors)
                    itog += item;
                MessageBox.Show(itog);
                return;
            }


            if (A < 0 || B < 0 || C < 0)
            {
                MessageBox.Show("Треугольник с отрицательными сторонами не может существовать");
                return;
            }
           
                

            if (A+B >= C && B+C>=A && A+C>=B)
            {
                double p = (A + B + C) / 2;
                double result = Math.Sqrt(p*(p-A)*(p-B)*(p-C));
                textBoxResult.Text = result.ToString();
            }
            else
                MessageBox.Show("Такой треугольник не может существовать");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxResult.Clear();
        }
    }
}
