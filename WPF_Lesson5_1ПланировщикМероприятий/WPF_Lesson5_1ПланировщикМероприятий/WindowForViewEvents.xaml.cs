using System;
using System.Windows;
using System.Windows.Controls;
using WPF_Lesson5_1ПланировщикМероприятий.ViewModel;


namespace WPF_Lesson5_1ПланировщикМероприятий
{
    /// <summary>
    /// Логика взаимодействия для WindowForViewEvents.xaml
    /// </summary>
    public partial class WindowForViewEvents : Window
    {
        public WindowForViewEvents(MyViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
