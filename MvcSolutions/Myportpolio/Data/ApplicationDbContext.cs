using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Myportpolio.Models;

namespace Myportpolio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Myportpolio.Models.Contact> Contact { get; set; }
        public DbSet<Myportpolio.Models.Account> Account { get; set; }
        public DbSet<Myportpolio.Models.Board> Boards { get; set; }
    }
}
