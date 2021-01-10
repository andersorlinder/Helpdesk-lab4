using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HR_Helpdesk.Models
{
    public class HR_HelpdeskModel
    {
        [Key]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required]
        [JsonPropertyName("date")]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [Required]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [Required]
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
