using System;
using System.ComponentModel.DataAnnotations;

namespace IT_Helpdesk.Models
{
    public class IT_HelpdeskModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Title { get; set; }
    }
}