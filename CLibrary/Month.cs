using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CLibrary
{
    [ComplexType]
    public class Month
    {
        [Required]
        public byte NumMonth { get; set; }

        public string NameMonth { get; set; }

        public readonly List<string> ListNamesMonth = new List<string>()
        {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"
        }; //Наименование месяцев.

        public List<int> ListNumMonth = new List<int>()
        {
            31,28,31,30,31,30,31,31,30,31,30,31
        }; //Кол-во дней в месяцах.
    }
}

