using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace WPF_Lesson5_1ПланировщикМероприятий.Model
{
    public class MyEventManager
    {
        private string filePath = "event.txt";
        private ObservableCollection<MyEvent> events = new ObservableCollection<MyEvent>();
        public ObservableCollection<MyEvent> Events => events;
        // Метод для добавления мероприятия
        public bool AddEvent(MyEvent _event)
        {
            if (FieldsAreValid(_event))
            {
                events.Add(_event);
                return true;
            }
            return false;
        }
        // Метод для проверки полей 
        public bool FieldsAreValid(MyEvent _event)
        {
            // Проверка на пустое поле имени
            if (string.IsNullOrEmpty(_event.Titel))
            {
                MessageBox.Show("Поле название мероприятия не должно быть пустым", "Заполнены не все поля");
                return false;
            }
            // Проверка на пустое поле телефона
            if (string.IsNullOrEmpty(_event.Description))
            {
                MessageBox.Show("Поле описание мероприятия не должен быть пустым", "Заполнены не все поля");
                return false;
            }
            return true;
        }
        // метод для удаления элемента
        public void RemoveElement(MyEvent _event)
        {
            events.Remove(_event);
        }
        // метод для сохранения списка в файл
        public void SaveMyEvent()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (MyEvent _event in events)
                {
                    writer.WriteLine($"{_event.Titel}|{_event.Description}|{_event.Date}|{_event.IsCompleted}");
                }
            }
        }
        //метод для считывания информации из файла
        public void LoadMyEvents()
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
                        events.Add(new MyEvent(parts[0], parts[1], DateTime.Parse(parts[2]), bool.Parse(parts[3])));
                    }
                }
            }
        }
    }
}
