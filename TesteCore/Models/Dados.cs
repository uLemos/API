namespace TesteCore.Models
{
    public class Dados
    {
        private static string _token = "AAADBA277B2ED68F44FA0683";
        private static string _instanceId = "392F639AB55430C01964FE0B8F23BD2A";

        public string Token 
        {
            get => _token;
            set => _token = value;
        }

        public string InstanceId 
        { 
            get => _instanceId;
            set => _instanceId = value;
        }
    }
}
