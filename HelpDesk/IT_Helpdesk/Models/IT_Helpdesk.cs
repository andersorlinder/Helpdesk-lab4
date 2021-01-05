using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Helpdesk.Models
{
    public class IT_HelpdeskModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Type { get; set; }

        public DateTime Date { get; set; }
            = DateTime.Now;

        [Required]
        public string Title { get; set; }
    }
}
