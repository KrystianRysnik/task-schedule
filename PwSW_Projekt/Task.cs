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
        DateTime endDate;
        bool isImportant;
        string description;

        public Task(string name, DateTime date, bool isImportant, string description)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Date = date;
            IsImportant = isImportant;
            Description = description;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public bool IsImportant { get => isImportant; set => isImportant = value; }
        public string Description { get => description; set => description = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
    }
}
