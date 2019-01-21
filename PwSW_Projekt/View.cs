using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwSW_Projekt
{
    public partial class View : Form
    {
        List<Task> tasks = new List<Task>();

        public View()
        {
            InitializeComponent();

            tasks.Add(new Task("Nazwa", new DateTime(2019, 2, 2, 14, 0, 0), true, "Opis"));
            tasks.Add(new Task("Nazwa 2", new DateTime(2019, 3, 2, 14, 0, 0), true, "Opis"));

        }

        private void newTaskBtn_Click(object sender, EventArgs e)
        {
            newTaskBtn.Font = new Font(newTaskBtn.Font.Name, newTaskBtn.Font.Size, FontStyle.Bold);
            newTaskBtn.ForeColor = Color.White;

            currentTasksBtn.Font = new Font(currentTasksBtn.Font.Name, currentTasksBtn.Font.Size, FontStyle.Regular);
            currentTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);

            completeTasksBtn.Font = new Font(completeTasksBtn.Font.Name, completeTasksBtn.Font.Size, FontStyle.Regular);
            completeTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);

            abandonedTaskBtn.Font = new Font(abandonedTaskBtn.Font.Name, abandonedTaskBtn.Font.Size, FontStyle.Regular);
            abandonedTaskBtn.ForeColor = Color.FromArgb(117, 117, 117);

            // Active Panel
            newTaskPanel.Visible = true;
            currentTasksPanel.Visible = false;
            //newTaskPanel.BringToFront();
        }

        private void currentTasksBtn_Click(object sender, EventArgs e)
        {
            newTaskBtn.Font = new Font(newTaskBtn.Font.Name, newTaskBtn.Font.Size, FontStyle.Regular);
            newTaskBtn.ForeColor = Color.FromArgb(117, 117, 117);

            currentTasksBtn.Font = new Font(currentTasksBtn.Font.Name, currentTasksBtn.Font.Size, FontStyle.Bold);
            currentTasksBtn.ForeColor = Color.White;

            completeTasksBtn.Font = new Font(completeTasksBtn.Font.Name, completeTasksBtn.Font.Size, FontStyle.Regular);
            completeTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);

            abandonedTaskBtn.Font = new Font(abandonedTaskBtn.Font.Name, abandonedTaskBtn.Font.Size, FontStyle.Regular);
            abandonedTaskBtn.ForeColor = Color.FromArgb(117, 117, 117);

            // Active Panel
            newTaskPanel.Visible = false;
            currentTasksPanel.Visible = true;
            //currentTasksPanel.BringToFront();

            int offsetY = 20;
            foreach (Task task in tasks)
            {
                TaskPanel taskPanel = new TaskPanel(task.Name, task.Days, task.Hours, task.Minutes, task.Seconds);
                taskPanel.Location = new System.Drawing.Point(20, offsetY);
                taskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                currentTasksPanel.Controls.Add(taskPanel);
                offsetY += 60;
            }
        }

        private void completeTasksBtn_Click(object sender, EventArgs e)
        {
            newTaskBtn.Font = new Font(newTaskBtn.Font.Name, newTaskBtn.Font.Size, FontStyle.Regular);
            newTaskBtn.ForeColor = Color.FromArgb(117, 117, 117);

            currentTasksBtn.Font = new Font(currentTasksBtn.Font.Name, currentTasksBtn.Font.Size, FontStyle.Regular);
            currentTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);
            
            completeTasksBtn.Font = new Font(completeTasksBtn.Font.Name, completeTasksBtn.Font.Size, FontStyle.Bold);
            completeTasksBtn.ForeColor = Color.White;

            abandonedTaskBtn.Font = new Font(abandonedTaskBtn.Font.Name, abandonedTaskBtn.Font.Size, FontStyle.Regular);
            abandonedTaskBtn.ForeColor = Color.FromArgb(117, 117, 117);
        }

        private void abandonedTaskBtn_Click(object sender, EventArgs e)
        {
            newTaskBtn.Font = new Font(newTaskBtn.Font.Name, newTaskBtn.Font.Size, FontStyle.Regular);
            newTaskBtn.ForeColor = Color.FromArgb(117, 117, 117);

            currentTasksBtn.Font = new Font(currentTasksBtn.Font.Name, currentTasksBtn.Font.Size, FontStyle.Regular);
            currentTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);

            completeTasksBtn.Font = new Font(completeTasksBtn.Font.Name, completeTasksBtn.Font.Size, FontStyle.Regular);
            completeTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);

            abandonedTaskBtn.Font = new Font(abandonedTaskBtn.Font.Name, abandonedTaskBtn.Font.Size, FontStyle.Bold);
            abandonedTaskBtn.ForeColor = Color.White;
        }

        private void newTaskSubmitBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
