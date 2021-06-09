using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssuePlanner.Models
{
    public class IssueViewModel
    {
        public List<GithubIssueModel> AllIssue { get; set; }
        public List<string> LeftTable { get; set; }

        public List<string> RightTable { get; set; }

        public string JsonString { get; set; }
    }
}
