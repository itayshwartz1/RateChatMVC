using System.ComponentModel.DataAnnotations;

namespace NewProject1.Models
{
    public class Rate
    {
        [Required]
        public int Id { get; set; } 

        public string Name { get; set; }

        [Required]
        public int Score { get; set; }

        public string Comment { get; set; }

        [Required]
        public string Time { get; set; }


    }
}
