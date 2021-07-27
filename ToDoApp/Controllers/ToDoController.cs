using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp
{
    [ApiController]
    [Route("ToDoApp")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoMenager _toDoMenager;
        private readonly IViewModelMapper _viewModelMapper;
        public ToDoController(IToDoMenager toDoMenager, IViewModelMapper viewModelMapper)
        {
            _toDoMenager = toDoMenager;
            _viewModelMapper = viewModelMapper;
        }

        [HttpGet]
        [Route("getAllTasks")]
        public IActionResult GetTasks()
        {
            _toDoMenager.AddNewUnderTask(new UnderTaskDto { Title = "Under Task 1", Description = "Under task to Main task id = 1", IsDone = true }, 1);

            var tasks = _toDoMenager.GetAllMainTasksWithUnderTasks();

            var taskViewModels = _viewModelMapper.Map(tasks);

            return Ok(taskViewModels);
        }
    }
}
