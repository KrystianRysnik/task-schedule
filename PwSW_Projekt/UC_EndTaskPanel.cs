using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwSW_Projekt
{
    public partial class UC_EndTaskPanel : UserControl
    {
        Task task;
        string date;

        public UC_EndTaskPanel()
        {
            InitializeComponent();
        }

        public UC_EndTaskPanel(Task task)
        {
            InitializeComponent();

            this.task = task;

            date = task.EndDate.ToLongDateString() + ", " + task.EndDate.ToShortTimeString();

            nameLabel.Text = task.Name;
            dateLabel.Text = date;
            dateLabel.Location = new Point(dateLabel.Parent.Width - dateLabel.Width - 15, 15);

            toolTip.SetToolTip(nameLabel, task.Comment);
        }
    }
}
