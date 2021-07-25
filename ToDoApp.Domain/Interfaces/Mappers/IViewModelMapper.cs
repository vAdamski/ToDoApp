using System.Collections.Generic;

namespace ToDoApp.Domain
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