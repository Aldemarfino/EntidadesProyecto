using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Proyect
    {
        public int IdProyect { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string State { get; set; }
        public List<Task> Tasks { get; set; }
        public User User { get; set; }

        public Proyect()
        {
            Tasks = new List<Task>();
        }

        public Proyect(int idProyect, string name, string description, DateTime startDate, DateTime endDate, string state)
        {
            IdProyect = idProyect;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            State = state;
            Tasks = new List<Task>();
        }
    }
}
