using Newtonsoft.Json;

namespace TesteCore.Dto
{
    public class SendLinkResponse
    {
        public string? Phone { get; set; }
        public string? Message { get; set; }
        public Uri? Image { get; set; }
        public Uri? LinkUrl { get; set; }
        public string? Title { get; set; }
        public string? LinkDescription { get; set; }
    }
}
