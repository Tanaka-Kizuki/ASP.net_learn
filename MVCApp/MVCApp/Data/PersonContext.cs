using System;
using MVCApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCApp.Data
{
    public class PersonContext:DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
