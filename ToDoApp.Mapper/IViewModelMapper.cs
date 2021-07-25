using System.Collections.Generic;
using ToDoApp.Domain;

namespace ToDoApp.Mapper
{
    public interface IViewModelMapper
    {
        List<MainTaskViewModel> Map(List<MainTaskDto> mainTaskDtos);
        List<MainTaskDto> Map(List<MainTaskViewModel> mainTaskViewModels);
        List<UnderTaskViewModel> Map(List<UnderTaskDto> underTaskDtos);
        List<UnderTaskDto> Map(List<UnderTaskViewModel> underTaskViewModels);
        MainTaskViewModel Map(MainTaskDto mainTaskDto);
        MainTaskDto Map(MainTaskViewModel mainTaskViewModel);
        UnderTaskViewModel Map(UnderTaskDto underTaskDto);
        UnderTaskDto Map(UnderTaskViewModel underTaskViewModel);
    }
}