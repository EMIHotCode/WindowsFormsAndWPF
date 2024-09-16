using System;
using System.Windows;
using System.Windows.Threading;
using WPF_Lesson4_1.ViewModel;

namespace WPF_Lesson4_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ContactViewModel contactViewModel = new ContactViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = contactViewModel;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contactViewModel.SaveContacts();
        }
    }
}
