using System;
using System.Windows.Forms;

namespace eBvel.Practic.Calendar_V2._1.Forms
{
    public partial class AddHoliDaysForm : Form
    {
        public AddHoliDaysForm()
        {
            InitializeComponent();
        }

        private void AddHollyDay_Button_Click(object sender, EventArgs e)
        {
            string SelectDate = dateTimePicker1.Value.ToShortDateString();
            listBox1.Items.Add(SelectDate);
        }

        private void DeleteDate_Button_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int a = listBox1.SelectedIndex;
                if (a == -1) return;
                listBox1.Items.RemoveAt(a);
            }
            else MessageBox.Show("Список пуст!", "Оповещение.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
