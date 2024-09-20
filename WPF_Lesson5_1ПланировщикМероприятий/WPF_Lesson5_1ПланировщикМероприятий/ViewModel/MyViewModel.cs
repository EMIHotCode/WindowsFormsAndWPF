using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Lesson5_1ПланировщикМероприятий.Model;
using System.Windows;

namespace WPF_Lesson5_1ПланировщикМероприятий.ViewModel
{
    public class MyViewModel
    {
        // Поле для работы с менеджером контактов
        private MyEventManager myeventManager = new MyEventManager();
        // Конструктор класса
        public MyViewModel()
        {
            myeventManager.LoadMyEvents();
        }
        // СВОЙСТВО, предоставляющее доступ к нашей коллекции мероприятий
        public ObservableCollection<MyEvent> myEvents { get { return myeventManager.Events; } }

        //// Метод для открытия окна добавления мероприятий
        //private void ShowAddContactWindow()
        //{
        //    WindowForViewEvents viewWindow = new WindowForViewEvents(this);
        //    viewWindow.Owner = Application.Current.MainWindow;
        //    SetTextBox("default", "default@email.ru", "+7 999 999-00-00");
        //    viewWindow.ShowDialog();
        //}
        // Поле для хранения комманды открытия окна просмотра мероприятия
        private RelayCommand openShowEventsList;
        // Свойство для button, предоставляющее доступ к команде открытия окна просмотра мероприятий
        public RelayCommand OpenShowEventsList
        {
            get
            {
                return openShowEventsList ?? (
                    new RelayCommand(obj =>
                    {
                        myeventManager.AddEvent(new );
                    })
                );
            }
        }
        // СВОЙСТВА для хранения данных, введенных пользователем в текстовые поля 
        public string TextBoxTitle { get; set; }
        public string TextBoxDescription { get; set; }
        public DateTime TextBoxData { get; set; }
        public bool IsComplete { get; set; }
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
