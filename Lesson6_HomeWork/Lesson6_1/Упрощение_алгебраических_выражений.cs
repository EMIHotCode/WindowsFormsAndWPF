using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson6_1
{
    public partial class Упрощение_алгебраических_выражений : Form
    {
        public Упрощение_алгебраических_выражений()
        {
            InitializeComponent();
        }

        private void btnResult1_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();
            if (double.TryParse(textBoxA1.Text, out double A))
            {
            }
            else
                errors.Add($"поле A - введена не цифра {Environment.NewLine}");

            if (double.TryParse(textBoxB1.Text, out double B))
            {
            }
            else
                errors.Add($"поле B - введена не цифра {Environment.NewLine}");

            if (errors.Count != 0)
            {
                string itog = "";
                foreach (var item in errors)
                    itog += item;

                MessageBox.Show(itog);
                errors.Clear();
                return;
            }

            double result = A * A - B * B;
                textBoxResult1.Text = result.ToString();

        }

        private void btn2Result_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();
            if (double.TryParse(textBoxA2.Text, out double A))
            {
            }
            else
                errors.Add($"поле A - введена не цифра {Environment.NewLine}");

            if (double.TryParse(textBox2B.Text, out double B))
            {
            }
            else
                errors.Add($"поле B - введена не цифра {Environment.NewLine}");

            if (errors.Count != 0)
            {
                string itog = "";
                foreach (var item in errors)
                    itog += item;

                MessageBox.Show(itog);
                errors.Clear();
                return;
            }

            double result = A * A + 2*A*B + B * B;
            textBoxResult2.Text = result.ToString();
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            textBoxA1.Clear();
            textBoxB1.Clear();
            textBoxResult1.Clear();
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            textBoxA2.Clear();
            textBox2B.Clear();
            textBoxResult2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
