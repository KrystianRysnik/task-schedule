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
    public partial class UC_TaskPanel : UserControl
    {
        DateTime date;
        int days;
        int hours;
        int minutes;
        int seconds;

        public UC_TaskPanel()
        {
            InitializeComponent();
        }

        public UC_TaskPanel(Task task)
        {
            InitializeComponent();

            date = task.Date;

            TimeSpan interval = date - DateTime.Now;
            days = interval.Days;
            hours = interval.Hours;
            minutes = interval.Minutes;
            seconds = interval.Seconds;

            nameLabel.Text = task.Name;
            daysLabel.Text = days < 10 ? "0" + days.ToString() : days.ToString();
            hoursLabel.Text = hours < 10 ? "0" + hours.ToString() : hours.ToString();
            minutesLabel.Text = minutes < 10 ? "0" + minutes.ToString() : minutes.ToString();
            secondsLabel.Text = seconds < 10 ? "0" + seconds.ToString() : seconds.ToString();
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan interval = date - DateTime.Now;
            days = interval.Days;
            hours = interval.Hours;
            minutes = interval.Minutes;
            seconds = interval.Seconds;

            daysLabel.Text = days < 10 ? "0" + days.ToString() : days.ToString();
            hoursLabel.Text = hours < 10 ? "0" + hours.ToString() : hours.ToString();
            minutesLabel.Text = minutes < 10 ? "0" + minutes.ToString() : minutes.ToString();
            secondsLabel.Text = seconds < 10 ? "0" + seconds.ToString() : seconds.ToString();
        }
    }
}
