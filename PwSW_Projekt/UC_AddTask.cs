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
    public partial class UC_AddTask : UserControl
    {
        string name;
        DateTime date;
        bool important;
        Task task;
        bool isEditMode = false;

        public UC_AddTask()
        {
            InitializeComponent();

            isEditMode = false;
            importantNoRadio.Checked = true;
        }

        public UC_AddTask(Task task)
        {
            InitializeComponent();

            isEditMode = true;
            this.task = task;

            newTaskSubmitBtn.Text = "EDYTUJ ZADANIE";
            nameTextBox.Text = task.Name;
            dateTimePicker.Value = task.Date;
            importantYesRadio.Checked = task.IsImportant ? true : false;
            importantNoRadio.Checked = task.IsImportant ? false : true;
        }

        private void newTaskSubmitBtn_Click(object sender, EventArgs e)
        {
            // Notify user about missing data
            nameReqLabel.Text = (nameTextBox.Text == "" || nameTextBox.Text == null) ? "(*) - to pole jest wymagane" : "(*)";
            dateReqLabel.Text = (dateTimePicker.Value <= DateTime.Now) ? "(*) - data/godzina jest mniejsza od aktualnej" : "(*)";
            importantReqLabel.Text = (!importantYesRadio.Checked && !importantNoRadio.Checked) ? "(*) - to pole jest wymagane" : "(*)";

            // Check that all required fields are filled
            if (nameTextBox.Text != "" 
                && nameTextBox.Text != null
                && dateTimePicker.Value > DateTime.Now
                && (importantNoRadio.Checked || importantYesRadio.Checked))
            {
                name = nameTextBox.Text;
                date = dateTimePicker.Value;
                important = importantYesRadio.Checked ? true : false;

                if (task != null && isEditMode)
                {
                    // Remove previously task
                    JsonData.currentTasks.Remove(JsonData.currentTasks.Find( t => t.Id.Contains( task.Id ) ) );
                }
              
                // Create and add new/edited task
                task = new Task(name, Category.Current, date, important);
                JsonData.currentTasks.Add(task);
                JsonData.currentTasks.Sort((t1, t2) => t1.Date.CompareTo(t2.Date));

                if (isEditMode)
                {
                    // Hide edit mode
                    Parent.Hide();
                    Form_View.clearContent();
                    Form_View.createListOfTasks();
                }
                else
                {
                    // Reset fields
                    nameTextBox.Text = null;
                    dateTimePicker.Value = DateTime.Now;
                    importantNoRadio.Checked = true;
                }
            }
        }
    }
}
