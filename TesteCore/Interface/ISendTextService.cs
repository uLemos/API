using TesteCore.Dto;
using TesteCore.Models;

namespace TesteCore.Services
{
    public interface ISendTextService
    {
        public Task<ResponseGenerico<SendTextResponse>> EnviaMensagem();

    }
}
