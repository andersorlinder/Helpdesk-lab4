using System;
using System.Text.Json.Serialization;

namespace IT_Helpdesk.Models.RequestModels
{
    public class SubmitRequest
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        public DateTime Date { get; set; }
            = DateTime.Now;

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}