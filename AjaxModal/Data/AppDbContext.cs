using AjaxModal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxModal.Data
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-7BGFQJH;Database=AjaxModaldb;Trusted_Connection=True;");
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
