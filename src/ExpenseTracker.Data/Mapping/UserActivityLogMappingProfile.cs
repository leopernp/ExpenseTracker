using AutoMapper;
using ExpenseTracker.Contract.DTO;
using ExpenseTracker.Data.ContextModels;

namespace ExpenseTracker.Data.Mapping;

public class UserActivityLogMappingProfile : Profile
{
    public UserActivityLogMappingProfile()
    {
        CreateMap<UserActivityLog, UserActivityLogDto>()
            .ForMember(dest => dest.PerformedByUsername, opt => opt.MapFrom(src => src.PerformedBy.Username))
            .ForMember(dest => dest.PerformedByFirstName, opt => opt.MapFrom(src => src.PerformedBy.FirstName))
            .ForMember(dest => dest.PerformedByLastName, opt => opt.MapFrom(src => src.PerformedBy.LastName))
            .ReverseMap()
            .ForMember(dest => dest.PerformedBy, opt => opt.Ignore());
    }
}
