using System.ComponentModel.DataAnnotations;

namespace NewProject1.Models
{
    public class Rate
    {
        public Rate()
        {

        }
		public Rate(int id, string name, int score, string comment, string time)
		{
			this.Id = id;
            this.Name = name;
            this.Score = score;
            this.Comment = comment;
            this.Time = time;
		}

		[Required]
        public int Id { get; set; } 

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1,5)]
        public int Score { get; set; }

        public string Comment { get; set; }

        [Required]
        public string Time { get; set; }


    }
}