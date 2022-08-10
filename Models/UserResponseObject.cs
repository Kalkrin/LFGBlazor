using System.Text.Json.Serialization;

namespace LFGWebApp
{
public class UserResponseObject
    {
        [JsonPropertyName("data")]
        public List<User> Data { get; set; }
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}