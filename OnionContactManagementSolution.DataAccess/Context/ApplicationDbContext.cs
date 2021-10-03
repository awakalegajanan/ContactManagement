using Microsoft.EntityFrameworkCore;
using OnionContactManagementSolution.Core.Interfaces;
using OnionContactManagementSolution.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionContactManagementSolution.DataAccess.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        public int SaveChanges()
        {
            return base.SaveChanges();            
        }
    }
}
