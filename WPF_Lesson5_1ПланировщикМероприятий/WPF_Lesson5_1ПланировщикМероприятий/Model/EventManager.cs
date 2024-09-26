using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            if (string.IsNullOrEmpty(_event.Title))
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
        // Метод для удаления элемента по индексу
        public bool RemoveByIndex(int index)
        {
            if (index >= 0 && index < events.Count)
            {
                events.RemoveAt(index);
                return true;
            }
            MessageBox.Show("Индекс вне границы диапазона");
            return false;
        }

        // Метод для удаления элемента если IsComplete = true
        public void RemoveByIsComplete()
        {
            for ( int i=0; i < events.Count; i++)
            {
                if (events[i].IsCompleted == true)
                {
                    events.Remove(events[i]);
                    i--;
                }
            }
        }

        // Метод для изменения элемента
        public bool EditEvent(int index, MyEvent _event)
            {
                if (FieldsAreValid(_event))
                {
                    events[index] = _event;
                    return true;
                }
                return false;
            }
        // метод для сохранения списка в файл
        public void SaveMyEvent()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (MyEvent _event in events)
                {
                    writer.WriteLine($"{_event.Title}|{_event.Description}|{_event.Date}|{_event.IsCompleted}");
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

        //метод для сортировки списка по дате по возрастанию 
        public void SortByDateMyEventsUp()
        {
            events = new ObservableCollection<MyEvent>(events.OrderBy(e => e.Date));
        }
        //метод для сортировки списка по дате по убыванию
        public void SortByDateMyEventsDown()
        {
            events = new ObservableCollection<MyEvent>(events.OrderByDescending(e => e.Date));
        }

        //метод для сортировки списка по выполнеными 
        public void SortByIsDoneEvents()
        {

        }

    }
}
