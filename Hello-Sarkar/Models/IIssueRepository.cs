using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Models
{
    public interface IIssueRepository
    {
        Issue GetIssue(int Id);
    }
}
