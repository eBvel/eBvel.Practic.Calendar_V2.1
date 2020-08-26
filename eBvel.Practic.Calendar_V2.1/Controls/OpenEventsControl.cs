using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CLibrary;
using eBvel.Calendar.Praktic.Final;
using System.Data.Entity;
using eBvel.Practic.Calendar_V2._1.Forms;
using System.Drawing;

namespace eBvel.Practic.Calendar_V2._1.Controls
{
    public partial class OpenEventsControl : UserControl
    {
        CalendarDBContext db;
        DateTime NOW;
        CheckingEvents CheckingTodayEvent;
        //
        //Method for searching objects in the table.
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
            CheckingTodayEvent.EventCheckingIsEventToDay += CheckingTodayEvent_EventCheckingIsEventToDay;
            CheckingTodayEvent.EventCheckingIsEvent += CheckingTodayEvent_EventCheckingIsEvent;
            CheckingTodayEvent.CheckingIsEvent(NOW);
            PastEvents();
        }
        //
        //Fail event.
        //
        private void CheckingTodayEvent_EventCheckingIsEvent(Events obj)
        {
            obj.IsEvent = false;
            db.SaveChanges();
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
        private void CheckingTodayEvent_EventCheckingIsEventToDay(Events obj)
        {
            MessageBox.Show($"На сегодня запланировано мероприятие.\n{obj.TextEvent}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //
        //To edit the event after a double click.
        //
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var eevent = FindElement() ?? throw new NullReferenceException("The element wasn't selected. Please, try again.");
                var addEventForm = new AddEventForm();
                addEventForm.comboBox1.Visible = true;
                //To load info to the combo box
                addEventForm.comboBox1.DataSource = db.Calendars.ToList();
                addEventForm.comboBox1.ValueMember = "Id";
                addEventForm.comboBox1.DisplayMember = "FullDate";
                addEventForm.comboBox1.Text = eevent.Calendars.ToString();
                //end load.
                addEventForm.EventTextBox.Text = eevent.TextEvent;
                addEventForm.PlaceEventTextBox.Text = eevent.PlaceEvent;
                addEventForm.dateTimePicker1.Value = Convert.ToDateTime(eevent.StartDate);
                addEventForm.dateTimePicker2.Value = Convert.ToDateTime(eevent.EndDate);

                DialogResult result = addEventForm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    eevent.Calendars = (CLibrary.Calendar)addEventForm.comboBox1.SelectedItem;
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
            dataGridView1.DataSource = db.DbEvents.Local.Where(p => p.TextEvent.Contains(SearchBox.Text)).ToList();
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
        //
        //
        void PastEvents()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(Convert.ToDateTime(row.Cells[1].Value.ToString()) < DateTime.Today)
                {
                    row.DefaultCellStyle.BackColor = Color.SlateGray;
                }
            }
        }
    }
}
