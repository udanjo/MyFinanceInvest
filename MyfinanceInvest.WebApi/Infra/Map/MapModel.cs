using AutoMapper;
using MyfinanceInvest.WebApi.Request;
using MyFinanceInvest.Domain.Entities;
using MyFinanceInvest.Response;

namespace MyFinanceInvest.Infra.Mapper
{
    public class MapModel : Profile
    {
        public MapModel()
        {
            CreateMap<BankInfo, BankResponse>().ReverseMap();
            CreateMap<BankRequest, BankInfo>().ReverseMap();
        }
    }
}