using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
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
            new LogVariables(8, "slkjdlf"),
            new LogVariables(10, "slkjdlf"),
            new LogVariables(12, "slkjdlf"),
            new LogVariables(14, "slkjdlf"),
            new LogVariables(16, "slkjdlf"),
            new LogVariables(18, "slkjdlf"),
            new LogVariables(20, "slkjdlf"),
            new LogVariables(22, "slkjdlf"),
            new LogVariables(0, "slkjdlf"),
            new LogVariables(2, "slkjdlf")
        };
        public MainWindow()
        {
            InitializeComponent();
            // Привязка данных
            varibls.DataContext = dayList;

            foreach (var day in dayList)
            {

            }
        }
    }
}
