using RestSharp;
using System.Dynamic;
using System.Text.Json;
using TesteCore.Dto;
using TesteCore.Models;
using TesteCore.Services;

namespace TesteCore.Rest
{
    public class ZapiApiRest : IZapiApi
    {
        public async Task<ResponseGenerico<SendTextResponse>> EnviaMensagem()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.z-api.io/instances/{new Dados().InstanceId}/token/{new Dados().Token}/send-text");
            var response = new ResponseGenerico<SendTextResponse>();

            using ( var client = new HttpClient())
            {
                var responseZapiApi = await client.SendAsync(request);
                var contentResponse = await responseZapiApi.Content.ReadAsStringAsync();
                var ObjResponse = JsonSerializer.Deserialize<SendTextResponse>(contentResponse);

                if (responseZapiApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseZapiApi.StatusCode;
                    response.DadosRetorno = ObjResponse;
                }
                else
                {
                    response.CodigoHttp = responseZapiApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        public Task<ResponseGenerico<SendLinkModel>> EnviaLink(string phone, string message, Uri image, Uri linkUrl, string title, string linkDescription)
        {
            throw new NotImplementedException();
        }
    }
}
