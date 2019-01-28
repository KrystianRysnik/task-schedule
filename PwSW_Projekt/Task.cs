using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwSW_Projekt
{
    public class Task : TaskCategory
    {
        string id;
        string name;
        DateTime date;
        DateTime endDate;
        bool isImportant;
        string comment;

        public Task(string name, Category category, DateTime date, bool isImportant)
        {
            Id = Guid.NewGuid().ToString();
            Category = category;
            Name = name;
            Date = date;
            IsImportant = isImportant;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public bool IsImportant { get => isImportant; set => isImportant = value; }
        public string Comment { get => comment; set => comment = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }       
    }
}
