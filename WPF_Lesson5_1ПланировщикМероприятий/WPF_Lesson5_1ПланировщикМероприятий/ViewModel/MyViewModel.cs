using System;
using System.Collections.ObjectModel;
using WPF_Lesson5_1ПланировщикМероприятий.Model;

namespace WPF_Lesson5_1ПланировщикМероприятий.ViewModel
{
    public class MyViewModel
    {
        // Поле для работы с менеджером мероприятий
        private MyEventManager myeventManager = new MyEventManager();

        // Конструктор класса
        public MyViewModel()
        {
            myeventManager.LoadMyEvents();
        }
        // СВОЙСТВО, предоставляющее доступ к нашей коллекции мероприятий
        public ObservableCollection<MyEvent> myEvents { get { return myeventManager.Events; } }



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
                        WindowForViewEvents window = new WindowForViewEvents(this);
                        window.ShowDialog();
                    })
                );
            }
        }

        // СВОЙСТВА для хранения данных, введенных пользователем в текстовые поля 
        public string TextBoxTitle { get; set; }
        public string TextBoxDescription { get; set; } 
        public DateTime TextBoxData { get; set; } = DateTime.Now;
        public bool IsComplete { get; set; }
        // поле для хранения комманды добавления нового мероприятия

        private RelayCommand addEventCommand;
        // СВОЙСТВО, предоставляющее доступ к команде добавления мероприятия
        public RelayCommand AddEventCommand
        {
            get
            {
                return addEventCommand ?? (
                    new RelayCommand(obj =>
                    {
                        myeventManager.AddEvent(new MyEvent(TextBoxTitle, TextBoxDescription, TextBoxData, IsComplete));
                    }
                    )
                );
            }
        }



        public void SaveMyEvents()
        {
            myeventManager.SaveMyEvent();
        }
        // поле для хранения комманды сохранения мероприятия

        private RelayCommand saveEventCommand;
        // СВОЙСТВО, предоставляющее доступ к команде сохнанения мероприятия
        public RelayCommand SaveEventCommand
        {
            get
            {
                return addEventCommand ?? (
                    new RelayCommand(obj =>
                    {
                        myeventManager.SaveMyEvent();
                    }
                    )
                );
            }
        }




        // Свойство для хранения выбранного индекса
        public int SelectedIndex { get; set; }

        // поле для хранения комманды удаления контакта

        private RelayCommand removeEventCommand;
        public RelayCommand RemoveEventCommand
        {
            get
            {
                    return removeEventCommand ?? (new RelayCommand(obj =>
                    {
                        myeventManager.RemoveByIndex(SelectedIndex);
                    }
                    ));
            }
        }



        // поле для хранения  команды редактирования мероприятия
        private RelayCommand editEventCommand;
        // свойство которое предоставляет доступ к команде редактирования мероприятия
        public RelayCommand EditEventCommand
        {
            get
            {
                return editEventCommand ?? (
                    new RelayCommand(obj =>
                    {
                        //MyEvent editMyEvent = myeventManager.Events[SelectedIndex];
                        //SetTextBox(editMyEvent.Titel, editMyEvent.Description, editMyEvent.Date, editMyEvent.IsCompleted);
                        MyEvent editMyEvent = new MyEvent(TextBoxTitle, TextBoxDescription, TextBoxData, IsComplete);
                        myeventManager.EditEvent(SelectedIndex, editMyEvent);

                    }));
            }
        }
    }

}
