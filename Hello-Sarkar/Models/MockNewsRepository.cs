using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Models
{
    public class MockNewsRepository : INewsRepository
    {
        private List<News> _newsList;
        public MockNewsRepository()
        {
            _newsList = new List<News>()
            {
                new News(){Id=1, Title="News 1 ", Info ="News 1 info is here, it is a first news of the site ", Source="Source no 1 "},
                new News(){Id=2, Title="News 2 ", Info ="News 2 info is here, it is a second news of the site ", Source="Source no 2 "},
                new News(){Id=3, Title="News 3 ", Info ="News 3 info is here, it is a first news of the site ", Source="Source no 3 "}
            };

        }
        public News Add(News news)
        {
            news.Id = _newsList.Max(e=>e.Id) + 1;
            _newsList.Add(news);
            return news;
        }

        public News Delete(int id)
        {
            News news = _newsList.FirstOrDefault(e => e.Id == id);
            if (news != null)
            {
                _newsList.Remove(news);
            }
            return news;
        }

        public IEnumerable<News> GetAllNews()
        {
            return _newsList;
        }

        public News GetNews(int Id)
        {
            return _newsList.FirstOrDefault(e => e.Id == Id);
        }

        public News Update(News newsChanges)
        {
            News news = _newsList.FirstOrDefault(e => e.Id == newsChanges.Id);
            if (news != null)
            {
                news.Title = newsChanges.Title;
                news.Info = newsChanges.Info;
                news.Source = newsChanges.Source;
            }
            return news;
        }
    }
}
