using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CLibrary
{
    [ComplexType]
    public class Day
    {
        [Required]
        public byte NumDay { get; set; }
        [Required]
        public string DayOfWeek { get; set; }
        //[Required]
        public bool RedDay { get; set; }

        public readonly List<string> ListDaysOfWeek = new List<string>()
        {
            "Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"
        };
    }
}
