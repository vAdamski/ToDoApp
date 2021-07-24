using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Domain
{
    public class MainTask : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; }

        public DateTime Deadline { get; set; }

        [NotMapped]
        public virtual List<UnderTask> UnderTasks { get; set; }
    }
}
