using NewProject1.Models;

namespace NewProject1.Services
{
	public class RateService : IRateService
	{
		public static List<Rate> rates = new List<Rate>();
		
		public List<Rate> GetAll() {
			return rates;
		}
		public Rate Get(int id) {
			return rates.Find(x => x.Id == id);
					
		}

		public void Create(string Name, int Score, string Comment, string Time) { 
			int id = rates.Max(x => x.Id) + 1;
			Rate rate = new Rate(id, Name, Score, Comment, Time);
			rates.Add(rate);
		}
		public void Edit(int id, string Name, int Score, string Comment, string Time) {
			Rate rate = Get(id);
			rate.Id = id;
			rate.Name = Name;
			rate.Score = Score;
			rate.Comment = Comment;
			rate.Time = Time;
		}
		public	void Delete(int id) {
			rates.Remove(Get(id));
		}
	}
}
