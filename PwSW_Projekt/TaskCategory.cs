using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwSW_Projekt
{
    public enum Category
    {
        Current,
        Complete,
        Abandoned
    }

    public class TaskCategory
    {
        Category category;

        public Category Category { get => category; set => category = value; }
    }
}
