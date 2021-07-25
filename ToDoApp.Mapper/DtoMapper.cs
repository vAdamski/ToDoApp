using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp.Mapper
{
    public class DtoMapper : IDtoMapper
    {
        private IMapper _mapper;
        public DtoMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<MainTask, MainTaskDto>().ReverseMap();
                config.CreateMap<UnderTask, UnderTaskDto>().ReverseMap();
            }).CreateMapper();
        }

        #region UnderTask Maps
        public UnderTaskDto Map(UnderTask underTask)
            => _mapper.Map<UnderTaskDto>(underTask);

        public List<UnderTaskDto> Map(List<UnderTask> underTasks)
            => _mapper.Map<List<UnderTaskDto>>(underTasks);

        public UnderTask Map(UnderTaskDto underTaskDto)
            => _mapper.Map<UnderTask>(underTaskDto);

        public List<UnderTask> Map(List<UnderTaskDto> underTaskDtos)
            => _mapper.Map<List<UnderTask>>(underTaskDtos);
        #endregion

        #region MainTask Maps
        public MainTaskDto Map(MainTask mainTask)
            => _mapper.Map<MainTaskDto>(mainTask);

        public List<MainTaskDto> Map(List<MainTask> mainTasks)
            => _mapper.Map<List<MainTaskDto>>(mainTasks);

        public MainTask Map(MainTaskDto mainTaskDto)
            => _mapper.Map<MainTask>(mainTaskDto);

        public List<MainTask> Map(List<MainTaskDto> mainTaskDtos)
            => _mapper.Map<List<MainTask>>(mainTaskDtos);
        #endregion
    }
}
