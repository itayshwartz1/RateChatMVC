using System.ComponentModel.DataAnnotations;

namespace NewProject1.Models
{
    public class Chat
    {


        [Key]
        public int Id { get; set; }

        [Required]
        public List<User> Users { get; set; } 

        public List<Message> Message { get; set; }

       
    }
}
