using AutoMapper;
using TesteCore.Dto;
using TesteCore.Models;

namespace TesteCore.Mappings
{
    public class SendTextMapping : Profile
    {
        public SendTextMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<SendTextResponse, SendTextModel>();
            CreateMap<SendTextModel, SendTextResponse>();
        }
    }
}
