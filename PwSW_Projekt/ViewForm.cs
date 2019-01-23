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
    public partial class ViewForm : Form
    {
        List<Task> tasks = new List<Task>();
        List<Task> completeTasks = new List<Task>();
        UserControl activeUC;

        public ViewForm()
        {
            InitializeComponent();

            tasks.Add(new Task("Nazwa", Category.Current, new DateTime(2019, 2, 2, 14, 0, 0), true, "Opis"));
            tasks.Add(new Task("Nazwa 2", Category.Current, new DateTime(2019, 3, 2, 14, 0, 0), true, "Opis"));
            tasks.Add(new Task("Nazwa 2", Category.Current, new DateTime(2019, 3, 2, 14, 0, 0), true, "Opis"));
            tasks.Add(new Task("Nazwa 2", Category.Current, new DateTime(2019, 3, 2, 14, 0, 0), true, "Opis"));
            tasks.Add(new Task("Nazwa 2", Category.Current, new DateTime(2019, 3, 2, 14, 0, 0), true, "Opis"));
            tasks.Add(new Task("Nazwa 2", Category.Current, new DateTime(2019, 3, 2, 14, 0, 0), true, "Opis"));
            tasks.Add(new Task("Nazwa 2", Category.Current, new DateTime(2019, 3, 2, 14, 0, 0), true, "Opis"));
            tasks.Add(new Task("Nazwa 2", Category.Current, new DateTime(2019, 3, 2, 14, 0, 0), true, "Opis"));

            Task task = new Task("Nazwa zakończonego", Category.Complete, new DateTime(2018, 1, 25, 14, 0, 0), false, "Opis");
            task.EndDate = new DateTime(2018, 1, 23, 18, 0, 0);
            completeTasks.Add(task);

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
            content.Controls.Clear();
            activeUC = new UC_AddTask();
            activeUC.Dock = DockStyle.Fill;
            activeUC.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            content.Controls.Add(activeUC);
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
            content.Controls.Clear();
            content.Controls.Remove(activeUC);
            activeUC = new UC_DisplayTasks();
            activeUC.Dock = DockStyle.Fill;
            activeUC.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            content.Controls.Add(activeUC);

            int offsetY = 20;
            foreach (Task task in tasks)
            {
                UC_TaskPanel taskPanel = new UC_TaskPanel(task);
                taskPanel.Location = new Point(20, offsetY);
                taskPanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                activeUC.Controls.Add(taskPanel);
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

            // Active Panel
            content.Controls.Clear();
            content.Controls.Remove(activeUC);
            activeUC = new UC_DisplayTasks();
            activeUC.Dock = DockStyle.Fill;
            activeUC.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            content.Controls.Add(activeUC);

            int offsetY = 20;
            foreach (Task task in completeTasks)
            {
                UC_EndTaskPanel endTaskPanel = new UC_EndTaskPanel(task);
                endTaskPanel.Location = new Point(20, offsetY);
                endTaskPanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                activeUC.Controls.Add(endTaskPanel);
                offsetY += 60;
            }
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
    }
}
