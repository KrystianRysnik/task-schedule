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
    public partial class UC_AddComment : UserControl
    {
        Task task;

        public UC_AddComment()
        {
            InitializeComponent();
        }

        public UC_AddComment(Task task)
        {
            InitializeComponent();

            this.task = task;
        }

        private void removeTaskSubmitBtn_Click(object sender, EventArgs e)
        {
            string comment = commentRichTextBox.Text;

            task.Comment = comment;

            JsonData.abandonedTasks.Add(task);
            JsonData.currentTasks.Remove(task);

            Parent.Hide();
            Form_View.clearContent();
            Form_View.createListOfTasks();
        }
    }
}
