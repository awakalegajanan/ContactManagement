using OnionContactManagementSolution.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionContactManagementSolution.Core.Models
{
    public class Contact : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
    }
}
