using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Models
{
    public class MockIssueRepository : IIssueRepository
    {
        private List<Issue> _issueList;
        public MockIssueRepository()
        {
            _issueList = new List<Issue>()
            {
                new Issue(){ID=1, District="KTM", Place="Koteshwor", Street="Kotdevi marg", IssuedDate =DateTime.Now, Subject ="Problem 1", IssueDetails="problem 1 details information "},
                new Issue(){ID=2, District="BKT", Place="Kausaltar", Street="Radhe marg", IssuedDate =DateTime.Now, Subject ="Problem 2", IssueDetails="problem 2 details information "},
                new Issue(){ID=3, District="Lalitpur", Place="Gwarko", Street="Buddha marg", IssuedDate =DateTime.Now, Subject ="Problem 3", IssueDetails="problem 3 details information "},
                new Issue(){ID=4, District="KTM", Place="Chabahil", Street="Pashupati marg", IssuedDate =DateTime.Now, Subject ="Problem 4", IssueDetails="problem 4 details information "}
            };

        }

        public IEnumerable<Issue> GetAllIssue()
        {
            return _issueList;
        }

        public Issue GetIssue(int Id)
        {
            return _issueList.FirstOrDefault(e => e.ID == Id);
        }
    }
}
