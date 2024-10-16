using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Task
    {
        public int IdTask { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime Deadline { get; set; }
        public string State { get; set; }
        public string Priority { get; set; }
        public Proyect Proyect { get; set; }
        public List<TaskRecord> Record { get; set; }
        public List<Archive> Archives { get; set; }

        public Task()
        {
            Record = new List<TaskRecord>();
            Archives = new List<Archive>();
        }

        public Task(int idTask, string title, string description, DateTime creationDate, DateTime deadline, string state, string priority)
        {
            IdTask = idTask;
            Title = title;
            Description = description;
            CreationDate = creationDate;
            Deadline = deadline;
            State = state;
            Priority = priority;
            Record = new List<TaskRecord>();
            Archives = new List<Archive>();
        }
    }
}
