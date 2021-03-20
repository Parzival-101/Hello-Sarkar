using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Models
{
    public interface INewsRepository
    {
        News GetNews(int Id);
        IEnumerable<News> GetAllNews();

        News Add(News news);
        News Update(News newsChanges);
        News Delete(int id);
    }
}
