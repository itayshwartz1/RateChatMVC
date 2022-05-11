using System.ComponentModel.DataAnnotations;

namespace NewProject1.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public User Sender { get; set; }
        [Required]
        public string Type { get; set; }




    }
}
