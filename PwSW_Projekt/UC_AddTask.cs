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
        string description;
        Task task;

        public UC_AddTask()
        {
            InitializeComponent();

            importantNoRadio.Checked = true;
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
                description = descriptionRichTexBox.Text;

                // Add task
                task = new Task(name, Category.Current, date, important, description);
                Form_View.tasks.Add(task);
                Form_View.tasks.Sort((t1, t2) => t1.Date.CompareTo(t2.Date));

                // Reset fields
                nameTextBox.Text = null;
                dateTimePicker.Value = DateTime.Now;
                importantNoRadio.Checked = true;
                descriptionRichTexBox.Text = null;
            }

        }
    }
}
