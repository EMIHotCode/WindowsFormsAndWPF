using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonsC_WFandWPF
{
    public partial class Form1 : Form
    {
        int choise = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (choise)
            {
                case 1:
                    DateTime nowD = DateTime.Now;
                    label1.Text = $"Сегодня дата: {nowD}";
                    break;

                case 2:
                    int daysInNowMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                    int nowDayData = DateTime.Now.Day;
                    label1.Text = $"До конца месяца осталось {daysInNowMonth - nowDayData} дней.";
                    break;


                case 3:
                    int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                    label1.Text = $"В этом месяце {daysInMonth} дней.";
                    break;

                default:
                    label1.Text = $"Введено неверное значение.";
                    break;
            }
            choise += 1;
            if (choise > 3)
                choise = 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            //MessageBox.Show($"Вы хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo);
            DialogResult answer = MessageBox.Show($"Вы хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo);
            if (answer == DialogResult.No)
            {
                // Отменяем закрытие
                e.Cancel = true;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
