using System;
using System.Collections.ObjectModel;
using WPF_Lesson4_1.Model;
using System.Windows;
using System.Runtime.Remoting;


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
            SetTextBox("default", "default@email.ru", "+7 999 999-00-00");
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

        // Свойство для хранения выбранного индекса
        public int SelectedIndex { get; set; }

        // поле для хранения комманды удаления контакта

        private RelayCommand removeContactCommand;
        public RelayCommand RemoveContactCommand
        {
            get
            {
                return removeContactCommand ?? (new RelayCommand(obj =>
                {
                   contactManager.RemoveByIndex(SelectedIndex);
                }
                ));
            }
        }

        // метод для установки значений в TextBox 
        public void SetTextBox(string name, string email, string phonNum)
        {
            TextBoxName = name;
            TextBoxEmail = email;
            TextBoxPhoneNumber = phonNum;
        }

        // метод для открытия окна редактирования контактов
        private void ShowEditContactWindow()
        {
            EditWindow editWindow = new EditWindow(this);
            if (SelectedIndex > -1)
            {
                editWindow.Owner = Application.Current.MainWindow;

                Contact contactChange = contactManager.Contacts[SelectedIndex];
                SetTextBox(contactChange.Name, contactChange.Email, contactChange.PhoneNumber);
                editWindow.ShowDialog();
            }

        }

        // поле для хранения команды окна для редактирования
        private RelayCommand openEditContactCommand;
        public RelayCommand OpenEditContactCommand
        {
            get
            {
                return openEditContactCommand ?? (
                    new RelayCommand(obj =>
                    {
                        ShowEditContactWindow();
                    }
                    )
                );
            }
        }

        // поле для хранения  команды редактирования команды
        private RelayCommand editContactCommand;
        // свойство которое предоставляет доступ к команде редактирования контакта
        public RelayCommand EditContactCommand
        {
            get
            {
                return editContactCommand ?? (
                    new RelayCommand(obj =>
                    {
                        Window window = obj as Window;
                        Contact editContact = new Contact(TextBoxName, TextBoxEmail, TextBoxPhoneNumber);
                        if (contactManager.EditContact(SelectedIndex, editContact))
                        {
                            window.Close(); 
                        }
                    }));
            }
        }

    }
}
