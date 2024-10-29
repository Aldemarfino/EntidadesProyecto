using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Reminder
    {
        public int IdReminder { get; set; }
        public Notification Notification { get; set; }
        public Task Task { get; set; }

        public Reminder() { }

    }
}
