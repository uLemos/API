using Newtonsoft.Json;

namespace TesteCore.Models
{
    public class SendLinkModel
    {
        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("image")]
        public Uri? Image { get; set; }

        [JsonProperty("linkUrl")]
        public Uri? LinkUrl { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("linkDescription")]
        public string? LinkDescription { get; set; }
    }
}
