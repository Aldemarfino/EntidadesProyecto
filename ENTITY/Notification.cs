using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Notification
    {
        public int IdNotification { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
        public User User { get; set; }

        public Notification() { }

        public Notification(int idNotification, string message, DateTime sendDate)
        {
            IdNotification = idNotification;
            Message = message;
            SendDate = sendDate;
        }
    }
}
