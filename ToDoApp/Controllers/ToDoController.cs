using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<ApplicationUser> _userManager;

        public ToDoController(IToDoMenager toDoMenager, IViewModelMapper viewModelMapper, UserManager<ApplicationUser> userManager)
        {
            _toDoMenager = toDoMenager;
            _viewModelMapper = viewModelMapper;
            _userManager = userManager;
        }

        [HttpGet]
        [Route("getAllTasks")]
        public IActionResult GetTasks()
        {
            var tasks = _toDoMenager.GetAllMainTasksWithUnderTasks();

            var taskViewModels = _viewModelMapper.Map(tasks);

            return Ok(taskViewModels);
        }

        [HttpGet]
        [Route("getAllTasksForLoggedInUser")]
        public async Task<IActionResult> GetTaskaForLoggedInUser()
        {
            var user = await _userManager.GetUserAsync(User);


            if (user == null)
            {
                return NotFound(null);
            }

            var tasksDto = _toDoMenager.GetAllTasksForUser(user);

            var tasksViewModel = _viewModelMapper.Map(tasksDto);

            return Ok(tasksViewModel);
        }

        [HttpPost]
        [Route("addNewTaskForUser")]
        public async Task<IActionResult> AddNewMainTaskForUser([FromBody]MainTaskViewModel mainTaskViewModel)
        {
            var mainTaskDto = _viewModelMapper.Map(mainTaskViewModel);

            var user = await _userManager.GetUserAsync(User);

            _toDoMenager.AddNewMainTaskForUser(mainTaskDto, user);

            return Ok();
        }


    }
}
