using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF_Lesson5_1ПланировщикМероприятий.Model
{
    public class MyEvent : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsCompleted { get; set; }
        public MyEvent (string titel, string description, DateTime date, bool iscompleted)
        {
            Title = titel;
            Description = description;
            Date = date;
            IsCompleted = iscompleted;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
