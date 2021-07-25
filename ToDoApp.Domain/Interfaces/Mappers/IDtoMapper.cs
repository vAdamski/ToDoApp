using System.Collections.Generic;
using ToDoApp.Domain;

namespace ToDoApp.Domain

{
    public interface IDtoMapper
    {
        List<MainTaskDto> Map(List<MainTask> mainTasks);
        List<MainTask> Map(List<MainTaskDto> mainTaskDtos);
        List<UnderTaskDto> Map(List<UnderTask> underTasks);
        List<UnderTask> Map(List<UnderTaskDto> underTaskDtos);
        MainTaskDto Map(MainTask mainTask);
        MainTask Map(MainTaskDto mainTaskDto);
        UnderTaskDto Map(UnderTask underTask);
        UnderTask Map(UnderTaskDto underTaskDto);
    }
}