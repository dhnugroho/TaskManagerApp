using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp
{
    internal class TaskModel
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}