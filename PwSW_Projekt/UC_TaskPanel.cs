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
        Task task;
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

            this.task = task;

            TimeSpan interval = this.task.Date - DateTime.Now;
            days = interval.Days;
            hours = interval.Hours;
            minutes = interval.Minutes;
            seconds = interval.Seconds;

            nameLabel.Text = task.Name;
            daysLabel.Text = days < 10 ? "0" + days.ToString() : days.ToString();
            hoursLabel.Text = hours < 10 ? "0" + hours.ToString() : hours.ToString();
            minutesLabel.Text = minutes < 10 ? "0" + minutes.ToString() : minutes.ToString();
            secondsLabel.Text = seconds < 10 ? "0" + seconds.ToString() : seconds.ToString();

            importantLabel.Visible = task.IsImportant;
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            complete();
        }

        private void completeIcon_Click(object sender, EventArgs e)
        {
            complete();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void editIcon_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            remove();
        }

        private void removeIcon_Click(object sender, EventArgs e)
        {
            remove();
        }

        private void complete()
        {
            task.EndDate = DateTime.Now;
            JsonData.completeTasks.Add(task);
            JsonData.currentTasks.Remove(task);

            Form_View.clearContent();
            Form_View.createListOfTasks();
        }

        private void edit()
        {
            Form_Edit formEdit = new Form_Edit();
            UC_AddTask editTask = new UC_AddTask(task);
            editTask.Width = formEdit.Width;
            editTask.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            formEdit.Controls.Add(editTask);
            formEdit.Show();
        }

        private void remove()
        {
            task.EndDate = DateTime.Now;

            Form_Edit formEdit = new Form_Edit();
            UC_AddComment addComment = new UC_AddComment(task);
            addComment.Width = formEdit.Width;
            addComment.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            formEdit.Controls.Add(addComment);
            formEdit.Show();          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan interval = task.Date - DateTime.Now;
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
