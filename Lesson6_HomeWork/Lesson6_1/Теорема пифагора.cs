using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lesson6_1
{
    public partial class Теорема_пифагора : Form
    {
        public Теорема_пифагора()
        {
            InitializeComponent();
            toolTip1.SetToolTip(txtBoxKatetA, "Дробные числа вводить через запятую");
            toolTip2.SetToolTip(txtBoxKatetB, "Дробные числа вводить через запятую");
            toolTip3.SetToolTip(txtBoxGepotenuza, "Дробные числа вводить через запятую");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // стороны треугольника должны быть больше 0
            // 
            double katetA = 0, katetB = 0, gipotenuzaC = 0;
            Regex regex = new Regex("^[+]?([0-9]*[,])?[0-9]+$");  // шаблон определяющий поле содержащее только цифры 

            if (regex.IsMatch(txtBoxKatetA.Text))
            {
                if (regex.IsMatch(txtBoxKatetB.Text) && !regex.IsMatch(txtBoxGepotenuza.Text))
                {
                    katetA = Double.Parse(txtBoxKatetA.Text);
                    katetB = Double.Parse(txtBoxKatetB.Text);
                    txtBoxGepotenuza.Text = Convert.ToString(string.Format("{0:.00}", (Math.Sqrt(Math.Pow(katetA, 2) + Math.Sqrt(Math.Pow(katetB, 2))))));
                }
                else if (!regex.IsMatch(txtBoxKatetB.Text) && regex.IsMatch(txtBoxGepotenuza.Text))
                {
                    katetA = Double.Parse(txtBoxKatetA.Text);
                    gipotenuzaC = Double.Parse(txtBoxGepotenuza.Text);
                    if (gipotenuzaC > katetA)
                    {
                        txtBoxKatetB.Text = Convert.ToString(string.Format("{0:.00}", (Math.Sqrt(Math.Pow(gipotenuzaC, 2) - Math.Sqrt(Math.Pow(katetA, 2))))));
                    }
                    else
                        MessageBox.Show("Гипотенуза должна быть длиннее катета");


                }
                else if (regex.IsMatch(txtBoxKatetB.Text) && regex.IsMatch(txtBoxGepotenuza.Text))
                {
                    katetA = Double.Parse(txtBoxKatetA.Text);
                    katetB = Double.Parse(txtBoxKatetB.Text);
                    gipotenuzaC = Double.Parse(txtBoxGepotenuza.Text);

                    if ((Math.Pow(katetA, 2) + Math.Pow(katetB, 2)) == Math.Pow(gipotenuzaC, 2))
                        MessageBox.Show("Треугольник с такими сторонами является прямоугольным");
                    else if (katetA + katetB > gipotenuzaC || katetB + gipotenuzaC > katetA || katetA + gipotenuzaC > katetB)
                        MessageBox.Show("Треугольник с такими сторонами НЕ является прямоугольным");
                    else
                        MessageBox.Show("Треугольник с такими сторонами НЕ может существовать");

                }

            }

            if (regex.IsMatch(txtBoxKatetB.Text))
            {
                if (regex.IsMatch(txtBoxGepotenuza.Text))
                {
                    gipotenuzaC = Double.Parse(txtBoxGepotenuza.Text);
                    katetB = Double.Parse(txtBoxKatetB.Text);
                    if (gipotenuzaC > katetB)
                    {
                        txtBoxKatetA.Text = Convert.ToString(string.Format("{0:.00}", (Math.Sqrt(Math.Pow(gipotenuzaC, 2) - Math.Sqrt(Math.Pow(katetB, 2))))));

                    }
                    else
                        MessageBox.Show("Гипотенуза должна быть длиннее катета");
                }
                else
                    MessageBox.Show("Введено мало значений для определения третей стороны прямоугольного треугольника. Или введены не числа больше Нуля.");
            }
            else
                MessageBox.Show("Введено мало значений для определения третей стороны прямоугольного треугольника. Или введены не числа больше Нуля.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxKatetA.Clear();
            txtBoxKatetB.Clear();
            txtBoxGepotenuza.Clear();
        }
    }
}
