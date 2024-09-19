using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using WPF_JurnalBoilerRoom.Model;

namespace WPF_JurnalBoilerRoom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<LogVariables> dayList = new BindingList<LogVariables>()
        {
            new LogVariables("8:00", "slkjdlf"),
            new LogVariables("10:00", "slkjdlf"),
            new LogVariables("12:00", "slkjdlf"),
            new LogVariables("14:00", "slkjdlf"),
            new LogVariables("16:00", "slkjdlf"),
            new LogVariables("18:00", "slkjdlf"),
            new LogVariables("20:00", "slkjdlf"),
            new LogVariables("22:00", "slkjdlf"),
            new LogVariables("00:00", "slkjdlf"),
            new LogVariables("02:00", "slkjdlf"),
            new LogVariables("04:00", "slkjdlf"),
            new LogVariables("06:00", "slkjdlf")
        };
        public MainWindow()
        {
            InitializeComponent();
            // Привязка данных
            //varibls.DataContext = dayList;
            foreach(var item in dayList)
            {
                varibls.Items.Add(item);

            }

        }
    }
}
