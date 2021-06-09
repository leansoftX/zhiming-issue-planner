using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace IssuePlanner.Models
{

    public class GithubIssueModel: BaseModel
    {
        public string IssueId { get; set; }
        public string IssueTitle { get; set; }
        public string Assignee { get; set; }
    }
}
