using System.ComponentModel.DataAnnotations;

namespace NewProject1.Models
{
    public class User
    {


        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }   
        
        [Required]
        public string Server { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Img { get; set; }

        public List<Chat> Chats { get; set; }
    }
}
