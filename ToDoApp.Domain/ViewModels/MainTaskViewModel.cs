﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Domain
{
    public class MainTaskViewModel
    {
        public string UserId { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; }

        public DateTime Deadline { get; set; }

        public IEnumerable<UnderTaskViewModel> UnderTasks { get; set; }
    }
}
