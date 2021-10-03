using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionContactManagementSolution.Core.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Models.Contact> Contacts { get; set; }
        int SaveChanges();
    }
}
