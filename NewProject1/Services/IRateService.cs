using NewProject1.Models;

namespace NewProject1.Services
{
    public interface IRateService
    {
        public List<Rate> GetAll();
        public Rate Get(int id);

        public void Create(string Name, int Score, string Comment, string time);

        public void Edit(int id, string Name, int Score, string Comment, string time);
        public void Delete(int id);


    }
}
