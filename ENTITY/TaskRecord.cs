using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class TaskRecord
    {
        public int IdTaskRecord { get; set; }
        public DateTime ModificationDate { get; set; }
        public string PreviousState { get; set; }
        public string NewState { get; set; }
        public Task Task { get; set; }

        public TaskRecord() { }

        public TaskRecord(int idTaskRecord, DateTime modificationDate, string previousState, string newState)
        {
            IdTaskRecord = idTaskRecord;
            ModificationDate = modificationDate;
            PreviousState = previousState;
            NewState = newState;
        }
    }
}
