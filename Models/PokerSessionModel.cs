using System.Text.Json.Serialization;

namespace SampleTestUI.Models
{
    public class PlayerSessions
    {
        [JsonPropertyName("Balance")]
        public decimal SessionBalance { get; set; }
        [JsonPropertyName("Date")]
        public DateTime SessionDate { get; set; }
    }
}
