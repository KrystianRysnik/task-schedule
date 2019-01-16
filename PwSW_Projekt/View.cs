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
        public View()
        {
            InitializeComponent();
        }

        private void newTaskBtn_Click(object sender, EventArgs e)
        {
            newTaskBtn.Font = new Font(newTaskBtn.Font.Name, newTaskBtn.Font.Size, FontStyle.Bold);
            newTaskBtn.ForeColor = Color.White;

            currentTasksBtn.Font = new Font(currentTasksBtn.Font.Name, currentTasksBtn.Font.Size, FontStyle.Regular);
            currentTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);

            completeTasksBtn.Font = new Font(completeTasksBtn.Font.Name, completeTasksBtn.Font.Size, FontStyle.Regular);
            completeTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);

            abondedTasksBtn.Font = new Font(abondedTasksBtn.Font.Name, abondedTasksBtn.Font.Size, FontStyle.Regular);
            abondedTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);

            // Active Panel
            newTaskPanel.BringToFront();
        }

        private void currentTasksBtn_Click(object sender, EventArgs e)
        {
            newTaskBtn.Font = new Font(newTaskBtn.Font.Name, newTaskBtn.Font.Size, FontStyle.Regular);
            newTaskBtn.ForeColor = Color.FromArgb(117, 117, 117);

            currentTasksBtn.Font = new Font(currentTasksBtn.Font.Name, currentTasksBtn.Font.Size, FontStyle.Bold);
            currentTasksBtn.ForeColor = Color.White;

            completeTasksBtn.Font = new Font(completeTasksBtn.Font.Name, completeTasksBtn.Font.Size, FontStyle.Regular);
            completeTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);

            abondedTasksBtn.Font = new Font(abondedTasksBtn.Font.Name, abondedTasksBtn.Font.Size, FontStyle.Regular);
            abondedTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);
        }

        private void completeTasksBtn_Click(object sender, EventArgs e)
        {
            newTaskBtn.Font = new Font(newTaskBtn.Font.Name, newTaskBtn.Font.Size, FontStyle.Regular);
            newTaskBtn.ForeColor = Color.FromArgb(117, 117, 117);

            currentTasksBtn.Font = new Font(currentTasksBtn.Font.Name, currentTasksBtn.Font.Size, FontStyle.Regular);
            currentTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);
            
            completeTasksBtn.Font = new Font(completeTasksBtn.Font.Name, completeTasksBtn.Font.Size, FontStyle.Bold);
            completeTasksBtn.ForeColor = Color.White;

            abondedTasksBtn.Font = new Font(abondedTasksBtn.Font.Name, abondedTasksBtn.Font.Size, FontStyle.Regular);
            abondedTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);
        }

        private void abondedTasksBtn_Click(object sender, EventArgs e)
        {
            newTaskBtn.Font = new Font(newTaskBtn.Font.Name, newTaskBtn.Font.Size, FontStyle.Regular);
            newTaskBtn.ForeColor = Color.FromArgb(117, 117, 117);

            currentTasksBtn.Font = new Font(currentTasksBtn.Font.Name, currentTasksBtn.Font.Size, FontStyle.Regular);
            currentTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);

            completeTasksBtn.Font = new Font(completeTasksBtn.Font.Name, completeTasksBtn.Font.Size, FontStyle.Regular);
            completeTasksBtn.ForeColor = Color.FromArgb(117, 117, 117);

            abondedTasksBtn.Font = new Font(abondedTasksBtn.Font.Name, abondedTasksBtn.Font.Size, FontStyle.Bold);
            abondedTasksBtn.ForeColor = Color.White;
        }

        private void newTaskSubmitBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
