using System;
using System.Collections.ObjectModel;
using WPF_Lesson4_1.Model;
using System.Windows;


namespace WPF_Lesson4_1.ViewModel
{
    public class ContactViewModel
    {
        // Поле для работы с менеджером контактов
        private ContactManager contactManager = new ContactManager();
        // Конструктор класса
        public ContactViewModel()
        {
            contactManager.LoadContacts();
        }
        // СВОЙСТВО, предоставляющее доступ к нашей коллекции контактов
        public ObservableCollection<Contact> Contacts { get { return contactManager.Contacts; } }

        // Метод для открытия окна добавления контактов
        private void ShowAddContactWindow()
        {
            AddWindow addWindow = new AddWindow(this);
            addWindow.Owner = Application.Current.MainWindow;
            addWindow.ShowDialog();
        }
        // Поле для хранения комманды открытия окна добавления контактов
        private RelayCommand openAddContactCommand;
        // Свойство для button, предоставляющее доступ к команде открытия окна
        public RelayCommand OpenAddContactCommand
        {
            get
            {
                return openAddContactCommand ?? (
                    new RelayCommand(obj =>
                    {
                        ShowAddContactWindow();
                    })
                );
            }
        }
        // СВОЙСТВА для хранения данных, введенных пользователем в текстовые поля 
        public string TextBoxName {  get; set; }
        public string TextBoxEmail { get; set; } 
        public string TextBoxPhoneNumber { get; set; }
        // поле для хранения комманды добавления нового контакта

        private RelayCommand addContactCommand;
        // СВОЙСТВО, предоставляющее доступ к команде добавления контакта
        public RelayCommand AddContactCommand
        {
            get
            {
                return addContactCommand ?? (
                    new RelayCommand(obj =>
                    {
                        Window window = obj as Window;
                        if (contactManager.AddContact(new Contact(TextBoxName, TextBoxEmail, TextBoxPhoneNumber)))
                        {
                            window.Close();
                        }
                    }
                    )
                );
            }
        }

        public void SaveContacts()
        {
            contactManager.SaveContacts();
        }

    }
}
