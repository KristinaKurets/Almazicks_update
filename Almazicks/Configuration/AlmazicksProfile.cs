using Almazicks.DataContracts.DataContracts;
using AutoMapper;
using Data.EntityModels;

namespace Almazicks.Configuration
{
    public class AlmazicksProfile : Profile
    {
        public AlmazicksProfile()
        {
            CreateMap<AnswerDto, Answer>().ReverseMap();
            CreateMap<HeroDto, Hero>().ReverseMap();
            CreateMap<QuestDto, Quest>().ReverseMap();
            CreateMap<StageDto, Stage>().ReverseMap();
        }
    }
}
