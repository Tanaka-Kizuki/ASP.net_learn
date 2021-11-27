using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SampleRazorApp.Data
{
    public class SampleRazorAppContext : DbContext {
        public SampleRazorAppContext(DbContextOptions<SampleRazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<SampleRazorApp.Models.Person>Person{get;set;}
    }
}
