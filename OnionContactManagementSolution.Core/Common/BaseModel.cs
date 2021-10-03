using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnionContactManagementSolution.Core.Common
{
    public abstract class BaseModel
    {
        [Key]
        public int CustId { get; set; }
    }
}
