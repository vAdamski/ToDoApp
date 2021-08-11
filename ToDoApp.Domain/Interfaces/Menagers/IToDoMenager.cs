using System.Collections.Generic;

namespace ToDoApp.Domain
{
    public interface IToDoMenager
    {
        /// <summary>
        /// Adding new mian task to database
        /// </summary>
        /// <param name="mainTaskDto">Main task dto witch one should be add to database</param>
        /// <returns>Returns true if success, false in other way</returns>
        bool AddNewMainTask(MainTaskDto mainTaskDto);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="underTaskDto"></param>
        /// <param name="mainTaskId"></param>
        /// <returns></returns>
        bool AddNewUnderTask(UnderTaskDto underTaskDto, int mainTaskId);
        bool AddNewMainTaskForUser(MainTaskDto mainTaskDto, ApplicationUser applicationUser);
        bool DeleteUnderTask(UnderTaskDto underTaskDto);
        bool DeleteMainTask(MainTaskDto mainTaskDto);
        List<MainTaskDto> GetAllMainTasks();
        List<UnderTaskDto> GetAllUnderTasksForAMainTask(int mainTaskId);
        List<MainTaskDto> GetAllMainTasksWithUnderTasks();
        List<MainTaskDto> GetAllTasksForUser(ApplicationUser applicationUser);
    }
}