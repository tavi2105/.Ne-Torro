using AutoMapper;

namespace FinancialStatement.Business
{
   public class FinancialStatementProfile: Profile
    {
        public FinancialStatementProfile()
        {
            CreateMap<Persistence.FinancialStatement, FinancialStatementDto>();
            CreateMap<FinancialStatementDto, Persistence.FinancialStatement>()
                .ForMember(dest => dest.UserId, opt => opt.Ignore());
            CreateMap<FinancialStatementForCreateDto, Persistence.FinancialStatement>()
                .ForMember(dest => dest.UserId, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore());

        }
    }
}
