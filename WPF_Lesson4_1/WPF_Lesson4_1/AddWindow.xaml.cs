using System.Windows;
using WPF_Lesson4_1.ViewModel;


namespace WPF_Lesson4_1
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow(ContactViewModel contactViewModel)
        {
            InitializeComponent();
            DataContext = contactViewModel;
        }
    }
}
