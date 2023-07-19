using AutoMapper;
using TesteCore.Dto;
using TesteCore.Models;

namespace TesteCore.Services
{
    public class SendTextServices : ISendTextService
    {
        private readonly IMapper _mapper;
        private readonly IZapiApi _zapiApi;

        public SendTextServices(IMapper mapper, IZapiApi zapiApi)
        {
            _mapper = mapper;
            _zapiApi = zapiApi;
        }

        public async Task<ResponseGenerico<SendTextResponse>> EnviaMensagem()
        {
            var mensagem = await _zapiApi.EnviaMensagem();
            return _mapper.Map<ResponseGenerico<SendTextResponse>>(mensagem);
        }
    }
}
