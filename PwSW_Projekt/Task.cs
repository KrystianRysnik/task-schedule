using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwSW_Projekt
{
    public class Task
    {
        string id;
        string name;
        DateTime date;
        bool isImportant;
        string description;

        int days;
        int hours;
        int minutes;
        int seconds;

        public Task(string name, DateTime date, bool isImportant, string description)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Date = date;
            IsImportant = isImportant;
            Description = description;

            TimeSpan interval = date - DateTime.Now;
            Days = interval.Days;
            Hours = interval.Hours;
            Minutes = interval.Minutes;
            Seconds = interval.Seconds;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public bool IsImportant { get => isImportant; set => isImportant = value; }
        public string Description { get => description; set => description = value; }
        public int Days { get => days; set => days = value; }
        public int Hours { get => hours; set => hours = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public int Seconds { get => seconds; set => seconds = value; }
    }
}
