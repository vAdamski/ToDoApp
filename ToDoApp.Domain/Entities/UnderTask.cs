using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Domain
{
    public class UnderTask : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; }

        [ForeignKey("MainTask")]
        public int MainTaskId { get; set; }

        public virtual MainTask MainTask { get; set; }

    }
}
