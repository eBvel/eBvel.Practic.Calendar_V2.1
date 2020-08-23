using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CLibrary;
using eBvel.Calendar.Praktic.Final;
using System.Data.Entity;
using eBvel.Practic.Calendar_V2._1.Forms;

namespace eBvel.Practic.Calendar_V2._1.Controls
{
    public partial class OpenEventsControl : UserControl
    {
        CalendarDBContext db;
        DateTime NOW;
        CheckingEvents CheckingTodayEvent;
        DateTime dd;
        //
        //Поиск объектов БД.
        //
        public Events FindElement()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int x = dataGridView1.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1[0, x].Value.ToString(), out int id);
                if (converted == false) return null;

                return db.DbEvents.Find(id);
            }
            else return null;
        }
        //
        //Second construction.
        //
        internal void SecondConstruction()
        {
            CheckingTodayEvent.EventCheckingIsEvent += CheckingTodayEvent_EventCheckingIsEvent;
            CheckingTodayEvent.CheckingIsEvent(NOW);
        }
        //
        //Construction.
        //
        public OpenEventsControl()
        {
            InitializeComponent();
            NOW = DateTime.Today;
            CheckingTodayEvent = new CheckingEvents();

            db = new CalendarDBContext();
            db.DbEvents.Load();
            dataGridView1.DataSource = db.DbEvents.Local.ToBindingList();
        }

        //
        //The event to checking today list.
        //
        private void CheckingTodayEvent_EventCheckingIsEvent(string obj)
        {
            string s = "";
            if (obj == "ToDay is Event!")
            {
                foreach (var item in db.DbEvents)
                {
                    if (item.Calendars.ToString() == NOW.ToShortDateString())
                    {
                        s = item.TextEvent;
                        break;
                    }
                }
                MessageBox.Show($"{obj}\n{s}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //
        //To edit the event after a double click.
        //
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var eevent = FindElement() ?? throw new NullReferenceException("SHOTO TUT NE TAK");
                var addEventForm = new AddEventForm();
                addEventForm.EventTextBox.Text = eevent.TextEvent;
                addEventForm.PlaceEventTextBox.Text = eevent.PlaceEvent;
                addEventForm.dateTimePicker1.Value = Convert.ToDateTime(eevent.StartDate);
                addEventForm.dateTimePicker2.Value = Convert.ToDateTime(eevent.EndDate);

                DialogResult result = addEventForm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    eevent.TextEvent = addEventForm.EventTextBox.Text;
                    eevent.PlaceEvent = addEventForm.PlaceEventTextBox.Text;
                    eevent.StartDate = addEventForm.dateTimePicker1.Value.ToShortTimeString();
                    eevent.EndDate = addEventForm.dateTimePicker2.Value.ToShortTimeString();
                    db.SaveChanges();
                    dataGridView1.Refresh();
                }
            }
        }
        //
        //Find the event in the table.
        //
        private void Search_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.DbEvents.Local.Where(p => p.TextEvent.Contains(textBox1.Text)).ToList();
        }
        //
        //Perform Click.
        //
        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Search_Button.PerformClick();
        }
        //
        //The event transfers to the other date.
        //
        private void Transfer_Button_Click(object sender, EventArgs e)
        {
            var eevent = FindElement() ?? throw new NullReferenceException("Для переноса, требуется выбрать мероприятие!");

        }
    }
}
