using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace WPF_Lesson4_1.Model
{
    public class ContactManager
    {
        // Путь к файлу
        private string filePath = "contacts.txt";
        // Список элементов
        private ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();

        // public ObservableCollection<Book> Books { get { return contacts; } }
        public ObservableCollection<Contact> Contacts => contacts;
        // Метод для добавления элемента
        public bool AddContact(Contact contact)
        {
            if (FieldsAreValid(contact))
            {
                contacts.Add(contact);
                return true;
            }
            return false;
        }

        // Метод для проверки полей 
        public bool FieldsAreValid(Contact contact)
        {
            // Проверка на пустое поле имени
            if (string.IsNullOrEmpty(contact.Name))
            {
                MessageBox.Show("Имя не должно быть пустым", "Заполнены не все поля");
                return false;
            }
            // Проверка на пустое поле телефона
            if (string.IsNullOrEmpty(contact.PhoneNumber))
            {
                MessageBox.Show("Номер телефона не должен быть пустым", "Заполнены не все поля");
                return false;
            }
            // Проверка на пустое поле почтового ящика
            if (string.IsNullOrEmpty(contact.Email))
            {
                MessageBox.Show("Почта не должно быть пустым", "Заполнены не все поля");
                return false;
            }
            // проверка номера телефона на формат +7 999 999-99-99
            if(!System.Text.RegularExpressions.Regex.IsMatch(contact.PhoneNumber, @"^\+7 \d{3} \d{3}-\d{2}-\d{2}$"))
            {
                MessageBox.Show("Номер телефона должен быть в формате +7 999 999-99-99", "Некоректные данные");
                return false;   
            }
            // проверка почты на формат mail@mail.ru
            if (!System.Text.RegularExpressions.Regex.IsMatch(contact.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email должен быть в формате mail@mail.ru", "Некоректные данные");
                return false;
            }
            return true;
        }
        //// Метод для удаления элемента
        //public void RemoveContact(Contact contact)
        //{
        //    contacts.Remove(contact);
        //}
        // Метод для удаления элемента по индексу
        public bool RemoveByIndex(int index)
        {
            if (index >=0 && index < contacts.Count)
            {
                contacts.RemoveAt(index);
                return true;
            }
            MessageBox.Show("Индекс вне границы диапазона");
            return false;
        }

        // Метод для изменения элемента
        public bool EditContact(int index, Contact contact)
        {
            if (FieldsAreValid(contact))
            {
                contacts[index] = contact;
                return true;
            }
            return false;
        }
        // Метод для сохранения данных в файл
        public void SaveContacts()
        {
            // 1. Создать объект StreamWriter
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // 2. Запись данных в файл
                foreach (Contact contact in contacts)
                {
                    writer.WriteLine($"{contact.Name}|{contact.Email}|{contact.PhoneNumber}");
                }
            }
        }
        // Метод для загрузки данных из файла
        public void LoadContacts()
        {
            if (File.Exists(filePath))
            {
                // Создать объект StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        contacts.Add(new Contact(parts[0], parts[1], parts[2]));
                    }
                }
            }
        }

        
    }
}
