using System;

namespace WPF_Lesson5_1ПланировщикМероприятий.Model
{
    public class MyEvent
    {
        public string Titel { get; set; }
        public string Description { get; set; }
        private DateTime date { get; set; }
        public bool IsCompleted { get; set; }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public MyEvent (string titel, string description, DateTime date, bool iscompleted)
        {
            Titel = titel;
            Description = description;
            Date = date;
            IsCompleted = iscompleted;
        }
    }
}
