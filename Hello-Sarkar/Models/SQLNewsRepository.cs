using Hello_Sarkar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Models
{
    public class SQLNewsRepository : INewsRepository
    {
        private readonly ApplicationDbContext context;

        public SQLNewsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public News Add(News news)
        {
            context.News.Add(news);
            context.SaveChanges();
            return news;
        }

        public News Delete(int id)
        {
            News news = context.News.Find(id);
            if (news != null)
            {
                context.News.Remove(news);
                context.SaveChanges();
            }
            return news;
        }

        public IEnumerable<News> GetAllNews()
        {
            return context.News;
        }

        public News GetNews(int Id)
        {
            return context.News.Find(Id);
        }

        public News Update(News newsChanges)
        {
            var news = context.News.Attach(newsChanges);
            news.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return newsChanges;
        }
    }
}
