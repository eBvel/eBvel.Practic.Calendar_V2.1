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

        public event Action<string> EventCheckingIsEvent;

        public void CheckingIsEvent(DateTime ToDay)
        {
            foreach (var item in db.Calendars)
            {
                if (Convert.ToDateTime(item.FullDate) > ToDay)
                {
                    break;
                }
                else if (item.FullDate == ToDay.ToShortDateString())
                {
                    if (item.Events.Count > 0)
                    {
                        EventCheckingIsEvent?.Invoke("ToDay is Event!");
                        break;
                    }
                }
            }
        }
    }
}
