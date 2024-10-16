using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class CalendarEvent
    {
        public int IdCalendarEvent { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Task task { get; set; }

        public CalendarEvent() { }

        public CalendarEvent(int idCalendarEvent, string title, string description, DateTime date)
        {
            IdCalendarEvent = idCalendarEvent;
            Title = title;
            Description = description;
            Date = date;
        }
    }
}
