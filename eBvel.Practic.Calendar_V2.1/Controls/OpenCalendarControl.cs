using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CLibrary;
using System.Data.Entity;
using eBvel.Practic.Calendar_V2._1.Forms;

namespace eBvel.Practic.Calendar_V2._1.Controls
{
    public partial class OpenCalendarControl : UserControl
    {
        CalendarDBContext db;
        int page;
        //
        //Поиск объектов.
        //
        public CLibrary.Calendar FindElement()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int x = dataGridView1.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1[0, x].Value.ToString(), out int id);
                if (converted == false) return null;

                return db.Calendars.Find(id);
            }
            else return null;
        }
        //
        //Construction.
        //
        public OpenCalendarControl()
        {
            InitializeComponent();
            db = new CalendarDBContext();
            page = db.Calendars.First().NMonth;
            db.Calendars.Load();
            label3.Text = page.ToString();
            dataGridView1.DataSource = db.Calendars.Local.ToBindingList();
        }
        //
        //Кнопка, добавить событие.
        //
        private void AddEventButton_Click(object sender, EventArgs e)
        {
            var eventDate = FindElement();
            var events = new Events();
            var addEventForm = new AddEventForm();
            DialogResult result = addEventForm.ShowDialog(this);
            try
            {
                if (result == DialogResult.OK)
                {
                    events.TextEvent = addEventForm.EventTextBox.Text;
                    events.PlaceEvent = addEventForm.PlaceEventTextBox.Text;
                    events.StartDate = addEventForm.dateTimePicker1.Value.ToShortTimeString();
                    events.EndDate = addEventForm.dateTimePicker2.Value.ToShortTimeString();
                    events.IsEvent = true;
                    events.Calendars = eventDate;
                }
                db.DbEvents.Add(events);
                db.SaveChanges();
                MessageBox.Show("Событие добавлено!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //Второй конструктор.
        //
        internal void SecondConstruction()
        {
            SelectHollyDays();
        }

        public void SelectHollyDays()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt16(row.Cells[6].Value) == 1)
                {
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.BackColor = Color.LightSeaGreen;
                }
                else if (Convert.ToBoolean(row.Cells[5].Value) == true)
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        //
        //To turn the page in left.
        //
        private void Left_Click(object sender, EventArgs e)
        {
            var rpage = LabelClick(0);
            label3.Text = rpage.ToString();
            dataGridView1.DataSource = db.Calendars.Local.Where(p => p.NMonth == rpage).ToList();
            SelectHollyDays();
        }
        //
        //To turn the page in right.
        //
        private void Right_Click(object sender, EventArgs e)
        {
            var rpage = LabelClick(1);
            label3.Text = rpage.ToString();
            dataGridView1.DataSource = db.Calendars.Local.Where(p => p.NMonth == rpage).ToList();
            SelectHollyDays();
        }
        //
        //Method, return a value for page.
        //
        public int LabelClick(int p)
        {
            if (p == 1)
            {
                return page < 12 ? ++page : page = 1;
            }
            else return page > 1 ? --page : page = 12;
        }
        //
        //To leave from the left label.
        //
        private void LeftLabel_Leave(object sender, EventArgs e)
        {
            Left_Label.ForeColor = Color.Black;

        }
        //
        //To enter to the left label.
        //
        private void LeftLabel_Enter(object sender, EventArgs e)
        {
            Left_Label.ForeColor = Color.Gray;
        }
        //
        //To leave from the right label.
        //
        private void RightLabel_Enter(object sender, EventArgs e)
        {
            Right_Label.ForeColor = Color.Gray;
        }
        //
        //To enter to the right label.
        //
        private void RightLabel_Leave(object sender, EventArgs e)
        {
            Right_Label.ForeColor = Color.Black;
        }
        //
        //The button for search objects in the table.
        //
        private void Search_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Calendars.Local.Where(p => p.FullDate.Contains(textBox1.Text)).OrderBy(p => p.Id).ToList();
        }

        private void SearchButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Search_Button.PerformClick();
        }

        private void GridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //var eventDate = FindElement();
            //ViewEvent_Label.Text += db.DbEvents.Local.Where(p => p.Calendars.ToString() == eventDate.FullDate).Select(p => p.TextEvent);
        }
    }
}
