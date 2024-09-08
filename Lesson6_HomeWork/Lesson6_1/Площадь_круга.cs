using System;
using System.Windows.Forms;

namespace Lesson6_1
{
    public partial class Площадь_круга : Form
    {
        public Площадь_круга()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxTask1.Text, out double radius))
            {
                if (radius >= 0 )
                {
                    labelRezult1.Visible = true;
                    textBoxRezult1.Visible = true;
                    labelRezult1.Text = "Площадь круга равна: ";
                    textBoxRezult1.Text = Convert.ToString(string.Format("{0:.00}", Math.PI * Math.Pow(radius, 2)));
                }
                else
                {
                    labelRezult1.Visible = true;
                    textBoxRezult1.Visible = false;
                    labelRezult1.Text = "Радиус круга должен быть положительным числом";
                }

            }
            else
            {
                labelRezult1.Visible = true;
                textBoxRezult1.Visible = false;
                labelRezult1.Text = "введено не число";
            }
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            textBoxTask1.Clear();
            textBoxRezult1.Clear();
            labelRezult1.Visible = false;
            textBoxRezult1.Visible = false;
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxTask2.Text, out double diametr))
            {
                if (diametr >= 0)
                {
                    labelRezult2.Visible = true;
                    textBoxRezult2.Visible = true;
                    labelRezult2.Text = "Площадь круга равна: ";
                    textBoxRezult2.Text = Convert.ToString(string.Format("{0:.00}", Math.Pow(diametr, 2) / 4 * Math.PI));
                }
                else
                {
                    labelRezult2.Visible = true;
                    textBoxRezult2.Visible = false;
                    labelRezult2.Text = "Диаметр круга должен быть положительным числом";
                }

            }
            else
            {
                labelRezult2.Visible = true;
                textBoxRezult2.Visible = false;
                labelRezult2.Text = "Введено не число";
            }
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            textBoxTask2.Clear();
            textBoxRezult2.Clear();
            labelRezult2.Visible = false;
            textBoxRezult2.Visible = false;
        }

        private void Площадь_круга_Load(object sender, EventArgs e)
        {
            labelRezult2.Visible = false;
            textBoxRezult2.Visible = false;

            labelRezult1.Visible = false;
            textBoxRezult1.Visible = false;

            labelRezult3.Visible = false;
            textBoxRezult3.Visible = false;

        }

        private void btnReset3_Click(object sender, EventArgs e)
        {
            textBoxTask3.Clear();
            textBoxRezult3.Clear();
            labelRezult3.Visible = false;
            textBoxRezult3.Visible = false;
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxTask3.Text, out double lengthRound))
            {
                if (lengthRound >= 0)
                {
                    labelRezult3.Visible = true;
                    textBoxRezult3.Visible = true;
                    labelRezult3.Text = "Площадь круга равна: ";
                    textBoxRezult3.Text = Convert.ToString(string.Format("{0:.00}", Math.Pow(lengthRound, 2) / (4 * Math.PI)));
                }
                else
                {
                    labelRezult3.Visible = true;
                    textBoxRezult3.Visible = false;
                    labelRezult3.Text = "Диаметр круга должен быть положительным числом";
                }

            }
            else
            {
                labelRezult3.Visible = true;
                textBoxRezult3.Visible = false;
                labelRezult3.Text = "Введено не число";
            }
        }
    }
}
