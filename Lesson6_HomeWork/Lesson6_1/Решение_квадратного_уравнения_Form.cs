using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson6_1
{
    public partial class Решение_квадратного_уравнения_Form : Form
    {
        public Решение_квадратного_уравнения_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();
            if (double.TryParse(txtBoxA.Text, out double A))
            {
            }
            else
                errors.Add($"поле A - введена не цифра {Environment.NewLine}");

            if (double.TryParse(txtBoxB.Text, out double B))
            {
            }
            else
                errors.Add($"поле B - введена не цифра {Environment.NewLine}");

            if (double.TryParse(txtBoxC.Text, out double C))
            {
            }
            else
                errors.Add($"поле C - введена не цифра {Environment.NewLine}");

            if (errors.Count != 0)
            {
                string itog ="";
                foreach (var item in errors)
                    itog += item;
                MessageBox.Show(itog);
                return;
            }


            double X1, X2;
            double deskrimenant = (B * B) - (4 * A * C);

            if (deskrimenant < 0)
            {
                MessageBox.Show("Действительных корней нет");
            }
            else if (deskrimenant > 0)
            {
                X1 = ((-B + Math.Sqrt(deskrimenant)) / (2 * A));
                X2 = ((-B - Math.Sqrt(deskrimenant)) / (2 * A));
                txtBoxX1.Text = X1.ToString();
                txtBoxX2.Text = X2.ToString();
            }
            else if (deskrimenant == 0)
            {
                X1 = (-B) / (2 * A);
                txtBoxX1.Text = X1.ToString();

                txtBoxX2.Visible = false;
                labelX2.Visible = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxA.Clear();
            txtBoxB.Clear();
            txtBoxC.Clear();
            txtBoxX1.Clear();
            txtBoxX2.Clear();
        }
    }
}
