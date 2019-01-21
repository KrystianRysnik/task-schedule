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
    public partial class TaskPanel : UserControl
    {
        public TaskPanel()
        {
            InitializeComponent();
        }

        public TaskPanel(string id, string name, int days, int hours, int minutes, int seconds)
        {
            InitializeComponent();


            nameLabel.Text = name;
            daysLabel.Text = days.ToString();
            hoursLabel.Text = hours.ToString();
            minutesLabel.Text = minutes.ToString();
            secondsLabel.Text = seconds.ToString();
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
    }
}
