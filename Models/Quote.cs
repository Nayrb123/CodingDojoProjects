using System.ComponentModel.DataAnnotations;

namespace quoting_dojo.Models
{
    public class Quote
    {
        [Required]
        [MinLength(2)]
        public string quote { get; set; }
        [Required]
        [MinLength(3)]
        public string user { get; set; }
    }
}