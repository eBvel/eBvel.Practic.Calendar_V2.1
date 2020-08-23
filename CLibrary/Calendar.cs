using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CLibrary
{
    public class Calendar
    {
        public Calendar()
        {
            Events = new List<Events>();
        }
        public int Id { get; set; }

        public override string ToString()
        {
            return FullDate;
        }

        public int Count
        {
            get
            {
                return Events.Where(p => p.IsEvent).Count();
            }
        }

        [Required]
        public int NumYear { get; set; }

        public Day Days { get; set; }

        public Month Months { get; set; }

        public string FullDate => string.Format("{0:D2}.{1:D2}.{2:D4}", Days.NumDay, Months.NumMonth, NumYear);
        public string cDay => Days.NumDay + " " + Days.DayOfWeek;
        public string cMonth => Months.NumMonth + " " + Months.NameMonth;
        public bool RD => Days.RedDay;

        public int NMonth => Months.NumMonth;

        public virtual ICollection<Events> Events { get; set; }
    }
}

