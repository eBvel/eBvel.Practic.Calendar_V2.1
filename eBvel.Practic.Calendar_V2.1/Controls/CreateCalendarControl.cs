using System;
using System.Windows.Forms;
using CLibrary;
using System.Data.Entity;
using eBvel.Practic.Calendar_V2._1.Forms;
using System.Collections.Generic;

namespace eBvel.Practic.Calendar_V2._1.Controls
{
    public partial class CreateCalendarControl : UserControl
    {
        CalendarDBContext db;
        public DateTime StartDay;
        List<string> ListHoliDays;
        bool bt1;
        //
        //Construction.
        //
        public CreateCalendarControl()
        {
            InitializeComponent();
            db = new CalendarDBContext();
            db.Calendars.Load();
            ListHoliDays = new List<string>();
        }
        //
        //Button, for filling the calendar db.
        //
        private void FirstDateButton_Click(object sender, EventArgs e)
        {
            var createForm = new CreateCalendarForm();
            var calendar = new CLibrary.Calendar()
            {
                Days = new CLibrary.Day(),
                Months = new Month(),
            };

            DialogResult result = createForm.ShowDialog(this);
            bt1 = FillCalendar(createForm, result, calendar);
            if (bt1)
            {
                HollyDaysButton.Enabled = true;
                checkBox1.Enabled = true;
                checkBox1.Checked = true;
            }
        }
        //
        //Method, for filling the calendar db.
        //
        private bool FillCalendar(CreateCalendarForm createForm, DialogResult result, CLibrary.Calendar calendar)//, List<CLibrary.Calendar> lcalendar)
        {
            if (result == DialogResult.OK)
            {
                StartDay = createForm.dateTimePicker1.Value;
                byte _day = Convert.ToByte(StartDay.Day);
                byte _week = (byte)StartDay.DayOfWeek;
                sbyte _month = Convert.ToSByte(StartDay.Month);
                short _year = Convert.ToInt16(StartDay.Year);
                byte _interval = 12;

                void LeapYear() //Function.
                {
                    if (_year % 4 == 0 && _month < 3)
                        calendar.Months.ListNumMonth[1]++;
                    else if (_year % 4 != 0 && calendar.Months.ListNumMonth[1] == 29)
                        calendar.Months.ListNumMonth[1]--;
                }
                try
                {
                    LeapYear();
                    calendar.NumYear = _year;
                    for (byte j = 0; j < _interval; j++)
                    {
                        if (_month + j == 13)
                        {
                            _year++;
                            calendar.NumYear = _year;
                            LeapYear();
                            _month = (sbyte)(1 - j);
                        }
                        calendar.Months.NumMonth = (byte)(_month + j);
                        calendar.Months.NameMonth = calendar.Months.ListNamesMonth[_month + j - 1];
                        for (byte k = 0; k < calendar.Months.ListNumMonth[_month + j - 1]; k++)
                        {
                            if (_week == 8)
                                _week = 1;
                            if (_day + k == calendar.Months.ListNumMonth[_month + j - 1] + 1)
                            {
                                _day = 1;
                                break;
                            }
                            calendar.Days.NumDay = (byte)(_day + k);
                            calendar.Days.DayOfWeek = calendar.Days.ListDaysOfWeek[_week - 1];
                            if (createForm.ListRedDays.Contains(calendar.Days.DayOfWeek))
                            {
                                calendar.Days.RedDay = true;
                            }
                            else calendar.Days.RedDay = false;
                            _week++;
                            db.Calendars.Add(calendar);
                            db.SaveChanges();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }
        //
        //Button, completes creation this calendar.
        //
        private void CreateCalendarButton_Click(object sender, EventArgs e)
        {
            foreach(var obj in db.Calendars)
            {
                if (ListHoliDays.Contains(obj.FullDate))
                {
                    obj.Days.RedDay = true;
                }
            }
            db.SaveChanges();
            MessageBox.Show("Календарь создан!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //
        //Button, adds to the list the holidays.
        //
        private void HollyDaysButton_Click(object sender, EventArgs e)
        {
            var holidaysForm = new AddHoliDaysForm();
            
            DialogResult result = holidaysForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                if (holidaysForm.listBox1.Items.Count > 0)
                {
                    foreach (var item in holidaysForm.listBox1.Items)
                    {
                        ListHoliDays.Add(item.ToString());
                    }
                }
                MessageBox.Show("Даты в списке отсутствуют.\r\nДобавьте даты и попробуйте снова.", "Оповещение", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CreateCalendar_Button.Enabled = true;
            checkBox2.Enabled = true;
            checkBox2.Checked = true;
        }
    }
}


