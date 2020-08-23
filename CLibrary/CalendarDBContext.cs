namespace CLibrary
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CalendarDBContext : DbContext
    {
        public CalendarDBContext()
            : base("name=CalendarDBConnection")
        {
        }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Events> DbEvents { get; set; }
    }
}