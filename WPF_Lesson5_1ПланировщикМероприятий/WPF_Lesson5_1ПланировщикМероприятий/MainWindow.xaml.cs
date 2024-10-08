﻿using System;
using System.Windows;
using WPF_Lesson5_1ПланировщикМероприятий.ViewModel;

namespace WPF_Lesson5_1ПланировщикМероприятий
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyViewModel vm = new MyViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowForViewEvents win = new WindowForViewEvents(vm);
            win.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            vm.SaveMyEvents();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            WindowForChangeEvents win = new WindowForChangeEvents(vm);
            win.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
