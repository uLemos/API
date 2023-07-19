using Microsoft.AspNetCore.Mvc;
using System.Net;
using TesteCore.Services;

namespace TesteCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendTextController : ControllerBase
    {
        public readonly ISendTextService _sendTextService;

        public SendTextController(ISendTextService sendTextService)
        {
            _sendTextService = sendTextService;
        }

        [HttpPost]
        public async Task<ActionResult> EnviarMensagem()
        {
            var response = await _sendTextService.EnviaMensagem();

            if (response.CodigoHttp == HttpStatusCode.OK)
                return Ok(response.DadosRetorno);
            else
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }
}
