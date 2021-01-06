using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Maintenance_Helpdesk.Models
{
    public class Maintenance_HelpdeskModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        [JsonPropertyName("type")]
        public string Type { get; set; } // Felanmälan, nycklar och passagekort, mm...

        [Required]
        [JsonPropertyName("priority")]
        public string Priority { get; set; }

        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Required]
        [JsonPropertyName("phone-number")]
        public int PhoneNumber { get; set; }

        [Required]
        [JsonPropertyName("email")]
        public int Email { get; set; }

        [Required]
        [JsonPropertyName("room-number")]
        public int RoomNumber { get; set; }

        [Required]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [Required]
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
