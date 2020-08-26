using CLibrary;
using System;

namespace eBvel.Calendar.Praktic.Final
{

    public class CheckingEvents
    {
        CalendarDBContext db;
        public CheckingEvents()
        {
            db = new CalendarDBContext();
        }

        public event Action<Events> EventCheckingIsEventToDay;
        public event Action<Events> EventCheckingIsEvent;

        public void CheckingIsEvent(DateTime ToDay)
        {
            foreach (var item in db.DbEvents)
            {
                if (item.Calendars.ToString() == ToDay.ToShortDateString())
                {
                    EventCheckingIsEventToDay?.Invoke(item);
                    break;
                }
                else if (DateTime.Parse(item.Calendars.ToString()) < ToDay)
                {
                    EventCheckingIsEvent?.Invoke(item);
                }
                else if (Convert.ToDateTime(item.Calendars.ToString()) > ToDay)
                {
                    break;
                }
            }
        }
    }
}
