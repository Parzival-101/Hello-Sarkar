using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Models
{
    public interface IIssueRepository
    {
        Issue GetIssue(int Id);
        IEnumerable<Issue> GetAllIssue();
        Issue Add(Issue issue);
        Issue Update(Issue issuechanges);
        Issue Delete(int id);

    }
}
