using Newtonsoft.Json;

namespace TesteCore.Models
{
    public class SendTextModel
    {
        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}
