using System;
using System.Windows.Forms;

namespace eBvel.Practic.Calendar_V2._1.Forms
{
    public partial class AddEventForm : Form
    {
        public AddEventForm()
        {
            InitializeComponent();
        }

        private void Label_TextBox_Click(object sender, EventArgs e)
        {
            Label_TextBox.Visible = false;
            PlaceEventTextBox.Focus();
        }

        private void PlaceEventTextBox_Leave(object sender, EventArgs e)
        {
            if (EventTextBox.Text == "")
                Label_TextBox.Visible = true;
        }

        private void EventTextBox_TextChanged(object sender, EventArgs e)
        {
            Label_TextBox.Visible = false;
        }
    }
}
