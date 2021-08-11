using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp.Mapper
{
    public class ViewModelMapper : IViewModelMapper
    {
        private IMapper _mapper;
        public ViewModelMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<MainTaskDto, MainTaskViewModel>().ReverseMap();
                config.CreateMap<UnderTaskDto, UnderTaskViewModel>().ReverseMap();
                config.CreateMap<UserRegisterDto, UserRegisterViewModel>().ReverseMap();
                config.CreateMap<UserLoginDto, UserLoginViewModel>().ReverseMap();
            }).CreateMapper();
        }

        #region UnderTask Maps
        public UnderTaskViewModel Map(UnderTaskDto underTaskDto)
            => _mapper.Map<UnderTaskViewModel>(underTaskDto);

        public List<UnderTaskViewModel> Map(List<UnderTaskDto> underTaskDtos)
            => _mapper.Map<List<UnderTaskViewModel>>(underTaskDtos);

        public UnderTaskDto Map(UnderTaskViewModel underTaskViewModel)
            => _mapper.Map<UnderTaskDto>(underTaskViewModel);

        public List<UnderTaskDto> Map(List<UnderTaskViewModel> underTaskViewModels)
            => _mapper.Map<List<UnderTaskDto>>(underTaskViewModels);
        #endregion

        #region MainTask Maps
        public MainTaskViewModel Map(MainTaskDto mainTaskDto)
            => _mapper.Map<MainTaskViewModel>(mainTaskDto);

        public List<MainTaskViewModel> Map(List<MainTaskDto> mainTaskDtos)
            => _mapper.Map<List<MainTaskViewModel>>(mainTaskDtos);

        public MainTaskDto Map(MainTaskViewModel mainTaskViewModel)
            => _mapper.Map<MainTaskDto>(mainTaskViewModel);

        public List<MainTaskDto> Map(List<MainTaskViewModel> mainTaskViewModels)
            => _mapper.Map<List<MainTaskDto>>(mainTaskViewModels);
        #endregion

        #region UserRegister Maps
        public UserRegisterViewModel Map(UserRegisterDto userRegisterDto)
            => _mapper.Map<UserRegisterViewModel>(userRegisterDto);

        public UserRegisterDto Map(UserRegisterViewModel userRegisterViewModel)
            => _mapper.Map<UserRegisterDto>(userRegisterViewModel);
        #endregion

        #region UserLogin Maps
        public UserLoginViewModel Map(UserLoginDto userLoginDto)
            => _mapper.Map<UserLoginViewModel>(userLoginDto);

        public UserLoginDto Map(UserLoginViewModel userLoginViewModel)
            => _mapper.Map<UserLoginDto>(userLoginViewModel);
        #endregion
    }
}
