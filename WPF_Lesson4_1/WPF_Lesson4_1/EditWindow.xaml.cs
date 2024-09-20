using System.Windows;
using WPF_Lesson4_1.ViewModel;

namespace WPF_Lesson4_1
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow(ContactViewModel contactViewModel)
        {
            InitializeComponent();
            DataContext = contactViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
