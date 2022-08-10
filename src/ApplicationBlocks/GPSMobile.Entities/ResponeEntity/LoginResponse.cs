using System.Text.Json.Serialization;

namespace GPSMobile.Entities.ResponeEntity
{
    public class LoginResponse
    {
        [JsonPropertyName("1")]
        public int CompanyId { set; get; }

        [JsonPropertyName("3")]
        public List<int> Permissions { set; get; }

        [JsonPropertyName("4")]
        public Guid UserId { set; get; }

        [JsonPropertyName("5")]
        public bool IsNeedChangePassword { set; get; }

        [JsonPropertyName("6")]
        public string AvatarUrl { set; get; }

        [JsonPropertyName("10")]
        public DateTime TimeServer { set; get; }

        [JsonPropertyName("11")]
        public string AccessToken { get; set; }

        [JsonPropertyName("13")]
        public int XNCode { get; set; }

        [JsonPropertyName("14")]
        public string UserName { get; set; }

        [JsonPropertyName("15")]
        public string FullName { get; set; }

        [JsonPropertyName("16")]
        public string PhoneNumber { get; set; }
    }
}