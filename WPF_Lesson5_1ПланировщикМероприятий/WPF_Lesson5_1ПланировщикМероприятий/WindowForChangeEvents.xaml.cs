using System;
using System.Windows;
using WPF_Lesson5_1ПланировщикМероприятий.ViewModel;
using System.Collections.Generic;
using System.Windows.Controls;
using WPF_Lesson5_1ПланировщикМероприятий.Model;


namespace WPF_Lesson5_1ПланировщикМероприятий
{
    /// <summary>
    /// Логика взаимодействия для WindowForChangeEvents.xaml
    /// </summary>
    public partial class WindowForChangeEvents : Window
    {
        MyViewModel first = new MyViewModel();
        public WindowForChangeEvents(MyViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;

            comboBoxTitle.ItemsSource = new List<string>()
            { "День рождения", "Праздник", "Конференция", "Семинар", "Прочее"};
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DG_Events_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MyEvent selectIndex = (MyEvent)DG_Events.SelectedItem;
            MyViewModel tmpObj = new MyViewModel();
            if (selectIndex != null)
            {
                comboBoxTitle.Text = selectIndex.Titel;
                //txtBoxDescription.Text = selectIndex.Description;
                datePickerEvent.SelectedDate = selectIndex.Date;
                //checkBoxIsDone.IsChecked = selectIndex.IsCompleted;
            }
        }

        private void EditEvents_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
