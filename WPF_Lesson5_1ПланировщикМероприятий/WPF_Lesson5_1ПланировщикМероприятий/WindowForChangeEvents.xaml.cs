using System.Windows;
using WPF_Lesson5_1ПланировщикМероприятий.ViewModel;


namespace WPF_Lesson5_1ПланировщикМероприятий
{
    /// <summary>
    /// Логика взаимодействия для WindowForChangeEvents.xaml
    /// </summary>
    public partial class WindowForChangeEvents : Window
    {
        public WindowForChangeEvents(MyViewModel vm)
        {
            InitializeComponent();
            comboBoxTitle.Items
                DataContext = vm;
        }
    }
}
