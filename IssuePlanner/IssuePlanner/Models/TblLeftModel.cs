using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssuePlanner.Models
{
    public class TblLeftModel: BaseModel
    {
        public string IssueId { get; set; }
    }

    public class TblRightModel: BaseModel
    {
        public string IssueId { get; set; }
    }
}
