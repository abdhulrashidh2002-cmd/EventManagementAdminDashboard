using System.Text.Json.Serialization;

namespace EventManagement.Models
{
    public class FeedbackModel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("eventId")]
        public string EventId { get; set; }

        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("date")]
        public DateTime? Date { get; set; }

    }
}
