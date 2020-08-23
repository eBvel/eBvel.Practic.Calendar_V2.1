using System;

namespace CLibrary
{
    public class Events
    {
        public int Id { get; set; }

        public int CalendarId { get; set; }

        public virtual Calendar Calendars { get; set; }

        public string TextEvent { get; set; }

        public string PlaceEvent { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public bool IsEvent { get; set; }

        //public override string ToString()
        //{
        //    return TextEvent;
        //}
    }
}
