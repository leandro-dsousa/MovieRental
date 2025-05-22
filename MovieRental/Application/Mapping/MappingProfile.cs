using AutoMapper;

namespace MovieRental.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();    
            DestinationMemberNamingConvention = new PascalCaseNamingConvention();    
        }
    }
}
