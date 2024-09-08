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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlgebra.SelectedIndex == 0)
            {
                Решение_квадратного_уравнения_Form form = new Решение_квадратного_уравнения_Form();
                form.ShowDialog();
            }
            else if (listBoxAlgebra.SelectedIndex == 1)
            {
                Упрощение_алгебраических_выражений form = new Упрощение_алгебраических_выражений();
                form.ShowDialog();
            }
        }

        private void listBoxGeometria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGeometria.SelectedIndex == 0)
            {
                Теорема_пифагора form = new Теорема_пифагора();
                form.ShowDialog();
            }
            else if (listBoxGeometria.SelectedIndex == 1)
            {
                площадь_треугольника_по_формуле_Герона form = new площадь_треугольника_по_формуле_Герона();
                form.ShowDialog();
            }
            else if (listBoxGeometria.SelectedIndex == 2)
            {
                Площадь_круга form = new Площадь_круга();
                form.ShowDialog();
            }

        }
    }
}
