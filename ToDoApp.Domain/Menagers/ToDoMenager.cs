using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Domain
{
    public class ToDoMenager : IToDoMenager
    {
        private readonly IMainTasksRepository _mainTasksRepository;
        private readonly IUnderTasksRepository _underTasksRepository;
        private readonly IDtoMapper _dtoMapper;

        public ToDoMenager(IMainTasksRepository mainTasksRepository,
                            IUnderTasksRepository underTasksRepository,
                            IDtoMapper dtoMapper)
        {
            _mainTasksRepository = mainTasksRepository;
            _underTasksRepository = underTasksRepository;
            _dtoMapper = dtoMapper;
        }

        public List<MainTaskDto> GetAllMainTasks()
        {
            var mainTasksEntities = _mainTasksRepository.GetAllMainTasks().ToList();

            return _dtoMapper.Map(mainTasksEntities);
        }

        public List<UnderTaskDto> GetAllUnderTasksForAMainTask(int mainTaskId)
        {
            var underTaskEntities = _underTasksRepository.GetAllUnderTasks().Where(x => x.MainTaskId == mainTaskId).ToList();

            return _dtoMapper.Map(underTaskEntities);
        }

        public bool AddNewUnderTask(UnderTaskDto underTaskDto, int mainTaskId)
        {
            var entity = _dtoMapper.Map(underTaskDto);

            entity.MainTaskId = mainTaskId;

            return _underTasksRepository.Add(entity);
        }

        public bool AddNewMainTask(MainTaskDto mainTaskDto)
        {
            var entity = _dtoMapper.Map(mainTaskDto);

            return _mainTasksRepository.Add(entity);
        }

        public bool DeleteUnderTask(UnderTaskDto underTaskDto)
        {
            var entity = _dtoMapper.Map(underTaskDto);

            return _underTasksRepository.Delete(entity);
        }

        public bool DeleteMainTask(MainTaskDto mainTaskDto)
        {
            var entity = _dtoMapper.Map(mainTaskDto);

            return _mainTasksRepository.Delete(entity);
        }
    }
}
