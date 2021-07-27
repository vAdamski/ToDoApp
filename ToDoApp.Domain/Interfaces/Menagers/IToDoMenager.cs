using System.Collections.Generic;

namespace ToDoApp.Domain
{
    public interface IToDoMenager
    {
        bool AddNewMainTask(MainTaskDto mainTaskDto);
        bool AddNewUnderTask(UnderTaskDto underTaskDto, int mainTaskId);
        bool DeleteUnderTask(UnderTaskDto underTaskDto);
        bool DeleteMainTask(MainTaskDto mainTaskDto);
        List<MainTaskDto> GetAllMainTasks();
        List<UnderTaskDto> GetAllUnderTasksForAMainTask(int mainTaskId);
        List<MainTaskDto> GetAllMainTasksWithUnderTasks();
    }
}