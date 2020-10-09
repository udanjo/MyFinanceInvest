using AutoMapper;
using MyFinanceInvest.Domain.Entities;
using MyFinanceInvest.Response;

namespace MyFinanceInvest.Infra.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BankInfo, BankResponse>().ReverseMap();
        }
    }
}