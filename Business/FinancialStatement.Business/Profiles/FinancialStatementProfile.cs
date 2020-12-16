using AutoMapper;

namespace FinancialStatement.Business
{
   public class FinancialStatementProfile: Profile
    {
        public FinancialStatementProfile()
        {
            CreateMap<Persistence.FinancialStatement, FinancialStatementDto>();
            CreateMap<FinancialStatementDto, Persistence.FinancialStatement>().ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id));

        }
    }
}
