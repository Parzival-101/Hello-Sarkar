using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Models
{
    public class SQLIssueRepository : IIssueRepository
    {
        private readonly AppDbContext context;

        public SQLIssueRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Issue Add(Issue issue)
        {
            context.Issues.Add(issue);
            context.SaveChanges();
            return issue;
        }

        public Issue Delete(int id)
        {
            Issue issue = context.Issues.Find(id);
            if (issue != null)
            {
                context.Issues.Remove(issue);
                context.SaveChanges();
            }
            return issue;
        }

        public IEnumerable<Issue> GetAllIssue()
        {
            return context.Issues;
        }

        public Issue GetIssue(int Id)
        {
            return context.Issues.Find(Id);
        }

        public Issue Update(Issue issuechanges)
        {
            var issue = context.Issues.Attach(issuechanges);
            issue.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return issuechanges;
        }
    }
}
